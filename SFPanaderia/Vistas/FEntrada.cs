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
    public partial class FEntrada : Form
    {
        public FEntrada()
        {
            InitializeComponent();
        }

        private void mensajesDeAyuda()
        {
            this.ttMensaje.SetToolTip(this.ctIdEntrada, "Codigo de la Entrada");
            this.ttMensaje.SetToolTip(this.ctProducto, "Eliga el producto a ingresar");
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
                    ctProducto.Text.Trim().Length == 0 ||
                    fechaEntrada.Text.Trim().Length == 0 
                  
                   );
        }

        //FUNCION LIMPIAR CAJA DE TEXTO
        private void LimpiarCajas()
        {
            ctIdEntrada.Clear();
            ctProducto.Clear();
            fechaEntrada.ResetText();
            gridDetalleEntrada.DataSource = null;

        }
        //FUNCION HABILITAR Y DESEBILITAR CONTROLER
        public void Habilitar(bool v)
        {
            //Text desactivados
            ctProducto.Enabled = !v;
            fechaEntrada.Enabled = !v;
           

            btnNuevo.Enabled = v;
            btnGuardar.Enabled = !v;
            btnCancelar.Enabled = !v;
            btnEliminar.Enabled = !v;
            btnAgregar.Enabled = !v;

        }

        private void FEntrada_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (CamposVacios())
            {
                mensajeError("Error todos los campos son obligatorios");
                ctProducto.Focus();
                return;
            }


            DetalleEntrada dEntrada = new DetalleEntrada(sessionEntrada);

            


        }
    }
}
