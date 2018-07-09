using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_AmministratoreInventario
{
    public partial class Aggiungi : Form
    {

        GestioneInventario gestioneInventario;
        
        public Aggiungi(GestioneInventario gestione)
        {
            gestioneInventario = gestione;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gestioneInventario.tableLayoutPanel1.Controls.Add(new RadioButton { Dock = DockStyle.None }, 0, gestioneInventario.riga);
            gestioneInventario.tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = textBox1.Text }, 1, gestioneInventario.riga);
            gestioneInventario.tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = textBox2.Text }, 2, gestioneInventario.riga);
            gestioneInventario.tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = textBox3.Text }, 3, gestioneInventario.riga);
            gestioneInventario.tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = textBox4.Text }, 4, gestioneInventario.riga);
            gestioneInventario.tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = textBox5.Text }, 5, gestioneInventario.riga);
            gestioneInventario.riga++;
            this.Close();
        }
    }
}
