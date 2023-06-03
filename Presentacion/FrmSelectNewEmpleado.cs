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
    public partial class FrmSelectNewEmpleado : Form
    {
        public FrmSelectNewEmpleado()
        {
            InitializeComponent();
        }
        ServiciosEmpleados S_empleados = new ServiciosEmpleados();
        private void Cargar()
        {
            CB_NewEmpleado.SelectedIndex = -1;

            List<Persona> empleados = S_empleados.ObtenerTodosEmpleados();

            CB_NewEmpleado.DataSource = empleados;
            CB_NewEmpleado.ValueMember = "Cedula";
            CB_NewEmpleado.DisplayMember = "Pr_Nombre";
        }


        private void GuardarNewEmpleado()
        {
            if (CB_NewEmpleado.SelectedItem != null)
            {
                Persona nuevoEmpleado = (Persona)CB_NewEmpleado.SelectedItem;
                string nuevaCedula = nuevoEmpleado.Cedula;

                if (DatosCompartidos.ObtenerCedulaEmp() != nuevaCedula)
                {                     
                    DatosCompartidos.ActualizarCedulaNuevoEmp(nuevaCedula);
                    this.Hide();  // Ocultar la ventana en lugar de cerrarla
                }
                else
                {
                    MessageBox.Show("No puedes elegir el mismo empleado de nuevo");
                }
            }
            else
            {
                MessageBox.Show("No hay datos seleccionados");
            }
        }

        private void CB_NewEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            GuardarNewEmpleado();
        }

        private void FrmSelectNewEmpleado_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
