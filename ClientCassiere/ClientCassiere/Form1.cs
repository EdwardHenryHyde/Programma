using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            this.Hide();
            
            InterfacciaCassiere interfacciaCassiere = new InterfacciaCassiere();
            interfacciaCassiere.Show();

            
        }
    }
}
