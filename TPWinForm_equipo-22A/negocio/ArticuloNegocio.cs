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
                acceso.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio,A.IdMarca, M.Descripcion AS Marca, A.IdCategoria, C.Descripcion AS Categoria FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id");
                //acceso.setearConsulta("SELECT Id, Codigo, Nombre, Descripcion, Precio FROM ARTICULOS");
                acceso.ejecutarLectura();

                while (acceso.Lector.Read())
                {
                    Articulo art = new Articulo();
                    art.Id = acceso.Lector.GetInt32(0); 
                    art.Codigo = acceso.Lector.GetString(1);
                    art.Nombre = acceso.Lector.GetString(2);
                    art.Descripcion = acceso.Lector.GetString(3);
                    art.Precio = acceso.Lector.GetDecimal(4);

                    int? idMarca = acceso.Lector.IsDBNull(5) ? (int?)null : acceso.Lector.GetInt32(5);
                    int? idCategoria = acceso.Lector.IsDBNull(7) ? (int?)null : acceso.Lector.GetInt32(7);

                    if (idMarca != null)
                    {
                        art.Marca = new Marca();
                        art.Marca.IdMarca = idMarca.Value;

                        if (!acceso.Lector.IsDBNull(6))
                            art.Marca.Descripcion = acceso.Lector.GetString(6);
                    }

                    
                    if (idCategoria != null)
                    {
                        art.Categoria = new Categoria();
                        art.Categoria.IdCategoria = idCategoria.Value;

                        if (!acceso.Lector.IsDBNull(8))
                            art.Categoria.Descripcion = acceso.Lector.GetString(8);

                        
                    }
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
                // Sin agregar esto, la conexión sigue abierta
                datos.cerrarConexion();

                datos.setearConsulta("Delete from ARTICULOS where Id = @Id");
                datos.setearParametros("@Id", id);
                datos.ejecutarAccion();
                datos.cerrarConexion();
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio,A.IdMarca, M.Descripcion AS Marca, A.IdCategoria, C.Descripcion AS Categoria FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id WHERE ";

                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "A.Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "A.Precio < " + filtro;
                            break;
                        default:
                            consulta += "A.Precio = " + filtro;
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

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo art = new Articulo();
                    art.Id = datos.Lector.GetInt32(0);
                    art.Codigo = datos.Lector.GetString(1);
                    art.Nombre = datos.Lector.GetString(2);
                    art.Descripcion = datos.Lector.GetString(3);
                    art.Precio = datos.Lector.GetDecimal(4);

                    int? idMarca = datos.Lector.IsDBNull(5) ? (int?)null : datos.Lector.GetInt32(5);
                    int? idCategoria = datos.Lector.IsDBNull(7) ? (int?)null : datos.Lector.GetInt32(7);

                    if (idMarca != null)
                    {
                        art.Marca = new Marca();
                        art.Marca.IdMarca = idMarca.Value;

                        if (!datos.Lector.IsDBNull(6))
                            art.Marca.Descripcion = datos.Lector.GetString(6);
                    }


                    if (idCategoria != null)
                    {
                        art.Categoria = new Categoria();
                        art.Categoria.IdCategoria = idCategoria.Value;

                        if (!datos.Lector.IsDBNull(8))
                            art.Categoria.Descripcion = datos.Lector.GetString(8);


                    }
                    lista.Add(art);
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
