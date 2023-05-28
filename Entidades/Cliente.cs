using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Cliente : Persona
    {

        public DateTime IngresoVehiculo { get; set; }
        public DateTime SalidaVehiculo { get; set;  }
        public string CedulaEmpleado { get; set; }
        public string PlacaVihiculo { get; set; }
        public float PrecioAcordado { get; set; }

        //public Cliente(string cedula, string nombre, string telefono, string direccion,Cuenta cuenta, DateTime ingresovehiculo, DateTime salidavehiculo, string cedulaempleado, string placaVihiculo, float precioAcordado) : base(cedula, nombre, telefono, direccion)
        //{
        //    IngresoVehiculo = ingresovehiculo;
        //    SalidaVehiculo = salidavehiculo;
        //    CedulaEmpleado = cedulaempleado;
        //    PlacaVihiculo = placaVihiculo;
        //    PrecioAcordado = precioAcordado;

        //}

        //public Cliente()
        //{
        //}

        //public override string ToString()
        //{
        //    return base.ToString() + $"{IngresoVehiculo.ToShortDateString()};{SalidaVehiculo.ToShortDateString()};{CedulaEmpleado};{PlacaVihiculo};{PrecioAcordado}";
        //}






    }
}
