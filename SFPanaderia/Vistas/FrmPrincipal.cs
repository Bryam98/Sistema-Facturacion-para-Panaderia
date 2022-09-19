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

        public FrmPrincipal(Usuario user)
        {
            InitializeComponent();

            this.usuario = user;
            LabelDate.Caption = DateTime.Now.ToString();

        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            string nombreCompleto = usuario.IdEmpleado.Nombres + " " + usuario.IdEmpleado.Apellidos;
            
            ctUserActivo.Caption = nombreCompleto;

            GestionAccesos();


        }

        private void GestionAccesos()
        {
            if (usuario.IdEmpleado.IdCargo.Nombre.ToUpper() == "CAJERO")
            {
                PageMantenimiento.Visible = false;
                PageAlmacen.Visible = false;
                PageAlmacen.Visible = false;


            }
            else if (usuario.IdEmpleado.IdCargo.Nombre.ToUpper() == "DIGITADOR")
            {
                GestionProductos.Visible = false;
                GestionPresentacion.Visible = false;
                GestionCategorias.Visible = false;
                PageVentas.Visible = false;
                
            }

        }

        private void barProducto_ItemClick(object sender, ItemClickEventArgs e)
        {
            FProducto fp = new FProducto();
            fp.MdiParent = this;
            fp.Show();
            BarProductos = false;

        }

        public bool BarIngreso { set { barIngreso.Enabled = value; } }
        public bool BarProductos { set { barProducto.Enabled = value; } }
        public bool BarCategorias{ set { barCategoria.Enabled = value; } }
        public bool BarPresentacion { set { barPresentacion.Enabled = value; } }
        public bool BarEmpleados { set { barEmpleados.Enabled = value; } }
        public bool BarClientes { set { barClientes.Enabled = value; } }
        public bool BarVentas { set { barVentas.Enabled = value; } }
        public bool BarCargos { set { barCargos.Enabled = value; } }
        public bool BarUsuarios { set { barUsuarios.Enabled = value; } }
        

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barCategoria_ItemClick(object sender, ItemClickEventArgs e)
        {
            FCategorias fc = new FCategorias();
            fc.MdiParent = this;
            fc.Show();
            BarCategorias = false;

        }

        private void barUsuarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            FUsuario fu = new FUsuario();
            fu.MdiParent = this;
            fu.Show();
            BarUsuarios = false;

        }

        private void barCargos_ItemClick(object sender, ItemClickEventArgs e)
        {
            FCargos fCargos = new FCargos();
            fCargos.MdiParent = this;
            fCargos.Show();
            BarCargos = false;

        }

        private void barIngresos_ItemClick(object sender, ItemClickEventArgs e)
        {
            FEntradas fEntradas = new FEntradas(usuario);
            fEntradas.MdiParent = this;
            fEntradas.Show();
            BarIngreso = false;
        }

        private void barPresentacion_ItemClick(object sender, ItemClickEventArgs e)
        {
            FPresentacion fPresentacion = new FPresentacion();
            fPresentacion.MdiParent = this;
            fPresentacion.Show();
            BarPresentacion = false;
        }

        private void barEmpleados_ItemClick(object sender, ItemClickEventArgs e)
        {
            FEmpleados fEmpleados = new FEmpleados();
            fEmpleados.MdiParent = this;
            fEmpleados.Show();
            BarEmpleados = false;
        }

        private void barVentas_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta();
            frmVenta.MdiParent = this;
            frmVenta.Show();
            BarVentas = false;

        }

        private void barClientes_ItemClick(object sender, ItemClickEventArgs e)
        {
            FClientes fClientes = new FClientes();
            fClientes.MdiParent = this;
            fClientes.Show();
            BarClientes = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabelDate.Caption = DateTime.Now.ToString();
        }
    }
}