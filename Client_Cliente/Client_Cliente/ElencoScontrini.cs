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
    public partial class ElencoScontrini : Form
    {
        public ElencoScontrini()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            InterfacciaCliente interfacciaCliente = new InterfacciaCliente();
            interfacciaCliente.Show();
            this.Close();
        }

        private void ottieniPremioButton_Click(object sender, EventArgs e)
        {
            ottieniPremio premio = new ottieniPremio();
            premio.Show();
            this.Close();
        }
    }
}
