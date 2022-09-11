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

namespace SFPanaderia.Vistas
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

      

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            Cliente cli = (Cliente)searchViewClientes.GetFocusedRow();
            string nombreCompleto;

            ctCedula.Text = cli.Cedula;
            nombreCompleto = cli.Nombres + " " + cli.Apellidos;
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            searchViewClientes.ActiveFilterString = "[IdEstado.Nombre] = 'Inactivo'";
        }


    
    }
}
