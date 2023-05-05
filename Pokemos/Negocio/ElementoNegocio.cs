using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ElementoNegocio
    {
        public List<Elemento> Listar()
        {
            List<Elemento> lista = new List<Elemento>();
            ConexionBD datos = new ConexionBD();
            try
            {
                datos.SetearConsulta("SELECT Id, Descripcion FROM ELEMENTOS");
                datos.EjecutarConsulta();
                while (datos.lector.Read())
                {
                    Elemento obj = new Elemento();
                    obj.Id = (int)datos.lector["Id"];
                    obj.Descripcion = (string)datos.lector["Descripcion"];

                    lista.Add(obj);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                datos.CerraConexion();
            }
        }
    }
}
