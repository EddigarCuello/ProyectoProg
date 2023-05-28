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

        #region "Variables"
        //CRUDEmpleado Servicios = new CRUDEmpleado();
        //CRUDAdmin ServiciosA = new CRUDAdmin();

        int PosX = 0;
        int PosY = 0;

        #endregion

        #region "Metodos"
        private void MoverVentana(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                PosX = e.X;
                PosY = e.Y;
            }
            else
            {
                Left = Left + (e.X - PosX);
                Top = Top + (e.Y - PosY);
            }
        }

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

        //private void Inicio()
        //{
        //    this.Hide();

        //    if (ServiciosA.ExisteCuenta(tbUsuario.Text, tbContraseña.Text) == true)
        //    {
        //        FrmLoginAdmin frmLoginAdmin = new FrmLoginAdmin();
        //        frmLoginAdmin.ShowDialog();
        //    }
        //    else
        //    {
        //        if (Servicios.ExisteCuenta(tbUsuario.Text, tbContraseña.Text) == true)
        //        {
        //            DatosCompartidos.ActualizarCedulaEmpleado(tbContraseña.Text);
        //            FrmLoginEmpleado frmLoginEmpleado = new FrmLoginEmpleado();
        //            frmLoginEmpleado.ShowDialog();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Nombre de usuario o contraseña incorrectos. Vuelva a intentarlo.");
        //            Mostrar();
        //        }

        //    }
        //}

        private void Registrarse()
        {
            Ocultar();
            FrmRegistrar registrar = new FrmRegistrar();
            registrar.ShowDialog();
        }
        #endregion

        #region "Eventos"
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Registrarse();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Inicio();
        }

        private void OcultarContraseña(TextBox tb)
        {
            tb.PasswordChar = '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CerrarApp();
        }

        private void PanelMovimientoDeVentana_MouseMove(object sender, MouseEventArgs e)
        {
            MoverVentana(e);
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            OcultarContraseña(tbContraseña);
        }
        #endregion

    }
}

