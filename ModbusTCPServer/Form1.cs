using ModbusTCPServer.Properties;
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

namespace ModbusTCPServer
{
    public partial class Form1 : Form
    {
        private Socket socket;
        private Socket clientSocket;
        private Thread thread;
        private Thread acceptThread;
        private bool isStart = false;

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

        private void btn_Create_Click(object sender, EventArgs e)
        {
            CreateServer();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Send();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            receiveText.Clear();
        }

        private void CreateServer()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEP = new IPEndPoint(IPAddress.Parse(ipText.Text), Convert.ToInt32(portText.Text));
            socket.Bind(localEP);
            socket.Listen(10);
            isStart = true;
            btn_Create.Enabled = false;

            acceptThread = new Thread(Accept);
            acceptThread.Start();

            thread = new Thread(Receive);
            thread.Start();
        }

        private void Accept()
        {
            while (isStart)
            {
                try
                {
                    if (clientSocket == null)
                    {
                        clientSocket = socket.Accept();
                    }
                }
                catch (SocketException se)
                {
                    MessageBox.Show(se.Message);
                }

                Thread.Sleep(200);
            }
        }

        private void Send()
        {
            if (!isStart)
            {
                autoSend.Checked = false;
                MessageBox.Show("服务器没有启动！ ");
                return;
            }

            receiveText.AppendText(string.Format("发：{0}\r\n", sendText.Text));
            char[] sendChar = sendText.Text.Replace(" ", "").ToCharArray();
            byte[] data = new byte[sendChar.Length / 2];
            string[] sendContent = new string[sendChar.Length / 2 + 1];
            for (int i = 0, j = 0; i < sendContent.Length && j < sendChar.Length; i++)
            {
                sendContent[i] = string.Format("{0}{1}", sendChar[j].ToString(), sendChar[j + 1].ToString());
                j += 2;
                //receiveText.AppendText(string.Format("{0}\r\n", sendContent[i]));
                data[i] = byte.Parse(sendContent[i], NumberStyles.HexNumber);
            }

            if (clientSocket != null)
            {
                clientSocket.Send(data);
            }
        }

        private void Receive()
        {
            while (isStart)
            {
                if (clientSocket == null)
                    continue;

                byte[] data = new byte[1024];
                try
                {
                    clientSocket.Receive(data);
                }
                catch (SocketException se)
                {
                    MessageBox.Show(se.Message);
                    CloseClientSocket();
                }
                //socket.Receive(data, 0, data.Length, SocketFlags.None);
                int length = data[5];
                byte[] dataShow = new byte[length + 6];
                for (int i = 0; i < dataShow.Length; i++)
                {
                    dataShow[i] = data[i];
                }
                string receiveContent = BitConverter.ToString(dataShow);
                ShowText(receiveContent);

                Thread.Sleep(100);
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

        /// <summary>
        /// 关闭已断开的客户端
        /// </summary>
        private void CloseClientSocket()
        {
            if (clientSocket != null)
            {
                clientSocket.Close();
                clientSocket = null;
            }
        }

        private void Disconnect()
        {
            try
            {
                btn_Create.Enabled = true;
                isStart = false;

                if (socket != null)
                {
                    //socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    socket = null;
                }

                if (thread != null)
                {
                    thread.Interrupt();
                    thread.Abort();
                    thread = null;
                }

                if (socket != null)
                {
                    //socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    socket = null;
                }

                //因为socket.Accept()会阻塞acceptThread，所以要先关闭socket，再关闭acceptThread，否则会卡死
                if (acceptThread != null)
                {
                    acceptThread.Interrupt();
                    acceptThread.Abort();
                    acceptThread = null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
