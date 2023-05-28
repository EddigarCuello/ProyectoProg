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
        List<string> Mensajes;
        Gestion_Direcciones Direcciones = new Gestion_Direcciones();
        Gestion_Administradores G_Administradores = new Gestion_Administradores();
        DataTable Ciudades = new DataTable();
        DataTable Barrios = new DataTable();
        DataTable Calles = new DataTable();


        public DataTable Listado_Ciudades()
        {
            Ciudades = Direcciones.ListadoCiudades();
            return Ciudades;
        }

        public DataTable Listado_Barrios(int Id_ciudad)
        {
            Barrios = Direcciones.ListadoBarrios(Id_ciudad);
            return Barrios;
        }

        public DataTable Listado_Calles(int Id_Barrios)
        {
            Calles = Direcciones.ListadoCalles(Id_Barrios);
            return Calles;
        }

        public string InsertarAdministradores(Persona administrador)
        {
            string msg1 = G_Administradores.InsertarAdministradores(administrador);
            return msg1;
        }

        public string InsertarCuenta(Cuenta cuenta, string CedulaAdm)
        {
            string msg2 = G_Administradores.InsertarCuenta(cuenta, CedulaAdm); 
            return msg2;
        }

        public string rollback()
        {
            string msgRb = G_Administradores.Rollback();
            return msgRb;
        }

    }
}
