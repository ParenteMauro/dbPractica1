﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using negocio;
using System.Collections;

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
                comando.CommandText = "SELECT P.id as idPokemon, P.Numero, P.Nombre, P.Descripcion, P.UrlImagen, E.Id AS idElemento ,E.Descripcion AS Tipo,D.Id AS idDebilidad, D.Descripcion AS Debilidad FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE  E.Id = P.IdTipo AND D.Id = P.IdDebilidad AND P.Activo = 1;";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)lector["idPokemon"];
                    aux.Numero = (int)lector["Numero"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    if (!(lector["UrlImagen"] is DBNull))
                    {
                        aux.UrlImagen = (string)lector["UrlImagen"];
                    }
                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)lector["idElemento"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)lector["idDebilidad"];
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
        public void quitar(int id)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("DELETE FROM POKEMONS WHERE Id= " + id + ";");
                conexion.ejecutarAccion();
            }
            catch(Exception ex) { throw ex; }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public void eliminarLogico(int id)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("UPDATE POKEMONS SET Activo = 0 WHERE Id=" + id);
                conexion.ejecutarAccion();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }
        public void modificar(Pokemon modificar)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("UPDATE POKEMONS SET Nombre = @nombre, Numero = @num, Descripcion = @Descripcion, UrlImagen = @img, IdTipo = @IdTipo , IdDebilidad = @IdDebilidad WHERE Id= @idPokemon");
                conexion.setearParametro("@idPokemon", modificar.Id);
                conexion.setearParametro("@nombre", modificar.Nombre);
                conexion.setearParametro("@num", modificar.Numero);
                conexion.setearParametro("@Descripcion", modificar.Descripcion);
                conexion.setearParametro("@img", modificar.UrlImagen);
                conexion.setearParametro("@IdTipo", modificar.Tipo.Id);
                conexion.setearParametro("@IdDebilidad", modificar.Debilidad.Id);
                conexion.ejecutarLectura();

            }
            catch (Exception ex) { throw ex; }
            finally
            {
                conexion.cerrarConexion();
            }

        }

        public List<Pokemon> filtrar(string campo, string criterio, string filtro)
        {
            AccesoDatos conexion = new AccesoDatos();
            List<Pokemon> listaFiltrada = new List<Pokemon>();
            try
            {
                string consulta;
                consulta = ("SELECT P.id as idPokemon, P.Numero, P.Nombre, P.Descripcion, P.UrlImagen, E.Id AS idElemento ,E.Descripcion AS Tipo,D.Id AS idDebilidad, D.Descripcion AS Debilidad FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE  E.Id = P.IdTipo AND D.Id = P.IdDebilidad AND P.Activo = 1 ");
                if (filtro != "") { 
                switch (criterio)
                {
                    case "Mayor a":
                    {
                        consulta += "AND Numero > " + filtro;
                        break;
                    }
                    case "Menor a":
                        consulta += "AND Numero <" + filtro;
                        break;
                    case "Igual a":
                        consulta += "AND Numero =" + filtro;
                        break;
                    case "Comienza con":
                        consulta += "AND Nombre LIKE '" + filtro + "%'";
                        break;
                    case "Termina en":
                        consulta += "AND Nombre LIKE '%" + filtro + "'";
                        break;
                    case "Contiene":
                        consulta += "AND Nombre LIKE '%" + filtro + "%'";
                        break;

                }
                }
                conexion.setearConsulta(consulta);
                conexion.ejecutarLectura();
                while (conexion.Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)conexion.Lector["idPokemon"];
                    aux.Numero = (int)conexion.Lector["Numero"];
                    aux.Nombre = (string)conexion.Lector["Nombre"];
                    aux.Descripcion = (string)conexion.Lector["Descripcion"];
                    if (!(conexion.Lector["UrlImagen"] is DBNull))
                    {
                        aux.UrlImagen = (string)conexion.Lector["UrlImagen"];
                    }
                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)conexion.Lector["idElemento"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)conexion.Lector["idDebilidad"];
                    aux.Tipo.Descripcion = (string)conexion.Lector["Tipo"];
                    aux.Debilidad.Descripcion = (string)conexion.Lector["Debilidad"];
                    listaFiltrada.Add(aux);
                }
                return listaFiltrada;

            }
            catch (Exception ex) { throw ex; }
            finally
            {
                conexion.cerrarConexion();
            }
        }
    }
}
