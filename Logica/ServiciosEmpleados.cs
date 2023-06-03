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
    

        
        public string InsertarEmpleado(Persona Empleado)
        {
            string msg1 = G_Empleados.InsertarEmpleados(Empleado);
            return msg1;
        }

       

        public DataTable ListareEmpleados_NumClientes() 
        {
            DataTable EMPCL = new DataTable();
            EMPCL = G_Empleados.ListadoEmpleado_NumClientes();
            return EMPCL;
        }
        //Filtado en codigo
        public Persona ObtDatosEmp(string Cedula)
        {

            List<Persona> empleados = new List<Persona>();
            Persona empleado = new Persona();

            empleados = G_Empleados.DatosEmp();
            foreach(Persona Emp in empleados)
            {
                if(Emp.Cedula == Cedula)
                {
                    empleado.Cedula = Emp.Cedula;
                    empleado.Usuario  = Emp.Usuario;
                    empleado.Pr_Nombre = Emp.Pr_Nombre;
                    empleado.Pr_Apellido = Emp.Pr_Apellido;
                    empleado.Telefono = Emp.Telefono;
                    empleado.Id_calle = Emp.Id_calle;

                }
            }

            return empleado;
        }
        //Filtrado en codigo
        

    }
}
