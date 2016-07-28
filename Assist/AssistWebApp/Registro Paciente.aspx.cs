using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace AssistWebApp
{
    public partial class Registro_Paciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillDropDownList(cboPais, "PkCountry", DropDownListBLL.mostrarPaises());
        }
            #region FillDropDownList

        private void FillDropDownList(HtmlSelect cbo, string valueField, DataTable dt)
        {
            cbo.DataSource = dt;
            cbo.DataValueField = valueField;
            cbo.DataTextField = "Description";
            cbo.DataBind();
        }
        #endregion

        private Registro_Paciente getValues()
        {
            Registro_Paciente p = new Registro_Paciente();

            p.Nombre = txtNombre.Value.ToString().Trim().ToUpper();
            p.Sexo = cboSexo.Value.ToString();
            p.Fec_Nac = Convert.ToDateTime(txtFechaNac.Value.ToString().Trim().ToUpper());
            p.FkCountry = Convert.ToInt32(ddlPais.SelectedValue.ToString());
            p.FkState = Convert.ToInt32(ddlMunicipio.SelectedValue.ToString());
            p.FkCity = Convert.ToInt32(ddlEstado.SelectedValue.ToString());
            p.Colonia = txtColonia.Value.ToString().Trim().ToUpper();
            p.Calle = txtCalle.Value.ToString().Trim().ToUpper();
            p.Cod_Postal = txtCodPostal.Value.ToString().Trim();
            p.Telefono = txtTelefono.Value.ToSring().Trim();
            p.Celular = txtCelular.Value.ToString().Trim();
            p.Email = txtEmail.Valu.ToString().Trim();
            p.CURP = txtCurp.Value.ToString().Trim().ToUpper();

        }





    }
}