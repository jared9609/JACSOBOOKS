using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entities;

namespace DataAccess
{
    public class DropDownListDal
    {
        #region mostrarPaises
        public static DataTable mostrarPaises()
        {
            //creando el datatable
            DataTable dtPaises = new DataTable();

            //añadiendo las columnas que llevara el datatable
            dtPaises.Columns.Add("PkCountry", typeof(int));
            dtPaises.Columns.Add("Description", typeof(String));

            //Añadir una fila o registro a el DataTable
            dtPaises.Rows.Add("0", "--Seleccione--");

            //espacio de nombres de la cadena de conexion
            using (var dbCtx = new dbAssistEntities())
            {
                //Query que traera la informacion de la base de datos
                var query = (from p in dbCtx.Pais select p).ToList();

                //ciclo for para crear las filas con la informacion de la base de datos
                query.ToList().ForEach((p) =>
                {
                    //creando una fila en el datatable
                    DataRow Row = dtPaises.NewRow();

                    //columnas que llevara la fila
                    Row.SetField<int>("PkCountry", p.PkCountry);
                    Row.SetField<string>("Descripcion", p.Description);

                    //Añadir la fila creada al DataTable
                    dtPaises.Rows.Add(Row);

                });
            }
            //regresar al DataTable con la informacion
            return dtPaises;
        }
        #endregion

        #region mostrarEstados
        public static DataTable mostrarEstado(int PaisId)
        {
            //creando el datatable
            DataTable dtEstado = new DataTable();

            //añadiendo las columnas que llevara el datatable
            dtEstado.Columns.Add("PkState", typeof(int));
            dtEstado.Columns.Add("Description", typeof(String));

            //Añadir una fila o registro a el DataTable
            dtEstado.Rows.Add("0,", "--Seleccione--");

            //espacio de nombres de la cadena de conexion
            using (var dbCtx = new dbAssistEntities())
            {
                //Query que traera la informacion de la base de datos
                var query = (from e in dbCtx.Estadoes where e.FkCountry == PaisId select e).ToList();

                //ciclo for para crear las filas con la informacion de la base de datos
                query.ToList().ForEach((p) =>
                {
                    //creando una fila en el datatable
                    DataRow Row = dtEstado.NewRow();

                    //columnas que llevara la fila
                    Row.SetField<int>("PkCountry", p.PkState);
                    Row.SetField<string>("Descripcion", p.Description);

                    //Añadir la fila creada al DataTable
                    dtEstado.Rows.Add(Row);

                });
            }
            //regresar al DataTable con la informacion
            return dtEstado;
        }
        #endregion

        #region mostrarMunicipios
        public static DataTable mostrarMunicipios(int EstadoId)
        {
            //creando el datatable
            DataTable dtMunicipios = new DataTable();

            //añadiendo las columnas que llevara el datatable
            dtMunicipios.Columns.Add("PkCity", typeof(int));
            dtMunicipios.Columns.Add("Description", typeof(String));

            //Añadir una fila o registro a el DataTable
            dtMunicipios.Rows.Add("0,", "--Seleccione--");

            //espacio de nombres de la cadena de conexion
            using (var dbCtx = new dbAssistEntities())
            {
                //Query que traera la informacion de la base de datos
                var query = (from m in dbCtx.Municipios where m.FkState == EstadoId select m).ToList();

                //ciclo for para crear las filas con la informacion de la base de datos
                query.ToList().ForEach((p) =>
                {
                    //creando una fila en el datatable
                    DataRow Row = dtMunicipios.NewRow();

                    //columnas que llevara la fila
                    Row.SetField<int>("PkCity", p.PkCity);
                    Row.SetField<string>("Descripcion", p.Description);

                    //Añadir la fila creada al DataTable
                    dtMunicipios.Rows.Add(Row);

                });
            }
            //regresar al DataTable con la informacion
            return dtMunicipios;
        }
        #endregion




    }
}
