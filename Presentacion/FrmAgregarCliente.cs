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

            dtpFecha_Salida.MinDate = DateTime.Today;
            dtpFecha_Salida.MaxDate = DateTime.Today.AddDays(14);
        }

        //ServiciosClientee Servicios = new ServiciosClientee();
        FrmLoginEmpleado frmLoginEmpleado = new FrmLoginEmpleado();


        private void Salir()
        {
            this.Close();
            frmLoginEmpleado.Show();

        }

        //private void Guardar()
        //{
        //    if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtPrecio_Acordado.Text) || string.IsNullOrEmpty(txtPlaca_vehiculo.Text) || string.IsNullOrEmpty(dtpFecha_Ingreso.Text) || string.IsNullOrEmpty(dtpFecha_Salida.Text))
        //    {

        //        MessageBox.Show("Faltan Datos");
        //    }
        //    else
        //    {
        //        Cliente Item = new Cliente();

        //        Item.Nombre = txtNombre.Text;
        //        Item.Cedula = txtCedula.Text;
        //        Item.Telefono = txtTelefono.Text;
        //        Item.Direccion = txtDireccion.Text;
        //        Item.PlacaVihiculo = txtPlaca_vehiculo.Text;
        //        Item.PrecioAcordado = float.Parse(txtPrecio_Acordado.Text);
        //        Item.IngresoVehiculo = DateTime.Now;
        //        Item.SalidaVehiculo = dtpFecha_Salida.Value;
        //        Item.CedulaEmpleado = DatosCompartidos.ObtenerCedulaEmpleado();
                

        //        var respuesta = Servicios.Agregar(Item);

        //        if (respuesta.Estado == true)
        //        {
        //            MessageBox.Show("El cliente " + respuesta.Item.Nombre.ToUpper() + " " + respuesta.Mensaje);
        //            txtCedula.Clear();
        //            txtDireccion.Clear();
        //            txtNombre.Clear();
        //            txtTelefono.Clear();
        //            txtPlaca_vehiculo.Clear();
        //            txtPrecio_Acordado.Clear();
        //            dtpFecha_Ingreso.Value = DateTime.Now;
        //            dtpFecha_Salida.Value = DateTime.Now;
        //            Salir();


        //        }
        //        else
        //        {
        //            MessageBox.Show(respuesta.Mensaje);
        //        }



        //    }

        //}

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
        
            //Guardar();
        }

    }
}
