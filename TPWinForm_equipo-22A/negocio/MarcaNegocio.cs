using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        private const int MaxDescripcion = 50;

        public List<Marca> listar()
        {
         
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion From Marcas;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();

                    aux.IdMarca = (int)datos.Lector["Id"];
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

        public void modificar(Marca marca)
        {
            ValidarMarca(marca, true);

            if (!ExisteMarcaPorId(marca.IdMarca))
                throw new Exception("La marca a modificar no existe.");

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update MARCAS set Descripcion = @desc Where Id = @id");
                datos.setearParametros("@desc", marca.Descripcion);
                datos.setearParametros("@id", marca.IdMarca);

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

        public void agregar(Marca nueva)
        {
            ValidarMarca(nueva, false);

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert Into Marcas (Descripcion) Values (@desc)");
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

        public void eliminar(int id)
        {
            if (id <= 0)
                throw new Exception("Debe seleccionar una marca válida.");

            if (!ExisteMarcaPorId(id))
                throw new Exception("La marca seleccionada no existe.");

            if (TieneArticulosAsociados(id))
                throw new Exception("No se puede eliminar la marca porque tiene artículos asociados.");

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from Marcas where id = @id");
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

        private void ValidarMarca(Marca marca, bool esModificacion)
        {
            if (marca == null)
                throw new Exception("Los datos de la marca son obligatorios.");

            if (esModificacion && marca.IdMarca <= 0)
                throw new Exception("El identificador de la marca es inválido.");

            if (string.IsNullOrWhiteSpace(marca.Descripcion))
                throw new Exception("La descripción de la marca es obligatoria.");

            marca.Descripcion = marca.Descripcion.Trim();

            if (marca.Descripcion.Length > MaxDescripcion)
                throw new Exception("La descripción de la marca no puede superar los 50 caracteres.");

            int? idExcluir = esModificacion ? (int?)marca.IdMarca : null;
            if (ExisteDescripcion(marca.Descripcion, idExcluir))
                throw new Exception("Ya existe una marca con la misma descripción.");
        }

        private bool ExisteDescripcion(string descripcion, int? idExcluir)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select count(1) from Marcas where UPPER(LTRIM(RTRIM(Descripcion))) = UPPER(LTRIM(RTRIM(@desc)))";

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

        private bool ExisteMarcaPorId(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select count(1) from Marcas where Id = @id");
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

        private bool TieneArticulosAsociados(int idMarca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select count(1) from ARTICULOS where IdMarca = @idMarca");
                datos.setearParametros("@idMarca", idMarca);

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

