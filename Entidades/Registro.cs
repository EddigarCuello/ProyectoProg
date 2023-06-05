using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Registro : Factura
    {
        public Registro()
        {
        }

        public Registro(string cod_Factura, double servicios, double prc_Revision, DateTime fecha_Fact, string cliente_CC, string empleado_CC, string placa, double prc_Total,string accion) : base(cod_Factura, servicios, prc_Revision, fecha_Fact, cliente_CC, empleado_CC, placa, prc_Total)
        {
            Accion = accion;
        }



        public string Accion { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{Accion}";

        }


    }
}
