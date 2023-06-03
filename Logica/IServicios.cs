using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IServicios <T>
    {
        string Insertar(T item);
        string Eliminar(string identificador);

        string Actualizar(T item);

        T Consultar(String identificador);
    }
}
