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
        public Response Agregar(Cliente Item)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Cliente Item)
        {
            throw new NotImplementedException();
        }

        public bool ExisteCuenta(string Nombre, string Cedula)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> MostrarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
