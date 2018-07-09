using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_GestoreNegozio
{
    public partial class ReportMensile : Form
    {
        public ReportMensile()
        {
            InitializeComponent();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Int32 port = 1239;
                TcpClient client = new TcpClient("127.0.0.1", port);
                Thread.Sleep(10);
                //mando la data

                Byte[] data = new Byte[256];
                data = System.Text.Encoding.ASCII.GetBytes("1");
                Thread.Sleep(10);

                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);



                data = new Byte[256];
                data = System.Text.Encoding.ASCII.GetBytes(textBox1.Text);
                Thread.Sleep(10);

                stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                //ricevo il numero di righe

                data = new Byte[256];
                String responseData = String.Empty;
                Thread.Sleep(10);
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);


                int righe = int.Parse(responseData);

                //riga per riga popolo la tabella
                string[] response = new string[righe];

                

                    data = new Byte[256];
                    responseData = String.Empty;
                    Thread.Sleep(10);
                    bytes = stream.Read(data, 0, data.Length);
                    label2.Text = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
          
                    Thread.Sleep(20);

                data = new Byte[256];
                responseData = String.Empty;
                Thread.Sleep(10);
                bytes = stream.Read(data, 0, data.Length);
                label3.Text = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

                Thread.Sleep(20);

                data = new Byte[256];
                responseData = String.Empty;
                Thread.Sleep(10);
                bytes = stream.Read(data, 0, data.Length);
                label4.Text = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

                Thread.Sleep(20);

                data = new Byte[256];
                responseData = String.Empty;
                Thread.Sleep(10);
                bytes = stream.Read(data, 0, data.Length);
                label5.Text = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

                Thread.Sleep(20);
                data = new Byte[256];
                responseData = String.Empty;
                Thread.Sleep(10);
                bytes = stream.Read(data, 0, data.Length);
                label6.Text = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

                Thread.Sleep(20);

            }
        }
        private void elencoScontriniButton_Click(object sender, EventArgs e)
        {
            Perdata perdata = new Perdata();
            perdata.Show();
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
    }
}
