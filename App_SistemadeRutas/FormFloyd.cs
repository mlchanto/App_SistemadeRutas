using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_SistemadeRutas
{
    public partial class FormFloyd : Form
    {
        public FormFloyd()
        {
            InitializeComponent();
        }
        public void CargarDatos(DataTable datos)
        {
            dgvFloyd.DataSource = datos;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormFloyd_Load(object sender, EventArgs e)
        {

        }
    }
}
