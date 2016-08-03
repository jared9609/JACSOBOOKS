using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
  public class DropDownListBLL
    {
        #region mostrarPaises
        public static DataTable mostrarPaises()
        {
            return DropDownListDal.mostrarPaises();
        }
        #endregion

        #region mostrarEstados
        public static DataTable mostrarEstado(int PaisId)
        {
            return DropDownListDal.mostrarEstado(PaisId);
        }
        #endregion

        #region mostrarPaises
        public static DataTable mostrarMunicipios(int EstadoId)
        {
            return DropDownListDal.mostrarMunicipios(EstadoId);
        }
#endregion
    }

}
