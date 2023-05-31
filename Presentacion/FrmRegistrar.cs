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
        int idCiudadSeleccionada;
        int idBarrioSeleccionado;
        int idCalleSeleccionada;
        string CodigoSecreto = "Admin2023";
        Persona Item = new Persona();
        Cuenta Cuenta = new Cuenta();
        string msg1;
        string msg2;

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

            DataTable barrios = admin.Listado_Barrios(idCiudad);

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

            DataRowView selectedRow = (DataRowView)CB_CIUDADES.SelectedItem;
            idCiudadSeleccionada = int.Parse(selectedRow["id_ciudad"].ToString());
        }

        private void ObtenerId_Barrio()
        {
            DataRowView selectedRow = (DataRowView)CB_BARRIOS.SelectedItem;
            if (selectedRow != null)
            { 
                idBarrioSeleccionado = int.Parse(selectedRow["id_barrio"].ToString());
            }
            
        }

        private void ObtenerId_Calle()
        {
            DataRowView selectedRow = (DataRowView)CB_CALLES.SelectedItem;
            idCalleSeleccionada = int.Parse(selectedRow["id_calle"].ToString());

        }



        private void MostrarCalles(int IdBarrio)
        {

            CB_CALLES.SelectedIndex = -1;

            DataTable calles = admin.Listado_Calles(IdBarrio);
            

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

        private bool ComprobarTextBox()
        {
            if (tbContraseña == tbRepeticionContraseña)
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
            if (ComprobarTextBox() == true)
            {
                MessageBox.Show("Las cotraseñas deben coicidir");
            }
            else
            {
                Cuenta.Contraseña = tbContraseña.Text;
                Cuenta.Usuario = tbUsuario.Text;
            }
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
            Item.Usuario = Cuenta.Usuario;

            

            if (txtCodigoSecreto.Text == CodigoSecreto)
            {
                msg2 = admin.InsertarCuenta(Cuenta);
                msg1 = admin.InsertarAdministradores(Item);
                if(msg2 == "OK")
                {
                    MessageBox.Show(msg1);
                }
                else
                {
                    MessageBox.Show(msg2);
                }
            }
            else
            {
                msg2 = empleados.InsertarCuenta(Cuenta);
                msg1 = empleados.InsertarAdministradores(Item);
                if (msg2 == "OK")
                {
                    MessageBox.Show(msg1);
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


        #endregion

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Comprobar() == false )
            {
                if (ComprobarTextBox() != false)
                {
                    Guardar();
                }else
                {
                    MessageBox.Show("Contraseñas no coinciden");
                }
                
                //Continuar();
            }
            else
            {
                MessageBox.Show("Faltan Datos");
            }
        }
    }
}
