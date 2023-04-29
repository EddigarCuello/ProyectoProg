using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CRUDAdmin : ICRUD<Administrador>
    {

        List<Administrador> lista;
        RepositorioAdministrador Archivos = new RepositorioAdministrador("Administrador.txt");

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

        public bool ExisteCuenta(string Nombre, string Cedula)
        {
            return Archivos.ExisteEntradaEnArchivo(Nombre, Cedula);  
        }
    }
}
