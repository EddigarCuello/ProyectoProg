using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion_Empleado
    {
        private static Conexion_Empleado conn = null;

        public Conexion_Empleado()
        {

        }

        public OracleConnection CrearConexion()
        {
            OracleConnection Cadena = new OracleConnection();

            try
            {
                Cadena.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
                          "(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)))" +
                          ";User Id=empleado;Password=oracle;";
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion_Empleado ObtenerInstancia()
        {
            if (conn == null)
            {
                conn = new Conexion_Empleado();
            }
            return conn;
        }
    }
}
