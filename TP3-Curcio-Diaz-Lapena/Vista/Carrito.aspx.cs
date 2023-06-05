using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Vista
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        protected List<Articulo> ListaArticulo { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Cantidad"] = 0;
            }
            else
            {
                //txbCantidad.Text = Session["Cantidad"].ToString();
            }

            if (Session["Carrito"] != null)
            {
                ListaArticulo = (List<Articulo>)Session["Carrito"];
                rptDatos.DataSource = ListaArticulo;
                rptDatos.DataBind();
            }
            else
            {
                ListaArticulo = new List<Articulo>();
            }
        }

        protected void btnEliminar_click(object sender, EventArgs e)
            
        {
            
            
                if (Session["Carrito"] != null)
                {
                    List<Articulo> articulosCarrito = (List<Articulo>)Session["Carrito"];

                    string idArticuloSeleccionado = ((Button)sender).CommandArgument;

                    Articulo articuloAEliminar = articulosCarrito.FirstOrDefault(a => a.ID == int.Parse(idArticuloSeleccionado));
                    if (articuloAEliminar != null)
                    {
                        articulosCarrito.Remove(articuloAEliminar);
                    }

                    Session["Carrito"] = articulosCarrito;

                    Response.Redirect("Carrito.aspx");
                }
            
        }

        protected void btnPlus_Click(object sender, EventArgs e)
        {
            int cantidad;
            //if (int.TryParse(txbCantidad.Text, out cantidad))
           // {
             //   cantidad = cantidad + 1;
                //txbCantidad.Text = cantidad.ToString();

                //Session["Cantidad"] = cantidad;
                

            //}
        }

        protected void btnLess_Click(object sender, EventArgs e)
        {
            //int cantidad;
            //if (int.TryParse(txbCantidad.Text, out cantidad))
            //{
              //  cantidad = cantidad - 1;
                //txbCantidad.Text = cantidad.ToString();

                //Session["Cantidad"] = cantidad;
                
            //}
        }

        protected void rptDatos_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Label lblNombre = (Label)e.Item.FindControl("lblNombre");
                TextBox txbCantidad = (TextBox)e.Item.FindControl("txbCantidad");

                Articulo articulo = (Articulo)e.Item.DataItem;
                
            }
        }
    }
}
