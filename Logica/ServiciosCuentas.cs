using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServiciosCuentas
    {
        Gestion_Cuenta G_cuentas = new Gestion_Cuenta();
        Gestion_Inicio G_inicio = new Gestion_Inicio();
        


        public string InsertarCuenta(CuentaUser cuenta)
        {
            string msg2 = G_cuentas.InsertarCuenta(cuenta);
            return msg2;
        }


        public CuentaUser DatosCuenta(string Cedula)
        {
            CuentaUser User = new CuentaUser();
            List<CuentaUser> Users = G_cuentas.Listadousuraios();

            foreach (CuentaUser Cuenta in Users)
            {
                if (Cuenta.cedula == Cedula)
                {
                    User.Usuario = Cuenta.Usuario;
                    User.Contraseña = Cuenta.Contraseña;
                    User.cedula = Cuenta.cedula;
                    User.Tipo_Cuenta = Cuenta.Tipo_Cuenta;
                }
            }
            return User;
        }

        public DataTable V_Cuentas()
        {
            DataTable V_cuentas = new DataTable();
            V_cuentas = G_inicio.ListadoCuentas();
            return V_cuentas;

        }

        public Persona ObtenerNombre(string cedula)
        {
            List<Persona> personas = new List<Persona>();
            personas = G_inicio.ObtenerNombres();
            Persona persona = new Persona();
            foreach (Persona person in personas)
            {
                if (person.Cedula == cedula)
                {
                    persona = person;
                }
            }
            return persona;
        }

        public string EliminarCuenta(string usuario)
        {
            string msg = G_cuentas.EliminarCuenta(usuario);
            return msg;
        }
    }
}
