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


namespace SFPanaderia.Vistas
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            //Si no hay productos desactivamos el boton de modificar y eliminar
            if(xpProductos.Count == 0)
            {
                btnElimnar.Enabled = false;
                btnEditar.Enabled = false;
            }


           
                
        }

        //funcion verifica los campos vacios
        public bool CamposVacios()
        {
            return (CtProducto.Text.Trim().Length == 0 || CtPrecio.Text.Trim().Length == 0
                || CtCantidad.Text.Trim().Length == 0 
                || searchCategoria.Text.Trim().Length == 0 || searchCategoria.Text.Equals("[Vacío]")
                || searchPresentacion.Text.Trim().Length == 0 || searchPresentacion.Text.Equals("[Vacío]")
                || searchEstado.Text.Trim().Length == 0 || searchEstado.Text.Equals("[Vacío]")

                );
        }

        //funcion desactiva los botones
        public void Habilitar(bool v)
        {
            btnNuevo.Enabled = v;
            btnGuardar.Enabled = !v;
            btnCancelar.Enabled = !v;
            btnEditar.Enabled = v;
            btnElimnar.Enabled = v;
        }
        private void LimpiarCajas()
        {
            CtProducto.Reset();
            CtPrecio.Reset();
            CtCantidad.Reset();
            CtCantidad.Reset();


        }
        //variable para ver si el producto se esta agregando o se esta editando
        bool editar = false;

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (CamposVacios())
            {
                MessageBox.Show("No debe dejar campos vacios.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            Producto producto;

            if (editar) {

               producto = (Producto)gridViewProductos.GetFocusedRow();

            }
            else
            {
                producto = new Producto(sessionProductos);
            }

            producto.IdCategoria = (Categoria) searchLookUpCategoria.GetFocusedRow();
            producto.Nombre = CtProducto.Text;
            producto.PrecioUnidad = Convert.ToInt32(CtPrecio.Text);
            producto.Existencias = Convert.ToInt32(CtCantidad.Text);
            producto.FechaRegistro = DateTime.Now;
            producto.IdPresentacion = (Presentacion)searchLookUpPresentacion.GetFocusedRow();
            producto.IdEstado = (Estado)searchLookUpEstado.GetFocusedRow();


            MessageBox.Show("Guardado", "Producto Guardado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            producto.Save();


            sessionProductos.CommitChanges();

            MessageBox.Show("Registro de cliente guardado.", "Guardar",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            xpProductos.Reload();


            LimpiarCajas();
            editar = false;
            Habilitar(true);

        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
        }
        

        private void btnElimnar_Click(object sender, EventArgs e)
        {
            var productoSeleccionado = (Producto)gridViewProductos.GetFocusedRow();

            if (productoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un registro en el grid!",
                    "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if ((MessageBox.Show("¿Seguro que desea borrar el registro?",
              "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) ==
              DialogResult.Yes)
            {
                sessionProductos.Delete(productoSeleccionado);
                sessionProductos.CommitChanges();
                xpProductos.Reload();
            }

         
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            CtProducto.Focus();
        }

        private void lbFecha_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //tomo lo selecionado
            Producto Producto = (Producto)gridViewProductos.GetFocusedRow();
            
            searchCategoria.Properties.DataSource = xpCategorias;
            CtProducto.Text = Producto.Nombre;
            CtPrecio.Text = Producto.PrecioUnidad.ToString();
            CtCantidad.Text = Producto.Existencias.ToString();
            searchPresentacion.Properties.DataSource = xpPresentaciones;
            searchEstado.Properties.DataSource = xpEstados;
            
            if (CamposVacios())
            {
                MessageBox.Show("Debe seleccionar un registro de cliente.",
                    "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
    
            editar = true;
            Habilitar(false);

        }
    }
}
