using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosClientes
    {
        Gestion_Clientes clientes = new Gestion_Clientes();
        public DataTable ObtInforVeh(string CedulaEmp)
        {
            DataTable VehiculoDatos = new DataTable();
            VehiculoDatos = clientes.Listado_Vehiculos_Clientes(CedulaEmp);
            return VehiculoDatos;
        }

        public string InsertarCliente(Cliente cliente) 
        {
            string msg = clientes.InsertarCliente(cliente);
            return msg;
        }

        public string InsertarVehiculos(Vehiculo vehiculo)
        {
            string msg = clientes.InsertarVehiculo(vehiculo);
            return msg;
        }

        public string InsertarCuentaCliente(Cuenta cuenta)
        {
            string msg = clientes.InsertarCuenta(cuenta);
            return msg;
        }


        public DataTable ObtFactura(string cl_cedula)
        {
            DataTable Factura = clientes.ObtenerFacturas(cl_cedula);
            return Factura;
        }

        public string InsertarFactura(Factura factura,string cilindraje,string tp_vehiculo,DateTime version)
        {
            double factor_version= 1;
            double factor_cilindraje = 1;
            double prc_servicios = 0;
            double prc_revision = 0;
            double total = 0;
            if (version.Year >= 2018)
            {
                factor_version = 1.2;
            }
            if(cilindraje == "ALTO")
            {
                factor_cilindraje = 1.5;
            }
            else
            {
                if(cilindraje == "MEDIO")
                {
                    factor_cilindraje = 1.2;
                }
                else
                {
                    factor_cilindraje = 1.1;
                }
            }

            if(tp_vehiculo == "Moto")
            {
                prc_revision = 15000;
                prc_servicios = (factor_cilindraje * factor_version * prc_revision);
                prc_servicios = Math.Round(prc_servicios);
            }
            else
            {
                prc_revision = 30000;
                prc_servicios = (factor_cilindraje * factor_version * prc_revision);
                prc_servicios = Math.Round(prc_servicios);
            }

            total = prc_servicios + prc_revision;
            total = Math.Round(total);     
            factura.servicios = prc_servicios;
            factura.Prc_Revision = prc_revision;
            factura.Prc_Total = total;

            string msg = clientes.InsertarFactura(factura);
            return msg;
        }

        public string ActualizarFactura(string idFactura, string cilindraje,string tp_vehiculo,DateTime version)
        {
            Factura factura = new Factura();
            double factor_version = 1;
            double factor_cilindraje = 1;
            double prc_servicios = 0;
            double prc_revision = 0;
            double total = 0;
            if (version.Year >= 2018)
            {
                factor_version = 1.2;
            }
            if (cilindraje == "ALTO")
            {
                factor_cilindraje = 1.5;
            }
            else
            {
                if (cilindraje == "MEDIO")
                {
                    factor_cilindraje = 1.2;
                }
                else
                {
                    factor_cilindraje = 1.1;
                }
            }

            if (tp_vehiculo == "Moto")
            {
                prc_revision = 15000;
                prc_servicios = (factor_cilindraje * factor_version * prc_revision);
                prc_servicios = Math.Round(prc_servicios);
            }
            else
            {
                prc_revision = 30000;
                prc_servicios = (factor_cilindraje * factor_version * prc_revision);
                prc_servicios = Math.Round(prc_servicios);
            }

            total = prc_servicios + prc_revision;
            total = Math.Round(total);
            factura.servicios = prc_servicios;
            factura.Prc_Revision = prc_revision;
            factura.Prc_Total = total;
            factura.Cod_Factura = idFactura;

            string msg = clientes.ActualizarFactura(factura);
            return msg;
        }

        public string ActualizarVehiculos(string placa, string nuevoTipoVehiculo, string nuevoModelo,
            string nuevaMarca, string nuevoCilindraje)
        {
             string msg = clientes.ActualizarVehiculo(placa,  nuevoTipoVehiculo,  nuevoModelo,
             nuevaMarca, nuevoCilindraje);
            return msg;
        }
        public DataTable ObtDatosVeh(string cl_cedula)
        {
            DataTable Vehiculos = clientes.ObtenerDatosVehiculo(cl_cedula);
            return Vehiculos;
        }



    }
}
