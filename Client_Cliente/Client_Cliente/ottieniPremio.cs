using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Cliente
{
    public partial class ottieniPremio : Form
    {
        public ottieniPremio()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            InterfacciaCliente interfacciaCliente = new InterfacciaCliente();
            interfacciaCliente.Show();
            this.Close();
        }

        private void elencoScontriniButton_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //2300
            label7.Text = "-900";
            label9.Text = "1400";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //2300
            label7.Text = "-600";
            label9.Text = "1700";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //2300
            label7.Text = "-500";
            label9.Text = "1800";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label7.ResetText();
            label9.Text = "2300";
            MessageBox.Show("Saldo Punti insufficente");
           
        }

    }
}
