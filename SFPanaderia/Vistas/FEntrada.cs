using SFPanaderia.PanaderiaBD;
using SFPanaderia.Servicios;
using SFPanaderia.Validaciones;
using SFPanaderia.Vistas.Modales;
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
    public partial class FEntrada : Form
    {

        int idProducto;
        DetalleEntrada dEntrada;
        int acum = 0;
        Entrada entrada;

        public FEntrada()
        {
            InitializeComponent();
        }

        private void mensajesDeAyuda()
        {
            this.ttMensaje.SetToolTip(this.ctIdEntrada, "Codigo de la Entrada");
            this.ttMensaje.SetToolTip(this.searchProductos, "Eliga el producto a ingresar");
            this.ttMensaje.SetToolTip(this.fechaEntrada, "Ingrese la fecha entrada");
            this.ttMensaje.SetToolTip(this.btnAgregar, "Agrega productos a la entrada");
            this.ttMensaje.SetToolTip(this.btnEliminar, "Elimina productos de la entrada");
            


        }

        private void mensajeCorrecto(string mensaje)
        {

            MessageBox.Show(mensaje, "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void mensajeError(string mensaje)
        {

            MessageBox.Show(mensaje, "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //Verificar si estan vacias la cajas
        private bool CamposVacios()
        {
            return (
                   
                    fechaEntrada.Text.Trim().Length == 0 ||
                    searchProductos.Text.Trim().Length == 0 || searchProductos.Text.Equals("[Vacío]")

                   );
        }

        //FUNCION LIMPIAR CAJA DE TEXTO
        private void LimpiarCajas()
        {
            ctIdEntrada.Clear();
            searchProductos.EditValue = null;
            fechaEntrada.ResetText();
            ctCantidad.Clear();
            //gridDetalleEntrada.DataSource = null;

        }
        //FUNCION HABILITAR Y DESEBILITAR CONTROLER
        public void Habilitar(bool v)
        {
            //Text desactivados
           searchProductos.Enabled = !v;
           fechaEntrada.Enabled = !v;
           

            btnNuevo.Enabled = v;
            btnGuardar.Enabled = !v;
            btnCancelar.Enabled = !v;
            btnEliminar.Enabled = !v;
            btnAgregar.Enabled = !v;

        }

        private void FEntrada_Load(object sender, EventArgs e)
        {
            Habilitar(true);
            entrada = new Entrada(sessionEntrada);
            gridDetalleEntrada.DataSource = entrada.DetalleEntradas;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (CamposVacios())
            {
                mensajeError("Error todos los campos son obligatorios");
                searchProductos.Focus();
                return;
            }


            dEntrada = new DetalleEntrada(sessionEntrada);

            dEntrada.IdProducto = (Producto)searchViewProductos.GetFocusedRow();
            dEntrada.Cantidad = Convert.ToInt32(ctCantidad.Text);
            //entrada.Save();

            entrada.DetalleEntradas.Add(dEntrada);

            
            acum = acum + dEntrada.Cantidad;
            CantidadTotal();

            gridDetalleEntrada.RefreshDataSource();
            LimpiarCajas();


        }

        private void CantidadTotal()
        {
            txtTotal.Text = acum.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
        }

       

        private void ctCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            searchProductos.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            Habilitar(true);
            LimpiarCajas();
            return;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var  elemento = (DetalleEntrada)gridViewDetalleEntrada.GetFocusedRow();
            entrada.DetalleEntradas.Remove(elemento);
            gridDetalleEntrada.RefreshDataSource();

        }

        private void searchProductos_Popup(object sender, EventArgs e)
        {
           searchViewProductos.ActiveFilterString = "[IdEstado.Nombre] = 'activo'";
        }

        private void searchProductos_EditValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
