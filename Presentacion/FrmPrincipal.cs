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
    public partial class FrmPrincipal : Form
    {
        

        public FrmPrincipal()
        {
            InitializeComponent();
        }
        CRUDEmpleado Servicios = new CRUDEmpleado();
        CRUDAdmin ServiciosA = new CRUDAdmin();
        
        private void Mostrar()
        {
            this.Show();
        }

        private void Ocultar()
        {
            this.Hide();
        }

        private void CerrarApp()
        {
            Environment.Exit(0);
        }

        private void Inicio()
        {
            this.Hide();

            if (ServiciosA.ExisteCuenta(tbUsuario.Text, txtCedula.Text) == true)
            {
                FrmLoginAdmin frmLoginAdmin = new FrmLoginAdmin();
                frmLoginAdmin.ShowDialog();
            }
            else
            {
                if (Servicios.ExisteCuenta(tbUsuario.Text, txtCedula.Text) == true)
                {
                    DatosCompartidos.ActualizarCedulaEmpleado(txtCedula.Text);
                    FrmLoginEmpleado frmLoginEmpleado = new FrmLoginEmpleado();
                    frmLoginEmpleado.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos. Vuelva a intentarlo.");
                    Mostrar();
                }

            }
        }

        private void Registrarse()
        {
            Ocultar();
            FrmRegistrar registrar = new FrmRegistrar();
            registrar.ShowDialog();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Registrarse();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Inicio();
        }

    private void btnSalir_Click(object sender, EventArgs e)
        {
            CerrarApp(); 
        }
    }
}

