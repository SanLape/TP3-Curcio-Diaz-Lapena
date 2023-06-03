using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";
            
            if (id != null)
            {
                ArticuloNegocio articulo = new ArticuloNegocio();
                Articulo seleccionado = (articulo.listar(id))[0];

                txtCodigo.Text = seleccionado.Codigo;
                txtNombre.Text = seleccionado.Nombre;
                txtDescripcion.Text = seleccionado.Descripcion;
                txtMarca.Text = seleccionado.marca.ToString();
                txtCategoria.Text = seleccionado.categoria.ToString();
                txtPrecio.Text = seleccionado.precio.ToString();
                //imgArticulo = seleccionado.imagenUrl.ToString();
                
            }

        }
    }
}