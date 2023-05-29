﻿using Entidades;
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
        ServiciosAdministradores admin = new ServiciosAdministradores();
        string tipo_cuenta;
        //CRUDAdmin ServiciosA = new CRUDAdmin();

        int PosX = 0;
        int PosY = 0;

        #endregion

        #region "Metodos"
        private bool GestionInicio()
        {
            string usuario = tbUsuario.Text;
            string contraseña = tbContraseña.Text;
            DataTable tablaCuentas = admin.V_Cuentas();
            bool coinciden = false;
            tipo_cuenta = ""; // Variable para guardar el tipo de cuenta

            foreach (DataRow row in tablaCuentas.Rows)
            {
                string usuarioTabla = row["usuario"].ToString();
                string contraseñaTabla = row["contraseña"].ToString();

                if (usuario == usuarioTabla && contraseña == contraseñaTabla)
                {
                    coinciden = true;
                    tipo_cuenta = row["tipo_cuenta"].ToString(); // Obtener el tipo de cuenta de la fila actual
                    break;
                }
            }

            return coinciden;
        }

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

        private void Inicio()
        {

            GestionInicio();
            MessageBox.Show(tipo_cuenta);
            this.Hide();

            if (GestionInicio() == true && tipo_cuenta == "Administrador")
            {
                FrmLoginAdmin frmLoginAdmin = new FrmLoginAdmin();
                frmLoginAdmin.ShowDialog();
            }
            else
            {
                if (GestionInicio() == true && tipo_cuenta == "Empleado")
                {
                    DatosCompartidos.ActualizarCedulaEmpleado(tbContraseña.Text);
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
        #endregion

        #region "Eventos"
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Registrarse();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Inicio();
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

