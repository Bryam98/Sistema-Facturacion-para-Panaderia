using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SFPanaderia.PanaderiaBD;
using SFPanaderia.Servicios;

namespace SFPanaderia.Vistas.Modales
{
    public partial class FIngresoCliente : Form
    {
        //servicio para obtenerCliente
        private readonly IServicesCliente servicesCliente;

        public FIngresoCliente(IServicesCliente servicesCliente)
        {
            InitializeComponent();
            this.servicesCliente = servicesCliente;
        }

        private void FIngresoCliente_Load(object sender, EventArgs e)
        {
            gridViewClientes.ActiveFilterString = "[IdEstado.Nombre] = 'Activo'";
        }

        private void gridViewClientes_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)gridViewClientes.GetFocusedRow();
            servicesCliente.ObtenerCliente(cliente);
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
