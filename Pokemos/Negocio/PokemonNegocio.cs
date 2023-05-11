using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
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
                comando.CommandText = "SELECT p.Id, p.Numero, p.Nombre, p.Descripcion, p.UrlImagen, e.Descripcion as tipo, el.Descripcion as Debilidad, el.Id iddebilidad, e.Id as idtipo from POKEMONS p INNER JOIN ELEMENTOS e on p.IdTipo=e.Id INNER JOIN ELEMENTOS el on el.Id=p.IdDebilidad";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    pokemon obj = new pokemon();

                    obj.Id = (int)lector["Id"];
                    obj.Numero = (int)lector["Numero"];
;                    obj.Nombre = (string)lector["Nombre"];
                    obj.Descripcion = (string)lector["Descripcion"];

                    if (!(lector["URLimagen"] is DBNull)) {
                        obj.URLImagen = (string)lector["URLImagen"];
                    }

                    obj.Tipo = new Elemento();
                    obj.Tipo.Descripcion = (string)lector["Tipo"];
                    obj.Tipo.Id = (int)lector["Idtipo"];

                    obj.Debilidad = new Elemento();
                    obj.Debilidad.Descripcion = (string)lector["Debilidad"];
                    obj.Debilidad.Id = (int)lector["iddebilidad"];
                    

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

        public void AgregarPokemon(pokemon nuevo)
        {
            ConexionBD datos = new ConexionBD();
            try
            {
                datos.SetearConsulta("INSERT into POKEMONS (Numero, nombre, Descripcion, activo, IdTipo, IdDebilidad, UrlImagen) VALUES (@num,@nomb,@descripcion,1, @idTipo, @Iddebilidad, @UrlImagen)");
                datos.setearparametro("@num",nuevo.Numero);
                datos.setearparametro("@nomb",nuevo.Nombre);
                datos.setearparametro("@descripcion", nuevo.Descripcion);
                datos.setearparametro("@idTipo", nuevo.Tipo.Id);
                datos.setearparametro("@Iddebilidad", nuevo.Debilidad.Id);
                datos.setearparametro("@UrlImagen", nuevo.URLImagen);
                datos.EjecutarAccion();
                datos.CerraConexion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerraConexion();
            }
        }
        public void Modificarpokemon(pokemon poke)
        {
            ConexionBD datos = new ConexionBD();
            try
            {
                datos.SetearConsulta("update POKEMONS set Numero=@Numero, Nombre=@Nombre, Descripcion=@Descripcion, UrlImagen=@UrlImagen, IdTipo=@IdTipo, IdDebilidad=@IdDebilidad, Activo=1 WHERE Id=@Id");
                datos.setearparametro("@Numero",poke.Numero);
                datos.setearparametro("@Nombre",poke.Nombre);
                datos.setearparametro("@Descripcion",poke.Descripcion);
                datos.setearparametro("@UrlImagen",poke.URLImagen);
                datos.setearparametro("@IdTipo",poke.Tipo.Id);
                datos.setearparametro("@IdDebilidad",poke.Debilidad.Id);
                datos.setearparametro("@Id",poke.Id);
                datos.EjecutarAccion();
                datos.CerraConexion();
            }
            catch (Exception ex )
            {

                throw ex;
            }
        }
        public void EliminacionFisica(int id)
        {
            ConexionBD datos = new ConexionBD();
            try
            {
                datos.SetearConsulta("DELETE from POKEMONS where id=@Id");
                datos.setearparametro("@Id", id);
                datos.EjecutarAccion();
                datos.CerraConexion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void eliminacionlogica(int id)
        {
            ConexionBD datos = new ConexionBD();
            try
            {
                datos.SetearConsulta("UPDATE POKEMONS set activo=0 WHERE id=@Id");
                datos.setearparametro("@Id", id);
                datos.EjecutarAccion();
                datos.CerraConexion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<pokemon> Filtrar(string criterio, string campo, string filtrar)
        {
            List<pokemon> listafiltrada = new List<pokemon>();
            ConexionBD datos = new ConexionBD();
            try
            {
                string consulta = "SELECT p.Id, p.Numero, p.Nombre, p.Descripcion, p.UrlImagen, e.Descripcion as tipo, el.Descripcion as Debilidad, el.Id iddebilidad, e.Id as idtipo from POKEMONS p INNER JOIN ELEMENTOS e on p.IdTipo=e.Id INNER JOIN ELEMENTOS el on el.Id=p.IdDebilidad WHERE ";
                switch (campo)
                {
                    case "Numero":
                        switch (criterio)
                        {
                            case "Menor que":
                                consulta += campo + " < " + filtrar;
                                break;
                            case "Igual que":
                                consulta += campo + " = " + filtrar;
                                break;
                            case "Mayor que":
                                consulta += campo + " > " + filtrar;
                                break;
                        }
                        break;
                    case "Nombre":
                        switch (criterio)
                        {
                            case "Empieza con":
                                consulta += campo + " like '" + filtrar + "%'";
                                break;
                            case "Termina con":
                                consulta += campo + " like '%" + filtrar + "'";
                                break;
                            case "Posee":
                                consulta += campo + " like '%" + filtrar + "%'";
                                break;
                        }
                        break;
                    case "Descripcion":
                        switch (criterio)
                        {
                            case "Empieza con":
                                consulta += "p."+campo + " like '" + filtrar + "%'";
                                break;
                            case "Termina con":
                                consulta += "p."+campo + " like '%" + filtrar + "'";
                                break;
                            case "Posee":
                                consulta += "p."+campo + " like '%" + filtrar + "%'";
                                break;
                        }
                        break;
                }
                datos.SetearConsulta(consulta);
                datos.EjecutarConsulta();
                while (datos.lector.Read())
                {
                    pokemon obj = new pokemon();

                    obj.Id = (int)datos.lector["Id"];
                    obj.Numero = (int)datos.lector["Numero"];
                    obj.Nombre = (string)datos.lector["Nombre"];
                    obj.Descripcion = (string)datos.lector["Descripcion"];

                    if (!(datos.lector["URLimagen"] is DBNull))
                    {
                        obj.URLImagen = (string)datos.lector["URLImagen"];
                    }

                    obj.Tipo = new Elemento();
                    obj.Tipo.Descripcion = (string)datos.lector["Tipo"];
                    obj.Tipo.Id = (int)datos.lector["Idtipo"];

                    obj.Debilidad = new Elemento();
                    obj.Debilidad.Descripcion = (string)datos.lector["Debilidad"];
                    obj.Debilidad.Id = (int)datos.lector["iddebilidad"];


                    listafiltrada.Add(obj);
                }               
                return listafiltrada;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
