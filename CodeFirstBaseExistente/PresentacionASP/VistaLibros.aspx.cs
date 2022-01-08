using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionASP
{
    public partial class VistaLibros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                TraerLibros();
            }
        }

        void TraerLibros()
        {
            Logica.Libro objLogicaLibro = new Logica.Libro();
            gvLibros.DataSource = objLogicaLibro.TraerTodos();
            gvLibros.DataBind();
        }

        protected void gvLibros_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvLibros.PageIndex = e.NewPageIndex;
            TraerLibros();
        }
    }
}