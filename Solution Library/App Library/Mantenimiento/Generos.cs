using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Mantenimiento
{
    public partial class Generos : Form
    {
        public Generos()
        {
            InitializeComponent();
        }

        BL.GeneroBL bl = new BL.GeneroBL();
        private void Generos_Load(object sender, EventArgs e)
        {
            dgbRegistros.DataSource = bl.listar();
        }

       
    }
}
