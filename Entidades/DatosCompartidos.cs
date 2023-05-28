using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class DatosCompartidos
    {
        public static string CedulaEmpleado { get; set; }
        public static string NombreEmpleado { get; set; }

        public static Persona Persona { get; set; }

        public static void ActualizarPersona(Persona persona)
        {
            Persona = persona;
        }

        public static Persona ObtenerPersona()
        {
            return Persona;
        }


        public static void ActualizarCedulaEmpleado(string cedula)
        {
            CedulaEmpleado = cedula;
        }

        public static void ActualizarNombreEmpleado(string nombre)
        {
            NombreEmpleado = nombre;
        }

        public static string ObtenerCedulaEmpleado()
        {
            return CedulaEmpleado;
        }

        public static string ObtenerNombreEmpleado()
        {
            return NombreEmpleado;
        }
    }
}
