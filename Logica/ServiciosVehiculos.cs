using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosVehiculos
    {
        Gestion_Vehiculos G_vehiculo = new Gestion_Vehiculos();
        public string InsertarVehiculos(Vehiculo vehiculo)
        {
            string msg = G_vehiculo.Insertar(vehiculo);
            return msg;
        }

        public string ActualizarVehiculos(Vehiculo vehiculo)
        {
            string msg = G_vehiculo.Actualizar(vehiculo);
            return msg;
        }
        public Vehiculo ObtDatosVeh(string cl_cedula)
        {
            Vehiculo vehiculo = new Vehiculo();
            List<Vehiculo> Vehiculos = G_vehiculo.Consultar();
            foreach (Vehiculo Veh in Vehiculos)
            {
                if (Veh.CedulaCliente == cl_cedula)
                {
                    vehiculo = Veh; break;
                }
            }

            return vehiculo;
        }

        public List<Vehiculo_Empleado> ObtInforVeh(string CedulaEmp)
        {
            List<Vehiculo_Empleado> vehiculo_Empleados = new List<Vehiculo_Empleado>();
            List<Vehiculo_Empleado> Filtro_vehiculo_Empleados = new List<Vehiculo_Empleado>();
            vehiculo_Empleados = G_vehiculo.Listado_Vehiculos_Clientes();
            foreach (Vehiculo_Empleado Veh_Emp in vehiculo_Empleados)
            {
                if (Veh_Emp.Emp_Cedula == CedulaEmp)
                {
                    Filtro_vehiculo_Empleados.Add(Veh_Emp);
                }
            }
            return Filtro_vehiculo_Empleados;
        }

        public string EliminarVehiculo (string placa) 
        {
            string msg = G_vehiculo.Eliminar(placa);
            return msg;
        }
    }
}
