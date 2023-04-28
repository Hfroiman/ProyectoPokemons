using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Pokemon
{
    public class PokemonNegocio
    {
        public List<pokemon> Listar()
        {
            List<pokemon> lista = new List<pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "Server=.\\SQLEXPRESS; database= POKEDEX_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT p.Numero, p.Nombre, p.Descripcion, p.UrlImagen, e.Descripcion as tipo, el.Descripcion as Debilidad from POKEMONS p INNER JOIN ELEMENTOS e on p.IdTipo=e.Id INNER JOIN ELEMENTOS el on el.Id=p.IdDebilidad";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    pokemon obj = new pokemon();

                    obj.Numero = (int)lector["Numero"];
                    obj.Nombre = (string)lector["Nombre"];
                    obj.Descripcion = (string)lector["Descripcion"];
                    obj.URLImagen = (string)lector["URLImagen"];

                    obj.Tipo = new Elemento();
                    obj.Tipo.Descripcion = (string)lector["Tipo"];

                    obj.Debilidad = new Elemento();
                    obj.Debilidad.Descripcion = (string)lector["Debilidad"];
                    

                    lista.Add(obj);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
