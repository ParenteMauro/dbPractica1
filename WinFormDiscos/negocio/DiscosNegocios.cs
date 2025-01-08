using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using negocio;

namespace WinFormDiscos
{
    public class DiscosNegocios
    {
        public List<Disco> listar() {

            List<Disco> listaDiscos = new List<Disco>();  
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try{
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database= DISCOS_DB; integrated security=true; ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion, T.Descripcion as TipoEdicion FROM DISCOS D, ESTILOS E, TIPOSEDICION T WHERE D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id;";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {

                    Disco aux = new Disco((string)lector["Titulo"], (DateTime)lector["FechaLanzamiento"], 
                        (int)lector["CantidadCanciones"], (string)lector["Descripcion"], (string)lector["TipoEdicion"]);

                    aux.UrlImagen = (string)lector["UrlImagenTapa"];
                    listaDiscos.Add(aux);

                }

                return listaDiscos;

             }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public void agregarDisco(Disco disco)
        {
            AccDatos accDatos = new AccDatos();

            accDatos.settearQuery("INSERT INTO DISCOS (Titulo, Fechalanzamiento, CantidadCanciones, UrlImagen, IdEstilo,IdEdicion) Values('" + disco.Titulo +"'," +
                disco.FechaLanzamiento + ", "+ disco.CantidadCanciones+", @UrlImagen, @IdEstilo, @IdEdicion )");
            accDatos.setearParametro("@UrlImagen", disco.UrlImagen);
            accDatos.setearParametro("@IdEstilo", disco.Estilo);
            accDatos.setearParametro("@IdEdicion", disco.Edicion);
        }

    } 
}

