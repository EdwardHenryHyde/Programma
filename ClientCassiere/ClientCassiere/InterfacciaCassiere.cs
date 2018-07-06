using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace ClientCassiere
{

    public partial class InterfacciaCassiere : Form
    {
        //System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();

        Double totale = 0.00;
        string scontrino = "";


        

        public InterfacciaCassiere()
        {
            
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 login = new Form1();
            login.Show();
        }

        private void cartaButton_Click(object sender, EventArgs e)
        {

            Int32 port = 1234;
            TcpClient client = new TcpClient("127.0.0.1", port);

            Byte[] data = new Byte[256];
            data = System.Text.Encoding.ASCII.GetBytes("2");

            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);

            Thread.Sleep(10);
            data = System.Text.Encoding.ASCII.GetBytes("" + textBox1.Text);
            stream.Write(data, 0, data.Length);


            data = new Byte[256];
            String responseData = String.Empty;
            Thread.Sleep(10);
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

            nameLabel.Text = responseData;

            stream.Close();
            client.Close();

        }

        private void aggiungiProdotto_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            totaleLabel.Text = "" + totale;

            Int32 port = 1234;
            TcpClient client = new TcpClient("127.0.0.1", port);

            Byte[] oggetto = new Byte[256];
            oggetto = System.Text.Encoding.ASCII.GetBytes("1");

            NetworkStream stream = client.GetStream();
            stream.Write(oggetto, 0, oggetto.Length);

            oggetto = new Byte[256];
            String responseData = String.Empty;
            Thread.Sleep(10);
            Int32 bytes = stream.Read(oggetto, 0, oggetto.Length);
            responseData = System.Text.Encoding.ASCII.GetString(oggetto, 0, bytes);

            string[] words = responseData.Split(':');

            string nomeOggetto = words[0];
            Double prezzoOggetto = Double.Parse(words[1]);

            totale = totale + prezzoOggetto;
            scontrino = scontrino + "1:" + nomeOggetto + ":" + prezzoOggetto + ";";

            scontrinoPanel.Controls.Add(new Label() { Text = "1" });
            scontrinoPanel.Controls.Add(new Label() { Text = nomeOggetto });
            scontrinoPanel.Controls.Add(new Label() { Text = "" + prezzoOggetto });

            totaleLabel.Text = "" + totale;


        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            //resetto i campi

            nameLabel.ResetText();
            totaleLabel.ResetText();
            textBox1.Text = "";

            scontrinoPanel.Controls.Clear();
            scontrinoPanel.RowCount = 0;
            scontrino = "";
            totale = 0.00;
        }

        private void fineButton_Click(object sender, EventArgs e)
        {
            //clientSocket.Connect("127.0.0.1", 8888);


            string sendText = scontrino + "." + totale;
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

            string carta = textBox1.Text;
            Thread.Sleep(10);

            Byte[] oggetto = new Byte[256];
            oggetto = System.Text.Encoding.ASCII.GetBytes(sendText);
            stream.Write(oggetto, 0, oggetto.Length);


            nameLabel.ResetText();
            totaleLabel.ResetText();
            textBox1.Text = "";

            scontrinoPanel.Controls.Clear();
            scontrinoPanel.RowCount = 0;
            scontrino = "";
            totale = 0.00;

        }

        private void cartaSi_CheckedChanged(object sender, EventArgs e)
        {
            cartaButton.Enabled = true;
        }

        private void cartaNo_CheckedChanged(object sender, EventArgs e)
        {
            cartaButton.Enabled = false;
        }
    }
}
