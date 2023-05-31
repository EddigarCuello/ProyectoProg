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

        public string InsertarFactura(string cl_cedula,string emp_cedula,string placa)
        {
            string msg = clientes.InsertarFactura(cl_cedula,emp_cedula,placa);
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
