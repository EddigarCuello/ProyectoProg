using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Cliente : Persona
    {


        public string CedulaEmpleado { get; set; }
  

        public Cliente()
        {
        }

        public Cliente(string cedula, string pr_nombre, string pr_apellido, string telefono, int id_calle, string usuario,string cedulaempleado) : base(cedula, pr_nombre, pr_apellido, telefono, id_calle, usuario)
        {
            CedulaEmpleado = cedulaempleado;

        }

        public override string ToString()
        {
            return base.ToString() + $"{CedulaEmpleado};";
        }






    }
}
