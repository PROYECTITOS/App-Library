using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lnkCerrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main pantalla = new Main();
            pantalla.Show();
        }
    }
}
