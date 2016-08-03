using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muestra_de_Excepciones
{
    public partial class frmMuestraExcepciones : Form
    {
        private int[] miarreglo = new int[] { 56, -2, 87 };
        string valorcadena = "";
        int numero = 2;

        public frmMuestraExcepciones()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void btnDivision_Click(object sender, EventArgs e)
        {
            CorrerExepciones(1);
        }

        private void btnIndice_Click(object sender, EventArgs e)
        {
            CorrerExepciones(2);
        }

      
        private void CorrerExepciones(int errorType)
        {
            try
            {
                switch (errorType)
                {

                    case 0:
                        int i1, i2, i3;
                        i1 = 99999999;
                        i2 = 99999999;
                        i3 = i1 * i2;
                        break;
                    case 1:
                        Decimal d1, d2, d3;
                        d1 = 34;
                        d2 = 0;
                        d3 = d1 / d2;
                        break;
                    case 2:
                        MessageBox.Show(miarreglo[3].ToString());
                        break;
                    case 3:
                        break;
                }

            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidCastException ex)
            {
            }
        }

        private void btnSobrecarga_Click(object sender, EventArgs e)
        {
            CorrerExepciones(0);
        }

        private void btnConversion_Click_1(object sender, EventArgs e)
        {
            CorrerExepciones(3);
        }
    }
}
