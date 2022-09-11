using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using SFPanaderia.PanaderiaBD;

namespace SFPanaderia.Vistas
{
    public partial class FrmPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        Usuario usuario;

        public FrmPrincipal(PanaderiaBD.Usuario user)
        {
            InitializeComponent();

            this.usuario = user;
           
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            string nombreCompleto = usuario.IdEmpleado.Nombres + " " + usuario.IdEmpleado.Apellidos;
            LabelDate.Caption = DateTime.Now.ToString();
            ctUserActivo.Caption = nombreCompleto;
        }
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem5_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }

        private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

      
    }
}