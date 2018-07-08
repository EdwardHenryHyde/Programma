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
            int len = responseData.IndexOf('\0');
            responseData = responseData.Substring(0, len);


            int righe = int.Parse(responseData);

            //riga per riga popolo la tabella

            for(int i = 0; i < righe; i++ )
            {
                data = new Byte[256];
                responseData = String.Empty;
                Thread.Sleep(10);
                bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                len = responseData.IndexOf('\0');
                responseData = responseData.Substring(0, len);

                string[] words = responseData.Split('@');

                tableLayoutPanel.Controls.Add(new Label() { Text = words[0] });
                tableLayoutPanel.Controls.Add(new Label() { Text = words[1] });
                tableLayoutPanel.Controls.Add(new Label() { Text = words[2] });


            }





        }
    }
}
