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
    public class Gestion_Cuenta
    {
        public string InsertarCuenta(CuentaUser cuenta)
        {
            string Rpta = " ";
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand();
                comando.Connection = sqlconn;
                comando.CommandText = "BEGIN :result := FN_LOGINS.FN_INSERTAR_CUENTA(:usuario, :contraseña); END;";
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("usuario", OracleDbType.Varchar2).Value = cuenta.Usuario;
                comando.Parameters.Add("contraseña", OracleDbType.Varchar2).Value = cuenta.Contraseña;

                sqlconn.Open();
                comando.ExecuteNonQuery();

                string resultado = comando.Parameters["result"].Value.ToString();

                if (resultado == "OK")
                {
                    Rpta = "OK";
                }
                else
                {
                    Rpta = "Error al guardar";
                }
            }
            catch (Exception ex)
            {
                Rpta = "Error al guardar Cuenta: " + ex.Message;
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }
            return Rpta;
        }

        public List<CuentaUser> Listadousuraios()
        {
            OracleDataReader ResultadoUsuarios;
            List<CuentaUser> usuarios = new List<CuentaUser>();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("select * FROM VISTA_USUARIOS", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                ResultadoUsuarios = comando.ExecuteReader();

                while (ResultadoUsuarios.Read())
                {
                    CuentaUser user = new CuentaUser();
                    user.Usuario = ResultadoUsuarios["usuario"].ToString();
                    user.Contraseña = ResultadoUsuarios["contraseña"].ToString();
                    user.cedula = ResultadoUsuarios["cedula"].ToString();
                    user.Tipo_Cuenta = ResultadoUsuarios["tipo_de_cuenta"].ToString();
                    usuarios.Add(user);
                }

                return usuarios;
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

        public string EliminarCuenta(string usuario)
        {
            string resultado = string.Empty;
            OracleConnection sqlconn = new OracleConnection();

            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand();
                comando.Connection = sqlconn;
                comando.CommandText = "BEGIN :result := FN_LOGINS.FN_ELIMINAR_CUENTA(:p_usuario); END;";
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("p_usuario", OracleDbType.Varchar2).Value = usuario;

                sqlconn.Open();
                comando.ExecuteNonQuery();

                resultado = comando.Parameters["result"].Value.ToString();

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                resultado = "Error al Eliminar la cuenta: " + ex.Message;
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }

            return resultado;
        }

    }
}
