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
                OracleCommand comando = new OracleCommand("BEGIN :result := FN_ADMINS.FN_INSERTAR_ADMINISTRADORES(:Adm_cedula, :pr_nombre, :pr_apellido, :id_calle, :telefono, :usuario); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("Adm_cedula", OracleDbType.Varchar2).Value = admin.Cedula;
                comando.Parameters.Add("pr_nombre", OracleDbType.Varchar2).Value = admin.Pr_Nombre;
                comando.Parameters.Add("pr_apellido", OracleDbType.Varchar2).Value = admin.Pr_Apellido;
                comando.Parameters.Add("id_calle", OracleDbType.Int32).Value = admin.Id_calle;
                comando.Parameters.Add("telefono", OracleDbType.Varchar2).Value = admin.Telefono;
                comando.Parameters.Add("usuario", OracleDbType.Varchar2).Value = admin.Usuario;

                sqlconn.Open();

                comando.ExecuteNonQuery();

                string resultado = comando.Parameters["result"].Value.ToString();

                if (resultado == "OK")
                {
                    Rpta = "OK";
                }
                else
                {
                    Rpta = resultado;
                }
            }
            catch (Exception ex)
            {
                Rpta = "Error al guardar administrador: " + ex.Message;
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

       



    }
}
