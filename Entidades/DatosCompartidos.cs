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
        public static string CedulaAdmin{ get; set; }
        public static string CedulaNuevoEmp { get; set; }

        public static string CedulaEmp { get; set; }

        public static void ActualizarCedula(string cedula)
        {
            Cedula = cedula;
        }


        public static string ObtenerCedula()
        {
            return Cedula;
        }



        public static void ActualizarCedulaAdmin(string cedula)
        {
            CedulaAdmin = cedula;
        }


        public static string ObtenerCedulaAdmin()
        {
            return CedulaAdmin;
        }

        public static void ActualizarCedulaNuevoEmp(string cedula)
        {
            CedulaNuevoEmp = cedula;
        }


        public static string ObtenerCedulaNuevoEmp()
        {
            return CedulaNuevoEmp;
        }

        public static void ActualizarCedulaEmp(string cedula)
        {
            CedulaEmp = cedula;
        }


        public static string ObtenerCedulaEmp()
        {
            return CedulaEmp;
        }



    }
}
