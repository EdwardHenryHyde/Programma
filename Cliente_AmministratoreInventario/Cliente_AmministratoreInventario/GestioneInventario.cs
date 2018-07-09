using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_AmministratoreInventario
{
    public partial class GestioneInventario : Form
    {
        public int riga = 0;
        public GestioneInventario()
        {
            InitializeComponent();

            //popolo la tabella

            tableLayoutPanel1.Controls.Add(new RadioButton {  Dock = DockStyle.None }, 0, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text="34" }, 1, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "23543" }, 2, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "Biscotti Kinder Delice" }, 3, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "2,45€" }, 4, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "10%" }, 5, riga);
            riga++;

            tableLayoutPanel1.Controls.Add(new RadioButton { Dock = DockStyle.None }, 0, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "233" }, 1, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "56756" }, 2, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "Acqua Panna 2lt" }, 3, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "0,89€" }, 4, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "5%" }, 5, riga);
            riga++;

            tableLayoutPanel1.Controls.Add(new RadioButton { Dock = DockStyle.None }, 0, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "54" }, 1, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "34553" }, 2, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "Carta Igenica 6pz" }, 3, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "3,22€" }, 4, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "15%" }, 5, riga);
            riga++;


            tableLayoutPanel1.Controls.Add(new RadioButton { Dock = DockStyle.None }, 0, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "332" }, 1, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "54353" }, 2, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "Latte Parmalat 0,5lt" }, 3, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "1,09€" }, 4, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "15%" }, 5, riga);
            riga++;

            tableLayoutPanel1.Controls.Add(new RadioButton { Dock = DockStyle.None }, 0, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "233" }, 1, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "65463" }, 2, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "Bagnoschiuma 0,7lt" }, 3, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "2,99€" }, 4, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "5%" }, 5, riga);
            riga++;

            tableLayoutPanel1.Controls.Add(new RadioButton { Dock = DockStyle.None }, 0, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "15" }, 1, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "34311" }, 2, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "Iphone X" }, 3, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "1245,99€" }, 4, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "3%" }, 5, riga);
            riga++;

            tableLayoutPanel1.Controls.Add(new RadioButton { Dock = DockStyle.None }, 0, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "1234" }, 1, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "44332" }, 2, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "Goleador fragola" }, 3, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "0,10€" }, 4, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "10%" }, 5, riga);
            riga++;

            tableLayoutPanel1.Controls.Add(new RadioButton { Dock = DockStyle.None }, 0, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "321" }, 1, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "55344" }, 2, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "Uovo Kinder" }, 3, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "1,39€" }, 4, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "5%" }, 5, riga);
            riga++;

            tableLayoutPanel1.Controls.Add(new RadioButton { Dock = DockStyle.None }, 0, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "43" }, 1, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "56775" }, 2, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "Cover Iphone X" }, 3, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "24,45€" }, 4, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "10%" }, 5, riga);
            riga++;

            tableLayoutPanel1.Controls.Add(new RadioButton { Dock = DockStyle.None }, 0, 9);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "81" }, 1, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "25244" }, 2, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "Samsung s9+" }, 3, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "822,00€" }, 4, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "5%" }, 5, riga);
            riga++;

            tableLayoutPanel1.Controls.Add(new RadioButton { Dock = DockStyle.None }, 0, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "34" }, 1, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "34579" }, 2, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "Cover s9+" }, 3, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "20,45€" }, 4, riga);
            tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = "10%" }, 5, riga);
            riga++;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void aggiungiButton_Click(object sender, EventArgs e)
        {

            Aggiungi aggiungi = new Aggiungi(this);
            aggiungi.Show();



          
        }

        private void rimuoviButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.RemoveAt(66);
            Thread.Sleep(10);
            tableLayoutPanel1.Controls.RemoveAt(66);
            Thread.Sleep(10);
            tableLayoutPanel1.Controls.RemoveAt(66);
            Thread.Sleep(10);
            tableLayoutPanel1.Controls.RemoveAt(66);
            Thread.Sleep(10);
            tableLayoutPanel1.Controls.RemoveAt(66);
            Thread.Sleep(10);
            tableLayoutPanel1.Controls.RemoveAt(66);
            Thread.Sleep(10);
        }

        private void modificaButton_Click(object sender, EventArgs e)
        {

            Modifica modifica = new Modifica(this);
            modifica.Show();




           


        }
    }
}
