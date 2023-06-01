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
    public partial class FrmAgregarCliente : Form
    {
        public FrmAgregarCliente()
        {
            InitializeComponent();

        }
        #region
        //ServiciosClientee Servicios = new ServiciosClientee();
        ServiciosAdministradores admin = new ServiciosAdministradores();
        ServiciosClientes clientes = new ServiciosClientes();
        int idCiudadSeleccionada;
        int idBarrioSeleccionado;
        int idCalleSeleccionada;
        string CodigoSecreto = "Admin2023";
        Cliente Cliente = new Cliente();
        Vehiculo vehiculo = new Vehiculo();
        Cuenta cuenta = new Cuenta();
        Factura factura = new Factura();
        string msg1;
        string msg2;
        string msg3;
        string msg4;
        #endregion


        #region "METODOS DIRECCIONES"
        private void MostrarCiudades()
        {
            CB_CIUDADES.DataSource = admin.Listado_Ciudades();
            CB_CIUDADES.ValueMember = "id_ciudad";
            CB_CIUDADES.DisplayMember = "nom_ciudad";
        }

        private void MostrarBarrios(int idCiudad)
        {
            CB_BARRIOS.SelectedIndex = -1;
            CB_CALLES.SelectedIndex = -1;

            List<Barrio> barrios = admin.Listado_Barrios(idCiudad);

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

            List<Calle> calles = admin.Listado_Calles(IdBarrio);


            CB_CALLES.DataSource = calles;
            CB_CALLES.ValueMember = "id_calle";
            CB_CALLES.DisplayMember = "nom_calle";
        }









        #endregion

        private bool ComprobarCampos()
        {
            if(string.IsNullOrEmpty(tbCedula.Text) || string.IsNullOrEmpty(tbPrNombre.Text) || string.IsNullOrEmpty(tbPrApellido.Text) ||
                 string.IsNullOrEmpty(tbTelefono.Text) || string.IsNullOrEmpty(CB_CALLES.Text) || string.IsNullOrEmpty(tbUser.Text) ||
                 string.IsNullOrEmpty(TbPass.Text) || string.IsNullOrEmpty(tbPlaca.Text) || string.IsNullOrEmpty(tbMarca.Text) ||
                 string.IsNullOrEmpty(tbCilindraje.Text) || string.IsNullOrEmpty(tbTipoVeh.Text))
            {
                return true;
            }else
            {
                return false;
            }
        }

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
            DatosCompartidos.ActualizarCedulaCliente(Cliente.Cedula);
            Cliente.Telefono = tbTelefono.Text;
            Cliente.Id_calle = idCalleSeleccionada;

            

            ObtenerCuenta();
            Cliente.Usuario = cuenta.Usuario;

            vehiculo.Marca = tbMarca.Text;
            vehiculo.Placa = tbPlaca.Text;
            vehiculo.Cilindraje = tbCilindraje.Text;
            vehiculo.Version = dtpVersion.Value;
            vehiculo.Modelo = tbModelo.Text;
            vehiculo.TipoVehiculo = tbTipoVeh.Text;
            vehiculo.CedulaCliente = Cliente.Cedula;

            factura.placa = vehiculo.Placa;
            factura.Cliente_CC = Cliente.Cedula;
            factura.Empleado_CC = Cliente.CedulaEmpleado;
            factura.fecha_Fact = System.DateTime.Now;





                msg2 = clientes.InsertarCuentaCliente(cuenta);
                msg1 = clientes.InsertarCliente(Cliente);
                msg3 = clientes.InsertarVehiculos(vehiculo);
                msg4 = clientes.InsertarFactura(factura,vehiculo.Cilindraje,vehiculo.TipoVehiculo,vehiculo.Version);

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

        private void Salir()
        {
            this.Close();
            
        }





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
    }
}
