using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosFactura
    {
        Gestion_Factura G_factura = new Gestion_Factura();


        public string InsertarFactura(Factura factura, string cilindraje, string tp_vehiculo, DateTime version)
        {
            double factor_version = 1;
            double factor_cilindraje = 1;
            double prc_servicios = 0;
            double prc_revision = 0;
            double total = 0;
            if (version.Year >= 2018)
            {
                factor_version = 1.2;
            }
            if (cilindraje == "ALTO")
            {
                factor_cilindraje = 1.5;
            }
            else
            {
                if (cilindraje == "MEDIO")
                {
                    factor_cilindraje = 1.2;
                }
                else
                {
                    factor_cilindraje = 1.1;
                }
            }

            if (tp_vehiculo == "Moto")
            {
                prc_revision = 15000;
                prc_servicios = (factor_cilindraje * factor_version * prc_revision);
                prc_servicios = Math.Round(prc_servicios);
            }
            else
            {
                prc_revision = 30000;
                prc_servicios = (factor_cilindraje * factor_version * prc_revision);
                prc_servicios = Math.Round(prc_servicios);
            }

            total = prc_servicios + prc_revision;
            total = Math.Round(total);
            factura.servicios = prc_servicios;
            factura.Prc_Revision = prc_revision;
            factura.Prc_Total = total;

            string msg = G_factura.InsertarFactura(factura);
            return msg;
        }

        public string ActualizarFactura(string idFactura, string cilindraje, string tp_vehiculo, DateTime version)
        {
            Factura factura = new Factura();
            double factor_version = 1;
            double factor_cilindraje = 1;
            double prc_servicios = 0;
            double prc_revision = 0;
            double total = 0;
            if (version.Year >= 2018)
            {
                factor_version = 1.2;
            }
            if (cilindraje == "ALTO")
            {
                factor_cilindraje = 1.5;
            }
            else
            {
                if (cilindraje == "MEDIO")
                {
                    factor_cilindraje = 1.2;
                }
                else
                {
                    factor_cilindraje = 1.1;
                }
            }

            if (tp_vehiculo == "Moto")
            {
                prc_revision = 15000;
                prc_servicios = (factor_cilindraje * factor_version * prc_revision);
                prc_servicios = Math.Round(prc_servicios);
            }
            else
            {
                prc_revision = 30000;
                prc_servicios = (factor_cilindraje * factor_version * prc_revision);
                prc_servicios = Math.Round(prc_servicios);
            }

            total = prc_servicios + prc_revision;
            total = Math.Round(total);
            factura.servicios = prc_servicios;
            factura.Prc_Revision = prc_revision;
            factura.Prc_Total = total;
            factura.Cod_Factura = idFactura;

            string msg = G_factura.ActualizarFactura(factura);
            return msg;
        }

        public Factura ObtFactura(string cl_cedula)
        {
            List<Factura> facturas = new List<Factura>();
            facturas = G_factura.ObtenerFacturas();
            Factura factura = new Factura();
            foreach (Factura fact in facturas)
            {
                if (fact.Cliente_CC == cl_cedula)
                {
                    factura = fact; break;
                }
            }
            return factura;
        }

        public string EliminarFactura(int p_id_factura)
        {
            string msg = G_factura.EliminarFactura(p_id_factura);
            return msg;
        }
    }
}
