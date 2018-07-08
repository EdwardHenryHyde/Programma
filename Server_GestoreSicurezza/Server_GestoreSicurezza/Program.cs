using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server_GestoreSicurezza
{
    class Program
    {
        static void Main(string[] args)
        {

            LogController logController = new LogController();

            TcpListener tcpListener = null;
            IPAddress ipAddress = Dns.GetHostEntry("127.0.0.1").AddressList[0];

            tcpListener = new TcpListener(1237);
            tcpListener.Start();


            while ((true))
            {
                try
                {

                    Thread.Sleep(10);
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();

                    byte[] bytes = new byte[256];
                    NetworkStream stream = tcpClient.GetStream();
                    stream.Read(bytes, 0, bytes.Length);
                    Thread.Sleep(10);
                    string mstrMessage = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                    int len = mstrMessage.IndexOf('\0');
                    mstrMessage = mstrMessage.Substring(0, len);

                    string[] res = logController.getEntry(mstrMessage);
                    string mstrResponse;
                    byte[] bytesSent;

                    if (res == null)
                    {
                        Thread.Sleep(10);
                        mstrResponse = "errore";
                        bytesSent = Encoding.ASCII.GetBytes(mstrResponse);
                        stream.Write(bytesSent, 0, bytesSent.Length);
                    }

                    Thread.Sleep(10);
                    mstrResponse = res.Length.ToString();
                    bytesSent = Encoding.ASCII.GetBytes(mstrResponse);
                    stream.Write(bytesSent, 0, bytesSent.Length);

                    foreach(string line in res)
                    {
                        mstrResponse = line;
                        bytesSent = Encoding.ASCII.GetBytes(mstrResponse);
                        stream.Write(bytesSent, 0, bytesSent.Length);
                        Thread.Sleep(10);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }



            }
        }
    }
}
