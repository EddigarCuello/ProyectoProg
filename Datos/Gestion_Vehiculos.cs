using Entidades;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Gestion_Vehiculos : IGestion<Vehiculo>
    {
        public List<Vehiculo_Empleado> Listado_Vehiculos_Clientes()
        {
            OracleDataReader ResultadVehClientes;
            List<Vehiculo_Empleado> vehiculo_Empleados = new List<Vehiculo_Empleado>();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                string consulta = "SELECT * FROM VISTA_VEHICULOS_EMPLEADO";
                OracleCommand comando = new OracleCommand(consulta, sqlconn);
                comando.CommandType = CommandType.Text;

                sqlconn.Open();
                ResultadVehClientes = comando.ExecuteReader();

                while (ResultadVehClientes.Read())
                {
                    Vehiculo_Empleado vehiculo_Empleado = new Vehiculo_Empleado();
                    vehiculo_Empleado.Cl_Cedula = ResultadVehClientes["cl_cedula"].ToString();
                    vehiculo_Empleado.pr_Nombre = ResultadVehClientes["pr_nombre"].ToString();
                    vehiculo_Empleado.pr_apellido = ResultadVehClientes["pr_apellido"].ToString();
                    vehiculo_Empleado.Emp_Cedula = ResultadVehClientes["emp_cedula"].ToString();
                    vehiculo_Empleado.Veh_Placa = ResultadVehClientes["veh_placa"].ToString();
                    vehiculo_Empleado.Marca = ResultadVehClientes["marca"].ToString();


                    vehiculo_Empleados.Add(vehiculo_Empleado);
                }
                return vehiculo_Empleados;
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

        public string Insertar(Vehiculo item)
        {
            string respuesta = string.Empty;
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :result := FN_VHS.FN_INSERTAR_VEHICULO(:placa, :tp_vehiculo, :modelo, :marca, :version, :cilindraje, :cl_cedula); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("placa", OracleDbType.Varchar2).Value = item.Placa;
                comando.Parameters.Add("tp_vehiculo", OracleDbType.Varchar2).Value = item.TipoVehiculo;
                comando.Parameters.Add("modelo", OracleDbType.Varchar2).Value = item.Modelo;
                comando.Parameters.Add("marca", OracleDbType.Varchar2).Value = item.Marca;
                comando.Parameters.Add("version", OracleDbType.Date).Value = item.Version;
                comando.Parameters.Add("cilindraje", OracleDbType.Varchar2).Value = item.Cilindraje;
                comando.Parameters.Add("cl_cedula", OracleDbType.Varchar2).Value = item.CedulaCliente;

                sqlconn.Open();

                comando.ExecuteNonQuery();

                respuesta = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                respuesta = "Error al guardar vehículo: " + ex.Message;
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
            string resultado = string.Empty;
            OracleConnection sqlconn = new OracleConnection();

            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand();
                comando.Connection = sqlconn;
                comando.CommandText = "BEGIN :result := FN_VHS.eliminar_vehiculo(:p_placa);END;";
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("p_placa", OracleDbType.Varchar2).Value = identificador;
                sqlconn.Open();
                comando.ExecuteNonQuery();

                resultado = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                resultado = "Error al Eliminar el vehiculo: " + ex.Message;
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

        public string Actualizar(Vehiculo item)
        {
            string resultado = "";
            OracleConnection sqlconn = new OracleConnection();
            DataTable resultadoTabla = new DataTable();

            try
            {
                // Crear la conexión a la base de datos
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand();
                comando.Connection = sqlconn;
                comando.CommandText = "BEGIN :result := " +
                                       "FN_VHS.actualizar_vehiculo(" +
                                       "   :p_placa," +
                                       "   :p_nuevo_tp_vehiculo," +
                                       "   :p_nuevo_modelo," +
                                       "   :p_nueva_marca," +
                                       "   :p_nuevo_cilindraje," +
                                       "   :p_nueva_version);" +
                                       "END;";
                comando.CommandType = CommandType.Text;

                // Agregar los parámetros de entrada
                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("p_placa", OracleDbType.Varchar2).Value = item.Placa;
                comando.Parameters.Add("p_nuevo_tp_vehiculo", OracleDbType.Varchar2).Value = item.TipoVehiculo;
                comando.Parameters.Add("p_nuevo_modelo", OracleDbType.Varchar2).Value = item.Modelo;
                comando.Parameters.Add("p_nueva_marca", OracleDbType.Varchar2).Value = item.Marca;
                comando.Parameters.Add("p_nuevo_cilindraje", OracleDbType.Varchar2).Value = item.Cilindraje;
                comando.Parameters.Add("p_nueva_version", OracleDbType.Date).Value = item.Version;

                // Abrir la conexión y ejecutar el comando
                sqlconn.Open();
                comando.ExecuteNonQuery();

                resultado = comando.Parameters["result"].Value.ToString();

                // Cerrar la conexión
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                resultado = "ERROR" + ex;
            }

            return resultado;
        }

        public List<Vehiculo> Consultar()
        {
            OracleDataReader ResultadoVehiculos;
            List<Vehiculo> Vehiculos = new List<Vehiculo>();
            OracleConnection sqlconn = new OracleConnection();

            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("SELECT * FROM VEHICULOS", sqlconn);
                comando.CommandType = CommandType.Text;

                sqlconn.Open();
                ResultadoVehiculos = comando.ExecuteReader();

                while (ResultadoVehiculos.Read())
                {
                    Vehiculo vehiculo = new Vehiculo();
                    vehiculo.Placa = ResultadoVehiculos["placa"].ToString();
                    vehiculo.TipoVehiculo = ResultadoVehiculos["tp_vehiculo"].ToString();
                    vehiculo.Modelo = ResultadoVehiculos["modelo"].ToString();
                    vehiculo.Marca = ResultadoVehiculos["marca"].ToString();
                    vehiculo.Version = DateTime.Parse(ResultadoVehiculos["version"].ToString());
                    vehiculo.Cilindraje = ResultadoVehiculos["cilindraje"].ToString();
                    vehiculo.CedulaCliente = ResultadoVehiculos["cl_cedula"].ToString();


                    Vehiculos.Add(vehiculo);
                }
                return Vehiculos;
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
