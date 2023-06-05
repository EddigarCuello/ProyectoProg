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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class FrmAgregarCliente : Form
    {
        public FrmAgregarCliente()
        {
            InitializeComponent();

        }
        #region "INSTANCIAS"
        //ServiciosClientee Servicios = new ServiciosClientee();
        ServiciosAdministradores admin = new ServiciosAdministradores();
        ServiciosClientes clientes = new ServiciosClientes();
        ServiciosFactura S_factura = new ServiciosFactura();
        ServiciosVehiculos S_vehiculos = new ServiciosVehiculos();
        ServiciosCuentas S_cuentas = new ServiciosCuentas();
        ServicioDirecciones S_direccionnes = new ServicioDirecciones();
        int idCiudadSeleccionada;
        int idBarrioSeleccionado;
        int idCalleSeleccionada;
        string CodigoSecreto = "Admin2023";
        Cliente Cliente = new Cliente();
        Vehiculo vehiculo = new Vehiculo();
        CuentaUser cuenta = new CuentaUser();
        Factura factura = new Factura();
        string cilindrajeSeleccionado;
        string msg1;
        string msg2;
        string msg3;
        string msg4;
        #endregion


        #region "METODOS DIRECCIONES"
        private void MostrarCiudades()
        {
            CB_CIUDADES.DataSource =S_direccionnes.Listado_Ciudades();
            CB_CIUDADES.ValueMember = "id_ciudad";
            CB_CIUDADES.DisplayMember = "nom_ciudad";
        }

        private void MostrarBarrios(int idCiudad)
        {
            CB_BARRIOS.SelectedIndex = -1;
            CB_CALLES.SelectedIndex = -1;

            List<Barrio> barrios = S_direccionnes.Listado_Barrios(idCiudad);

            CB_BARRIOS.DataSource = barrios;
            CB_BARRIOS.ValueMember = "id_barrio";
            CB_BARRIOS.DisplayMember = "nom_barrio";



        }
        private void DesactivarCb_Barrios()
        {
            CB_BARRIOS.Enabled = false;
        }

        private void ActivarCb_Barrios()
        {
            CB_BARRIOS.Enabled = true;
        }

        private void ObtenerId_Ciudad()
        {
            Ciudad ciudadSeleccionada = (Ciudad)CB_CIUDADES.SelectedItem;
            idCiudadSeleccionada = ciudadSeleccionada.Id_Ciudad;
        }


        private void ObtenerId_Barrio()
        {
            Barrio barrioSeleccionado = (Barrio)CB_BARRIOS.SelectedItem;
            if (barrioSeleccionado != null)
            {
                idBarrioSeleccionado = barrioSeleccionado.id_Barrio;
            }
        }


        private void ObtenerId_Calle()
        {
            Calle calleSeleccionada = (Calle)CB_CALLES.SelectedItem;
            if (calleSeleccionada != null)
            {
                idCalleSeleccionada = calleSeleccionada.Id_Calle;
            }
        }
        private void MostrarCalles(int IdBarrio)
        {

            CB_CALLES.SelectedIndex = -1;

            List<Calle> calles = S_direccionnes.Listado_Calles(IdBarrio);


            CB_CALLES.DataSource = calles;
            CB_CALLES.ValueMember = "id_calle";
            CB_CALLES.DisplayMember = "nom_calle";
        }

        #endregion

        #region "METODOS DEL FORM"
        private bool ComprobarCampos()
        {
            if (string.IsNullOrEmpty(tbCedula.Text) || string.IsNullOrEmpty(tbPrNombre.Text) || string.IsNullOrEmpty(tbPrApellido.Text) ||
                string.IsNullOrEmpty(tbTelefono.Text) || string.IsNullOrEmpty(CB_CALLES.Text) || string.IsNullOrEmpty(tbUser.Text) ||
                string.IsNullOrEmpty(TbPass.Text) || string.IsNullOrEmpty(tbPlaca.Text) || string.IsNullOrEmpty(tbMarca.Text) ||  CB_CALLES.SelectedIndex == -1 || (!rbMoto.Checked && !rbCarro.Checked))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void VaciarTodo()
        {
            // Vaciar TextBoxes
            tbCedula.Text = string.Empty;
            tbPrNombre.Text = string.Empty;
            tbPrApellido.Text = string.Empty;
            tbTelefono.Text = string.Empty;
            tbUser.Text = string.Empty;
            TbPass.Text = string.Empty;
            tbPlaca.Text = string.Empty;
            tbMarca.Text = string.Empty;
            tbModelo.Text = string.Empty;


            // Reiniciar RadioButtons
            rbMoto.Checked = false;
            rbCarro.Checked = false;
        }


        private void Salir()
        {
            
            this.Close();
            

        }
        private void CargarCbCilindraje()
        {
            cbCilindraje.Items.Add("ALTO");
            cbCilindraje.Items.Add("MEDIO");
            cbCilindraje.Items.Add("BAJO");

        }
        #endregion

        #region "METODO DE DATOS"
        public void ObtenerCuenta()
        {
            cuenta.Contraseña = TbPass.Text;
            cuenta.Usuario = tbUser.Text;
        }
        public void Guardar()
        {

            Cliente.Pr_Nombre = tbPrNombre.Text;
            Cliente.Pr_Apellido = tbPrApellido.Text;
            Cliente.Cedula = tbCedula.Text;
            Cliente.CedulaEmpleado = DatosCompartidos.ObtenerCedula();
           // DatosCompartidos.ActualizarCedulaCliente(Cliente.Cedula);
            Cliente.Telefono = tbTelefono.Text;
            Cliente.Id_calle = idCalleSeleccionada;



            ObtenerCuenta();
            string TipoVeh;
            if (rbMoto.Checked)
            {
                TipoVeh = "Moto";
            }
            else
            {
                TipoVeh = "Carro";
            }
            Cliente.Usuario = cuenta.Usuario;

            vehiculo.Marca = tbMarca.Text;
            vehiculo.Placa = tbPlaca.Text;
            vehiculo.Cilindraje = cilindrajeSeleccionado;
            vehiculo.Version = dtpVersion.Value;
            vehiculo.Modelo = tbModelo.Text;
            vehiculo.TipoVehiculo = TipoVeh;
            vehiculo.CedulaCliente = Cliente.Cedula;

            factura.placa = vehiculo.Placa;
            factura.Cliente_CC = Cliente.Cedula;
            factura.Empleado_CC = Cliente.CedulaEmpleado;
            factura.fecha_Fact = System.DateTime.Now;



            msg2 = S_cuentas.InsertarCuenta(cuenta);
            msg1 = clientes.Insertar(Cliente);
            msg3 = S_vehiculos.Insertar(vehiculo);
            msg4 = S_factura.InsertarFactura(factura, vehiculo.Cilindraje, vehiculo.TipoVehiculo, vehiculo.Version);

            MessageBox.Show(msg4);
            if (msg2 == "OK")
            {
                MessageBox.Show(msg1);
            }
            else
            {
                MessageBox.Show(msg2);
            }

        }
        #endregion

        #region "EVENTOS"
        private void CB_CIUDADES_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerId_Ciudad();
            MostrarBarrios(idCiudadSeleccionada);
        }

        private void CB_BARRIOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(idBarrioSeleccionado.ToString());
            ObtenerId_Barrio();
            MostrarCalles(idBarrioSeleccionado);
            ObtenerId_Calle();


        }

        private void FrmAgregarCliente_Load(object sender, EventArgs e)
        {
            MostrarCiudades();
            CargarCbCilindraje();
            VaciarTodo();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            if (ComprobarCampos() == false)
            {
                Guardar();
                Salir();


            }
            else
            {
                MessageBox.Show("Faltan Datos");
            }
        }
        private void CB_CALLES_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerId_Calle();
        }
        private void cbCilindraje_SelectedIndexChanged(object sender, EventArgs e)
        {
            cilindrajeSeleccionado = cbCilindraje.SelectedItem.ToString();
        }

        #endregion


    }
}
