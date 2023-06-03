using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo_Empleado
    {
        public string Cl_Cedula { get; set; }
        public string pr_Nombre { get; set; }
        public string pr_apellido { get; set; }
        public string Emp_Cedula { get;set; }
        public string Veh_Placa { get; set;}
        public string Marca { get; set;}

        public Vehiculo_Empleado(string cl_Cedula, string pr_Nombre, string pr_apellido, string emp_Cedula, string veh_Placa, string marca)
        {
            Cl_Cedula = cl_Cedula;
            this.pr_Nombre = pr_Nombre;
            this.pr_apellido = pr_apellido;
            Emp_Cedula = emp_Cedula;
            Veh_Placa = veh_Placa;
            Marca = marca;
        }

        public Vehiculo_Empleado()
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
