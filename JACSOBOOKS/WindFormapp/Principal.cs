using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindFormapp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmChica frm1 = new frmChica();
            frm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCalendar frm2 = new frmCalendar();
            frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEscorpion frm3 = new frmEscorpion();
            frm3.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmOlvide frm4 = new frmOlvide();
            frm4.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmCiudad frm5 = new frmCiudad();
            frm5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmReyna frm6 = new frmReyna();
            frm6.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmViuda frm7 = new frmViuda();
            frm7.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmBesos frm8 = new frmBesos();
            frm8.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmOlvido frm9 = new frmOlvido();
            frm9.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmOlvide frm10 = new frmOlvide();
            frm10.ShowDialog();
        }
    }
}
