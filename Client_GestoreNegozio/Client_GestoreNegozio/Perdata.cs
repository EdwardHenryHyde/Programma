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
    public partial class Perdata : Form
    {
        public Perdata()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Int32 port = 1239;
            TcpClient client = new TcpClient("127.0.0.1", port);
            Thread.Sleep(10);
            //mando la data

            Byte[] data = new Byte[256];
            data = System.Text.Encoding.ASCII.GetBytes("2");
            Thread.Sleep(10);

            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);



            data = new Byte[256];
            data = System.Text.Encoding.ASCII.GetBytes(dateTimePicker1.Text);
            Thread.Sleep(10);

            stream.Write(data, 0, data.Length);

            data = System.Text.Encoding.ASCII.GetBytes(dateTimePicker2.Text);
            Thread.Sleep(10);

            stream.Write(data, 0, data.Length);

            //ricevo il numero di righe

            data = new Byte[256];
            String responseData = String.Empty;
            Thread.Sleep(10);
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);


            int righe = int.Parse(responseData);

            //riga per riga popolo la tabella

            for (int i = 0; i < righe; i++)
            {
                data = new Byte[256];
                responseData = String.Empty;
                Thread.Sleep(10);
                bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

                tableLayoutPanel1.Controls.Add(new Label() { Text = responseData });

            }
        }
    }
}
