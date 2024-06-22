using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Parcial
{
    public static class daoConexion
    {
        private static string ConnectionString = "Server=DES-ACOLEMAN;Database=parcial;Trusted_Connection=SSPI;MultipleActiveResultSets=true";

        //conexion generica para utilizar en los formularios
        public static DataClasses1DataContext GetDataContext()
        {
            SqlConnection conexion = new SqlConnection(ConnectionString);
            return new DataClasses1DataContext(conexion);
        }
    }
}