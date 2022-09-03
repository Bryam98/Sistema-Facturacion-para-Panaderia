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

namespace SFPanaderia.Vistas
{
    public partial class FProducto : Form
    {
        public FProducto()
        {
            InitializeComponent();
        }




        //funcion verifica los campos vacios
        public bool CamposVacios()
        {
            return (ctNombre.Text.Trim().Length == 0 
                || ctPrecio.Text.Trim().Length == 0
                || ctCantidad.Text.Trim().Length == 0
                || searchCategoria.Text.Trim().Length == 0 || searchCategoria.Text.Equals("[Vacío]")
                || searchPresentacion.Text.Trim().Length == 0 || searchPresentacion.Text.Equals("[Vacío]")
                || searchEstado.Text.Trim().Length == 0 || searchEstado.Text.Equals("[Vacío]")

                );
        }


        private void MensajeCorrecto(string mensaje)
        {

            MessageBox.Show(mensaje, "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void mensajeError(string mensaje)
        {

            MessageBox.Show(mensaje, "Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //FUNCION LIMPIAR CAJA DE TEXTO
        private void LimpiarCajas()
        {
            ctId.Clear();
            ctNombre.Clear();
            ctPrecio.Clear();
            ctCantidad.Clear();
            searchCategoria.Reset();
            searchPresentacion.Reset();
            searchEstado.Reset();
          

        }
        //FUNCION HABILITAR Y DESEBILITAR CONTROLER
        public void Habilitar(bool v)
        {

            ctNombre.Enabled = !v;
            ctNombre.Enabled = !v;
            ctPrecio.Enabled = !v;
            ctCantidad.Enabled = !v;
            dateFRegistro.Enabled = !v;
            searchCategoria.Enabled = !v;
            searchPresentacion.Enabled = !v;
            searchEstado.Enabled = !v;

            btnNuevo.Enabled = v;
            btnGuardar.Enabled = !v;
            btnCancelar.Enabled = !v;
            btnEditar.Enabled = v;
            btnEliminar.Enabled = v;

        }

        private void FProducto_Load(object sender, EventArgs e)
        {
            Habilitar(true);
            dateFRegistro.DateTime = DateTime.Now.Date;

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            ctNombre.Focus();

        }

        //variable para verificar si estamos en ediccion de producto o guardando nuevo
        private bool IsEditar = false;

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (CamposVacios())
            {
                mensajeError("Todo Lo campos deben estar completos");
                ctNombre.Focus();
                return;
            }

            Producto producto;


            if (!IsEditar)
            {

                producto = new Producto(sessionProductos);
            }
            else
            {
                producto = (Producto)gridViewProductos.GetFocusedRow();
            }


            producto.Nombre = ctNombre.Text;
            producto.PrecioUnidad = Convert.ToDouble(ctPrecio.Text);
            producto.Existencias = Convert.ToInt32(ctCantidad.Text);
            producto.FechaRegistro = DateTime.Now.Date;
            producto.IdCategoria = (Categoria)searchEditCategoria.GetFocusedRow();
            producto.IdPresentacion = (Presentacion)searchEditPresentacion.GetFocusedRow();
            producto.IdEstado = (Estado)searchEditEstado.GetFocusedRow();

            producto.Save();

            try
            {
                sessionProductos.CommitChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            MensajeCorrecto("Registro Guardado Correctamente");
            LimpiarCajas();
            xpCategorias.Reload();
            IsEditar = false;
            Habilitar(true);

            //Nos cambia a la seccion de Listado de Categorias
            this.tabControl1.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            LimpiarCajas();
            return;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Producto producto = (Producto)gridViewProductos.GetFocusedRow();

            if (producto == null)
            {
                mensajeError("Debe selecionar un registro a editar");
                return;
            }

            ctId.Text = producto.IdProducto.ToString();
            ctNombre.Text = producto.Nombre.ToString();
            ctPrecio.Text = producto.PrecioUnidad.ToString();
            ctCantidad.Text = producto.Existencias.ToString();
            
            IsEditar = true;
            Habilitar(false);

            this.tabControl1.SelectedIndex = 1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
