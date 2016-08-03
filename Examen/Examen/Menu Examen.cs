using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Menu_Examen_Load(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            frmAgregarAlumno frm = new frmAgregarAlumno();
            frm.Show();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarAlumno frm1 = new frmModificarAlumno();
            frm1.Show();
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            frmVerCurso frm2 = new frmVerCurso();
            frm2.Show();
        }
    }
}
