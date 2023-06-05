using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Vista
{
    public partial class Default : System.Web.UI.Page
    {


        public List<Articulo> ListaArticulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {


            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulo = negocio.listarConSP();

            if (!IsPostBack)
            {
                repRepetidor.DataSource = ListaArticulo;
                repRepetidor.DataBind();
            }




        }

        protected void btnAddCart_Click(object sender, EventArgs e)
        {
            string id = ((Button)sender).CommandArgument;
            int idArticulo = int.Parse(id);

            Articulo articulo = ListaArticulo.FirstOrDefault(a => a.ID == idArticulo);

            if (articulo != null)
            {
                // Obtener la lista de artículos en el carrito desde la sesión
                List<Articulo> carrito;

                if (Session["Carrito"] != null)
                {
                    carrito = (List<Articulo>)Session["Carrito"];
                }
                else
                {
                    carrito = new List<Articulo>();
                }

                // Agregar el artículo seleccionado al carrito
                carrito.Add(articulo);

                // Actualizar la variable de sesión con la lista actualizada del carrito
                Session["Carrito"] = carrito;
            }
        }

    }
}
