using Entidades;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Gestion_Clientes
    {
        public DataTable Listado_Vehiculos_Clientes(string CedulaEmp)
        {
            OracleDataReader ResultadVehClientes;
            DataTable TablaVehClientes = new DataTable();
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                string consulta = "SELECT * FROM VISTA_VEHICULOS_EMPLEADO WHERE EMP_CEDULA  = :cedula";
                OracleCommand comando = new OracleCommand(consulta, sqlconn);
                comando.CommandType = CommandType.Text;
                comando.Parameters.Add(new OracleParameter("cedula", CedulaEmp));

                sqlconn.Open();
                ResultadVehClientes = comando.ExecuteReader();
                TablaVehClientes.Load(ResultadVehClientes);
                return TablaVehClientes;
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

        public string InsertarCliente(Cliente cliente)
        {
            string respuesta = string.Empty;
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :result := FN_CLIENTS.FN_INSERTAR_CLIENTE(:Cl_cedula, :pr_nombre, :pr_apellido, :Emp_cedula, :id_calle, :telefono, :usuario); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("Cl_cedula", OracleDbType.Varchar2).Value = cliente.Cedula;
                comando.Parameters.Add("pr_nombre", OracleDbType.Varchar2).Value = cliente.Pr_Nombre;
                comando.Parameters.Add("pr_apellido", OracleDbType.Varchar2).Value = cliente.Pr_Apellido;
                comando.Parameters.Add("Emp_cedula", OracleDbType.Varchar2).Value = cliente.CedulaEmpleado;
                comando.Parameters.Add("id_calle", OracleDbType.Int32).Value = cliente.Id_calle;
                comando.Parameters.Add("telefono", OracleDbType.Varchar2).Value = cliente.Telefono;
                comando.Parameters.Add("usuario", OracleDbType.Varchar2).Value = cliente.Usuario;

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

        public string InsertarVehiculo(Vehiculo vehiculo)
        {
            string respuesta = string.Empty;
            OracleConnection sqlconn = new OracleConnection();
            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("BEGIN :result := FN_VHS.FN_INSERTAR_VEHICULO(:placa, :tp_vehiculo, :modelo, :marca, :version, :cilindraje, :cl_cedula); END;", sqlconn);
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("placa", OracleDbType.Varchar2).Value = vehiculo.Placa;
                comando.Parameters.Add("tp_vehiculo", OracleDbType.Varchar2).Value = vehiculo.TipoVehiculo;
                comando.Parameters.Add("modelo", OracleDbType.Varchar2).Value = vehiculo.Modelo;
                comando.Parameters.Add("marca", OracleDbType.Varchar2).Value = vehiculo.Marca;
                comando.Parameters.Add("version", OracleDbType.Date).Value = vehiculo.Version;
                comando.Parameters.Add("cilindraje", OracleDbType.Varchar2).Value = vehiculo.Cilindraje;
                comando.Parameters.Add("cl_cedula", OracleDbType.Varchar2).Value = vehiculo.CedulaCliente;

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

        public string InsertarFactura(Factura factura)
        {
            string resultado = string.Empty;
            OracleConnection sqlconn = new OracleConnection();

            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand();
                comando.Connection = sqlconn;
                comando.CommandText = "BEGIN :result := FN_FACTURES.FN_AGREGARFACTURA(:servicio, :prc_revision, :fecha_fact, :cl_cedula, :emp_cedula, :placa, :prc_total); END;";
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("servicio", OracleDbType.Varchar2).Value = factura.servicios;
                comando.Parameters.Add("prc_revision", OracleDbType.Decimal).Value = factura.Prc_Revision;
                comando.Parameters.Add("fecha_fact", OracleDbType.Date).Value = factura.fecha_Fact;
                comando.Parameters.Add("cl_cedula", OracleDbType.Varchar2).Value = factura.Cliente_CC;
                comando.Parameters.Add("emp_cedula", OracleDbType.Varchar2).Value = factura.Empleado_CC;
                comando.Parameters.Add("placa", OracleDbType.Varchar2).Value = factura.placa;
                comando.Parameters.Add("prc_total", OracleDbType.Decimal).Value = factura.Prc_Total;

                sqlconn.Open();
                comando.ExecuteNonQuery();

                resultado = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                resultado = "Error al agregar la factura: " + ex.Message;
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

         public string ActualizarFactura(Factura factura)
        {
            string resultado = string.Empty;
            OracleConnection sqlconn = new OracleConnection();

            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand();
                comando.Connection = sqlconn;
                comando.CommandText = "BEGIN :result := FN_FACTURES.actualizar_factura(:factura_id, :servicios, :prc_revision, :total);END;";
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("cod_factura", OracleDbType.Int32).Value = int.Parse(factura.Cod_Factura);
                comando.Parameters.Add("servicio", OracleDbType.Varchar2).Value = factura.servicios;
                comando.Parameters.Add("prc_revision", OracleDbType.Decimal).Value = factura.Prc_Revision;
                comando.Parameters.Add("total", OracleDbType.Decimal).Value = factura.Prc_Total;

                sqlconn.Open();
                comando.ExecuteNonQuery();

                resultado = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                resultado = "Error al agregar o actualizar la factura: " + ex.Message;
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


        public DataTable ObtenerFacturas(string cl_cedula)
        {
            DataTable tablaFactura = new DataTable();
            OracleConnection sqlconn = new OracleConnection();

            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand();
                comando.Connection = sqlconn;
                comando.CommandText = "SELECT * FROM Vista_Facturas WHERE CL_CEDULA = :cedula";
                comando.CommandType = CommandType.Text;

                // Parámetro de entrada - Cédula del cliente
                comando.Parameters.Add("cedula", OracleDbType.Varchar2).Value = cl_cedula;

                sqlconn.Open();

                OracleDataAdapter adapter = new OracleDataAdapter(comando);
                adapter.Fill(tablaFactura);

                return tablaFactura;
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

        public string ActualizarVehiculo(string placa, string nuevoTipoVehiculo, string nuevoModelo,
    string nuevaMarca, string nuevoCilindraje)
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
                                       "   :p_nuevo_cilindraje);" +
                                       "END;";
                comando.CommandType = CommandType.Text;

                // Agregar los parámetros de entrada
                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("p_placa", OracleDbType.Varchar2).Value = placa;
                comando.Parameters.Add("p_nuevo_tp_vehiculo", OracleDbType.Varchar2).Value = nuevoTipoVehiculo;
                comando.Parameters.Add("p_nuevo_modelo", OracleDbType.Varchar2).Value = nuevoModelo;
                comando.Parameters.Add("p_nueva_marca", OracleDbType.Varchar2).Value = nuevaMarca;
                comando.Parameters.Add("p_nuevo_cilindraje", OracleDbType.Varchar2).Value = nuevoCilindraje;

                // Abrir la conexión y ejecutar el comando
                sqlconn.Open();
                comando.ExecuteNonQuery();

                resultado = comando.Parameters["result"].Value.ToString();

                // Cerrar la conexión
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                 resultado = "ERROR" +  ex;
            }

            return resultado;
        }



        public DataTable ObtenerDatosVehiculo(string cedula)
        {
            OracleDataReader resultadoVehiculo;
            DataTable tablaVehiculo = new DataTable();
            OracleConnection sqlconn = new OracleConnection();

            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand("DECLARE CEDULA_CL VARCHAR2(10); v_Return SYS_REFCURSOR; BEGIN CEDULA_CL := :cedula_cl; v_Return := FN_VHS.OBTENERDATOSVEHICULO(CEDULA_CL => CEDULA_CL); :cur := v_Return; END;", sqlconn);
                comando.CommandType = CommandType.Text;

                // Parámetro de entrada - Cédula del cliente
                comando.Parameters.Add(new OracleParameter("cedula_cl", cedula));

                // Parámetro de salida - Cursor de resultado
                comando.Parameters.Add(new OracleParameter("cur", OracleDbType.RefCursor, ParameterDirection.Output));

                sqlconn.Open();
                resultadoVehiculo = comando.ExecuteReader();
                tablaVehiculo.Load(resultadoVehiculo);

                return tablaVehiculo;
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
