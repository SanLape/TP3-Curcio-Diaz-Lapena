using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace Vista
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulo { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) // Verificar si la página es cargada por primera vez o es una carga posterior debido a una acción del usuario
            {
                // Asignar el valor inicial de la cantidad en 0
                Session["Cantidad"] = 0;
            }
            else
            {
                // La página es cargada posteriormente, restaurar el valor de la cantidad desde la sesión
                txbCantidad.Text = Session["Cantidad"].ToString();
            }

            if (Session["Carrito"] != null)
            {
                List<Articulo> carrito = (List<Articulo>)Session["Carrito"];
                ListaArticulo = carrito;
            }
            else
            {
                ListaArticulo = new List<Articulo>();
            }

            // Enlaza la lista de artículos al control Repeater
           
        }

        protected void btnEliminar_click(object sender, EventArgs e)
        {

        }

        protected void btnPlus_Click(object sender, EventArgs e)
        {
            int cantidad;
            if (int.TryParse(txbCantidad.Text, out cantidad))
            {
                cantidad = cantidad + 1;
                txbCantidad.Text = cantidad.ToString();

                Session["Cantidad"] = cantidad;
            }
        }

        protected void btnLess_Click(object sender, EventArgs e)
        {
            int cantidad;
            if (int.TryParse(txbCantidad.Text, out cantidad))
            {
                cantidad = cantidad - 1;
                txbCantidad.Text = cantidad.ToString();

                Session["Cantidad"] = cantidad;
            }
        }
    }
}