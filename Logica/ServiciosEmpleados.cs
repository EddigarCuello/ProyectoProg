using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosEmpleados
    {
        Gestion_Empleados G_Empleados = new Gestion_Empleados();
        
        public string InsertarAdministradores(Persona administrador)
        {
            string msg1 = G_Empleados.InsertarEmpleados(administrador);
            return msg1;
        }

        public string InsertarCuenta(Cuenta cuenta)
        {
            string msg2 = G_Empleados.InsertarCuenta(cuenta);
            return msg2;
        }


        public DataTable ListadoClientes()
        {
            return null;
        }

        public DataTable ListareEmpleados_NumClientes() 
        {
            DataTable EMPCL = new DataTable();
            EMPCL = G_Empleados.ListadoEmpleado_NumClientes();
            return EMPCL;
        }

        public DataTable ObtDatosEmp(string Cedula)
        {
            DataTable Datos = new DataTable();
            Datos = G_Empleados.DatosEmp(Cedula);
            return Datos;
        }

    }
}
