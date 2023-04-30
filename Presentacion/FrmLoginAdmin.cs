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
        CRUDEmpleado Servicios = new CRUDEmpleado();
        CRUDAdmin ServiciosA = new CRUDAdmin();
        public FrmLoginAdmin()
        {
            InitializeComponent();
            dgEmpleados.AllowUserToAddRows = false;
            dgEmpleados.RowHeadersVisible = false;
        }
        void Cargar()
        {
            dgEmpleados.Rows.Clear();
            foreach (var item in Servicios.MostrarTodo())
            {
                dgEmpleados.Rows.Add(item.Cedula,
                                item.Nombre,
                                item.NumeroDeVehiculos,
                                item.Salario);
            }
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void FrmLoginAdmin_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
        void Salir()
        {
            this.Close();
        }

        private void FrmLoginAdmin_FormClosing(object sender, FormClosingEventArgs e)
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
