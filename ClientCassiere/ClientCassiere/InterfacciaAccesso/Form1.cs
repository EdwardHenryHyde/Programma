﻿using System;
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

namespace ClientCassiere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';

        }

        private void Login_Click(object sender, EventArgs e)
        {
            

            Int32 port = 1235;
            TcpClient client = new TcpClient("127.0.0.1", port);
            Byte[] oggetto = new Byte[256];
            oggetto = System.Text.Encoding.ASCII.GetBytes("1");

            NetworkStream stream = client.GetStream();
            stream.Write(oggetto, 0, oggetto.Length);

            Thread.Sleep(10);
            Byte[] credenziali = new Byte[256];
            credenziali = System.Text.Encoding.ASCII.GetBytes(usernameTextBox.Text + ":" + passwordTextBox.Text);
            stream.Write(credenziali, 0, credenziali.Length);


            oggetto = new Byte[256];
            String responseData = String.Empty;
            Thread.Sleep(10);
            Int32 bytes = stream.Read(oggetto, 0, oggetto.Length);
            responseData = System.Text.Encoding.ASCII.GetString(oggetto, 0, bytes);


            if (responseData == "ok")
            {
                Thread.Sleep(10);
                InterfacciaCassiere interfacciaCassiere = new InterfacciaCassiere();
                interfacciaCassiere.Show();

            }
            else
            {
                MessageBox.Show("Credenziali Errate");
            }

            this.Hide();

        }
    }
}
