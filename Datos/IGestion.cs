using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface IGestion <T>
    {
        string Insertar(T item);
        string Eliminar(string identificador);

        string Actualizar(T item);

        List<T> Consultar();
    }
}
