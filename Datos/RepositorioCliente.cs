using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioCliente
    {
        private string ruta;

        public RepositorioCliente(string ruta)
        {
            this.ruta = ruta;
        }
        public Response Guardar(Cliente guardar)
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
        public List<Cliente> Recuperar()
        {
            List<Cliente> Clientes = new List<Cliente>();

            if (!File.Exists(ruta))
            {
                File.Create(ruta).Close();
            }

            using (StreamReader reader = new StreamReader(ruta))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] campos = linea.Split(';');
                    if (campos.Length == 9)
                    {
                        Cliente Cliente = new Cliente
                        {
                            Nombre = campos[0],
                            Direccion = campos[1],
                            Cedula = campos[2],
                            Telefono = campos[3],
                            IngresoVehiculo = DateTime.Parse(campos[4]),
                            SalidaVehiculo = DateTime.Parse((campos[5])),
                            CedulaEmpleado = campos[6],
                            PlacaVihiculo = campos[7],
                            PrecioAcordado = float.Parse(campos[8])
                        };

                        Clientes.Add(Cliente);
                    }
                }
            }

            return Clientes;
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


                        if (valores.Length >= 2 && valores[0] == Cedula && valores[1] == Nombre)
                        {
                            encontrado = true;
                            break;
                        }
                    }
                }
            }



            return encontrado;
        }
    }
}
