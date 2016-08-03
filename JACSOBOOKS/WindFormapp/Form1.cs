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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseDeDatos bd = new BaseDeDatos();

            string usuario = bd.selectstring("select usuario from Usuarios where usuario = '" + textBox1.Text + "'");
            string contraseña = bd.selectstring("select contraseña from Usuarios where contraseña = '" + textBox2.Text + "'");

            if (textBox1.TextLength > 0 && textBox2.TextLength > 0)
            {
                if (usuario == textBox1.Text && contraseña == textBox2.Text)
                {
                    Datos.Ac = bd.selectstring("select nivel from suarios where usuario = '" + textBox1.TextLength + "'");
                    
                    this.Hide();

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
