using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciudades
    {
        public string Id_Ciudad { get; set; }

        public string Nom_Ciudad { get; set; }

        public Ciudades(string id_Ciudad, string nom_Ciudad)
        {
            Id_Ciudad = id_Ciudad;
            Nom_Ciudad = nom_Ciudad;
        }
    }
}
