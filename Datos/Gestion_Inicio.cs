using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Gestion_Inicio
    {
        public DataTable ListadoCuentas()
        {
            OracleDataReader ResultadoCuentas;
            DataTable TablaCuentas = new DataTable();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM VISTA_USUARIOS", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                ResultadoCuentas = comando.ExecuteReader();
                TablaCuentas.Load(ResultadoCuentas);
                return TablaCuentas;
            }
            catch (Exception ex)
            {
                throw ex;
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
