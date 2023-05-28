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
        public string Pr_Nombre { get;set; }
        public string Pr_Apellido { get; set; }
        public string Telefono { get; set; }
        public int Id_calle { get; set;}

        public Persona(string cedula, string pr_nombre, string pr_apellido, string telefono, int id_calle)
        {
            Cedula = cedula;
            Pr_Nombre = pr_nombre;
            Pr_Apellido = pr_apellido;
            Telefono = telefono;
            Id_calle = id_calle;

        }

        public Persona()
        {
        }

        public override string ToString()
        {
            return $"{Cedula};{Pr_Nombre};{Pr_Apellido};{Telefono};{Id_calle};";
        }
    }
}
