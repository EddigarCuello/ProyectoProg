using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosClientes : IServicios<Cliente>
    {
        Gestion_Clientes G_clientes = new Gestion_Clientes();


        public string Insertar(Cliente item)
        {
            string msg = G_clientes.Insertar(item);
            return msg;
        }

        public string Eliminar(string identificador)
        {
            string msg = G_clientes.Eliminar(identificador);
            return msg;
        }

        public string Actualizar(Cliente item)
        {
            string msg = G_clientes.Actualizar(item);
            return msg;
        }

        public Cliente Consultar(String identificador)
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes = G_clientes.Consultar();
            Cliente cliente = new Cliente();
            foreach (Cliente client in clientes)
            {
                if (client.Cedula == identificador)
                {
                    cliente = client;
                }
            }

            return cliente;
        }
    }
}
