using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosAdministradores
    {
        #region "Declaraciones y Varables"
        Gestion_Direcciones Direcciones = new Gestion_Direcciones();
        Gestion_Administradores G_Administradores = new Gestion_Administradores();
        Gestion_Inicio inicio = new Gestion_Inicio();
        DataTable V_cuentas = new DataTable();
        List<Ciudad> Ciudades ;
        List<Barrio> Barrios;
        List<Calle> Calles;
        #endregion



        public List<Ciudad> Listado_Ciudades()
        {
            Ciudades = Direcciones.ListadoCiudades();
            return Ciudades;
        }

        public List<Barrio>  Listado_Barrios(int Id_ciudad)
        {
            List<Barrio> FiltroBarrios = new List<Barrio>();
            Barrios = Direcciones.ListadoBarrios();
            
            foreach(var Barrio in Barrios) 
            { 
                if(Barrio.Id_Ciudad == Id_ciudad)
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

            foreach(var Calle in Calles)
            {
                if (Calle.Id_Barrio == Id_Barrios)
                {
                    FiltroCalles.Add(Calle);
                }
            }

            return FiltroCalles;
        }

        public string InsertarAdministradores(Persona administrador)
        {
            string msg1 = G_Administradores.InsertarAdministradores(administrador);
            return msg1;
        }

        public string InsertarCuenta(Cuenta cuenta)
        {
            string msg2 = G_Administradores.InsertarCuenta(cuenta); 
            return msg2;
        }

        public string rollback()
        {
            string msgRb = G_Administradores.Rollback();
            return msgRb;
        }

        public DataTable V_Cuentas()
        {
            V_cuentas = inicio.ListadoCuentas();
            return V_cuentas;

        }

    }
}
