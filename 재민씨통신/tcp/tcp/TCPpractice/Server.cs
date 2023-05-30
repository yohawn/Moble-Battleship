﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPpractice
{
    class Server
    {
        public static TcpListener listener;
        public static TcpClient client = new TcpClient();

        public static void ServerStart(string ip, string port)
        {
            try
            {
                //listener = new TcpListener(IPAddress.Parse(ip), int.Parse(port));
                listener = new TcpListener(IPAddress.Any, int.Parse(port));
                listener.Start();
                //client = listener.AcceptTcpClient();

                listener.BeginAcceptTcpClient(AcceptClientCallback, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void AcceptClientCallback(IAsyncResult asyncResult)
        {
            client = listener.EndAcceptTcpClient(asyncResult);
        }
    }
}
