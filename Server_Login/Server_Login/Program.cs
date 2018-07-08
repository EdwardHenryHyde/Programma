using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server_Login
{
    class Program
    {
        static void Main(string[] args)
        {

            LoginController loginController = new LoginController();
            RegistrazioneController registrazioneController = new RegistrazioneController();

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
                    stream.Read(bytes, 0, bytes.Length);
                    Thread.Sleep(10);
                    string mstrMessage = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                    mstrMessage = mstrMessage.Substring(0, 1);


                    if(int.Parse(mstrMessage) == 1)
                    {

                        Thread.Sleep(10);
                        bytes = new byte[256];
                        stream.Read(bytes, 0, bytes.Length);
                        mstrMessage = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                        int len = mstrMessage.IndexOf('\0');
                        mstrMessage = mstrMessage.Substring(0, len);
                        Thread.Sleep(10);

                        string[] words = mstrMessage.Split(':');

                        string mstrResponse = loginController.verificaCredenziali(words[0], words[1]);
                        byte[] bytesSent = Encoding.ASCII.GetBytes(mstrResponse);
                        stream.Write(bytesSent, 0, bytesSent.Length);
                    
                    }

                    else if(int.Parse(mstrMessage) == 2)
                    {
                        Thread.Sleep(10);
                        bytes = new byte[256];
                        stream.Read(bytes, 0, bytes.Length);
                        mstrMessage = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                        int len = mstrMessage.IndexOf('\0');
                        mstrMessage = mstrMessage.Substring(0, len);
                        Thread.Sleep(10);

                        string[] input = mstrMessage.Split(':');
                        
                        string mstrResponse = registrazioneController.registra(input[0], input[1], input[2], input[3], input[4], input[5], input[6], input[7], input[8], input[9]);
                        loginController.aggiornaLogin();
                        byte[] bytesSent = Encoding.ASCII.GetBytes(mstrResponse);
                        stream.Write(bytesSent, 0, bytesSent.Length);


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
