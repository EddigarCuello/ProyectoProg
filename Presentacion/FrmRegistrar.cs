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
        List<string> mensajes;
        string msg1;
        string msg2;
        string CedulaAdmin;

        #endregion

        #region "METODOS"
        private void MostrarCiudades()
        {
            CB_CIUDADES.DataSource = admin.Listado_Ciudades();
            CB_CIUDADES.ValueMember = "id_ciudad";
            CB_CIUDADES.DisplayMember = "nom_ciudad";
        }

        private void MostrarBarrios(int idCiudad)
        {
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
            idBarrioSeleccionado = int.Parse(selectedRow["id_barrio"].ToString());
        }

        private void ObtenerId_Calle()
        {
            DataRowView selectedRow = (DataRowView)CB_CALLES.SelectedItem;
            idCalleSeleccionada = int.Parse(selectedRow["id_calle"].ToString());

        }



        private void MostrarCalles(int IdBarrio)
        {
            DataTable calles = admin.Listado_Calles(IdBarrio);

            CB_CALLES.DataSource = calles;
            CB_CALLES.ValueMember = "id_calle";
            CB_CALLES.DisplayMember = "nom_calle";
        }

        private bool Comprobar()
        {
            if (string.IsNullOrEmpty(txtPrNombre.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(CB_CALLES.Text) /*|| string.IsNullOrEmpty(.Text)*/)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Guardar()
        {
            Item.Pr_Nombre = txtPrNombre.Text;
            Item.Pr_Apellido = txtPrApellido.Text;
            Item.Cedula = txtCedula.Text;
            Item.Telefono = txtTelefono.Text;
            Item.Id_calle = idCalleSeleccionada;     


            if (txtCodigoSecreto.Text != CodigoSecreto)
            {
                ObtenerCuenta();
                CedulaAdmin = Item.Cedula;
                msg1 = empleados.InsertarAdministradores(Item);
                msg2 = empleados.InsertarCuenta(Cuenta, CedulaAdmin);

                Console.WriteLine(msg2 + "\n");


                if (msg2 != "OK")
                {
                    MessageBox.Show("id_calle = :" + idCalleSeleccionada.ToString() + msg2);
                }
                else
                {

                    MessageBox.Show("id_calle = :" + idCalleSeleccionada.ToString() + msg1);
                }


            }
            else
            {
                ObtenerCuenta();
                CedulaAdmin = Item.Cedula;
                msg1 = admin.InsertarAdministradores(Item);
                msg2 = admin.InsertarCuenta(Cuenta, CedulaAdmin);
                

                Console.WriteLine(msg2 + "\n");
                
                

                if (msg2 != "OK")
                {
                    MessageBox.Show("id_calle = :" + idCalleSeleccionada.ToString() + msg2);
                }
                else
                {
                    
                    MessageBox.Show("id_calle = :" + idCalleSeleccionada.ToString() + msg1);
                }
                
                //MessageBox.Show(msg2);
                //Console.WriteLine(msg1);

            }
        }



        #endregion
        void Salir()
        {
            FrmPrincipal.Show();
            this.Close();
        }
        private void Continuar()
        {
            FrmCrearCuenta frmCrearCuenta = new FrmCrearCuenta();
            frmCrearCuenta.ShowDialog();
            this.Hide();
        }



        

        private bool ComprobarTextBox()
        {
            if (txtContraseña == tbRepeticionContraseña)
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
                Cuenta.Contraseña = txtContraseña.Text;
                Cuenta.Usuario = txtUsuario.Text;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void btnContinuarRegistro_Click(object sender, EventArgs e)
        {

            
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Comprobar() == false)
            {
                
                Guardar();
                //Continuar();
            }
            else
            {
                MessageBox.Show("Faltan Datos ");
            }
        }
    }
}
