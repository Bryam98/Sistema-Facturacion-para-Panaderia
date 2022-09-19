using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using SFPanaderia.PanaderiaBD;
using SFPanaderia.Validaciones;
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
    public partial class FEntradas : Form
    {
        //int idProducto;
        DetalleEntrada dEntrada;
        int acum = 0;
        Entrada entrada;
        Usuario usuario;
        public FEntradas(Usuario user)
        {
            this.usuario = user;
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

                    searchProductos.Text.Trim().Length == 0 || searchProductos.Text.Equals("[Vacío]")

                  );
        }
        private bool CamposVaciosEntrada()
        {
            return (


                    fechaEntrada.Text.Trim().Length == 0 ||
                    searchEstados.Text.Trim().Length == 0 || searchEstados.Text.Equals("[Vacío]")

                  );
        }

        //FUNCION LIMPIAR CAJA DE TEXTO
        private void LimpiarCajas()
        {
            ctIdEntrada.Clear();
            searchProductos.EditValue = null;
            fechaEntrada.Text = DateTime.Now.Date.ToString();
            ctCantidad.Clear();
            txtTotal.Text = "0.00";
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
        private void FEntradas_Load(object sender, EventArgs e)
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
            dEntrada.Save();

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var elemento = (DetalleEntrada)gridViewDetalleEntrada.GetFocusedRow();
            entrada.DetalleEntradas.Remove(elemento);
          
            
           // entrada.Save();

            acum = acum - elemento.Cantidad;
            txtTotal.Text = acum.ToString() ;
            gridDetalleEntrada.RefreshDataSource();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            searchProductos.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (CamposVaciosEntrada())
            {
                mensajeError("Error todos los campos son obligatorios");
                fechaEntrada.Focus();
                return;
            }

            foreach (Empleado emp in xpEmpleados)
            {
                if (emp.IdEmpleado == usuario.IdEmpleado.IdEmpleado)
                    entrada.IdEmpleado = emp;
            }
            //asignamos id por defecto
            foreach (Estado estado in xpEstados)
            {
                if (estado.IdEstado == 1)
                    entrada.IdEstado = estado;

            }
            entrada.FechaEntrada = DateTime.Now.Date;
            entrada.Total = acum;

           foreach(var item in entrada.DetalleEntradas)
            {
                item.IdProducto.Existencias = item.IdProducto.Existencias + item.Cantidad;
            }

            //entrada.Save();
            sessionEntrada.CommitChanges();
            MessageBox.Show("Registro de Entrada almacenado.", "Venta",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            entrada = new Entrada(sessionEntrada);
            gridDetalleEntrada.DataSource = null;
            gridDetalleEntrada.Refresh();
            xpEntradas.Reload();
            gridDetalleEntrada.DataSource = entrada.DetalleEntradas;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            LimpiarCajas();
            return;
        }

        private void searchProductos_Properties_Popup(object sender, EventArgs e)
        {
            searchViewProductos.ActiveFilterString = "[IdEstado.Nombre] = 'activo'";
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            Entrada entradaAnular = (Entrada)gridViewEntradas.GetFocusedRow();

            if ((MessageBox.Show("Esta Seguro de anular la entrada", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) == DialogResult.No)
            {
                return;
            }

            if (xpEntradas.Count == 0)
            {
                mensajeError("No hay registros aun");
                return;
            }


            if (entradaAnular == null)
            {
                mensajeError("Debe selecionar un registro a Anular");
                return;
            }


            int result = ActulizarStockProducto(entradaAnular.IdEntrada);

            if (result == 0 )
            {
                mensajeError("Ocurrio un actulizar el stock");
            }

            //actulizamos el estado
            foreach (Entrada entrada in xpEntradas)
            {
                if (entrada.IdEntrada == entradaAnular.IdEntrada)
                {
                    entrada.Total = entradaAnular.Total;
                    entrada.FechaEntrada = entradaAnular.FechaEntrada;
                    foreach (Estado estado in xpEstados)
                    {
                        if (estado.IdEstado == 3)
                            entrada.IdEstado = estado;
                    }
                    foreach (Empleado emp in xpEmpleados)
                    {
                        if (emp.IdEmpleado == usuario.IdEmpleado.IdEmpleado)
                            entrada.IdEmpleado = emp;
                    }

                }

            }

            mensajeCorrecto("Entrada anulada correctamente");
            xpEntradas.Reload();


        }

        private int ActulizarStockProducto(int idEntrada)
        {
            string queryActualizarStock = @"UPDATE PanaderiaBD.dbo.Producto 
            set Producto.existencias = (Producto.existencias - DetalleEntrada.cantidad)
            from Producto, DetalleEntrada where Producto.idProducto = DetalleEntrada.idProducto
            AND DetalleEntrada.idEntrada =" + idEntrada;

            int rowsAffected = sessionEntrada.ExecuteNonQuery(queryActualizarStock);

            return rowsAffected;
        }

        private void ctCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
