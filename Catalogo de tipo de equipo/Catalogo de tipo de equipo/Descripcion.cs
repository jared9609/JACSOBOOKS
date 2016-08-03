using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo_de_tipo_de_equipo
{
    public partial class frmDescripcion : Form
    {
        public frmDescripcion()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDesktop_Click(object sender, EventArgs e)
        {
            frmCrear frm2 = new frmCrear();

            frm2.Show();

            this.Close();
        }

        private void btnLaptop_Click(object sender, EventArgs e)
        {
            frmCrear frm2 = new frmCrear();
            frm2.Show();
            this.Close();
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            frmCrear frm2 = new frmCrear();
            frm2.Show();
            this.Close();
        }
    }
}
