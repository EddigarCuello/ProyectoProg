using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuenta
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set;}

        public Cuenta(string usuario, string contraseña)
        {
            Usuario = usuario;
            Contraseña = contraseña;
        }

        public Cuenta()
        {
        }

        public override string ToString()
        {
            return $"{Usuario};{Contraseña}";
        }
    }
}
