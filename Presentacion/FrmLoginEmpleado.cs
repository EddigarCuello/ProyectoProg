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
    public partial class FrmLoginEmpleado : Form
    {

        
        public FrmLoginEmpleado()
        {
            InitializeComponent();
            dgClientes.AllowUserToAddRows = false;
            dgClientes.RowHeadersVisible = false;
        }

        //FrmAgregarCliente frmAgregarCliente = new FrmAgregarCliente();
        FrmPrincipal frmPrincipal = new FrmPrincipal();
        //ServiciosClientee Servicios = new ServiciosClientee();


        //private void AgregarCliente()
        //{
        //    frmAgregarCliente.Show();
        //    this.Hide();
        //}
        private void Cargar()
        {
            //dgClientes.DataSource = Servicios.MostrarTodo();
        }
        private void Salir()
        {
            this.Close();
            frmPrincipal.Show();
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            //AgregarCliente(); 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
        private void FrmLoginEmpleado_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
