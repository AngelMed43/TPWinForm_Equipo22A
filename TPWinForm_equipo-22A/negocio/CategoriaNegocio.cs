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
        private const int MaxDescripcion = 50;

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
                    aux.Descripcion = datos.Lector["Descripcion"] as string;

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
            ValidarCategoria(nueva, false);

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
            ValidarCategoria(categoria, true);

            if (!ExisteCategoriaPorId(categoria.IdCategoria))
                throw new Exception("La categoría a modificar no existe.");

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
            if (id <= 0)
                throw new Exception("Debe seleccionar una categoría válida.");

            if (!ExisteCategoriaPorId(id))
                throw new Exception("La categoría seleccionada no existe.");

            if (TieneArticulosAsociados(id))
                throw new Exception("No se puede eliminar la categoría porque tiene artículos asociados.");

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

        private void ValidarCategoria(Categoria categoria, bool esModificacion)
        {
            if (categoria == null)
                throw new Exception("Los datos de la categoría son obligatorios.");

            if (esModificacion && categoria.IdCategoria <= 0)
                throw new Exception("El identificador de la categoría es inválido.");

            if (string.IsNullOrWhiteSpace(categoria.Descripcion))
                throw new Exception("La descripción de la categoría es obligatoria.");

            categoria.Descripcion = categoria.Descripcion.Trim();

            if (categoria.Descripcion.Length > MaxDescripcion)
                throw new Exception("La descripción de la categoría no puede superar los 50 caracteres.");

            int? idExcluir = esModificacion ? (int?)categoria.IdCategoria : null;
            if (ExisteDescripcion(categoria.Descripcion, idExcluir))
                throw new Exception("Ya existe una categoría con la misma descripción.");
        }

        private bool ExisteDescripcion(string descripcion, int? idExcluir)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select count(1) from CATEGORIAS where UPPER(LTRIM(RTRIM(Descripcion))) = UPPER(LTRIM(RTRIM(@desc)))";

                if (idExcluir.HasValue)
                    consulta += " and Id <> @id";

                datos.setearConsulta(consulta);
                datos.setearParametros("@desc", descripcion);

                if (idExcluir.HasValue)
                    datos.setearParametros("@id", idExcluir.Value);

                object resultado = datos.ejecutarAccionConRetorno();
                int cantidad = Convert.ToInt32(resultado);
                return cantidad > 0;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        private bool ExisteCategoriaPorId(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select count(1) from CATEGORIAS where Id = @id");
                datos.setearParametros("@id", id);

                object resultado = datos.ejecutarAccionConRetorno();
                int cantidad = Convert.ToInt32(resultado);
                return cantidad > 0;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        private bool TieneArticulosAsociados(int idCategoria)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select count(1) from ARTICULOS where IdCategoria = @idCategoria");
                datos.setearParametros("@idCategoria", idCategoria);

                object resultado = datos.ejecutarAccionConRetorno();
                int cantidad = Convert.ToInt32(resultado);
                return cantidad > 0;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
