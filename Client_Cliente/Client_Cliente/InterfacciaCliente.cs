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
    public partial class InterfacciaCliente : Form
    {
        public InterfacciaCliente()
        {
            InitializeComponent();
        }

        private void ottieniPremioButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ottieniPremio premio = new ottieniPremio();
            premio.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void elencoScontriniButton_Click(object sender, EventArgs e)
        {
            ElencoScontrini elencoScontrini = new ElencoScontrini();
            elencoScontrini.Show();
            this.Close();
        }
    }
}
