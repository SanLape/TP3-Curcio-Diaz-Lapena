using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        //Id,Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio

        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string ImagenURL { get; set; }
        public decimal precio { get; set; }
        public Marca marca { get; set; }
        public Categoria categoria { get; set; }
    }
}
