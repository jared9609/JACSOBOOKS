using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    class UserDAL
    {
        #region variables
        public static bool usuarioExistente(string user,String pass )
        { 
            var query = (from u in bd.Users
             where u.Username == user && u.Password == pass
             select u).Count();
            if (query > 0)
                return true;
            else
                return false;


    }

}
