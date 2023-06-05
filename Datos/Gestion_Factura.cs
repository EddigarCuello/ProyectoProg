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
    public class Gestion_Factura : IGestion<Factura>
    {


        public string Insertar(Factura item)
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
                comando.Parameters.Add("servicio", OracleDbType.Varchar2).Value = item.servicios;
                comando.Parameters.Add("prc_revision", OracleDbType.Decimal).Value = item.Prc_Revision;
                comando.Parameters.Add("fecha_fact", OracleDbType.Date).Value = item.fecha_Fact;
                comando.Parameters.Add("cl_cedula", OracleDbType.Varchar2).Value = item.Cliente_CC;
                comando.Parameters.Add("emp_cedula", OracleDbType.Varchar2).Value = item.Empleado_CC;
                comando.Parameters.Add("placa", OracleDbType.Varchar2).Value = item.placa;
                comando.Parameters.Add("prc_total", OracleDbType.Decimal).Value = item.Prc_Total;

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

        public string Eliminar(string identificador)
        {
            string resultado = "";
            OracleConnection sqlconn = new OracleConnection();

            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand();
                comando.Connection = sqlconn;
                comando.CommandText = "BEGIN :result := FN_FACTURES.eliminar_factura(:factura_id);END;";
                comando.CommandType = CommandType.Text;

                comando.Parameters.Add("result", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add("factura_id", OracleDbType.Int32).Value = int.Parse( identificador);
                sqlconn.Open();
                comando.ExecuteNonQuery();

                resultado = comando.Parameters["result"].Value.ToString();
            }
            catch (Exception ex)
            {
                resultado = "Error al Eliminar la factura: " + ex.Message;
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

        public string Actualizar(Factura item)
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
                comando.Parameters.Add("cod_factura", OracleDbType.Int32).Value = int.Parse(item.Cod_Factura);
                comando.Parameters.Add("servicio", OracleDbType.Varchar2).Value = item.servicios;
                comando.Parameters.Add("prc_revision", OracleDbType.Decimal).Value = item.Prc_Revision;
                comando.Parameters.Add("total", OracleDbType.Decimal).Value = item.Prc_Total;

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

        public List<Factura> Consultar()
        {
            List<Factura> Facturas = new List<Factura>();
            OracleDataReader ResultadoFacturas;
            OracleConnection sqlconn = new OracleConnection();

            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand();
                comando.Connection = sqlconn;
                comando.CommandText = "SELECT * FROM Vista_Facturas";
                comando.CommandType = CommandType.Text;

                sqlconn.Open();
                ResultadoFacturas = comando.ExecuteReader();

                while (ResultadoFacturas.Read())
                {
                    Factura factura = new Factura();
                    factura.servicios = Convert.ToDouble(ResultadoFacturas["servicio"]);
                    factura.Prc_Revision = Convert.ToDouble(ResultadoFacturas["prc_revision"]);
                    factura.fecha_Fact = DateTime.Parse(ResultadoFacturas["fecha_fact"].ToString());
                    factura.Cliente_CC = ResultadoFacturas["cl_cedula"].ToString();
                    factura.Empleado_CC = ResultadoFacturas["emp_cedula"].ToString();
                    factura.placa = ResultadoFacturas["placa"].ToString();
                    factura.Prc_Total = Convert.ToDouble(ResultadoFacturas["pago_total"]);
                    factura.Cod_Factura = ResultadoFacturas["cod_factura"].ToString();


                    Facturas.Add(factura);
                }
                return Facturas;
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

        public List<Registro> ConsultarRegistro()
        {
            List<Registro> Registros = new List<Registro>();
            OracleDataReader ResultadoRegistro;
            OracleConnection sqlconn = new OracleConnection();

            try
            {
                sqlconn = Conexion_Propietario.ObtenerInstancia().CrearConexion();
                OracleCommand comando = new OracleCommand();
                comando.Connection = sqlconn;
                comando.CommandText = "SELECT * FROM REGISTROS";
                comando.CommandType = CommandType.Text;

                sqlconn.Open();
                ResultadoRegistro = comando.ExecuteReader();

                while (ResultadoRegistro.Read())
                {
                    Registro Registro = new Registro();
                    Registro.servicios = Convert.ToDouble(ResultadoRegistro["servicio"]);
                    Registro.Prc_Revision = Convert.ToDouble(ResultadoRegistro["prc_revision"]);
                    Registro.fecha_Fact = DateTime.Parse(ResultadoRegistro["fecha_fact"].ToString());
                    Registro.Cliente_CC = ResultadoRegistro["cl_cedula"].ToString();
                    Registro.Empleado_CC = ResultadoRegistro["emp_cedula"].ToString();
                    Registro.placa = ResultadoRegistro["placa"].ToString();
                    Registro.Cod_Factura = ResultadoRegistro["cod_factura"].ToString();
                    Registro.Accion = ResultadoRegistro["accion"].ToString();


                    Registros.Add(Registro);
                }
                return Registros;
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
