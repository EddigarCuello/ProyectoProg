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
    public partial class FrmLoginCliente : Form
    {
        

        public FrmLoginCliente()
        {
            InitializeComponent();

            
        }

        #region "INSTANCIAS"
        ServiciosClientes clientes = new ServiciosClientes();
        FrmPrincipal principal = new FrmPrincipal();
        ServiciosEmpleados ServiciosEmpleados = new ServiciosEmpleados();
        ServiciosAdministradores Administradores = new ServiciosAdministradores();
        ServiciosFactura S_factura = new ServiciosFactura();
        ServiciosCuentas S_cuenta = new ServiciosCuentas();
        Factura factura = new Factura();
        ServicioReporte S_reporte = new ServicioReporte();
        #endregion

        #region "Metodos para datos"
        private void CargarDatosFactura()
        {


            
            factura = S_factura.ObtFactura(DatosCompartidos.ObtenerCedula());

            if (factura != null)
            {


                lbCoidgoFact.Text = factura.Cod_Factura;
                lbPrc_Servicios.Text = factura.servicios.ToString();
                lbPrc_Revision.Text = factura.Prc_Revision.ToString();
                lb_Total.Text = factura.Prc_Total.ToString();
                lbFechaFact.Text = factura.fecha_Fact.ToString();
            }
            else
            {
                MessageBox.Show("No se encontraron datos de la factura.");
                lbCoidgoFact.Text = "None";
                lbPrc_Servicios.Text = "None";
                lbPrc_Revision.Text = "None";
                lb_Total.Text = "None";
                lbFechaFact.Text = "None";
            }


        }

        private void CargarCuenta()
        {
            CuentaUser DatosUsuario = S_cuenta.DatosCuenta(DatosCompartidos.ObtenerCedula());
            string CC_Cliente = DatosCompartidos.ObtenerCedula();

            Persona persona1 = new Persona();
            persona1 = S_cuenta.ObtenerNombre(CC_Cliente);
            lbNombres.Text = persona1.Pr_Nombre + "\n " + persona1.Pr_Apellido;

            // Verificar si se obtuvieron datos de la cuenta
            if (DatosUsuario != null)
            {
                // Obtener los valores de las propiedades del objeto DatosUsuario
                lbUser.Text = DatosUsuario.Usuario;
                lbPass.Text = DatosUsuario.Contraseña;
            }
        }

        private void GenerarPdf()
        {

            string nombrePDF = "FACTURA " + factura.Cod_Factura.ToString();
            S_reporte.GenerarPDFFactura(factura, nombrePDF);

            // Abrir el archivo PDF después de generarlo
            string rutaPDF = nombrePDF + ".pdf";
            System.Diagnostics.Process.Start(rutaPDF);

        }

        #endregion

        #region "Metodos del form"
        private void Salir()
        {

            principal.Show();
            this.Close();
        }
        #endregion

        #region "EVENTOS"
        private void FrmLoginCliente_Load(object sender, EventArgs e)
        {
            CargarDatosFactura();
            CargarCuenta();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
        #endregion

        private void btngenerarPdf_Click(object sender, EventArgs e)
        {
            GenerarPdf();
        }
    }
}
