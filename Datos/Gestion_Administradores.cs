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
    public class Gestion_Administradores
    {
        public string InsertarAdministradores(Persona admin)
        {
            string Rpta = " ";
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("PC_INSERTAR_ADMINISTRADORES", sqlconn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Adm_cedula", OracleDbType.Varchar2).Value = admin.Cedula;
                comando.Parameters.Add("pr_nombre", OracleDbType.Varchar2).Value = admin.Pr_Nombre;
                comando.Parameters.Add("pr_apellido", OracleDbType.Varchar2).Value = admin.Pr_Apellido;
                comando.Parameters.Add("id_calle", OracleDbType.Int32).Value = admin.Id_calle;
                comando.Parameters.Add("telefono", OracleDbType.Varchar2).Value = admin.Telefono;
                
                sqlconn.Open();

                Rpta = !(comando.ExecuteNonQuery() >= 1) ?"OK":"Este Administrador ya fue insertado Restriccion Integridad Referencial";
                
            }
            catch (Exception ex)
            {
                Rpta = "Error al guardar administrador" + ex;
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

        public string InsertarCuenta(Cuenta cuenta,string CedulaAdm)
        {
            string Rpta = " ";
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("PC_INSERTAR_CUENTA", sqlconn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("usuario", OracleDbType.Varchar2).Value = cuenta.Usuario;
                comando.Parameters.Add("contraseña", OracleDbType.Varchar2).Value = cuenta.Contraseña;
                comando.Parameters.Add("adm_cedula", OracleDbType.Varchar2).Value = CedulaAdm;

                sqlconn.Open();

                Rpta = !(comando.ExecuteNonQuery() >= 1) ? "OK" : "Esta Cuenta ya fue creada Restriccion Integridad Referencial";

            }
            catch (Exception ex)
            {
                Rpta = "Error al guardar Cuenta" + ex;
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

        public string Rollback()
        {
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("ROLLBACK", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                comando.ExecuteNonQuery();
                return "Rollback realizado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al realizar el rollback: " + ex.Message;
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
