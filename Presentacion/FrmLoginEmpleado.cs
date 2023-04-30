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
    }
}
