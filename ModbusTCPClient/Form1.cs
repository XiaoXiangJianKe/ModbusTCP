using ModbusTCPClient.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusTCPClient
{
    public partial class Form1 : Form
    {
        private ModbusTCP modbusTCP;
        private Socket socket;
        private Thread thread;
        private bool connected = false;

        private delegate void SetTextCallback(string text);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Settings.Default.Reload();
            ipText.Text = Settings.Default["ip"].ToString();
            portText.Text = Settings.Default["port"].ToString();
            sendText.Text = Settings.Default["command"].ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Disconnect();

            Settings.Default["ip"] = ipText.Text;
            Settings.Default["port"] = portText.Text;
            Settings.Default["command"] = sendText.Text;
            Settings.Default.Save();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void autoSend_CheckedChanged(object sender, EventArgs e)
        {
            if (autoSend.Checked)
            {
                timer1.Enabled = true;
                timer1.Interval = Convert.ToInt32(textBoxInterval.Text);
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            receiveText.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Send();
        }

        private void Connect()
        {
            //socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(ipText.Text), Convert.ToInt32(portText.Text));

            modbusTCP = new ModbusTCP(ipText.Text, Convert.ToInt32(portText.Text));

            try
            {
                //socket.Connect(remoteEP);
                modbusTCP.Connect();
                connected = true;
                btn_Connect.Enabled = false;
            }
            catch (SocketException se)
            {
                MessageBox.Show("连接服务器失败 " + se.Message);
            }

            thread = new Thread(Receive);
            thread.Start();
        }

        private void Send()
        {
            if (!connected)
            {
                autoSend.Checked = false;
                MessageBox.Show("服务器没有连接 ");
                return;
            }

            //byte[] data = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0x06, 0x01, 0x01, 0x00, 0x14, 0x00, 0x13 };
            //byte[] data = new byte[12];
            //receiveText.AppendText(string.Format("发：{0}\r\n", sendText.Text));
            //char[] sendChar = sendText.Text.Replace(" ", "").ToCharArray();
            //byte[] data = new byte[sendChar.Length / 2];
            //string[] sendContent = new string[sendChar.Length / 2 + 1];
            //for (int i = 0, j = 0; i < sendContent.Length && j < sendChar.Length; i++)
            //{
            //    sendContent[i] = string.Format("{0}{1}", sendChar[j].ToString(), sendChar[j + 1].ToString());
            //    j += 2;
            //    //receiveText.AppendText(string.Format("{0}\r\n", sendContent[i]));
            //    data[i] = byte.Parse(sendContent[i], NumberStyles.HexNumber);
            //}

            //socket.Send(data);
            //socket.Send(data, 0, data.Length, SocketFlags.None);

            int quantitly = int.Parse(quantity.Text);
            byte[] sendData = null;
            if (functionCodeList.Text == "01")
            {
                sendData = modbusTCP.ReadAllCoil(quantitly);
            }
            else if (functionCodeList.Text == "03")
            {
                sendData = modbusTCP.ReadAllRegister(quantitly);
            }

            if (sendData != null)
            {
                string dataStr = BitConverter.ToString(sendData);
                sendText.Text = dataStr;
                receiveText.AppendText(string.Format("发：{0}\r\n", sendText.Text));
            }
        }

        private void Receive()
        {
            while (connected)
            {
                byte[] data = null;
                try
                {
                    //socket.Receive(data);

                    data = modbusTCP.Receive();
                }
                catch (SocketException se)
                {
                    MessageBox.Show(se.Message);
                    this.Disconnect();
                }
                //socket.Receive(data, 0, data.Length, SocketFlags.None);
                if (data != null)
                {
                    int length = data[5];
                    byte[] dataShow = new byte[length + 6];
                    for (int i = 0; i < dataShow.Length; i++)
                    {
                        dataShow[i] = data[i];
                    }
                    string receiveContent = BitConverter.ToString(dataShow);
                    ShowText(receiveContent);
                }
                else
                {
                    this.Disconnect();
                }
            }
        }

        private void ShowText(string text)
        {
            //在线程里以安全方式调用控件，否则报异常
            if (receiveText.InvokeRequired)
            {
                SetTextCallback callback = new SetTextCallback(ShowText);
                Invoke(callback, new object[] { text });
            }
            else
            {
                receiveText.AppendText(string.Format("收：{0}\r\n", text));
            }
        }

        private void Disconnect()
        {
            btn_Connect.Enabled = true;

            if (thread != null)
            {
                connected = false;
                thread.Interrupt();
                thread.Abort();
                thread = null;
            }

            if (socket != null)
            {
                socket.Close();
                socket = null;
            }

            if (modbusTCP != null)
            {
                modbusTCP.Disconnect();
                modbusTCP = null;
            }
        }
    }
}
