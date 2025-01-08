using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WinFormDiscos;
using System.Data;

namespace negocio
{
    public class EstiloNegocios
    {
        public List<Estilo> listar()
        {
            List<Estilo> listaEstilo = new List<Estilo>();

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "server=.\\SQLEXPRESS; database= DISCOS_DB; integrated security=true;";
    
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT Id, Descripcion FROM ESTILOS;";
            comando.Connection = conexion;
           
            SqlDataReader lector;
            try{
                conexion.Open();
                Estilo estilo = new Estilo();
                lector = comando.ExecuteReader();
                while (lector.Read())

                {
                    estilo.Id = (int)lector["Id"];
                    estilo.Descripcion = (string)lector["Descripcion"];
                    listaEstilo.Add(estilo);
                    
                }
                return listaEstilo;

            }
            catch(Exception ex) 
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
