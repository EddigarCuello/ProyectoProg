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
    public partial class FrmRegistrar : Form
    {
        public FrmRegistrar()
        {
            InitializeComponent();
        }
        
        #region "VARIABLES"
        ServiciosAdministradores admin = new ServiciosAdministradores();
        ServiciosEmpleados empleados = new ServiciosEmpleados();
        FrmPrincipal FrmPrincipal = new FrmPrincipal();
        ServiciosCuentas S_cuenta = new ServiciosCuentas();
        ServicioDirecciones S_direcciones = new ServicioDirecciones();
        int idCiudadSeleccionada;
        int idBarrioSeleccionado;
        int idCalleSeleccionada;
        string CodigoSecreto = "Admin2023";
        Persona Item = new Persona();
        CuentaUser Cuenta = new CuentaUser();
        string msg1;
        string msg2;

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

        #region "METODOS PARA EL FORM"
        private bool Comprobar()
        {
            if (string.IsNullOrEmpty(txtPrNombre.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtCedula.Text) ||
                string.IsNullOrEmpty(CB_CALLES.Text) || string.IsNullOrEmpty(tbUsuario.Text) || string.IsNullOrEmpty(tbContraseña.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        private void ObtenerCuenta()
        {
                Cuenta.Contraseña = tbContraseña.Text;
                Cuenta.Usuario = tbUsuario.Text;

        }

        void Salir()
        {
            FrmPrincipal.Show();
            this.Close();
        }
        #endregion

        #region "MANEJO DE INFORMACION"
        public void Guardar()
        {

            Item.Pr_Nombre = txtPrNombre.Text;
            Item.Pr_Apellido = txtPrApellido.Text;
            Item.Cedula = txtCedula.Text;
            Item.Telefono = txtTelefono.Text;
            Item.Id_calle = idCalleSeleccionada;
            ObtenerCuenta();
            Item.Usuario = tbUsuario.Text;

            

            if (txtCodigoSecreto.Text == CodigoSecreto)
            {
                msg2 = S_cuenta.InsertarCuenta(Cuenta);
                msg1 = admin.InsertarAdministradores(Item);
                if(msg2 == "OK")
                {
                    MessageBox.Show("Se regisstro Correctamente");
                }
                else
                {
                    MessageBox.Show(msg2);
                }
            }
            else
            {
                msg2 = S_cuenta.InsertarCuenta(Cuenta);
                msg1 = empleados.InsertarEmpleado(Item);
                if (msg2 == "OK")
                {
                    MessageBox.Show("Se registro correctamente");
                }
                else
                {
                    MessageBox.Show(msg2);
                }

            }
        }

        #endregion

        #region "EVENTOS"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
        private void FrmRegistrar_Load(object sender, EventArgs e)
        {

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

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Comprobar() == false)
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

        #endregion


    }
}
