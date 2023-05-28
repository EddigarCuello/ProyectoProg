using Datos;
using Entidades;
using System;
using System.Collections.Generic;
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

        public string InsertarCuenta(Cuenta cuenta, string CedulaAdm)
        {
            string msg2 = G_Empleados.InsertarCuenta(cuenta, CedulaAdm);
            return msg2;
        }

        public string rollback()
        {
            string msgRb = G_Empleados.Rollback();
            return msgRb;
        }
    }
}
