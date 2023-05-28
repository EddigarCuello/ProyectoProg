using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CalcularPrecioRevision
    {
        public double CalcularRevision(Vehiculo vehiculo)
        {
            if (vehiculo.TipoVehiculo == "Moto")
            {
                return 15000;
            }
            else
            {
                if (vehiculo.TipoVehiculo == "Carro")
                {
                    return 30000;
                }
                else
                {
                    return 50000;
                }
            }
               
            
        }
    }
}
