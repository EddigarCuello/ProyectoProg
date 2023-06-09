﻿using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CRUDEmpleado : ICRUD<Empleado>
    {

        List<Empleado> lista;
        RepositorioEmpleado Archivos = new RepositorioEmpleado("Empleados.txt");

        public CRUDEmpleado()
        {

            Refresh();

        }
        private void Refresh()
        {
            lista = Archivos.Recuperar();
        }
        public Response Agregar(Empleado Item)
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

        public List<Empleado> MostrarTodo()
        {
            if (lista == null) 
            {
                Refresh();
            }
            return lista;
        }

        public bool Existe(Empleado Item)
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

        public bool ExisteUsuario(Empleado Item)
        {
            if ((lista != null) && (Item != null))
            {

                foreach (var Obj in lista)
                {
                    if (Obj.Cuenta.Usuario == Item.Cuenta.Usuario && Obj.Cuenta.Contraseña== Item.Cuenta.Contraseña)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool ExisteCuenta(string Usuario, string Contraseña)
        {
            return Archivos.ExisteEntradaEnArchivo(Usuario, Contraseña);
        }



    }
}
