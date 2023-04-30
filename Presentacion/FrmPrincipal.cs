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
        List<Administrador> ListaA;
        CRUDEmpleado Servicios = new CRUDEmpleado();
        CRUDAdmin ServiciosA = new CRUDAdmin();

        void AbrirFormularioRegistrar(FrmRegistrar f)
        {
            this.Hide();
            f.ShowDialog(this);
        }

        void AbrirFormularioLoginAdmin(FrmLoginAdmin f)
        {
            this.Hide();
            f.ShowDialog(this);
        }
        void AbrirFormularioLoginEmpleado(FrmLoginEmpleado f)
        {
            this.Hide();
            f.ShowDialog(this);
        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            AbrirFormularioRegistrar(new FrmRegistrar());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ServiciosA.ExisteCuenta(tbUsuario.Text, tbContraseña.Text) == true)
            {
                AbrirFormularioLoginAdmin(new FrmLoginAdmin());
            }
            else
            {
                if (Servicios.ExisteCuenta(tbUsuario.Text, tbContraseña.Text) == true)
                {
                    AbrirFormularioLoginEmpleado(new FrmLoginEmpleado());
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos. Vuelva a intentarlo.");
                }
                
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

