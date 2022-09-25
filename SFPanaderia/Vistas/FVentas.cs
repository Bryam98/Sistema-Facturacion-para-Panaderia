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
using System.Globalization;


namespace SFPanaderia.Vistas
{
    public partial class FVentas : Form
    {
        int cont = 0;
        int total = 0;
        Venta venta;
        Usuario usuario;
        public FVentas(Usuario user)
        {
            this.usuario = user;
            InitializeComponent();
        }


        private void mensajesDeAyuda()
        {
            this.ttMensaje.SetToolTip(this.fechaVenta, "Ingrese la fecha de venta");
            this.ttMensaje.SetToolTip(this.ctCedula, "Cedula del cliente");
            this.ttMensaje.SetToolTip(this.ctIdCliente, "Id del cliente");
            this.ttMensaje.SetToolTip(this.ctPrecio, "Precio del producto");
            this.ttMensaje.SetToolTip(this.ctStock, "Existencias del producto");
            this.ttMensaje.SetToolTip(this.ctIdProducto, "Id del producto");
            this.ttMensaje.SetToolTip(this.ctDescuento, "Descuento del producto");
            this.ttMensaje.SetToolTip(this.ctSub, "SubTotal de la venta");
            this.ttMensaje.SetToolTip(this.ctTotal, "Total de venta en cordobas");





        }

        private void mensajeCorrecto(string mensaje)
        {

            MessageBox.Show(mensaje, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void mensajeError(string mensaje)
        {

            MessageBox.Show(mensaje, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //FUNCION LIMPIAR CAJA DE TEXTO
        private void LimpiarCajasDetalle()
        {
            
            searchProducto.EditValue = null;

            
            ctCantidad.ResetText(); 
            ctIdProducto.Clear();
            ctPrecio.Clear();
            ctStock.Clear();
            ctDescuento.ResetText();
            ctSub.Text = "0.00";

        }
        private void LimpiarCajasVentas()
        {
            fechaVenta.EditValue = DateTime.Now.Date;
            ctDescuento.Text = "0.00";
            ctTotal.Text = "0.00";

            searchCliente.EditValue = null;
            ctCedula.Clear();
            ctIdCliente.Clear();
        }
        //FUNCION HABILITAR Y DESEBILITAR CONTROLER
        public void Habilitar(bool v)
        {
            searchCliente.Focus();
          

            btnGuardar.Enabled = !v;
            btnCancelar.Enabled = !v;
            btnEliminar.Enabled = !v;
        
        }
  

        private void FVentas_Load(object sender, EventArgs e)
        {
            Habilitar(true);
            venta = new Venta(sessionVentas);
            gridDetalle.DataSource = venta.DetalleVentas;
        }

        private void ctCantidad_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void searchProducto_EditValueChanged(object sender, EventArgs e)
        {
            Producto producto = (Producto)searchViewProducto.GetFocusedRow();

            ctIdProducto.Text = producto.IdProducto.ToString();
            ctPrecio.Text = producto.PrecioUnidad.ToString();
            ctStock.Text = producto.Existencias.ToString();



        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

     
            if (searchProducto.Text.Trim().Length == 0 || searchProducto.Text.Equals("[Vacío]"))
            {
                mensajeError("Error debe seleccionar un producto");
                searchProducto.Focus();
                return;
            }
           
            if (ctCantidad.Text.Trim().Length == 0)
            {
                mensajeError("Error debe agregar una cantidad de producto");
                ctCantidad.Focus();
                return;
            }


            DetalleVenta detalle = new DetalleVenta(sessionVentas);

            detalle.IdProducto = (Producto)searchViewProducto.GetFocusedRow();
            detalle.Cantidad = Convert.ToInt32(ctCantidad.Text);
            detalle.SubTotal = Convert.ToInt32(ctSub.Text);
          

            detalle.Save();
            venta.DetalleVentas.Add(detalle);


            total = total + (Convert.ToInt32(ctSub.Text));
            ctTotal.Text = total.ToString();
            cont++;

            HabilitarControlesGuardado();

            gridDetalle.RefreshDataSource();
            LimpiarCajasDetalle();
       


        }

        private void HabilitarControlesGuardado()
        {
           
            if(cont > 0)
            {
                btnCancelar.Enabled = true;
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = true;


            }
            else 
            {
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DetalleVenta elemento = (DetalleVenta)gridViewDetalle.GetFocusedRow();

            if (elemento == null)
            {
                mensajeError("Error debe selecionar un producto");
                return;
            }

            venta.DetalleVentas.Remove(elemento);

            //borra el objeto de la memoria
            elemento.Delete();

            total = total - Convert.ToInt32(elemento.SubTotal);
            ctTotal.Text = total.ToString();
            cont--;


            searchProducto.Focus();
            HabilitarControlesGuardado();
            gridDetalle.RefreshDataSource();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchCliente_EditValueChanged_1(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)searchViewCliente.GetFocusedRow();


            ctIdCliente.Text = cliente.IdCliente.ToString();
            ctCedula.Text = cliente.Cedula;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int cantidad = 0;

            if (fechaVenta.Text.Trim().Length == 0)
            {
                mensajeError("Error debe seleccionar un fecha de venta");
                fechaVenta.Focus();
                return;
            }

            venta.IdCliente = (Cliente)searchViewCliente.GetFocusedRow();

            foreach (Empleado emp in xpEmpleados)
            {
                if (emp.IdEmpleado == usuario.IdEmpleado.IdEmpleado)
                    venta.IdEmpleado = emp;
            }
            //asignamos id por defecto
            foreach (Estado estado in xpEstados)
            {
                if (estado.IdEstado == 1)
                    venta.IdEstado = estado;

            }


           
            venta.FechaVenta = DateTime.Now.Date;
            //venta.MontoFinal = CalcularTotal();
            venta.MontoFinal = Convert.ToDouble(ctTotal.Text);

            foreach (var item in venta.DetalleVentas)
            {
                item.IdProducto.Existencias = item.IdProducto.Existencias - item.Cantidad;

                if (item.IdProducto.Existencias == 0)
                {
                    foreach (Estado estado in xpEstados)
                    {
                        if (estado.IdEstado == 2)
                            item.IdProducto.IdEstado = estado;

                    }
                }

                //obtenemos el total del productos comprados
                cantidad = cantidad + item.Cantidad;
            }

             venta.Cantidad = cantidad;



            venta.Save();
            sessionVentas.CommitChanges();
            MessageBox.Show("Registro de venta almacenado.", "Venta",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Creamos un nuevo para la siguiente entrada
            venta = new Venta(sessionVentas);


            //asignamos null a la grid
            gridDetalle.DataSource = null;

            //refrecasmos el grid detalle de entrada despues de haberlo  limpiado
            gridDetalle.Refresh();


            //asignamos el valor al grilla detalle de entrada con el nuevo objeto entrada
            gridDetalle.DataSource = venta.DetalleVentas;


            //reiniciamos los controller
            Habilitar(true);
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;

            //limpiamos las cajas de texto
            LimpiarCajasDetalle();
            LimpiarCajasVentas();

        }

        //private double CalcularTotal()
        //{
          
        //    double total = Double.Parse(ctTotal.Text, CultureInfo.InvariantCulture);
        //    double descuento = Double.Parse(ctDescuento.Text, CultureInfo.InvariantCulture);

        //    total = total - (total * (descuento / 100));

        //    return total;
        //}

    
        private void ctCantidad_TextChanged(object sender, EventArgs e)
        {
            Producto producto = (Producto)searchViewProducto.GetFocusedRow();
            int cantidad = 0;


            if (searchProducto.EditValue == null)
            {
                mensajeError("Error debe seleccionar un producto");
                searchProducto.Focus();
                return;
            }

            try
            {
                cantidad = Convert.ToInt32(ctCantidad.Text);

            }
            catch
            {
                cantidad = 0;
            }

            if (cantidad > producto.Existencias)
            {
                mensajeError("Error la cantidad a vender es mayor a la existencias");
                searchProducto.Focus();
                ctCantidad.Clear();
                return;
            }



            ctSub.Text = Convert.ToString(producto.PrecioUnidad * cantidad);
        }

        private void searchCliente_Properties_Popup(object sender, EventArgs e)
        {
            searchViewCliente.ActiveFilterString = "[IdEstado.Nombre] = 'activo'";
        }

        private void searchProducto_Properties_Popup(object sender, EventArgs e)
        {
            searchViewProducto.ActiveFilterString = "[IdEstado.Nombre] = 'activo'";
        }
    }
}
