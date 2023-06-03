using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioDirecciones
    {
        Gestion_Direcciones Direcciones = new Gestion_Direcciones();
        List<Ciudad> Ciudades;
        List<Barrio> Barrios;
        List<Calle> Calles;
        public List<Ciudad> Listado_Ciudades()
        {
            Ciudades = Direcciones.ListadoCiudades();
            return Ciudades;
        }

        public List<Barrio> Listado_Barrios(int Id_ciudad)
        {
            List<Barrio> FiltroBarrios = new List<Barrio>();
            Barrios = Direcciones.ListadoBarrios();

            foreach (var Barrio in Barrios)
            {
                if (Barrio.Id_Ciudad == Id_ciudad)
                {
                    FiltroBarrios.Add(Barrio);
                }
            }
            return FiltroBarrios;
        }

        public List<Calle> Listado_Calles(int Id_Barrios)
        {
            List<Calle> FiltroCalles = new List<Calle>();
            Calles = Direcciones.ListadoCalles();

            foreach (var Calle in Calles)
            {
                if (Calle.Id_Barrio == Id_Barrios)
                {
                    FiltroCalles.Add(Calle);
                }
            }

            return FiltroCalles;
        }
    }
}
