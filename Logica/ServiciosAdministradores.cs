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
    public class ServiciosAdministradores
    {
        #region "Declaraciones y Varables"
        
        Gestion_Administradores G_Administradores = new Gestion_Administradores();

        #endregion
        public string InsertarAdministradores(Persona administrador)
        {
            string msg1 = G_Administradores.InsertarAdministradores(administrador);
            return msg1;
        }

    }
}
