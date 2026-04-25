using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {

        public List<Articulo> listarArticulos()
        {
            AccesoDatos acceso = new AccesoDatos();
            List<Articulo> listaArticulo = new List<Articulo>();

            try
            {
                acceso.setearConsulta("Select Codigo, Nombre, Descripcion, Precio from ARTICULOS");
                acceso.ejecutarLectura();

                while (acceso.Lector.Read())
                {
                    Articulo art = new Articulo();
                    art.Codigo = acceso.Lector.GetString(0);
                    art.Nombre = acceso.Lector.GetString(1);
                    art.Descripcion = acceso.Lector.GetString(2);
                    art.Precio = acceso.Lector.GetDecimal(3);

                    listaArticulo.Add(art);
                }
                return listaArticulo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                acceso.cerrarConexion();
            }
        }

        // AUN NO SE IMPLEMENTA PERO SE DEJA DIAGRAMADA
        public List<Articulo> detalleArticulo()
        {
            AccesoDatos acceso = new AccesoDatos();
            List<Articulo> listaArticulo = new List<Articulo>();

            try
            {
                acceso.setearConsulta("Select Id,Codigo, Nombre, Descripcion,IdMarca,IdCategoria, Precio from ARTICULOS");
                acceso.ejecutarLectura();

                while (acceso.Lector.Read())
                {
                    Articulo art = new Articulo();
                    art.Id = acceso.Lector.GetInt32(0);
                    art.Codigo = acceso.Lector.GetString(1);
                    art.Nombre = acceso.Lector.GetString(2);
                    art.Descripcion = acceso.Lector.GetString(3);
                    //art.Marca = (int)acceso.Lector.GetInt32(4);
                    //art.Categoria = (int)acceso.Lector.GetString(5);
                    art.Precio = acceso.Lector.GetDecimal(6);



                    listaArticulo.Add(art);
                }
                return listaArticulo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                acceso.cerrarConexion();
            }
        }
    }
}
