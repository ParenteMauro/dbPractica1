using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace negocio
{
    public class AccDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public AccDatos()
        {
            
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database= DISCOS_DB; integrated security=true; ");
            comando = new SqlCommand();
            
        }   

        public void settearQuery(string query)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;
        }
        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void ejecutarAccion()
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

        public void cerrarConexion()
        {
            if (lector != null)
            {
                conexion.Close();
            }
        }

    }
}
