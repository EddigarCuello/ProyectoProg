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
        ServiciosClientes clientes = new ServiciosClientes();
        FrmPrincipal principal = new FrmPrincipal();
        ServiciosEmpleados ServiciosEmpleados = new ServiciosEmpleados();
        private void CargarDatosFactura()
        {


                // Obtener los datos de la factura correspondiente a la cédula del cliente
                DataTable DtFactura = clientes.ObtFactura(DatosCompartidos.ObtenerCedula());

                // Verificar si se obtuvieron datos de la factura
                if (DtFactura.Rows.Count > 0)
                {
                    // Obtener los valores de las columnas de la primera fila de la tabla
                    string codFactura = DtFactura.Rows[0]["COD_FACTURA"].ToString();
                    string servicio = DtFactura.Rows[0]["SERVICIO"].ToString();
                    string prcRevision = DtFactura.Rows[0]["PRC_REVISION"].ToString();
                    string pagoTotal = DtFactura.Rows[0]["PAGO_TOTAL"].ToString();
                    string fechaFact = DtFactura.Rows[0]["FECHA_FACT"].ToString();
                    string empCedula = DtFactura.Rows[0]["EMP_CEDULA"].ToString();
                    string placa = DtFactura.Rows[0]["PLACA"].ToString();

                    // Actualizar los valores de los labels con los datos obtenidos
                    lbCoidgoFact.Text = codFactura;
                    lbPrc_Servicios.Text = servicio;
                    lbPrc_Revision.Text = prcRevision;
                    lb_Total.Text = pagoTotal;
                    lbFechaFact.Text = fechaFact;
                }
                else
                {
                    // No se encontraron datos de la factura, puedes mostrar un mensaje o realizar alguna acción adicional si es necesario
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
            DataTable Dtcuenta =ServiciosEmpleados.DatosCuenta (DatosCompartidos.ObtenerCedula());

            // Verificar si se obtuvieron datos de la factura
            if (Dtcuenta.Rows.Count > 0)
            {
                // Obtener los valores de las columnas de la primera fila de la tabla
                lbUser.Text= Dtcuenta.Rows[0]["USUARIO"].ToString();
                lbPass.Text = Dtcuenta.Rows[0]["CONTRASEÑA"].ToString();

            }
        }

        private void Salir()
        {

            principal.Show();
            this.Close();
        }
        private void FrmLoginCliente_Load(object sender, EventArgs e)
        {
            CargarDatosFactura();
            CargarCuenta();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
    }
}
