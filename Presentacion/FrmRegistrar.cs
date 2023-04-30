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
        CRUDEmpleado Servicios = new CRUDEmpleado();
        CRUDAdmin ServiciosA = new CRUDAdmin();
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
        void Salir()
        {
            this.Close();
        }

        private void FrmRegistrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            var respuesta = MessageBox.Show("Desea Salir", "Agenda Contactos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.Owner.Show();
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }



        public void Guardar()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(cbTipoMiembro.Text))
            {

                MessageBox.Show("Faltan Datos");
            }
            else
            {
                if (cbTipoMiembro.SelectedItem.ToString() == "Empleado")
                {
                    Empleado Item = new Empleado();

                    Item.Nombre = txtNombre.Text;
                    Item.Cedula = txtCedula.Text;
                    Item.Telefono = txtTelefono.Text;
                    Item.Direccion = txtDireccion.Text;
                    Item.Salario = 0;
                    Item.NumeroDeVehiculos = 0;

                    var respuesta = Servicios.Agregar(Item);

                    if (respuesta.Estado == true)
                    {
                        MessageBox.Show("EL EMPLEADO " + respuesta.Item.Nombre.ToUpper() + " " + respuesta.Mensaje);
                        txtCedula.Clear();
                        cbTipoMiembro.ResetText();
                        txtDireccion.Clear();
                        txtNombre.Clear();
                        txtTelefono.Clear();
                        this.Close();


                    }
                    else
                    {
                        MessageBox.Show(respuesta.Mensaje);
                    }

                }
                else
                {
                    Administrador Item = new Administrador();

                    Item.Nombre = txtNombre.Text;
                    Item.Cedula = txtCedula.Text;
                    Item.Telefono = txtTelefono.Text;
                    Item.Direccion = txtDireccion.Text;
                    Item.GananciasEmpresa = 0;

                    var respuesta = ServiciosA.Agregar(Item);

                    if (respuesta.Estado == true)
                    {
                        MessageBox.Show("EL EMPLEADO " + respuesta.Item.Nombre.ToUpper() + " " + respuesta.Mensaje);
                        txtCedula.Clear();
                        cbTipoMiembro.ResetText();
                        txtDireccion.Clear();
                        txtNombre.Clear();
                        txtTelefono.Clear();
                        this.Close();


                    }
                    else
                    {
                        MessageBox.Show(respuesta.Mensaje);
                    }

                }


            }

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Guardar();
        }


    }
}
