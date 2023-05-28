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
    public class CRUDAdmin : ICRUD<Administrador>
    {

        List<Administrador> lista;
        DataTable TablaCiudades = new DataTable();
        DataTable TablaBarrios = new DataTable();
        DataTable TablaCalles = new DataTable();
        RepositorioAdministrador Archivos = new RepositorioAdministrador("Administrador.txt");

        Gestion_Direcciones Direcciones = new Gestion_Direcciones();
        

        public CRUDAdmin()
        {

            //Refresh();

        }
        private void Refresh()
        {
            lista = Archivos.Recuperar();
        }
        public Response Agregar(Administrador Item)
        {
            if (Existe(Item))
            {
                return new Response("Este prestamista ya esta registrado", false, null);
                
            }
            else
            {
                var EmpleadoG = Archivos.Guardar(Item);
                Refresh();
                return EmpleadoG;
            }
        }

        public List<Administrador> MostrarTodo()
        {
            Refresh();
            return lista;
        }



        public bool Existe(Administrador Item)
        {
            if ((lista != null) && (Item != null))
            {

                foreach (var Obj in lista)
                {
                    if (Obj.Nombre == Item.Nombre && Obj.Cedula == Item.Cedula)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool ExisteUsuario(Administrador Item)
        {
            if ((lista != null) && (Item != null))
            {

                foreach (var Obj in lista)
                {
                    if (Obj.Cuenta.Usuario == Item.Cuenta.Usuario && Obj.Cuenta.Contraseña == Item.Cuenta.Contraseña)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool ExisteCuenta(string Nombre, string Cedula)
        {
            return Archivos.ExisteEntradaEnArchivo(Nombre, Cedula);  
        }

        public DataTable Listado_ciudades()
        {  
            TablaCiudades = Direcciones.ListadoCiudades();  
            return TablaCiudades;
        }

        public DataTable Listado_barrios()
        {
            TablaBarrios = Direcciones.ListadoBarrios();
            return TablaBarrios;
        }

        public DataTable Listado_Calles()
        {
            TablaCalles = Direcciones.ListadoCalles();
            return TablaCalles;
        }
    }
}
