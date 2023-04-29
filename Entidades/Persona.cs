using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public string Cedula {  get; set; }
        public string Nombre { get;set; }
        public string Telefono { get; set; }
        public string Direccion { get; set;}

        public Persona(string cedula, string nombre, string telefono, string direccion)
        {
            Cedula = cedula;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
        }

        public Persona()
        {
        }

        public override string ToString()
        {
            return $"{Cedula};{Nombre};{Telefono};{Direccion};";
        }
    }
}
