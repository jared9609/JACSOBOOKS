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
    public partial class frmVerCurso : Form
    {
        public frmVerCurso()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtVer.Text = "Desarrollo de aplicaciones";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtVer.Text = "Programacion";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtVer.Text = "Seminario de sistemas";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtVer.Text = "Desarrollo de aplicaciones web";
        }
    }
}
