using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Persona
    {


        public float GananciasEmpresa { get; set; }

        public Administrador(string cedula, string nombre, string telefono, string direccion, float gananciasempresa) : base(cedula, nombre, telefono, direccion)
        {
            GananciasEmpresa = gananciasempresa;
        }

        public Administrador()
        {
        }

        public override string ToString()
        {
            return base.ToString() + $"{GananciasEmpresa}";
        }



    }
}
