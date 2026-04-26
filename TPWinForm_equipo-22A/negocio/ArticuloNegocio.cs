using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public void insertArticulo(Articulo art)
        {

            AccesoDatos acceso = new AccesoDatos();

            try
            {
                acceso.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values (@Codigo,@Nombre,@Descripcion,@IdMarca, @IdCategoria,@Precio)");
                acceso.setearParametros("@Codigo", art.Codigo);
                acceso.setearParametros("@Nombre", art.Nombre);
                acceso.setearParametros("@Descripcion", art.Descripcion);
                acceso.setearParametros("@IdMarca", art.Marca.IdMarca);
                acceso.setearParametros("@IdCategoria",art.Categoria.IdCategoria);
                acceso.setearParametros("@Precio",art.Precio);
                
                
                acceso.ejecutarAccion();
            }
            catch (Exception ex)
            {
                
                //Por el momento
                //Por el momento
                //Por el momento
                MessageBox.Show(ex.ToString());
                //throw ex;
            }
            finally
            {
                acceso.cerrarConexion();
            }
        }

        public void agregarImagen(Imagen img, int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @Url)");
                datos.setearParametros("@IdArticulo", idArticulo);
                datos.setearParametros("@Url", img.UrlImagen);

                datos.ejecutarAccion();
            }
            finally
            {
                datos.cerrarConexion();
            }
        }




        // AUN NO SE IMPLEMENTA PERO SE DEJA DIAGRAMADA
        // AUN NO SE IMPLEMENTA PERO SE DEJA DIAGRAMADA
        // AUN NO SE IMPLEMENTA PERO SE DEJA DIAGRAMADA
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
                    art.Marca.IdMarca = (int)acceso.Lector.GetInt32(4);
                    art.Categoria.IdCategoria = acceso.Lector.GetInt32(5);
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


        public void eliminarArticulo(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                // Elimino primero las imagenes ya que hay una relación entre tablas
                datos.setearConsulta("Delete from IMAGENES where IdArticulo = @Id");
                datos.setearParametros("@Id", id);
                datos.ejecutarAccion();

                datos.setearConsulta("Delete from ARTICULOS where IdArticulo = @Id");
                datos.setearParametros("@Id", id);
                datos.ejecutarAccion();
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
