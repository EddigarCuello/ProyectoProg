using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Barrio
    {
        public int id_Barrio { get; set; }
        public int Id_Ciudad { get; set; }
        public string Nom_Barrio { get; set; }

        public Barrio(int id_Barrio, int id_Ciudad, string nom_Barrio)
        {
            this.id_Barrio = id_Barrio;
            Id_Ciudad = id_Ciudad;
            Nom_Barrio = nom_Barrio;
        }

        public Barrio() 
        { 
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
