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
            dgClientes.AllowUserToAddRows = false;
            dgClientes.RowHeadersVisible = false;
            
        }

        #region "VARIABLES"
        FrmPrincipal frmPrincipal = new FrmPrincipal();
        FrmAgregarCliente frmAgregarCliente = new FrmAgregarCliente();
        ServiciosClientes clientes = new ServiciosClientes();
        ServiciosFactura S_factura = new ServiciosFactura();
        ServiciosVehiculos S_vehiculos = new ServiciosVehiculos();
        ServicioDirecciones S_direcciones = new ServicioDirecciones();
        ServiciosCuentas S_cuentas = new ServiciosCuentas();
        Factura Factura = new Factura();
        CuentaUser DatosUsuarioCLiente = new CuentaUser();
        string cedula_cl = "";
        Cliente P_cliente = new Cliente();
        int idFActura;
        string placa;
        int idCiudadSeleccionada;
        int idBarrioSeleccionado;
        int idCalleSeleccionada;
        string cilindrajeSeleccionado;
        #endregion

        #region "Metodos para el form"
        private void Salir()
        {
            this.Close();
            frmPrincipal.Show();

        }

        private bool ComprobartbVehiculos()
        {
            if (string.IsNullOrEmpty(tbPlaca.Text) || string.IsNullOrEmpty(tbMarca.Text) ||
                string.IsNullOrEmpty(tbModelo.Text) || (!rbMoto.Checked && !rbCarro.Checked) ||
                cbCilindraje.SelectedIndex == -1)
            {
                return true;
            }

            return false;
        }

        private void FrmAgregarCliente()
        {
            frmAgregarCliente.ShowDialog();
        }

        private void DesactivarPanelCliente()
        {
            pnCliente.Visible = false;
            pnVehiculo.Visible = true;
            
        }

        private void ActivarPanelCliente()
        {
            pnVehiculo.Visible = false;
            pnCliente.Visible = true;
            
        }
        private bool ComprobartbCliente()
        {
            if (string.IsNullOrEmpty(tbPr_Nombre.Text) || string.IsNullOrEmpty(tbPr_Apellido.Text) ||
                string.IsNullOrEmpty(tbTelefono.Text))
            {
                return true;
            }

            return false;
        }

        private void CargarCbCilindraje()
        {
            cbCilindraje.Items.Add("ALTO");
            cbCilindraje.Items.Add("MEDIO");
            cbCilindraje.Items.Add("BAJO");

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
                string msgF = S_factura.ActualizarFactura(idFActura.ToString(),cilindrajeSeleccionado, TipoVeh, dtpVersion.Value);
                vehiculo.Placa = tbPlaca.Text;
                vehiculo.TipoVehiculo = TipoVeh;
                vehiculo.Modelo = tbModelo.Text;
                vehiculo.Marca = tbMarca.Text;
                vehiculo.Cilindraje = cilindrajeSeleccionado;
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
                cedula_cl = cl_cedula;
                CargarCuentaCliente();
                Vehiculo Vehiculos = new Vehiculo();
                Vehiculos = S_vehiculos.Consultar(cl_cedula);

                if (Vehiculos != null)
                {
                    // Obtener los valores de las columnas de la primera fila de la tabla
                    placa = Vehiculos.Placa;
                    tbPlaca.Text = Vehiculos.Placa;
                    tbModelo.Text = Vehiculos.Modelo;
                    tbMarca.Text = Vehiculos.Marca;
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
            CuentaUser DatosUsuario = S_cuentas.DatosCuenta(DatosCompartidos.ObtenerCedula());

            // Verificar si se obtuvieron datos de la cuenta
            if (DatosUsuario != null)
            {
                // Obtener los valores de las propiedades del objeto DatosUsuario
                lbUser.Text = DatosUsuario.Usuario;
                lbPass.Text = DatosUsuario.Contraseña;
            }
        }

        private void CargarCuentaCliente()
        {
            DatosUsuarioCLiente = S_cuentas.DatosCuenta(cedula_cl);
            
        }

        private void Cargar()
        {
            string CC_Emp = DatosCompartidos.ObtenerCedula();
            dgClientes.DataSource = S_vehiculos.ObtInforVehiculos(CC_Emp);

            // Ocultar la cuarta columna (índice 3)
            dgClientes.Columns[3].Visible = false;
            Persona persona = new Persona();
            persona = S_cuentas.ObtenerNombre(CC_Emp);
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
                    if(factura.Cod_Factura != null)
                    {
                        idFActura = int.Parse( factura.Cod_Factura);
                    }
                    else
                    {
                        idFActura= 0;
                    }

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

        private void CargarDatosCliente(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgClientes.Rows[e.RowIndex];
                string cl_cedula = fila.Cells[0].Value.ToString();


                
                P_cliente = clientes.Consultar(cl_cedula);

                if (P_cliente != null)
                {

                    tbPr_Nombre.Text = P_cliente.Pr_Nombre;
                    tbPr_Apellido.Text = P_cliente.Pr_Apellido;
                    tbTelefono.Text = P_cliente.Telefono;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos del cliente.");
                    tbPr_Nombre.Text = "None";
                    tbPr_Apellido.Text = "None";
                    tbTelefono.Text = "None";
                    

                }

            }
        }

        private void EliminarCuenta()
        {
            CuentaUser cuentaCliente = new CuentaUser();
            cuentaCliente = S_cuentas.DatosCuenta(cedula_cl);
            if (dgClientes.SelectedRows.Count > 0)
            {
                if(idFActura != 0)
                {
                    string msF = S_factura.EliminarFactura(idFActura);
                    string msV = S_vehiculos.Eliminar(placa);
                    string msC = clientes.Eliminar(cedula_cl);
                    string msAc = S_cuentas.EliminarCuenta(cuentaCliente.Usuario);
                    MessageBox.Show(msF + msV  + msC + msAc);
                }else
                {
                    string msV = S_vehiculos.Eliminar(placa);
                    string msC = clientes.Eliminar(cedula_cl);
                    string msAc = S_cuentas.EliminarCuenta(cuentaCliente.Usuario);
                    MessageBox.Show(msV + msC + msAc);
                }


            }
        }
        private void ActualizarCliente()
        {
            if (ComprobartbCliente() == false)
            {
                Cliente cliente = new Cliente();
                cliente.Pr_Apellido = tbPr_Apellido.Text;
                cliente.Pr_Nombre = tbPr_Nombre.Text;
                cliente.Telefono = tbTelefono.Text;
                cliente.Id_calle = idCalleSeleccionada;
                cliente.Cedula = P_cliente.Cedula;
                string msg = clientes.Actualizar(cliente);
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("Faltann Datos");
            }

        }
        private void facturaNula()
        {
            lbCoidgoFact.Text = "None";
            lbPrc_Servicios.Text = "None";
            lbPrc_Revision.Text = "None";
            lb_Total.Text = "None";
            lbFechaFact.Text = "None";
        }


        #endregion

        #region "METODOS DIRECCIONES"
        private void MostrarCiudades()
        {
            CB_CIUDADES.DataSource = S_direcciones.Listado_Ciudades();
            CB_CIUDADES.ValueMember = "id_ciudad";
            CB_CIUDADES.DisplayMember = "nom_ciudad";
        }

        private void MostrarBarrios(int idCiudad)
        {
            CB_BARRIOS.SelectedIndex = -1;
            CB_CALLES.SelectedIndex = -1;

            List<Barrio> barrios = S_direcciones.Listado_Barrios(idCiudad);

            CB_BARRIOS.DataSource = barrios;
            CB_BARRIOS.ValueMember = "id_barrio";
            CB_BARRIOS.DisplayMember = "nom_barrio";



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

            List<Calle> calles = S_direcciones.Listado_Calles(IdBarrio);


            CB_CALLES.DataSource = calles;
            CB_CALLES.ValueMember = "id_calle";
            CB_CALLES.DisplayMember = "nom_calle";
        }

        #endregion

        #region "Eventos"
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DesactivarPanelCliente();
            Cargar();
            CargarCuenta();
            dgClientes.ClearSelection();
            facturaNula();
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
            DesactivarPanelCliente();
            Cargar();
            CargarCuenta();
            CargarCbCilindraje();
            dgClientes.ClearSelection();
        }

        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DesactivarPanelCliente();
            MostrarVeh(e);
            CargarDatosFactura(e);
        }

        private void btnEditarVeh_Click(object sender, EventArgs e)
        {
            ActualizarVeh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgClientes.SelectedRows.Count > 0)
            {
                EliminarCuenta();
            }
            else
            {
                MessageBox.Show("Debe seleccionar antes");
            }
            
        }

        private void dgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ActivarPanelCliente();
            CargarDatosCliente(e);
            MostrarCiudades();
        }

        private void CB_CIUDADES_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerId_Ciudad();
            MostrarBarrios(idCiudadSeleccionada);
        }

        private void CB_BARRIOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerId_Barrio();
            MostrarCalles(idBarrioSeleccionado);
            ObtenerId_Calle();
        }

        private void CB_CALLES_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerId_Calle();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            ActualizarCliente();
        }

        #endregion

        private void cbCilindraje_SelectedIndexChanged(object sender, EventArgs e)
        {
            cilindrajeSeleccionado = cbCilindraje.SelectedItem.ToString();
        }
    }
}


