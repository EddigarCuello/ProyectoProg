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

        #region "VARIABLES"
        ServiciosAdministradores admin = new ServiciosAdministradores();
        ServiciosCuentas S_cuentas = new ServiciosCuentas();
        string tipo_cuenta;

        int PosX = 0;
        int PosY = 0;

        #endregion

        #region "METODOS PARA EL FORM"

        private void Registrarse()
        {
            Ocultar();
            FrmRegistrar registrar = new FrmRegistrar();
            registrar.ShowDialog();
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
        #endregion

        #region "METODO DE INFORMACION"

        private bool GestionInicio()
        {
            string usuario = tbUsuario.Text;
            string contraseña = tbContraseña.Text;
            DataTable tablaCuentas = S_cuentas.V_Cuentas();
            
            bool coinciden = false;
            tipo_cuenta = ""; // Variable para guardar el tipo de cuenta

            foreach (DataRow row in tablaCuentas.Rows)
            {
                string usuarioTabla = row["usuario"].ToString();
                string contraseñaTabla = row["contraseña"].ToString();

                if (usuario == usuarioTabla && contraseña == contraseñaTabla)
                {
                    coinciden = true;
                    DatosCompartidos.ActualizarCedula(row["cedula"].ToString());
                    tipo_cuenta = row["tipo_de_cuenta"].ToString(); // Obtener el tipo de cuenta de la fila actual
                    if(tipo_cuenta == "Administrador")
                    {
                        DatosCompartidos.ActualizarCedulaAdmin(row["cedula"].ToString());
                    }
                    break;
                }
            }

            return coinciden;
        }
        private void Inicio()
        {

            //GestionInicio();
            //MessageBox.Show(tipo_cuenta);
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
                    
                    FrmLoginEmpleado frmLoginEmpleado = new FrmLoginEmpleado();
                    frmLoginEmpleado.ShowDialog();
                }
                else
                {
                    if (GestionInicio() == true && tipo_cuenta == "Cliente")
                    {
                        FrmLoginCliente frmLoginCliente = new FrmLoginCliente();
                        frmLoginCliente.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos. Vuelva a intentarlo.");
                        Mostrar();
                    }
                    
                }

            }
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

