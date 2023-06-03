using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaUser
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set;}

        public string cedula { get; set; }
        public string Tipo_Cuenta { get; set; }

        public CuentaUser(string usuario, string contraseña, string cedula, string tipo_Cuenta)
        {
            Usuario = usuario;
            Contraseña = contraseña;
            this.cedula = cedula;
            Tipo_Cuenta = tipo_Cuenta;
        }

        public CuentaUser()
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
