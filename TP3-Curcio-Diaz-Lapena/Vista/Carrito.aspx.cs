using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_click(object sender, EventArgs e)
        {

        }

        protected void btnPlus_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(txbCantidad.Text);
            cantidad = cantidad + 1;
            txbCantidad.Text = cantidad.ToString();
        }

        protected void btnLess_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(txbCantidad.Text);
            cantidad = cantidad - 1;
            txbCantidad.Text = cantidad.ToString();
        }
    }
}