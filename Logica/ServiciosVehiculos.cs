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
    public class ServiciosVehiculos :IServicios<Vehiculo>
    {
        Gestion_Vehiculos G_vehiculo = new Gestion_Vehiculos();


        public List<Vehiculo_Empleado> ObtInforVehiculos(string CedulaEmp)
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

        public string Insertar(Vehiculo item)
        {
            string msg = G_vehiculo.Insertar(item);
            return msg;
        }

        public string Eliminar(string identificador)
        {
            string msg = G_vehiculo.Eliminar(identificador);
            return msg;
        }

        public string Actualizar(Vehiculo item)
        {
            string msg = G_vehiculo.Actualizar(item);
            return msg;
        }

        public Vehiculo Consultar(string identificador)
        {
            Vehiculo vehiculo = new Vehiculo();
            List<Vehiculo> Vehiculos = G_vehiculo.Consultar();
            foreach (Vehiculo Veh in Vehiculos)
            {
                if (Veh.CedulaCliente == identificador)
                {
                    vehiculo = Veh; break;
                }
            }

            return vehiculo;
        }
    }
}
