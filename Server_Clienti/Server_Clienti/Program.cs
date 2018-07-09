using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server_Clienti
{
    class Program
    {
        static void Main(string[] args)
        {

            TerminaleClienteController controller = new TerminaleClienteController();

            TcpListener tcpListener = null;
            IPAddress ipAddress = Dns.GetHostEntry("127.0.0.1").AddressList[0];

            tcpListener = new TcpListener(1235);
            tcpListener.Start();

            while (true)
            {
                try
                {

                    Thread.Sleep(10);
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();

                    byte[] bytes = new byte[256];
                    NetworkStream stream = tcpClient.GetStream();
                    Thread.Sleep(10);

                    string[] mstrResponse = controller.getElencoScontrini();
                    string righe = mstrResponse.Length.ToString();
                    byte[] bytesSent = Encoding.ASCII.GetBytes(righe);
                    stream.Write(bytesSent, 0, bytesSent.Length);
                    Thread.Sleep(20);

                    foreach(string line in mstrResponse)
                    {
                        bytesSent = Encoding.ASCII.GetBytes(line);
                        stream.Write(bytesSent, 0, bytesSent.Length);
                        Thread.Sleep(20);
                    }

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }




            }
        }
    }
}
