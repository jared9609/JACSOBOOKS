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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearNuevo_Click(object sender, EventArgs e)
        {
            frmCrear frm2 = new frmCrear();
            frm2.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmDescripcion frm1 = new frmDescripcion();
            frm1.Show();

        }
    }
}
