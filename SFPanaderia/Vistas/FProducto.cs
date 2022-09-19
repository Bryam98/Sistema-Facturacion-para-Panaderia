using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using SFPanaderia.PanaderiaBD;
using SFPanaderia.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        //variable para verificar si estamos en ediccion de producto o guardando nuevo
        private bool IsEditar = false;

        Producto producto;
        int valorCategoria, valorPresentacion, valorEstado;

        public FProducto()
        {
            InitializeComponent();
            mensajesDeAyuda();
        }


        private void mensajesDeAyuda()
        {
            this.ttMensaje.SetToolTip(this.ctId, "Codigo del producto");
            this.ttMensaje.SetToolTip(this.ctNombre, "Ingrese el nombre del producto");
            this.ttMensaje.SetToolTip(this.ctPrecio, "Ingrese el precio del producto");
            this.ttMensaje.SetToolTip(this.ctCantidad, "Ingrese la cantidad del producto");
            this.ttMensaje.SetToolTip(this.searchCategoria, "seleccione la categoria del producto");
            this.ttMensaje.SetToolTip(this.searchPresentacion, "seleccione la presentacion del producto");
            this.ttMensaje.SetToolTip(this.searchEstado, "seleccione el estado del producto");
        


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

            MessageBox.Show(mensaje, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void mensajeError(string mensaje)
        {

            MessageBox.Show(mensaje, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //FUNCION LIMPIAR CAJA DE TEXTO
        private void LimpiarCajas()
        {
            ctId.Clear();
            ctNombre.Clear();
            ctPrecio.Clear();
            ctCantidad.Clear();
            searchCategoria.EditValue = null;
            searchPresentacion.EditValue = null;
            searchEstado.EditValue = 1;


        }
        //FUNCION HABILITAR Y DESEBILITAR CONTROLER
        public void Habilitar(bool v)
        {

            ctNombre.Enabled = !v;
            ctNombre.Enabled = !v;
            ctPrecio.Enabled = !v;
            ctCantidad.Enabled = !v;
            searchCategoria.Enabled = !v;
            searchPresentacion.Enabled = !v;
           

            btnNuevo.Enabled = v;
            btnGuardar.Enabled = !v;
            btnCancelar.Enabled = !v;
            btnEditar.Enabled = v;
            btnEliminar.Enabled = v;
            btnSalir.Enabled = v;
        }

        private void FProducto_Load(object sender, EventArgs e)
        {
            Habilitar(true);
            gridViewProductos.ActiveFilterString = "[IdEstado.Nombre] = 'Activo'";


        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            ctNombre.Focus();

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (CamposVacios())
            {
                mensajeError("Todo Lo campos deben estar completos");
                ctNombre.Focus();
                return;
            }

            //verificar si el productos existe


            if ((MessageBox.Show("Esta Seguro que desea guardar el registro", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) == DialogResult.No)
            {
                if (IsEditar)
                {

                    IsEditar = false;
                }

                LimpiarCajas();
                return;
            }

            if (!IsEditar)
            {

                producto = new Producto(sessionProductos);

                producto.Nombre = ctNombre.Text;
                producto.PrecioUnidad = Convert.ToDouble(ctPrecio.Text);
                producto.Existencias = Convert.ToInt32(ctCantidad.Text);
                producto.FechaRegistro = DateTime.Now.Date;
                producto.IdCategoria = (Categoria)searchEditCategoria.GetFocusedRow();
                producto.IdPresentacion = (Presentacion)searchEditPresentacion.GetFocusedRow();

                //asignamos id por defecto
                foreach (Estado estado in xpEstado)
                {
                    if (estado.IdEstado == 1)
                        producto.IdEstado = estado;

                }

            }
            else
            {
                producto = (Producto)gridViewProductos.GetFocusedRow();

                if (searchCategoria.EditValue == null || Convert.ToInt32(searchCategoria.EditValue) != valorCategoria)
                {
                    producto.IdCategoria = (Categoria)searchEditCategoria.GetFocusedRow();
                }
                else
                {
                    producto.IdCategoria.IdCategoria = valorCategoria;
                }

                if (searchPresentacion.EditValue == null || Convert.ToInt32(searchPresentacion.EditValue) != valorPresentacion)
                {
                    producto.IdPresentacion = (Presentacion)searchEditPresentacion.GetFocusedRow();
                }
                else
                {
                    producto.IdPresentacion.IdPresentacion = valorPresentacion;
                }

                if (searchEstado.EditValue == null || Convert.ToInt32(searchEstado.EditValue) != valorEstado)
                {
                    producto.IdEstado = (Estado)searchEditEstado.GetFocusedRow();
                }
                else
                {
                    producto.IdEstado.IdEstado = valorEstado;
                }



                producto.Nombre = ctNombre.Text;
                producto.PrecioUnidad = Convert.ToDouble(ctPrecio.Text);
                producto.Existencias = Convert.ToInt32(ctCantidad.Text);
                //aplico filtro activo por si se activo un cliente inactivo
                rrActivo.Checked = true;
            }

            try
            {

                producto.Save();
                sessionProductos.CommitChanges();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            MensajeCorrecto("Registro Guardado Correctamente");
            LimpiarCajas();
            xpProductos.Reload();
            IsEditar = false;
            Habilitar(true);

            //Nos cambia a la seccion de Listado de Categorias
            this.tabControl1.SelectedIndex = 0;
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

            searchCategoria.EditValue = producto.IdCategoria.IdCategoria;
            valorCategoria = producto.IdCategoria.IdCategoria;

            searchPresentacion.EditValue = producto.IdPresentacion.IdPresentacion;
            valorPresentacion = producto.IdPresentacion.IdPresentacion;

            searchEstado.EditValue = producto.IdEstado.IdEstado;
            valorEstado = producto.IdEstado.IdEstado;


            IsEditar = true;
            Habilitar(false);
            searchEstado.Enabled = true;
            this.tabControl1.SelectedIndex = 1;
        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (xpProductos.Count == 0)
            {
                mensajeError("Error a un no existe Productos registrados...!!");
                return;
            }

            Producto producto = (Producto)gridViewProductos.GetFocusedRow();

            if (producto == null)
            {

                mensajeError("Debe seleccionar un registro a eliminar");
                return;
            }

            var result = MessageBox.Show("Seguro que desea eliminar el registro", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.No)
            {

                return;
            }
            producto.Delete();
            sessionProductos.CommitChanges();

            MensajeCorrecto("El registro fue eliminado correctamente");
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //si estamos edicion y cancelamos mandamo a la seccion 1
            if (IsEditar)
            {
                Habilitar(true);
                LimpiarCajas();
                tabControl1.SelectedIndex = 0;

            } 
            else
            {
                Habilitar(true);
                LimpiarCajas();
                return;

            }
         
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rrActivo_CheckedChanged(object sender, EventArgs e)
        {
            gridViewProductos.ActiveFilterString = "[IdEstado.Nombre] = 'Activo'";
            xpProductos.Reload();
        }


        private void rrInactivos_CheckedChanged(object sender, EventArgs e)
        {
            gridViewProductos.ActiveFilterString = "[IdEstado.Nombre] = 'Inactivo'";
            xpProductos.Reload();
        }

        private void ctNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }


        private void ctPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void ctCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

    }
}
