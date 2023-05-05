using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ConexionBD
    {
        private SqlConnection Conexion;

        private SqlCommand Comando;

        private SqlDataReader Lector;

        public SqlDataReader lector
        {
            get { return Lector;}
        }

        public ConexionBD()
        {
                Conexion = new SqlConnection("Server =.\\SQLEXPRESS; database = POKEDEX_DB; integrated security = true");
                Comando = new SqlCommand();
        }

        public void SetearConsulta(string consulta)
        {
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = consulta;
        }
        public void EjecutarConsulta()
        {
            Comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                Lector = Comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void CerraConexion()
        {
            if(Lector!= null)
            {
                Lector.Close();
            }
            Conexion.Close();
        }
    }
}
