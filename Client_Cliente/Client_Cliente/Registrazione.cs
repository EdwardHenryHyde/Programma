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
    public partial class Registrazione : Form
    {
        public Registrazione()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';

        }

        private void registra_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Stampa scontrino");
            Thread.Sleep(10);

            Int32 port = 1234;
            TcpClient client = new TcpClient("127.0.0.1", port);
            Thread.Sleep(10);

            Byte[] data = new Byte[256];
            data = System.Text.Encoding.ASCII.GetBytes("3");
            Thread.Sleep(10);

            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);

            Thread.Sleep(10);

            Byte[] oggetto = new Byte[256];
           // oggetto = System.Text.Encoding.ASCII.GetBytes();
            stream.Write(oggetto, 0, oggetto.Length);



        }


    }
 }

