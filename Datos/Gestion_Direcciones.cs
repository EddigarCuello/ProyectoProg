using Entidades;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Gestion_Direcciones
    {
        public List<Ciudad> ListadoCiudades()
        {
            OracleDataReader ResultadoCiudades;
            List<Ciudad> ciudades = new List<Ciudad>();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT nom_ciudad, id_ciudad FROM ciudades", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                ResultadoCiudades = comando.ExecuteReader();

                while (ResultadoCiudades.Read())
                {
                    Ciudad ciudad = new Ciudad();
                    ciudad.Nom_Ciudad = ResultadoCiudades["nom_ciudad"].ToString();
                    ciudad.Id_Ciudad = Convert.ToInt32(ResultadoCiudades["id_ciudad"]);
                    ciudades.Add(ciudad);
                }

                return ciudades;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }
        }



        public List<Barrio> ListadoBarrios()
        {
            OracleDataReader ResultadoBarrios;
            List<Barrio> Barrios = new List<Barrio>();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("select * FROM barrios", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                ResultadoBarrios = comando.ExecuteReader();

                while (ResultadoBarrios.Read())
                {
                    Barrio barrio = new Barrio();
                    barrio.Nom_Barrio= ResultadoBarrios["nom_barrio"].ToString();
                    barrio.id_Barrio = Convert.ToInt32(ResultadoBarrios["id_barrio"]);
                    barrio.Id_Ciudad = Convert.ToInt32(ResultadoBarrios["id_ciudad"]);
                    Barrios.Add( barrio);
                }

                return Barrios;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }
        }




        public List<Calle> ListadoCalles()
        {
            OracleDataReader ResultadoCalles;
            List<Calle> Calles = new List<Calle>();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("select * FROM calles", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                ResultadoCalles = comando.ExecuteReader();

                while (ResultadoCalles.Read())
                {
                    Calle calle = new Calle();
                    calle.Nom_Calle = ResultadoCalles["nom_calle"].ToString();
                    calle.Id_Calle = Convert.ToInt32(ResultadoCalles["id_calle"]);
                    calle.Id_Barrio = Convert.ToInt32(ResultadoCalles["id_barrio"]);
                    Calles.Add(calle);
                }

                return Calles;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }
        }
    }
}
