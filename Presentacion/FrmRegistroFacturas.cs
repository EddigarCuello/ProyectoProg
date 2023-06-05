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
    public partial class FrmRegistroFacturas : Form
    {
        public FrmRegistroFacturas()
        {
            InitializeComponent();
        }

        ServiciosFactura S_factura = new ServiciosFactura();
        
        private void CargarRegistro()
        {
            dgregistro.DataSource = S_factura.ObtenerRegistros();
            dgregistro.Columns["prc_total"].Visible = false;
        }
        private void Salir()
        {
            this.Close();
        }

        private void FrmRegistroFacturas_Load(object sender, EventArgs e)
        {
            CargarRegistro();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
    }
}
