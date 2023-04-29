using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface ICRUD <T>
    {
        Response Agregar(T Item);
        List<T> MostrarTodo();
        bool Existe(T Item);
        bool ExisteCuenta(string Nombre, string Cedula);

    }
}
