using Entidades;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Datos
{
    public class Gestion_Clientes : IGestion<Cliente>
    {
        public string Insertar(Cliente item)
        {
            string respuesta = string.Empty;
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :result := FN_CLIENTS.FN_INSERTAR_CLIENTE(:Cl_cedula, :pr_nombre, :pr_apellido, :Emp_cedula, :id_calle, :telefono, :usuario); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("Cl_cedula", OracleDbType.Varchar2).Value = item.Cedula;
                comando.Parameters.Add("pr_nombre", OracleDbType.Varchar2).Value = item.Pr_Nombre;
                comando.Parameters.Add("pr_apellido", OracleDbType.Varchar2).Value = item.Pr_Apellido;
                comando.Parameters.Add("Emp_cedula", OracleDbType.Varchar2).Value = item.CedulaEmpleado;
                comando.Parameters.Add("id_calle", OracleDbType.Int32).Value = item.Id_calle;
                comando.Parameters.Add("telefono", OracleDbType.Varchar2).Value = item.Telefono;
                comando.Parameters.Add("usuario", OracleDbType.Varchar2).Value = item.Usuario;

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

        public string Eliminar(string identificador)
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
                                       "FN_CLIENTS.EliminarCliente(:p_cl_cedula);" +
                                       "END;";
                comando.CommandType = CommandType.Text;


                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("p_cl_cedula", OracleDbType.Varchar2).Value = identificador;


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

        public string Actualizar(Cliente item)
        {
            string respuesta = string.Empty;
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :result := FN_CLIENTS.actualizar_cliente(:Cl_cedula, :pr_nombre, :pr_apellido, :telefono, :id_calle); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("Cl_cedula", OracleDbType.Varchar2).Value = item.Cedula;
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

        public List<Cliente> Consultar()
        {

            OracleDataReader ResultadoClientes;
            List<Cliente> clientes = new List<Cliente>();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM clientes", sqlconn);
                comando.CommandType = CommandType.Text;
                sqlconn.Open();
                ResultadoClientes = comando.ExecuteReader();

                while (ResultadoClientes.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Cedula = ResultadoClientes["cl_cedula"].ToString();
                    cliente.CedulaEmpleado = ResultadoClientes["emp_cedula"].ToString();
                    cliente.Pr_Nombre = ResultadoClientes["pr_nombre"].ToString();
                    cliente.Pr_Apellido = ResultadoClientes["pr_apellido"].ToString();
                    cliente.Telefono = ResultadoClientes["telefono"].ToString();
                    cliente.Usuario = ResultadoClientes["usuario"].ToString();
                    cliente.Id_calle = Convert.ToInt32(ResultadoClientes["id_calle"]);

                    clientes.Add(cliente);
                }

                return clientes;
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
    }

}
