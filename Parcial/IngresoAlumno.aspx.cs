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
    public partial class IngresoAlumnos : System.Web.UI.Page
    {
        // Almaceno en db la conexion utilizada
        DataClasses1DataContext db = daoConexion.GetDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        // Metodo encargado de limpiar la informacion cargada 
        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
            txtMail.Text = "";
            opciones.SelectedIndex = 0;
        }
        // Metodo encargado de insertar en la base de datos y reenviar a MostrarDatos con un id_alumno almancenado en cache
        protected void btnEnviar_Click(object sender, EventArgs e) {
            try
            {
                alumnos alumnos = new alumnos();
                alumnos.Nombre = txtNombre.Text.Trim();
                alumnos.Apellido = txtApellido.Text.Trim();
                alumnos.DNI = txtDni.Text.Trim();
                alumnos.Email = txtMail.Text.Trim();
                alumnos.Turno = opciones.SelectedValue;
                this.db.alumnos.InsertOnSubmit(alumnos);
                this.db.SubmitChanges();
                Page.Session["alumno_id"] = alumnos.Id;
                Response.Redirect("MostrarDatos.aspx");
            }
            catch (Exception ex)
            {
                Exceptions.MensajearError("Error al insertar usuario", ex, Response);
            }         
        }


    }
}