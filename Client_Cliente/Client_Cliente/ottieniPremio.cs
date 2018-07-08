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
        int saldo = 2300;
        int pentole = 900;
        int piatti = 600;
        int bicchieri = 500;
        int materasso = 2500;

        public ottieniPremio()
        {
            InitializeComponent();
            label6.Text = saldo.ToString();
            label7.ResetText();
            label9.Text = label6.Text;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            InterfacciaCliente interfacciaCliente = new InterfacciaCliente();
            interfacciaCliente.Show();
            this.Close();
        }

        private void elencoScontriniButton_Click(object sender, EventArgs e)
        {
            ElencoScontrini elencoScontrini = new ElencoScontrini();
            elencoScontrini.Show();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (saldo >= pentole)
                {
                    label7.Text = "-" + pentole.ToString();
                    label9.Text = (saldo - pentole).ToString();
                }
                else
                {
                    MessageBox.Show("Saldo Punti insufficente");
                    label9.Text = saldo.ToString();

                }
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                if (saldo >= piatti)
                {
                    label7.Text = "-" + piatti.ToString();
                    label9.Text = (saldo - piatti).ToString();
                }
                else
                {
                    MessageBox.Show("Saldo Punti insufficente");
                    label9.Text = saldo.ToString();
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                if (saldo >= bicchieri)
                {
                    label7.Text = "-" + bicchieri.ToString();
                    label9.Text = (saldo - bicchieri).ToString();
                }
                else
                {
                    MessageBox.Show("Saldo Punti insufficente");
                    label9.Text = saldo.ToString();

                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                if (saldo >= materasso)
                {
                    label7.Text = "-" + materasso.ToString();
                    label9.Text = (saldo - materasso).ToString();
                }
                else
                {
                    MessageBox.Show("Saldo Punti insufficente");
                    label9.Text = saldo.ToString();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (saldo >= pentole)
                {
                    saldo = saldo - pentole;
                    MessageBox.Show("premio acquistato!");
                    label6.Text = saldo.ToString();
                    label7.ResetText();
                    label9.Text = label6.Text;
                }
                else
                {
                    MessageBox.Show("Saldo Punti insufficente!");
                }
            }
            if (radioButton2.Checked)
            {

                if (saldo >= piatti)
                {
                    saldo = saldo - piatti;
                    MessageBox.Show("premio acquistato!");
                    label6.Text = saldo.ToString();
                    label7.ResetText();
                    label9.Text = label6.Text;
                }
                else
                {
                    MessageBox.Show("Saldo Punti insufficente!");
                }
               
            }
            if (radioButton3.Checked)
            {

                if (saldo >= bicchieri)
                {
                    saldo = saldo - bicchieri;
                    MessageBox.Show("premio acquistato!");
                    label6.Text = saldo.ToString();
                    label7.ResetText();
                    label9.Text = label6.Text;
                }
                else
                {
                    MessageBox.Show("Saldo Punti insufficente!");
                }
               
            }
            if (radioButton4.Checked)
            {
                if (saldo >= materasso)
                {
                    saldo = saldo - materasso;
                    MessageBox.Show("premio acquistato!");
                    label6.Text = saldo.ToString();
                    label7.ResetText();
                    label9.Text = label6.Text;
                }
                else
                {
                    MessageBox.Show("Saldo Punti insufficente!");
                }
                
            }
        }

        private void ottieniPremioButton_Click(object sender, EventArgs e)
        {

        }
    }
}
