using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionASP
{
    public partial class ConsultaLibros : System.Web.UI.Page
    {
        Logica.Libro objLogicaLibro = new Logica.Libro();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TraerLibros();
            }
        }
        void TraerLibros()
        {

            gvLibros.DataSource = objLogicaLibro.TraerViewModel();
            gvLibros.DataBind();
        }

        protected void gvLibros_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvLibros.PageIndex = e.NewPageIndex;
            TraerLibros();
            gvAutores.Visible = false;
        }

        protected void gvLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvLibrosAutor.Visible = false;
            gvAutores.Visible = true;
            GridViewRow fila = gvLibros.SelectedRow;
            string strISBN = fila.Cells[1].Text;
            Entidades.Libro libro = objLogicaLibro.TraerxISBN(strISBN);
            gvAutores.DataSource = libro.Autores;
            gvAutores.DataBind();
        }

        protected void gvAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvLibrosAutor.Visible = true;
            GridViewRow fila = gvAutores.SelectedRow;
            int intIdAutor = Convert.ToInt32(fila.Cells[1].Text);
            Entidades.Autore autor = objLogicaLibro.TraerAutorxID(intIdAutor);
            gvLibrosAutor.DataSource = autor.Libros;
            gvLibrosAutor.DataBind();
        }
    }
}