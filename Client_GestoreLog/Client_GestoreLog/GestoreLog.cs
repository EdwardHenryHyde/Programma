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

namespace Client_GestoreLog
{
    public partial class GestoreLog : Form
    {
        public GestoreLog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker.Text);

            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowCount = 0;

            Int32 port = 1237;
            TcpClient client = new TcpClient("127.0.0.1", port);
            Thread.Sleep(10);
            //mando la data

            Byte[] data = new Byte[256];
            data = System.Text.Encoding.ASCII.GetBytes(dateTimePicker.Text);
            Thread.Sleep(10);

            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);

            //ricevo il numero di righe

            data = new Byte[256];
            String responseData = String.Empty;
            Thread.Sleep(10);
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

            if (!responseData.Equals("errore"))
            {
                int righe = int.Parse(responseData);

                //riga per riga popolo la tabella

                for (int i = 0; i < righe; i++)
                {
                    data = new Byte[256];
                    responseData = "";
                    bytes = stream.Read(data, 0, data.Length);
                    Thread.Sleep(10);
                    responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                    //MessageBox.Show(responseData);
                    string[] words = new string[3];
                    words = responseData.Split('@');

                    tableLayoutPanel.Controls.Add(new Label { Text = words[0] },0,i);
                    tableLayoutPanel.Controls.Add(new Label { Text = words[1], AutoSize = true },1,i);
                    tableLayoutPanel.Controls.Add(new Label { Text = words[2] },2,i);

                    data = new Byte[256];
                    data = System.Text.Encoding.ASCII.GetBytes("ok");
                    Thread.Sleep(10);

                    stream = client.GetStream();
                    stream.Write(data, 0, data.Length);
                }
            }
            else
            {
                MessageBox.Show("Data non disponibile");
            }




        }
    }
}
