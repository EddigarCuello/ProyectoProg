using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioEmpleado
    {
        private string ruta;

        public RepositorioEmpleado(string ruta)
        {
            this.ruta = ruta;
        }
        public Response Guardar(Empleado guardar)
        {
            try
            {
                StreamWriter Escritor = new StreamWriter(ruta, true);

                Escritor.WriteLine(guardar.ToString());
                Escritor.Close();

                return new Response("HA SIDO GUARDADO EXITOSOSAMENTE", true, guardar);
            }
            catch (Exception)
            {
                return new Response("FALLO AL GUARDAR", false, null);
            }


        }
        public List<Empleado> Recuperar()
        {
            List<Empleado> Empleados = new List<Empleado>();

            using (StreamReader reader = new StreamReader(ruta))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] campos = linea.Split(';');
                    if (campos.Length == 6)
                    {
                        Empleado Empleado = new Empleado
                        {
                            Cedula = campos[0],
                            Nombre = campos[1],
                            Direccion = campos[2],
                            Telefono = campos[3],
                            Salario = float.Parse(campos[4]),
                            NumeroDeVehiculos = int.Parse(campos[5])
                        };

                        Empleados.Add(Empleado);
                    }
                }
            }

            return Empleados;
        }

        public bool ExisteEntradaEnArchivo(string Nombre, string Cedula)
        {
            bool encontrado = false;

            if (File.Exists(ruta))
            {
                using (StreamReader lector = new StreamReader(ruta))
                {
                    string linea;
                    while ((linea = lector.ReadLine()) != null)
                    {
                        string[] valores = linea.Split(';');

                        Console.WriteLine($"Comparando: Cedula {valores[0]} con {Cedula} y Nombre {valores[1]} con {Nombre}");

                        if (valores.Length >= 2 && valores[0] == Cedula && valores[1] == Nombre)
                        {
                            encontrado = true;
                            break;
                        }
                    }
                }
            }


            Console.WriteLine($"Entrada encontrada en datos: {encontrado}");

            return encontrado;
        }

    }
}
