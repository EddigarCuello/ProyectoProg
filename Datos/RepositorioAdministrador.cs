using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioAdministrador
    {
        private string ruta;

        public RepositorioAdministrador(string ruta)
        {
            this.ruta = ruta;
        }
        public Response Guardar(Administrador guardar)
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
        public List<Administrador> Recuperar()
        {
            List<Administrador> Admins = new List<Administrador>();

            using (StreamReader reader = new StreamReader(ruta))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] campos = linea.Split(';');
                    if (campos.Length == 5)
                    {
                        Administrador Admin = new Administrador
                        {
                            Nombre = campos[0],
                            Direccion = campos[1],
                            Cedula = campos[2],
                            Telefono = campos[3],
                            GananciasEmpresa = float.Parse(campos[4])
                        };

                        Admins.Add(Admin);
                    }
                }
            }
            return Admins;
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
