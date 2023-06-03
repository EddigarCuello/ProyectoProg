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
    public partial class FrmLoginAdmin : Form
    {
        public FrmLoginAdmin()
        {
            InitializeComponent();
            dgEmpleados.AllowUserToAddRows = false;
            dgEmpleados.RowHeadersVisible = false;
        }



        #region "INSTANCIAS"
        FrmPrincipal frmPrincipal = new FrmPrincipal();
        ServiciosEmpleados empleados = new ServiciosEmpleados();
        ServiciosAdministradores Administradores = new ServiciosAdministradores();
        ServiciosCuentas S_cuentas = new ServiciosCuentas();

        #endregion

        #region "METODOS PARA DATOS"
        private void Cargar()
        {
            dgEmpleados.DataSource = empleados.ListareEmpleados_NumClientes();
            string CC_Cliente = DatosCompartidos.ObtenerCedula();

            Persona persona1 = new Persona();
            persona1 = S_cuentas.ObtenerNombre(CC_Cliente);
            lbNombres.Text = persona1.Pr_Nombre + "\n " + persona1.Pr_Apellido;
        }

        private void CargarCuenta()
        {
            CuentaUser DatosUsuario = S_cuentas.DatosCuenta(DatosCompartidos.ObtenerCedulaAdmin());

            // Verificar si se obtuvieron datos de la cuenta
            if (DatosUsuario != null)
            {
                // Obtener los valores de las propiedades del objeto DatosUsuario
                lbUser.Text = DatosUsuario.Usuario;
                lbPass.Text = DatosUsuario.Contraseña;
            }
        }

        private void DatosParaLogearEmpleado(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgEmpleados.Rows[e.RowIndex];
                string emp_cedula = fila.Cells[0].Value.ToString();

                DatosCompartidos.ActualizarCedula(emp_cedula);


            }
        }
        private void CargarLogEmpleado()
        {
            FrmLoginEmpleadoForAdmin frmLoginEmpleado = new FrmLoginEmpleadoForAdmin();
            frmLoginEmpleado.ShowDialog();
        }
        #endregion

        #region "METODOS PARA EL FORM"
        void Salir()
        {
            this.Close();
            frmPrincipal.Show();
        }
        #endregion

        #region "EVENTOS"
        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void FrmLoginAdmin_Load(object sender, EventArgs e)
        {
            Cargar();
            CargarCuenta();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
        #endregion

        private void dgEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DatosParaLogearEmpleado(e);
            CargarLogEmpleado();

        }
    }
}
