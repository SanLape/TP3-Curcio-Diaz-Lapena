using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Imagen
    {
        public int ID { get; set; }
        public string ImagenUrl { get; set; }


        public override string ToString()       // SOBREESCRITURA DEL METODO -> VIDEO -> Sobreescritura de metodo: 8:18
        {
            return ImagenUrl;
        }

    }
}
