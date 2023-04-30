using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CRUDCliente : ICRUD<Cliente>
    {
        List<Cliente> lista;
        RepositorioCliente Archivos = new RepositorioCliente("Clietes.txt");

        public CRUDCliente()
        {

            Refresh();

        }
        private void Refresh()
        {
            lista = Archivos.Recuperar();
        }
        public Response Agregar(Cliente Item)
        {
            if (Existe(Item))
            {
                return new Response("Este prestamista ya esta registrado", false, null);

            }
            else
            {
                var ClienteG = Archivos.Guardar(Item);
                Refresh();
                return ClienteG;
            }
        }

        public List<Cliente> MostrarTodo()
        {
            Refresh();
            return lista;
        }

        public bool Existe(Cliente Item)
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
