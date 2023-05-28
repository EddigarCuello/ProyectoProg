using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion_Propietario
    {
        private static Conexion_Propietario conn = null;

        public Conexion_Propietario()
        {

        }

        public OracleConnection CrearConexion()
        {
            OracleConnection Cadena = new OracleConnection();

            try 
            {
                Cadena.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
                          "(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)))" +
                          ";User Id=propietario;Password=oracle;";
            }
            catch (Exception ex) 
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion_Propietario ObtenerInstancia() 
        {
            if (conn == null)
            {
                conn = new Conexion_Propietario();
            }
            return conn;
        }
    }
}
