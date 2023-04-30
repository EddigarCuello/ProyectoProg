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
    }
}
