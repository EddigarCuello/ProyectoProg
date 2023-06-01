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
    public  class Gestion_Empleados
    {
        public string InsertarEmpleados(Persona empleado)
        {
            string Rpta = " ";
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :result := FN_INSERTAR_EMPLEADO(:Emp_cedula, :pr_nombre, :pr_apellido, :id_calle, :telefono, :usuario); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("Emp_cedula", OracleDbType.Varchar2).Value = empleado.Cedula;
                comando.Parameters.Add("pr_nombre", OracleDbType.Varchar2).Value = empleado.Pr_Nombre;
                comando.Parameters.Add("pr_apellido", OracleDbType.Varchar2).Value = empleado.Pr_Apellido;
                comando.Parameters.Add("id_calle", OracleDbType.Int32).Value = empleado.Id_calle;
                comando.Parameters.Add("telefono", OracleDbType.Varchar2).Value = empleado.Telefono;
                comando.Parameters.Add("usuario", OracleDbType.Varchar2).Value = empleado.Usuario;

                sqlconn.Open();

                comando.ExecuteNonQuery();

                Rpta = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                Rpta = "Error al guardar empleado: " + ex.Message;
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

        public string InsertarCuenta(Cuenta cuenta)
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

        public DataTable ListadoEmpleado_NumClientes()
        {
            OracleDataReader ResultadoEMPCL;
            DataTable TablaEMPCL = new DataTable();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM V_EMPLEADOS_CLIENTES", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                ResultadoEMPCL = comando.ExecuteReader();
                TablaEMPCL.Load(ResultadoEMPCL);
                return TablaEMPCL;
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

        public DataTable DatosEmp(string cedula)
        {
            OracleDataReader ResultadoDatosEmp;
            DataTable TablaDatosEmp = new DataTable();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :cursor := FN_EMPLOYEES.ObtenerDatosEmpleado(:cedula); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                // Parámetro de entrada - Cédula del empleado
                comando.Parameters.Add(new OracleParameter("cedula", cedula));

                // Parámetro de salida - Cursor de resultado
                comando.Parameters.Add(new OracleParameter("cursor", OracleDbType.RefCursor, ParameterDirection.Output));

                sqlconn.Open();
                ResultadoDatosEmp = comando.ExecuteReader();
                TablaDatosEmp.Load(ResultadoDatosEmp);
                return TablaDatosEmp;
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

        public DataTable ListadoCuentas(string cedula)
        {
            OracleDataReader ResultadoCuentas;
            DataTable TablaCuentas = new DataTable();
            OracleConnection sqlconn = new OracleConnection();

            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM VISTA_USUARIOS WHERE CEDULA = :cedula", sqlconn);
                comando.CommandType = CommandType.Text;

                // Parámetro de entrada - Cédula
                comando.Parameters.Add(new OracleParameter("cedula", cedula));

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
