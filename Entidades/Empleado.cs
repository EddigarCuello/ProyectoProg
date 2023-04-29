using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {


        public float Salario { get; set; }
        public int NumeroDeVehiculos { get; set; }

        public Empleado(string cedula, string nombre, string telefono, string direccion, float salario, int numerodevehiculos) : base(cedula, nombre, telefono, direccion)
        {
            Salario = salario;
            NumeroDeVehiculos = numerodevehiculos;
        }

        public Empleado()
        {
        }

        public override string ToString()
        {
            return base.ToString()  + $"{Salario};{NumeroDeVehiculos}";
        }



    }
}
