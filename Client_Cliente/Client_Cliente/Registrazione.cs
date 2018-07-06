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
            Int32 port = 1236;
            TcpClient client = new TcpClient("127.0.0.1", port);
            Thread.Sleep(10);



            string linea = nomeTextBox.Text + ":" + cognomeTextBox.Text + ":" + dateTimePicker.Text + ":" + cittaTextBox.Text + ":" + provinciaTextBox.Text + ":" + capTextBox.Text + ":" + viaTextBox.Text + ":" + telefonoTextBox.Text + ":" + cartaTextBox.Text + ":" + passwordTextBox.Text;
            MessageBox.Show(linea);

            Thread.Sleep(10);

            Byte[] data = new Byte[256];
            data = System.Text.Encoding.ASCII.GetBytes("2");
            Thread.Sleep(10);

            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);
            Thread.Sleep(10);


            data = new Byte[256];
            data = System.Text.Encoding.ASCII.GetBytes(linea);
            Thread.Sleep(10);

            stream = client.GetStream();
            stream.Write(data, 0, data.Length);

            Thread.Sleep(10);

            Byte[] oggetto = new Byte[256];
            oggetto = new Byte[256];
            String responseData = String.Empty;
            Thread.Sleep(10);
            Int32 bytes = stream.Read(oggetto, 0, oggetto.Length);
            responseData = System.Text.Encoding.ASCII.GetString(oggetto, 0, bytes);
            string[] words = responseData.Split(':');

            string username = words[0];
            string password = words[1];

            MessageBox.Show("Username: " + username + "   Password: " + password);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }
    }
 }

