using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class frmModificarAlumno : Form
    {
        public frmModificarAlumno()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(local);Initial Catalog=Escuela;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String query = "INSERT UPDATE alumno(Nombre, Direccion, Telefono, DNI,FKCurso)VALUES('" + txtNombre.Text + "', '" + txtDireccion.Text + "','" + txtTelefono.Text + "','" + txtDNI.Text + "', '" + txtCurso.Text + ")";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    MessageBox.Show("Modificado correctamente");
                    conn.Close();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtDNI.Clear();
            txtCurso.Clear();
        }
    }
}