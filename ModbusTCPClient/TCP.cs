using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusTCPClient
{
    public abstract class TCP
    {
        public abstract void Connect();
        public abstract void Send(byte[] data);
        public abstract byte[] Receive();
        public abstract void Disconnect();
    }
}
