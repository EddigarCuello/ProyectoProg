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
        CRUDCliente Servicios = new CRUDCliente();
        public FrmLoginEmpleado()
        {
            InitializeComponent();
            dgClientes.AllowUserToAddRows = false;
            dgClientes.RowHeadersVisible = false;
        }
        void Cargar()
        {
            dgClientes.Rows.Clear();
            foreach (var item in Servicios.MostrarTodo())
            {
                dgClientes.Rows.Add(item.Cedula,
                                item.Nombre,
                                item.PlacaVihiculo,
                                item.IngresoVehiculo
                                );
            }
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpleado FrmAgregarEmpleado = new FrmAgregarEmpleado();
            FrmAgregarEmpleado.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
        void Salir()
        {
            this.Close();
        }



        private void FrmLoginEmpleado_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
