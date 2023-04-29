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
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            FrmRegistrar FrmRegistrarF = new FrmRegistrar();
            FrmRegistrarF.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ServiciosA.ExisteCuenta(tbUsuario.Text, tbContraseña.Text) == true)
            {
                FrmLoginAdmin FrmLoginA = new FrmLoginAdmin();
                FrmLoginA.ShowDialog();
            }
            else
            {
                if (Servicios.ExisteCuenta(tbUsuario.Text, tbContraseña.Text) == true)
                {
                    FrmLoginEmpleado FrmLoginE = new FrmLoginEmpleado();
                    FrmLoginE.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos. Vuelva a intentarlo.");
                }
                
            }
        }
    }
}

