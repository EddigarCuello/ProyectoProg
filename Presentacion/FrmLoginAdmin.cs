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
        ServiciosClientes S_clientes = new ServiciosClientes();
        FrmSelectNewEmpleado newEmpleado = new FrmSelectNewEmpleado();
        ServiciosVehiculos S_vehiculos = new ServiciosVehiculos();
        ServiciosAdministradores Administradores = new ServiciosAdministradores();
        ServicioDirecciones S_direcciones = new ServicioDirecciones();
        ServiciosCuentas S_cuentas = new ServiciosCuentas();
        ServiciosFactura S_factura = new ServiciosFactura();
        CuentaUser DatosUsuarioEmp = new CuentaUser();
        Persona P_empleado = new Persona();
        List<Persona> L_empleados = new List<Persona>();
        int idCiudadSeleccionada;
        int idBarrioSeleccionado;
        int idCalleSeleccionada;
        string Nueva_cedula_empleado;

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

        private void CargarDatosEmpleado(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgEmpleados.Rows[e.RowIndex];
                string emp_cedula = fila.Cells[0].Value.ToString();
                CargarCuentaEmp(emp_cedula);
                DatosCompartidos.ActualizarCedulaEmp(emp_cedula);



                P_empleado = empleados.ObtDatosEmp(emp_cedula);

                if (P_empleado != null)
                {

                    tbPr_nombre.Text = P_empleado.Pr_Nombre;
                    tbPr_apellido.Text = P_empleado.Pr_Apellido;
                    tbTelefono.Text = P_empleado.Telefono;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos del cliente.");
                    tbPr_nombre.Text = "None";
                    tbPr_apellido.Text = "None";
                    tbTelefono.Text = "None";


                }

            }
        }


        private void ActualizarEmpleado()
        {
            Persona Empleado = new Persona();
            Empleado.Pr_Apellido = tbPr_apellido.Text;
            Empleado.Pr_Nombre = tbPr_nombre.Text;
            Empleado.Telefono = tbTelefono.Text;
            Empleado.Id_calle = idCalleSeleccionada;
            Empleado.Cedula = P_empleado.Cedula;
            string msg = empleados.ActualizarEmpleado(Empleado);
            MessageBox.Show(P_empleado.Cedula);
            MessageBox.Show(msg);
        }

        private void MostrarVentanaNuevoEmp() 
        {
            newEmpleado.ShowDialog();
        }

        private void CargarCuentaEmp(string cedula_emp)
        {
            DatosUsuarioEmp = S_cuentas.DatosCuenta(cedula_emp);

        }
        private void EliminarEmpleado()
        {
            string msg = empleados.EliminarEmpleado(DatosCompartidos.ObtenerCedulaEmp(),
                DatosCompartidos.ObtenerCedulaNuevoEmp());
            string msAc = S_cuentas.EliminarCuenta(DatosUsuarioEmp.Usuario);
            MessageBox.Show(msg + msAc);
        }

        #endregion

        #region "METODOS PARA EL FORM"
        void Salir()
        {
            this.Close();
            frmPrincipal.Show();
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

        #region "EVENTOS"
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Cargar();
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

        private void dgEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatosEmpleado(e);
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

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarEmpleado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            MostrarVentanaNuevoEmp();
            EliminarEmpleado();
        }
    }
}
