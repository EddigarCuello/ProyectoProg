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

        CRUDEmpleado Servicios = new CRUDEmpleado();
        FrmPrincipal frmPrincipal = new FrmPrincipal();
        void Cargar()
        {
            dgEmpleados.DataSource = Servicios.MostrarTodo();
        }
        void Salir()
        {
            this.Close();
            frmPrincipal.Show();
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



    }
}
