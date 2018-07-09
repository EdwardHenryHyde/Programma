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

namespace Client_Cliente
{
    public partial class ElencoScontrini : Form
    {
        public ElencoScontrini()
        {
            InitializeComponent();

            Int32 port = 1238;
            TcpClient client = new TcpClient("127.0.0.1", port);
            Thread.Sleep(10);
            NetworkStream stream = client.GetStream();



            Byte[] data = new Byte[256];
            String responseData = String.Empty;
            Thread.Sleep(10);
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);


            int righe = int.Parse(responseData);

            for (int i = 0; i < righe; i++)
            {
                data = new Byte[256];
                responseData = String.Empty;
                Thread.Sleep(10);
                bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

                string[] words = responseData.Split('@');

                tableLayoutPanel1.Controls.Add(new Label() {/*Dock = DockStyle.Fill,*/ Text = words[0] });
                tableLayoutPanel1.Controls.Add(new Label() { /*Dock = DockStyle.Fill,*/ Text = words[1] });
                tableLayoutPanel1.Controls.Add(new Label() { /*Dock = DockStyle.Fill,*/ Text = words[2] + "€" });
                tableLayoutPanel1.Controls.Add(new Label() { /*Dock = DockStyle.Fill,*/ Text = words[3] });


            }


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            InterfacciaCliente interfacciaCliente = new InterfacciaCliente();
            interfacciaCliente.Show();
            this.Close();
        }

        private void ottieniPremioButton_Click(object sender, EventArgs e)
        {
            ottieniPremio premio = new ottieniPremio();
            premio.Show();
            this.Close();
        }

        
    }
}
