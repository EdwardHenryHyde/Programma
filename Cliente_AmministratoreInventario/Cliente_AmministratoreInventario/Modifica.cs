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
    public partial class Modifica : Form
    {
        GestioneInventario gestioneInventario;
        public Modifica(GestioneInventario importedInventario)
        {
            gestioneInventario = importedInventario;
            InitializeComponent();
         
            textBox1.Text = "34";
            textBox2.Text = "23543";
            textBox3.Text = "Bisscotti Kinder Delice";
            textBox4.Text = "2,45";
            textBox5.Text = "10%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gestioneInventario.tableLayoutPanel1.Controls.RemoveAt(0);
            Thread.Sleep(10);
            gestioneInventario.tableLayoutPanel1.Controls.RemoveAt(0);
            Thread.Sleep(10);
            gestioneInventario.tableLayoutPanel1.Controls.RemoveAt(0);
            Thread.Sleep(10);
            gestioneInventario.tableLayoutPanel1.Controls.RemoveAt(0);
            Thread.Sleep(10);
            gestioneInventario.tableLayoutPanel1.Controls.RemoveAt(0);
            Thread.Sleep(10);
            gestioneInventario.tableLayoutPanel1.Controls.RemoveAt(0);
            Thread.Sleep(10);


            gestioneInventario.tableLayoutPanel1.Controls.Add(new RadioButton { Dock = DockStyle.None }, 0, 0);
            gestioneInventario.tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = textBox1.Text }, 1, 0);
            gestioneInventario.tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = textBox2.Text }, 2, 0);
            gestioneInventario.tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = textBox3.Text }, 3, 0);
            gestioneInventario.tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = textBox4.Text }, 4, 0);
            gestioneInventario.tableLayoutPanel1.Controls.Add(new Label { /* Dock = DockStyle.Fill , */ Text = textBox5.Text }, 5, 0);

            this.Close();
        }
    }
}
