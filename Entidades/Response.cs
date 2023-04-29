using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Response
    {
        public Response(string mensaje, bool estado, Persona contacto)
        {
            Mensaje = mensaje;
            Estado = estado;
            Item = contacto;
        }

        public string Mensaje { get; set; }
        public bool Estado { get; set; }
        public Persona Item { get; set; }
    }
}
