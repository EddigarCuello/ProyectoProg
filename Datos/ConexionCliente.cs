using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    internal class ConexionCliente
    {
        public static ConexionCliente conn = null;

        public ConexionCliente()
        {

        }

        public OracleConnection CrearConexion()
        {
            OracleConnection Cadena = new OracleConnection();

            try
            {
                Cadena.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
                          "(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)))" +
                          ";User Id=cliente;Password=oracle;";
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static ConexionCliente ObtenerInstancia()
        {
            if (conn == null)
            {
                conn = new ConexionCliente();
            }
            return conn;
        }
    }
}
