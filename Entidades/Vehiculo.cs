using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string  Cilindraje { get; set; }
        public DateTime Version { get; set; }
        public string Marca { get; set; }
        public string TipoVehiculo { get; set; }

        public string CedulaCliente { get; set; }

        public Vehiculo(string placa, string modelo, string cilindraje, DateTime version, string marca, string tipoVehiculo, string cedulaCliente)
        {
            Placa = placa;
            Modelo = modelo;
            Cilindraje = cilindraje;
            Version = version;
            Marca = marca;
            TipoVehiculo = tipoVehiculo;
            CedulaCliente = cedulaCliente;
        }

        public Vehiculo() { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
