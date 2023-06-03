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
    public partial class FrmLoginEmpleadoForAdmin : Form
    {
        public FrmLoginEmpleadoForAdmin()
        {
            InitializeComponent();
            tbPlaca.Enabled = false;
            pnPersona.Visible = false;
            dgClientes.AllowUserToAddRows = false;
            dgClientes.RowHeadersVisible = false;
        }

        #region "VARIABLES"
        
        FrmAgregarCliente frmAgregarCliente = new FrmAgregarCliente();
        ServiciosClientes clientes = new ServiciosClientes();
        ServiciosEmpleados empleados = new ServiciosEmpleados();
        ServiciosAdministradores Administradores = new ServiciosAdministradores();
        ServiciosVehiculos S_vehiculos = new ServiciosVehiculos();
        ServiciosFactura S_factura = new ServiciosFactura();
        ServiciosCuentas S_cuenta = new ServiciosCuentas();
        Factura Factura = new Factura();
        string cedula_cl = "";
        string idFActura;
        string placa_veh;
        string usuario;
        #endregion

        #region "Metodos para el form"
        private void Salir()
        {
            this.Close();

        }

        private bool ComprobartbVehiculos()
        {
            if (string.IsNullOrEmpty(tbPlaca.Text) || string.IsNullOrEmpty(tbMarca.Text) ||
                string.IsNullOrEmpty(tbModelo.Text) || (!rbMoto.Checked && !rbCarro.Checked))
            {
                return true;
            }

            return false;
        }

        private void FrmAgregarCliente()
        {
            frmAgregarCliente.ShowDialog();
        }
        #endregion

        #region "Metodo para datos"
        private void ActualizarVeh()
        {
            if (ComprobartbVehiculos() == false)
            {
                string TipoVeh;
                if (rbMoto.Checked)
                {
                    TipoVeh = "Moto";
                }
                else
                {
                    TipoVeh = "Carro";
                }
                Vehiculo vehiculo = new Vehiculo();
                string msgF = S_factura.ActualizarFactura(idFActura, tbCilindraje.Text, TipoVeh, dtpVersion.Value);
                vehiculo.Placa = tbPlaca.Text;
                vehiculo.TipoVehiculo = TipoVeh;
                vehiculo.Modelo = tbModelo.Text;
                vehiculo.Marca = tbMarca.Text;
                vehiculo.Cilindraje = tbCilindraje.Text;
                vehiculo.Version = dtpVersion.Value;

                string msg = S_vehiculos.Actualizar(vehiculo);



                MessageBox.Show(" y " + msgF);//"Se ha editado correctamente");

            }
            else
            {
                MessageBox.Show("Faltan Datos");
            }
        }
        private void MostrarVeh(DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)  // Verificar que se haya hecho clic en una fila válida
            {
                DataGridViewRow fila = dgClientes.Rows[e.RowIndex];

                string cl_cedula = fila.Cells[0].Value.ToString();
                Vehiculo Vehiculos = new Vehiculo();
                Vehiculos = S_vehiculos.Consultar(cl_cedula);

                if (Vehiculos != null)
                {
                    // Obtener los valores de las columnas de la primera fila de la tabla
                    tbPlaca.Text = Vehiculos.Placa;
                    tbModelo.Text = Vehiculos.Modelo;
                    tbMarca.Text = Vehiculos.Marca;
                    tbCilindraje.Text = Vehiculos.Cilindraje;
                    dtpVersion.Value = Vehiculos.Version;
                }
                else
                {
                    MessageBox.Show("Sin Datos");
                }
            }

        }
        private void CargarCuenta()
        {
            CuentaUser DatosUsuario = S_cuenta.DatosCuenta(DatosCompartidos.ObtenerCedula());

            // Verificar si se obtuvieron datos de la cuenta
            if (DatosUsuario != null)
            {
                // Obtener los valores de las propiedades del objeto DatosUsuario
                lbUser.Text = DatosUsuario.Usuario;
                lbPass.Text = DatosUsuario.Contraseña;
            }
        }

        private void Cargar()
        {
            string CC_Emp = DatosCompartidos.ObtenerCedula();
            dgClientes.DataSource = S_vehiculos.ObtInforVehiculos(CC_Emp);

            // Ocultar la cuarta columna (índice 3)
            dgClientes.Columns[3].Visible = false;
            Persona persona = new Persona();
            persona = S_cuenta.ObtenerNombre(CC_Emp);
            lbNombres.Text = persona.Pr_Nombre + "\n " + persona.Pr_Apellido;
        }

        private void CargarDatosFactura(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgClientes.Rows[e.RowIndex];
                string cl_cedula = fila.Cells[0].Value.ToString();


                Factura factura = new Factura();
                factura = S_factura.ObtFactura(cl_cedula);

                if (factura != null)
                {

                    idFActura = factura.Cod_Factura;
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
        }
        #endregion

        #region "Eventos"
        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            Cargar();
        }
        private void btnAgregarCliente_Click_1(object sender, EventArgs e)
        {
            FrmAgregarCliente();
        }
        private void FrmLoginEmpleadoForAdmin_Load(object sender, EventArgs e)
        {
            Cargar();
            CargarCuenta();
        }
        private void dgClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MostrarVeh(e);
            CargarDatosFactura(e);
        }
        private void btnEditarVeh_Click_1(object sender, EventArgs e)
        {
            ActualizarVeh();
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Salir();
        }





        #endregion


    }
}
