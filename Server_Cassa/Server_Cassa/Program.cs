using Server_Cassa.Server_EmissioneScontrino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server_Cassa
{
    class Program
    {
        
        static void Main(string[] args)
        {

            EmissioneScontrinoController controllerScontrino = new EmissioneScontrinoController();

            TcpListener tcpListener = null;
            IPAddress ipAddress = Dns.GetHostEntry("127.0.0.1").AddressList[0];

            tcpListener = new TcpListener(1234);
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
                    mstrMessage = mstrMessage.Substring(0, 1);




                    if (int.Parse(mstrMessage) == 1)
                    {

                        Thread.Sleep(10);
                        string mstrResponse = controllerScontrino.aggiungiProdotto();
                        byte[] bytesSent = Encoding.ASCII.GetBytes(mstrResponse);
                        stream.Write(bytesSent, 0, bytesSent.Length);


                    }
                    else if (int.Parse(mstrMessage) == 2)
                    {
                        Thread.Sleep(10);
                        bytes = new byte[256];
                        stream.Read(bytes, 0, bytes.Length);
                        mstrMessage = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                        mstrMessage = mstrMessage.Substring(0, 5);
                        Thread.Sleep(10);
                        string mstrResponse = controllerScontrino.getNomeFromIdCarta(int.Parse(mstrMessage));
                        byte[] bytesSent = Encoding.ASCII.GetBytes(mstrResponse);
                        stream.Write(bytesSent, 0, bytesSent.Length);

                    }
                    else if (int.Parse(mstrMessage) == 3)
                    {
                        Thread.Sleep(10);
                        bytes = new byte[256];
                        stream.Read(bytes, 0, bytes.Length);
                        mstrMessage = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                        int len = mstrMessage.IndexOf('\0');
                        mstrMessage = mstrMessage.Substring(0, len);
                        Thread.Sleep(10);
                        controllerScontrino.concludiScontrino(mstrMessage);
                        
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
