using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();          // SE CONFIGURA LA CONECCION (EN ACCESO DATOS)
            
            try
            {
                datos.setConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion Marca, A.IdCategoria, C.Descripcion Categoria, A.Precio from ARTICULOS A, CATEGORIAS C, MARCAS M WHERE A.IdCategoria = C.Id AND  A.IdMarca = M.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    //SE CREAO UN OBJETO AUXILIAR PARA CARGALO EN LA LECTURA Y SE AGRUEGA EN LA LSITA 

                    Articulo aux = new Articulo();
                    
                    aux.ID = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    
                    //idMarca
                    
                    aux.marca = new Marca();
                    aux.marca.ID = (int)datos.Lector["IdMarca"];
                    aux.marca.Descripcion = (string)datos.Lector["Marca"];          // ES EL ALIAS DE LA COLUMNA EN LA CONSULTA 
                    
                    //idCategoria

                    aux.categoria = new Categoria();
                    aux.categoria.ID = (int)(datos.Lector["IdCategoria"]);
                    aux.categoria.Descripcion = (string)datos.Lector["Categoria"];  // ES EL ALIAS DE LA COLUMNA EN LA CONSULTA 

                    aux.precio = (decimal)datos.Lector["Precio"];

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

        public void agregar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values ('" + art.Codigo + "', '" + art.Nombre + "', '" +  art.Descripcion + "' , @IdMarca, @idCategoria, " + art.precio + ")");
                datos.setParametro("@IdMarca", art.marca.ID);
                datos.setParametro("@idCategoria", art.categoria.ID);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); } 
        }

        public void modificar (Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idmarca, IdCategoria = @idcategoria, precio = @precio where Id = @id ");
                datos.setParametro("@codigo", articulo.Codigo);
                datos.setParametro("@nombre", articulo.Nombre);
                datos.setParametro("@descripcion", articulo.Descripcion);
                datos.setParametro("@idmarca", articulo.marca.ID);
                datos.setParametro("@idcategoria", articulo.categoria.ID);
                datos.setParametro("@precio", articulo.precio);
                datos.setParametro("@id", articulo.ID);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setConsulta("DELETE FROM ARTICULOS WHERE ID = @ID");
                datos.setParametro("@ID", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        
        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List <Articulo> lista = new List <Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion Marca, A.IdCategoria, C.Descripcion Categoria, A.Precio from ARTICULOS A, CATEGORIAS C, MARCAS M WHERE A.IdCategoria = C.Id AND  A.IdMarca = M.Id And ";
                if(campo == "Codigo")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "A.Codigo like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "A.Codigo like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "A.Codigo like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "A.Nombre like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "A.Nombre like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "A.Nombre like '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "A.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "A.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "A.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                datos.setConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    //SE CREAO UN OBJETO AUXILIAR PARA CARGALO EN LA LECTURA Y SE AGRUEGA EN LA LSITA 

                    Articulo aux = new Articulo();

                    aux.ID = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    //idMarca

                    aux.marca = new Marca();
                    aux.marca.ID = (int)datos.Lector["IdMarca"];
                    aux.marca.Descripcion = (string)datos.Lector["Marca"];          // ES EL ALIAS DE LA COLUMNA EN LA CONSULTA 

                    //idCategoria

                    aux.categoria = new Categoria();
                    aux.categoria.ID = (int)(datos.Lector["IdCategoria"]);
                    aux.categoria.Descripcion = (string)datos.Lector["Categoria"];  // ES EL ALIAS DE LA COLUMNA EN LA CONSULTA 

                    aux.precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
