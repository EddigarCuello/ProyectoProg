using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmLoginEmpleado : Form
    {

        
        public FrmLoginEmpleado()
        {
            InitializeComponent();
            tbPlaca.Enabled = false;
            pnPersona.Visible = false;
        }
        #region
        FrmPrincipal frmPrincipal = new FrmPrincipal();
        ServiciosClientes ServiciosC  = new ServiciosClientes();
        FrmAgregarCliente frmAgregarCliente = new FrmAgregarCliente();
        ServiciosClientes clientes = new ServiciosClientes();
        string cedulacl = "";
        #endregion
        private bool ComprobartbVehiculos()
        {
            if (string.IsNullOrEmpty(tbPlaca.Text) || string.IsNullOrEmpty(tbMarca.Text) ||
                string.IsNullOrEmpty(tbModelo.Text) || (!rbMoto.Checked && !rbCarro.Checked))
            {
                return true;
            }

            return false;
        }


        private void MostrarVeh(DataGridViewCellEventArgs e)
        {

                if (e.RowIndex >= 0)  // Verificar que se haya hecho clic en una fila válida
                {
                    DataGridViewRow fila = dgClientes.Rows[e.RowIndex];

                    string cl_cedula = fila.Cells[0].Value.ToString();
                    //MessageBox.Show(cl_cedula);
                    DataTable Vehiculos = new DataTable();
                    Vehiculos = clientes.ObtDatosVeh(cl_cedula);
                    
                    if (Vehiculos.Rows.Count > 0)
                    {
                        // Obtener los valores de las columnas de la primera fila de la tabla
                        tbPlaca.Text = Vehiculos.Rows[0]["PLACA"].ToString();
                        tbModelo.Text = Vehiculos.Rows[0]["MODELO"].ToString();
                        tbMarca.Text = Vehiculos.Rows[0]["MARCA"].ToString();
                        tbCilindraje.Text = Vehiculos.Rows[0]["CILINDRAJE"].ToString();


                    }
                }
 
        }


        private void ActualizarVeh()
        {
            if (ComprobartbVehiculos() == false)
            {
                string TipoVeh;
                if (rbMoto.Checked)
                {
                    TipoVeh = "moto";
                }
                else
                {
                    TipoVeh = "carro";
                }
                string msg = clientes.ActualizarVehiculos(tbPlaca.Text,TipoVeh, tbModelo.Text,
             tbMarca.Text, tbCilindraje.Text);
                MessageBox.Show("Se ha editado correctamente");
            }
            else
            {
                MessageBox.Show("Faltan Datos");
            }
        }



        private void FrmAgregarCliente()
        {
           frmAgregarCliente.ShowDialog();
            

           
        }
        private void Cargar()
        {
            string CC_Emp = DatosCompartidos.ObtenerCedula();
            dgClientes.DataSource = ServiciosC.ObtInforVeh(CC_Emp);

            // Ocultar la cuarta columna (índice 3)
            dgClientes.Columns[3].Visible = false;
        }

        private void CargarDatosFactura(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Verificar que se haya hecho clic en una fila válida
            {
                DataGridViewRow fila = dgClientes.Rows[e.RowIndex];

                // Obtener el valor de la columna "CL_CEDULA" de la fila seleccionada
                //string cl_cedula = fila.Cells["CL_CEDULA"].Value.ToString();
                string cl_cedula = fila.Cells[0].Value.ToString();
                //MessageBox.Show(cl_cedula);


                // Obtener los datos de la factura correspondiente a la cédula del cliente
                DataTable DtFactura = clientes.ObtFactura(cl_cedula);

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
        }


        private void Salir()
        {
            this.Close();
            frmPrincipal.Show();
            
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Cargar(); 
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente();   
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
        private void FrmLoginEmpleado_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarVeh(e);
            CargarDatosFactura(e);
        }

        private void btnEditarVeh_Click(object sender, EventArgs e)
        {
            ActualizarVeh();
        }
    }
}


