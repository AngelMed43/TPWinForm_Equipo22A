using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Conexion_BDD
{
    public class AccesoDatos
    {
        private SqlConnection ConexionBDD;
        private SqlCommand ComandoBDD;
        private SqlDataReader LectorBDD;

        public SqlDataReader LectorBdd
        {
            get { return LectorBDD; }
        }

        public AccesoDatos() 
        {
            ConexionBDD = new SqlConnection("server=.\\SQLEXPRESS;database=NOMBREBDD; intregrated security=true");
            ComandoBDD = new SqlCommand();
        }

        public void Consultas(string Consulta)
        {
            ComandoBDD.CommandType = System.Data.CommandType.Text;
            ComandoBDD.CommandText = Consulta;
        } 

        public void EjecutarLectura()
        {
            ComandoBDD.Connection = ConexionBDD;
            try
            {
                ConexionBDD.Open();
                LectorBDD = ComandoBDD.ExecuteReader();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void TerminarConexion()
        {
            if (LectorBdd != null) LectorBDD.Close();
            ConexionBDD.Close();
        }


    }
}
