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
    public partial class FrmAgregarEmpleado : Form
    {
        public string Cedula { get; set; }
        public FrmAgregarEmpleado()
        {
            InitializeComponent();

            dtpFecha_Salida.MinDate = DateTime.Today;
            dtpFecha_Salida.MaxDate = DateTime.Today.AddDays(14);
        }
        CRUDCliente Servicios = new CRUDCliente();
        CRUDEmpleado Servicio = new CRUDEmpleado();
        FrmLoginEmpleado Empleado = new FrmLoginEmpleado();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        void Salir()
        {
            this.Close();
        }

        public void Guardar()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtPrecio_Acordado.Text) || string.IsNullOrEmpty(txtPlaca_vehiculo.Text) || string.IsNullOrEmpty(dtpFecha_Ingreso.Text) || string.IsNullOrEmpty(dtpFecha_Salida.Text))
            {

                MessageBox.Show("Faltan Datos");
            }
            else
            {
                Cliente Item = new Cliente();

                Item.Nombre = txtNombre.Text;
                Item.Cedula = txtCedula.Text;
                Item.Telefono = txtTelefono.Text;
                Item.Direccion = txtDireccion.Text;
                Item.PlacaVihiculo = txtPlaca_vehiculo.Text;
                Item.PrecioAcordado = float.Parse(txtPrecio_Acordado.Text);
                Item.IngresoVehiculo = DateTime.Now;
                Item.SalidaVehiculo = dtpFecha_Salida.Value;
                Item.CedulaEmpleado = Cedula;

                var respuesta = Servicios.Agregar(Item);

                if (respuesta.Estado == true)
                {
                    MessageBox.Show("EL EMPLEADO " + respuesta.Item.Nombre.ToUpper() + " " + respuesta.Mensaje);
                    txtCedula.Clear();
                    txtDireccion.Clear();
                    txtNombre.Clear();
                    txtTelefono.Clear();
                    txtPlaca_vehiculo.Clear();
                    txtPrecio_Acordado.Clear();
                    dtpFecha_Ingreso.Value = DateTime.Now;
                    dtpFecha_Salida.Value = DateTime.Now;
                    this.Close();


                }
                else
                {
                    MessageBox.Show(respuesta.Mensaje);
                }



            }

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

    }
}
