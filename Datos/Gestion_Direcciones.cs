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
        public DataTable ListadoCiudades()
        {
            OracleDataReader ResultadoCiudades;
            DataTable TablaCiudades = new DataTable();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT nom_ciudad,id_ciudad FROM  ciudades", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                ResultadoCiudades = comando.ExecuteReader();
                TablaCiudades.Load(ResultadoCiudades);
                return TablaCiudades;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            { 
                if(sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }  
            }

        }

        public DataTable ListadoBarrios(int IdCiudad)
        {
            OracleDataReader ResultadoBarrios;
            DataTable TablaBarrios = new DataTable();
            OracleConnection sqlconn = null;
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :resultado := ObtenerBarriosPorCiudad(:idCiudad); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("resultado", OracleDbType.RefCursor).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("idCiudad", OracleDbType.Int32).Value = IdCiudad;

                sqlconn.Open();
                ResultadoBarrios = comando.ExecuteReader();

                TablaBarrios.Load(ResultadoBarrios);

                return TablaBarrios;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los barrios", ex);
            }
            finally
            {
                if (sqlconn != null && sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }
        }




        public DataTable ListadoCalles(int IdBarrio)
        {
            OracleDataReader ResultadoCalles;
            DataTable TablaCalles = new DataTable();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :resultado := ObtenerCallesPorBarrio(:idBarrio); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("resultado", OracleDbType.RefCursor).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("idCiudad", OracleDbType.Int32).Value = IdBarrio;
                sqlconn.Open();
                ResultadoCalles = comando.ExecuteReader();
                TablaCalles.Load(ResultadoCalles);

                return TablaCalles;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los barrios", ex);
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
