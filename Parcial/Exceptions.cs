using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;
using System.Data.Common;

namespace Parcial
{
    public static class Exceptions
    {
        //Excepcion generica para utilizar en los formularios    
        public static void MensajearError(String mensaje , Exception ex, HttpResponse response)
        {
            response.Write($"<p style='color:red;'>{mensaje +" "+ ex.Message}</p>");
        }

    }
}