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
                OracleCommand comando = new OracleCommand("BEGIN :result := FN_EMPLOYEES.FN_INSERTAR_EMPLEADO(:Emp_cedula, :pr_nombre, :pr_apellido, :id_calle, :telefono, :usuario); END;", sqlconn);
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

        public List<Persona> DatosEmp()
        {
            OracleDataReader ResultadoEmpleado;
            List<Persona> Empleados = new List<Persona>();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("select * FROM empleados", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                ResultadoEmpleado = comando.ExecuteReader();

                while (ResultadoEmpleado.Read())
                {
                    Persona empleado = new Persona();
                    empleado.Cedula = ResultadoEmpleado["emp_cedula"].ToString();
                    empleado.Pr_Nombre = ResultadoEmpleado["pr_nombre"].ToString();
                    empleado.Pr_Apellido = ResultadoEmpleado["pr_apellido"].ToString();
                    empleado.Id_calle = Convert.ToInt32(ResultadoEmpleado["id_calle"]);
                    empleado.Telefono = ResultadoEmpleado["telefono"].ToString();
                    empleado.Usuario= ResultadoEmpleado["usuario"].ToString();
                    Empleados.Add(empleado);
                }

                return Empleados;
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


        public string Actualizar(Persona item)
        {
            string respuesta = string.Empty;
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :result := FN_EMPLOYEES.actualizar_empleado(:emp_cedula, :pr_nombre, :pr_apellido, :telefono, :id_calle); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("emp_cedula", OracleDbType.Varchar2).Value = item.Cedula;
                comando.Parameters.Add("pr_nombre", OracleDbType.Varchar2).Value = item.Pr_Nombre;
                comando.Parameters.Add("pr_apellido", OracleDbType.Varchar2).Value = item.Pr_Apellido;
                comando.Parameters.Add("telefono", OracleDbType.Varchar2).Value = item.Telefono;
                comando.Parameters.Add("id_calle", OracleDbType.Int32).Value = item.Id_calle;


                sqlconn.Open();

                comando.ExecuteNonQuery();

                respuesta = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                respuesta = "Error al guardar cliente: " + ex.Message;
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }

            return respuesta;
        }


        public string Eliminar(string identificador,string identificador2)
        {
            string resultado = "";
            OracleConnection sqlconn = new OracleConnection();
            DataTable resultadoTabla = new DataTable();

            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand();
                comando.Connection = sqlconn;
                comando.CommandText = "BEGIN :result := " +
                                       "FN_EMPLOYEES.ELIMINAREMPLEADO(:p_emp_cedula,:p_nuevo_emp_cedula);" +
                                       "END;";
                comando.CommandType = CommandType.Text;


                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("p_emp_cedula", OracleDbType.Varchar2).Value = identificador;
                comando.Parameters.Add("p_nuevo_emp_cedula", OracleDbType.Varchar2).Value = identificador2;


                sqlconn.Open();
                comando.ExecuteNonQuery();

                resultado = comando.Parameters["result"].Value.ToString();

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                resultado = "ERROR al eliminar el cliente" + ex;
            }

            return resultado;
        }

    }
}
