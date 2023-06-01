using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calle
    {
        public int Id_Calle { get; set; }
        public int Id_Barrio { get; set; }
        public string Nom_Calle { get; set; }

        public Calle(int id_Calle, int id_Barrio, string nom_Calle)
        {
            Id_Calle = id_Calle;
            Id_Barrio = id_Barrio;
            Nom_Calle = nom_Calle;
        }

        public Calle () 
        {
            
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
