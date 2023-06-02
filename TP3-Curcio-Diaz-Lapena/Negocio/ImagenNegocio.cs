using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ImagenNegocio
    {
        
        public List<Imagen> listar()
        {
            List<Imagen> lista = new List<Imagen>();  // LISTA DEL OBJETO
            AccesoDatos datos = new AccesoDatos();          // SE CONFIGURA LA CONECCION (EN ACCESO DATOS)

            try
            {

                datos.setConsulta("SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.ID = (int)datos.Lector["Id"];
                    
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);

                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}

