using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial
{
    public partial class ListadoComentarios : System.Web.UI.Page
    {
        DataClasses1DataContext db = daoConexion.GetDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                CargarComentarios();
            }

        }

        protected void CargarComentarios()
        {
            try
            {
                var comentarios = from c in db.comentarios
                                  join a in db.alumnos on c.AlumnoId equals a.Id
                                  select new
                                  {
                                      a.DNI,
                                      a.Apellido,
                                      c.Comentario,
                                      c.Id
                                  };

                DataGrid.DataSource = comentarios.ToList();
                DataGrid.DataBind();
            }
            catch (Exception ex)
            {
                Exceptions.MensajearError("Error al cargar los comentarios", ex, Response);
            }
        }

        protected void DataGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            DataGrid.EditIndex = e.NewEditIndex;
            CargarComentarios();
        }

        protected void DataGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int comentarioId = Convert.ToInt32(DataGrid.DataKeys[e.RowIndex].Value);
                var comentario = db.comentarios.FirstOrDefault(c => c.Id == comentarioId);
                if (comentario != null)
                {
                    db.comentarios.DeleteOnSubmit(comentario);
                    db.SubmitChanges();
                    CargarComentarios();
                }
            
        }

        protected void DataGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int comentarioId = Convert.ToInt32(DataGrid.DataKeys[e.RowIndex].Value);     
            GridViewRow row = DataGrid.Rows[e.RowIndex];

           
            TextBox txtComentario = (TextBox)row.FindControl("txtComentario");
            string nuevoComentario = txtComentario.Text;
   
            var comentario = db.comentarios.FirstOrDefault(c => c.Id == comentarioId);
            if (comentario != null)
            {
                comentario.Comentario = nuevoComentario;
                db.SubmitChanges();
            }                 
            DataGrid.EditIndex = -1;
            CargarComentarios();

        }
       

    }
}
