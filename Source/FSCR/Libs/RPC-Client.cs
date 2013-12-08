using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace FSCR.Libs
{
    class RPC_Client
    {
        Socket start = null;
        String server = null;
        int port = 80;

        public RPC_Client(string server, int port)
        {
            this.server = server;
            this.port = port;
        }

        public bool connect(string server, int port)
        {
            this.server = server;
            this.port = port;
            IPHostEntry hostEntry = null;

            hostEntry = Dns.GetHostEntry(server);

            foreach (IPAddress address in hostEntry.AddressList)
            {
                IPEndPoint ipe = new IPEndPoint(address, port);
                Socket tempSocket =
                    new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                tempSocket.Connect(ipe);

                if (tempSocket.Connected)
                {
                    start = tempSocket;
                    break;
                }
                else
                {
                    continue;
                }
            }
            return (start != null);
        }

        public string request(string cmd)
        {
            String result = "";
            Byte[] bytesSent = Encoding.ASCII.GetBytes(cmd);
            Byte[] bytesReceived = new Byte[256];

            if (start == null)
            {
                if (!connect(server, port))
                {
                    MessageBox.Show("Connection failed");
                    return null;
                }
            }

            start.Send(bytesSent, bytesSent.Length, 0);

            int bytes = 0;

            try
            {
                do
                {
                    bytes = start.Receive(bytesReceived, bytesReceived.Length, 0);
                    result = result + Encoding.ASCII.GetString(bytesReceived, 0, bytes);
                }
                while (bytes > 0);

            }
            catch (Exception e)
            {
                if (e != null) { 
                }
            }
            if (start.Connected)
            {
                start.Close();
            }
            start.Dispose();
            start = null;

            return result;
        }
    }
}
