using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionASP
{
    public partial class VistaAlgunos : System.Web.UI.Page
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

            gvLibros.DataSource = objLogicaLibro.TraerAlgunos();
            gvLibros.DataBind();
        }

        protected void gvLibros_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvLibros.PageIndex = e.NewPageIndex;
            TraerLibros();
        }

        protected void gvLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAutores.Items.Clear();
            GridViewRow filaSelect = gvLibros.SelectedRow;
            string strISBN = filaSelect.Cells[1].Text;
            foreach (var libro in objLogicaLibro.TraerTodos())
            {
                if (libro.ISBN == strISBN)
                {
                    foreach (var a in libro.Autores)
                    {
                        lbAutores.Items.Add($"{a.Apellido} , {a.Nombre} {a.Pais.Nombre}");
                    }
                }
            }
        }
    }
}