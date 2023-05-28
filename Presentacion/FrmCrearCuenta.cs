using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmCrearCuenta : Form
    {
        public FrmCrearCuenta()
        {
            InitializeComponent();
        }
        Cuenta cuenta = new Cuenta();
        FrmRegistrar frmregistrar = new FrmRegistrar();
        //CRUDEmpleado Servicios = new CRUDEmpleado();
        //ManipularBD ServiciosA = new ManipularBD();
        FrmPrincipal frmPrincipal = new FrmPrincipal();

        public Persona persona { get; set; }
        private void OcultarContraseña(TextBox tb)
        {
            tb.PasswordChar = '*';
        }

        private bool  ComprobarTextBox()
        {
            if (tbContraseña == tbRepeticionContraseña)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private Cuenta GuardarCuenta()
        {
            if (ComprobarTextBox() == true)
            {
                MessageBox.Show("Las cotraseñas deben coicidir");
            }
            else
            {
                cuenta.Contraseña = tbContraseña.Text;
                cuenta.Usuario = tbUsuario.Text;
            }
            
            return cuenta;
            
        }

        private void Salir()
        {
            this.Close();
            frmregistrar.Close();
            frmPrincipal.Show();
        }

        //private string ProcesarPersona(Persona persona)
        //{
        //    if (persona is Administrador)
        //    {
        //        return "Admin";
        //    }
        //    else if (persona is Empleado)
        //    {
        //        return "Empleado";
        //    }
        //    else
        //    {
        //        return "Cliente";
        //    }
        //}

        //private void GuardarEnArchivo()
        //{
        //    Persona persona = DatosCompartidos.ObtenerPersona();
        //    persona.Cuenta = GuardarCuenta();
            

        //    if (ProcesarPersona(persona) == "Admin")
        //    {
        //        Administrador administrador = new Administrador(persona);
        //        var respuesta = ServiciosA.Agregar(administrador);

        //        if (respuesta.Estado == true)
        //        {
        //            MessageBox.Show(respuesta.Item.Nombre.ToUpper() + " " + respuesta.Mensaje);
        //        }
        //        else
        //        {
        //            MessageBox.Show(respuesta.Mensaje);
        //        }
        //    }
        //    else
        //    {
        //        Empleado empleado = new Empleado(persona);
        //        var respuesta = Servicios.Agregar(empleado);

        //        if (respuesta.Estado == true)
        //        {
        //            MessageBox.Show(respuesta.Item.Nombre.ToUpper() + " " + respuesta.Mensaje);
        //        }
        //        else
        //        {
        //            MessageBox.Show(respuesta.Mensaje);
        //        }
        //    }
        //}

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //GuardarEnArchivo();
            Salir();
        }

        private void tbContraseña_TextChanged(object sender, EventArgs e)
        {
            OcultarContraseña(tbContraseña);
        }

        private void tbRepeticionContraseña_TextChanged(object sender, EventArgs e)
        {
            OcultarContraseña(tbRepeticionContraseña);
        }
    }
}
