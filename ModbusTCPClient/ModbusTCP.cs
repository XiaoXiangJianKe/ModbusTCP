using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusTCPClient
{
    public class ModbusTCP : TCP
    {
        private string ip;
        private int port;
        private Socket socket;
        private bool connected = false;

        private static readonly int PORT_COUNT = 96;
        private int[] sendSignals = new int[PORT_COUNT];
        private int[] receiveSignals = new int[PORT_COUNT];

        public ModbusTCP(string ip, int port)
        {
            this.ip = ip;
            this.port = port;
        }

        public override void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(ip), port);
            try
            {
                socket.Connect(remoteEP);
                connected = true;
            }
            catch(SocketException se)
            {
                MessageBox.Show("连接服务器失败 " + se.Message);
            }
        }

        public override void Disconnect()
        {
            connected = false;

            if (socket != null)
            {
                socket.Close();
                socket = null;
            }
        }

        public override byte[] Receive()
        {
            if(connected)
            {
                byte[] data = new byte[1024];
                try
                {
                    socket.Receive(data);
                }
                catch (SocketException se)
                {
                    MessageBox.Show(se.Message);
                    Disconnect();
                }

                AnalyzeReceiveData(data);
                return data;
            }
            return null;
        }

        public override void Send(byte[] data)
        {
            if (!connected)
            {
                MessageBox.Show("服务器没有连接 ");
                return;
            }

            try
            {
                socket.Send(data);
            }
            catch(SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        /// <summary>
        /// 读多个线圈
        /// </summary>
        /// <param name="quantity">线圈数量</param>
        public byte[] ReadAllCoil(int quantity)
        {
            //00 00 00 00 00 06 01 01 00 00 00 0A

            //事务处理标识符，2个字节，一般每次通信之后将被要求加1以区别不同的通信数据报文，可以理解为id
            byte transactionIdHigh = 0x00;//事务处理标识符高位
            byte transactionIdLow = 0x00;//事务处理标识符低位

            //协议标识符，2个字节，00 00表示Modbus协议
            byte protocolIdHigh = 0x00;//协议标识高位
            byte protocolIdLow = 0x00;//协议标识低位

            byte byteLengthHigh = 0x00;
            byte byteLengthLow = 0x06;
            byte slaveId = 0x01;
            byte functionCode = 0x01;
            byte addressHigh = 0x00;
            byte addressLow = 0x00;
            byte coilNumHigh = 0x00;
            byte coilNumLow = byte.Parse(quantity.ToString());

            int totalLength = 12;
            byte[] sendData = new byte[totalLength];
            sendData[0] = transactionIdHigh;
            sendData[1] = transactionIdLow;
            sendData[2] = protocolIdHigh;
            sendData[3] = protocolIdLow;
            sendData[4] = byteLengthHigh;
            sendData[5] = byteLengthLow;
            sendData[6] = slaveId;
            sendData[7] = functionCode;
            sendData[8] = addressHigh;
            sendData[9] = addressLow;
            sendData[10] = coilNumHigh;
            sendData[11] = coilNumLow;

            Send(sendData);

            return sendData;
        }

        /// <summary>
        /// 读多个保持寄存器
        /// </summary>
        /// <param name="quantity">寄存器数量</param>
        public byte[] ReadAllRegister(int quantity)
        {
            //00 00 00 00 00 06 01 03 00 00 00 01

            //事务处理标识符，2个字节，一般每次通信之后将被要求加1以区别不同的通信数据报文，可以理解为id
            byte transactionIdHigh = 0x00;//事务处理标识符高位
            byte transactionIdLow = 0x00;//事务处理标识符低位

            //协议标识符，2个字节，00 00表示Modbus协议
            byte protocolIdHigh = 0x00;//协议标识高位
            byte protocolIdLow = 0x00;//协议标识低位

            byte byteLengthHigh = 0x00;
            byte byteLengthLow = 0x06;
            byte slaveId = 0x01;
            byte functionCode = 0x03;
            byte addressHigh = 0x00;
            byte addressLow = 0x00;
            byte registerNumHigh = 0x00;
            byte registerNumLow = byte.Parse(quantity.ToString());

            int totalLength = 12;
            byte[] sendData = new byte[totalLength];
            sendData[0] = transactionIdHigh;
            sendData[1] = transactionIdLow;
            sendData[2] = protocolIdHigh;
            sendData[3] = protocolIdLow;
            sendData[4] = byteLengthHigh;
            sendData[5] = byteLengthLow;
            sendData[6] = slaveId;
            sendData[7] = functionCode;
            sendData[8] = addressHigh;
            sendData[9] = addressLow;
            sendData[10] = registerNumHigh;
            sendData[11] = registerNumLow;

            Send(sendData);

            return sendData;
        }

        public void WriteAllCoil()
        {

        }

        public void WriteAllRegister()
        {

        }

        /// <summary>
        /// 解析从站应答的报文数据
        /// </summary>
        /// <param name="data">00 00 00 00 00 05 01 01 02 7F 00</param>
        private void AnalyzeReceiveData(byte[] data)
        {
            int functionCode = data[7];
            if (functionCode == 1)//读多个线圈，00 00 00 00 00 05 01 01 02 7F 00
            {
                int byteCount = data[8];
                for (int i = 0; i < byteCount; i++)
                {
                    string value = Convert.ToString(data[9 + i], 2).PadLeft(8, '0');
                    for (int j = value.Length - 1; j >= 0; j--)
                    {
                        receiveSignals[i * 8 + (value.Length - 1 - j)] = int.Parse(value[j].ToString());
                    }
                }
            }
            else if (functionCode == 3)//读多个保持寄存器，00 00 00 00 00 05 01 03 02 00 01
            {
                int byteCount = data[8];
                for (int i = 0; i < byteCount;)
                {
                    string valueHigh = Convert.ToString(data[9 + i], 2).PadLeft(8, '0');
                    string valueLow = Convert.ToString(data[10 + i], 2).PadLeft(8, '0');
                    string value = valueHigh + valueLow;
                    for (int j = value.Length - 1; j >= 0; j--)
                    {
                        receiveSignals[i * 8 + (value.Length - 1 - j)] = int.Parse(value[j].ToString());
                    }
                    i += 2;
                }
            }
        }
    }
}
