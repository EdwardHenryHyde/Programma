using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_GestoreNegozio
{
    public partial class InterfacciaGestoreNegozio : Form
    {
        public InterfacciaGestoreNegozio()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void elencoScontriniButton_Click(object sender, EventArgs e)
        {
            Perdata perdata = new Perdata();
            perdata.Show();
            this.Close();
        }

        private void ottieniPremioButton_Click(object sender, EventArgs e)
        {
            ReportMensile reportMensile = new ReportMensile();
            reportMensile.Show();
            this.Close();
        }
    }
}
