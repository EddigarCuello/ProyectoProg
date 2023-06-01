using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        public string Cod_Factura { get; set; }
        public double servicios { get; set; }
        public double Prc_Revision { get; set; }
        public DateTime fecha_Fact { get; set; }
        public string Cliente_CC { get; set; }
        public string Empleado_CC { get; set; }
        public string placa { get; set; }
        public double Prc_Total { get; set; }

        public Factura(string cod_Factura, double servicios, double prc_Revision, DateTime fecha_Fact, string cliente_CC, string empleado_CC, string placa, double prc_Total)
        {
            Cod_Factura = cod_Factura;
            this.servicios = servicios;
            Prc_Revision = prc_Revision;
            this.fecha_Fact = fecha_Fact;
            Cliente_CC = cliente_CC;
            Empleado_CC = empleado_CC;
            this.placa = placa;
            Prc_Total = prc_Total;
        }
        public Factura()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
