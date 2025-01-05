using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using negocio;
namespace WindowsFormsApp1
{
    public class PokemonNegocio
    {
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database= POKEDEX_DB; integrated security=true; ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT P.Numero, P.Nombre, P.Descripcion, P.UrlImagen, E.Descripcion AS Tipo, D.Descripcion AS Debilidad FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE  E.Id = P.IdTipo AND D.Id = P.IdDebilidad;\r\n";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = (int)lector["Numero"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    if (!(lector["UrlImagen"] is DBNull))
                    {
                        aux.UrlImagen = (string)lector["UrlImagen"];
                    }
                    aux.Tipo = new Elemento();
                    aux.Debilidad = new Elemento();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];
                    lista.Add(aux);
                }

                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;
        }
        public void agregar(Pokemon nuevo)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("INSERT into POKEMONS(Numero, Nombre, Descripcion,Activo, IdTipo, IdDebilidad, UrlImagen) VALUES (" + nuevo.Numero + ", '" + nuevo.Nombre + "', '" + 
                    nuevo.Descripcion + "',1,@IdTipo,@IdDebilidad,@Url);");
                conexion.setearParametro("@IdTipo",nuevo.Tipo.Id);
                conexion.setearParametro("@IdDebilidad", nuevo.Debilidad.Id);
                conexion.setearParametro("@Url", nuevo.UrlImagen);
                conexion.ejecutarAccion();

            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public void actualizar()
        {
            AccesoDatos actualizar = new AccesoDatos();
            try
            {
                actualizar.setearConsulta("");
            }
            catch(Exception ex) { throw ex; }
            finally
            {
                actualizar.cerrarConexion();
            }
        }
        public void quitar(string nombre)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("DELETE FROM POKEMONS WHERE Nombre = '" + nombre + "';");
                conexion.ejecutarAccion();
            }
            catch(Exception ex) { throw ex; }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public void modificar(Pokemon modificar)
        {

        }
    }
}
