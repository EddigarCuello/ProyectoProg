using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class DatosCompartidos
    {
        public static string Cedula { get; set; }
        public static string CedulaCliente { get; set; }

        public static void ActualizarCedula(string cedula)
        {
            Cedula = cedula;
        }


        public static string ObtenerCedula()
        {
            return Cedula;
        }

        

        public static void ActualizarCedulaCLiente(string cedula)
        {
            CedulaCliente = cedula;
        }


        public static string ObtenerCedulaCLiente()
        {
            return CedulaCliente;
        }



    }
}
