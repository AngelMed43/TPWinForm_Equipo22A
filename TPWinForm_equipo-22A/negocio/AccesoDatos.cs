using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS;database=CATALOGO_P3_DB; Integrated Security=True");
            comando = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;

            //Agregado ya que no limpia los parametros anteriores
            comando.Parameters.Clear();
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();

                // Añadido porque no cierra la conexión
                // conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object ejecutarAccionConRetorno()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                return comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void cerrarConexion()
        {
            if (Lector != null) lector.Close();
            conexion.Close();
        }

        public void setearParametros(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
    }
}

