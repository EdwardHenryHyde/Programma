using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server_GestoreNegozio
{
    class Program
    {
        static void Main(string[] args)
        {

            StatisticheController controllerStatistiche = new StatisticheController();

            TcpListener tcpListener = null;
            IPAddress ipAddress = Dns.GetHostEntry("127.0.0.1").AddressList[0];

            tcpListener = new TcpListener(1239);
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
                        //DA RIFARE
                        Thread.Sleep(10);
                        bytes = new byte[256];
                        stream.Read(bytes, 0, bytes.Length);
                        mstrMessage = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                        int len = mstrMessage.IndexOf('\0');
                        mstrMessage = mstrMessage.Substring(0, len);

                        Thread.Sleep(10);
                        string[] mstrResponse = controllerStatistiche.getReportMensile(mstrMessage);
                        string righe = mstrResponse.Length.ToString();
                        byte[] bytesSent = Encoding.ASCII.GetBytes(righe);
                        Thread.Sleep(10);
                        stream.Write(bytesSent, 0, bytesSent.Length);
                        foreach (string line in mstrResponse)
                        {
                            bytesSent = Encoding.ASCII.GetBytes(line);
                            Thread.Sleep(10);
                            stream.Write(bytesSent, 0, bytesSent.Length);
                        }

                    }
                    else if (int.Parse(mstrMessage) == 2)
                    {
                        //DA RIFARE
                        Thread.Sleep(10);
                        bytes = new byte[256];
                        stream.Read(bytes, 0, bytes.Length);
                        mstrMessage = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                        int len = mstrMessage.IndexOf('\0');
                        string mstrMessageInizio = mstrMessage.Substring(0, len);

                        bytes = new byte[256];
                        stream.Read(bytes, 0, bytes.Length);
                        mstrMessage = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                        len = mstrMessage.IndexOf('\0');
                        string mstrMessageFine = mstrMessage.Substring(0, len);


                        Thread.Sleep(10);
                        string[] mstrResponse = controllerStatistiche.getStatistiche(mstrMessageInizio, mstrMessageFine);
                        string righe = mstrResponse.Length.ToString();
                        byte[] bytesSent = Encoding.ASCII.GetBytes(righe);
                        stream.Write(bytesSent, 0, bytesSent.Length);

                        foreach(string line in mstrResponse)
                        {
                            bytesSent = Encoding.ASCII.GetBytes(line);
                            Thread.Sleep(10);
                            stream.Write(bytesSent, 0, bytesSent.Length);
                        }

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
