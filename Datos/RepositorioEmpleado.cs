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
                            Nombre = campos[0],
                            Direccion = campos[1],
                            Cedula = campos[2],
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
            string rutaArchivo = ruta;
            bool encontrado = false;

            if (File.Exists(rutaArchivo))
            {
                string[] Archivo = File.ReadAllLines(rutaArchivo);
                foreach (string linea in Archivo)
                {
                    if (linea.Contains(Nombre) && linea.Contains(Cedula))
                    {
                        encontrado = true;
                        break;
                    }
                }
            }

            return encontrado;
        }

    }
}
