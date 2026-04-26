using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion_BDD
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {

            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion From CATEGORIAS;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                     Categoria aux = new Categoria();

                    aux.IdCategoria = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

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
        public void agregar(Categoria nueva)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert Into CATEGORIAS (Descripcion) Values (@desc)");
                datos.setearParametros("@desc", nueva.Descripcion);

                datos.ejecutarAccion();
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
        public void modificar(Categoria categoria)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update CATEGORIAS set Descripcion = @desc Where Id = @id");
                datos.setearParametros("@desc", categoria.Descripcion);
                datos.setearParametros("@id", categoria.IdCategoria);

                datos.ejecutarAccion();
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

        public void eliminarCategoria(int id)
        {
           AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from CATEGORIAS where id = @id");
                datos.setearParametros("@id", id);
                datos.ejecutarAccion();
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
        /*public int obtenerProximoId()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT MAX(Id) FROM CATEGORIAS");
                object resultado = datos.ejecutarAccionConRetorno();

                if (resultado == null || resultado is DBNull)
                    return 1;

                return ((int)resultado) + 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }*/
    }
}
