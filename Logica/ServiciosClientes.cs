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
    public class ServiciosClientes
    {
        Gestion_Clientes G_clientes = new Gestion_Clientes();
        public string InsertarCliente(Cliente cliente) 
        {
            string msg = G_clientes.Insertar(cliente);
            return msg;
        }
        public string EliminarCliente(string cliente)
        {
            string msg = G_clientes.Eliminar(cliente);
            return msg;
        }

        public Cliente ObtCliente(string cedula)
        {
            List<Cliente> clientes = new List<Cliente>();
             clientes= G_clientes.Consultar();
            Cliente cliente = new Cliente();
            foreach(Cliente client in clientes)
            {
                if(client.Cedula == cedula)
                {
                    cliente = client;
                }
            }

            return cliente;

        }

        public string ActualizarCliente(Cliente cliente)
        {
            string msg = G_clientes.Actualizar(cliente);
            return msg;
        }
    }
}
