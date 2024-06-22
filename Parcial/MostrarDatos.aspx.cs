using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial
{
    public partial class MostrarDatos : System.Web.UI.Page
    {
        // Almaceno en db la conexion utilizada
        DataClasses1DataContext db = daoConexion.GetDataContext();

        // Al iniciar el load de la pagina analizo si fue por un postback y si hay un id usuario en session 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Session["alumno_id"] != null)
            {
                try {
                    int alumnoId = Convert.ToInt32(Session["alumno_id"]);
                    CargarDatosAlumno(alumnoId);
                }
                catch (Exception ex)
                {
                    Exceptions.MensajearError("Error no se puedo cargar los datos del usuario", ex, Response);
                }
  
            }
        }

        // funcion encargada de obtener el dato del alumno que cargo sus datos, lo hace consultando por el id alumno  
        protected void CargarDatosAlumno(int alumnoId)
        {                   
            try
                {
                var alumno = this.db.alumnos.FirstOrDefault(a => a.Id == alumnoId);
                if (alumno != null)
                {
                    lblApellido.Text = alumno.Apellido;
                    lblNombre.Text = alumno.Nombre;
                    lblDNI.Text = alumno.DNI;
                    lblEmail.Text = alumno.Email;
                    lblTurno.Text = alumno.Turno;
                 }
                 else
                 {
                    Response.Write("<script>alert('No se encontró el alumno');</script>");
                 }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error al obtener al cargar alumno", ex);               
                }
            
        }

        // ACOLEMAN : Almacena los comentarios del alumno  su dni , apellido, y id alumno,
        // ambos los obtuve desde los label ya que en esta instancia el objeto no existe
        // y redirecciona a la pagina de inicio
        protected void btnGuardarComentario_Click(object sender, EventArgs e)
        {          
           if (Session["alumno_id"] != null)
            {           
                try
                {                         
                    comentarios comentario = new comentarios();                        
                    {                            
                        comentario.Comentario = txtComentario.Text.Trim();
                        comentario.DNI = lblDNI.Text.Trim();
                        comentario.Apellido = lblApellido.Text.Trim();
                        comentario.AlumnoId = Convert.ToInt32(Session["alumno_id"]);
                     };
                    this.db.comentarios.InsertOnSubmit(comentario);
                    this.db.SubmitChanges();
                    Response.Redirect("IngresoAlumno.aspx");                    
                }
                catch (Exception ex)
                {
                    Exceptions.MensajearError("Error al insertar comentario del alumno" + lblApellido.Text.Trim(), ex, Response);
                }
            }
            else
            {               
                Response.Write("<script>alert('No se ha proporcionado un Id de alumno válido');</script>");
            }
        }
    }
}