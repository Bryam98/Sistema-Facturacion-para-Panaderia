using SFPanaderia.PanaderiaBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using SFPanaderia.Servicios;
using SFPanaderia.Vistas.Modales;

namespace SFPanaderia.Vistas
{
    public partial class FrmVenta : Form, IServicesCliente
    {
        public FrmVenta()
        {
            InitializeComponent();

        }

      

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //Cliente cli = (Cliente)searchViewClientes.GetFocusedRow();
            //string nombreCompleto;

            //ctCedula.Text = cli.Cedula;
            //nombreCompleto = cli.Nombres + " " + cli.Apellidos;
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            //searchViewClientes.ActiveFilterString = "[IdEstado.Nombre] = 'Inactivo'";
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FIngresoCliente fIngreso = new FIngresoCliente(this);
            fIngreso.ShowDialog();
        }

        public void ObtenerCliente(Cliente DataCliente)
        {
            string nombreCompleto;

            ctId.Text = DataCliente.IdCliente.ToString();
            ctCedula.Text = DataCliente.Cedula;
     
            nombreCompleto = DataCliente.Nombres + " " + DataCliente.Apellidos;
            ctNombre.Text = nombreCompleto;


        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            //FModalProductos fModalProductos = new FModalProductos(this);
            //fModalProductos.ShowDialog();

        }

        //public void ObtenerProducto(Producto Data)
        //{
        //    ctIdProducto.Text = Data.IdProducto.ToString();
        //    ctProducto.Text = Data.Nombre;
        //    ctStock.Text = Data.Existencias.ToString();
        //    ctPrecio.Text = Data.PrecioUnidad.ToString();

           
        //}
    }
}
