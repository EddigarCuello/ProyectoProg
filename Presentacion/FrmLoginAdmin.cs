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

        FrmPrincipal frmPrincipal = new FrmPrincipal();
        ServiciosEmpleados empleados = new ServiciosEmpleados();
        void Cargar()
        {
            dgEmpleados.DataSource = empleados.ListareEmpleados_NumClientes();
        }
        void Salir()
        {
            this.Close();
            frmPrincipal.Show();
        }
        private void CargarCuenta()
        {
            DataTable Dtcuenta = empleados.DatosCuenta(DatosCompartidos.ObtenerCedula());

            // Verificar si se obtuvieron datos de la factura
            if (Dtcuenta.Rows.Count > 0)
            {
                // Obtener los valores de las columnas de la primera fila de la tabla
                lbUser.Text = Dtcuenta.Rows[0]["USUARIO"].ToString();
                lbPass.Text = Dtcuenta.Rows[0]["CONTRASEÑA"].ToString();

            }
        }
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
    }
}
