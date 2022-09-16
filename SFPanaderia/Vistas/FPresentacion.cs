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
    public partial class FPresentacion : Form
    {

        Presentacion p;
        public FPresentacion()
        {
            InitializeComponent();
            this.mensajesDeAyuda();
        }


        private void mensajesDeAyuda()
        {
            this.ttMensaje.SetToolTip(this.ctNombre, "Ingrese Nombre de la presentacion");
            this.ttMensaje.SetToolTip(this.ctDescripcion, "Ingrese Descripcion de la presentacion");
        }

        private void mensajeCorrecto(string mensaje)
        {

            MessageBox.Show(mensaje, "Presentacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void mensajeError(string mensaje)
        {

            MessageBox.Show(mensaje, "Presentacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //Verificar si estan vacias la cajas
        private bool CamposVacios()
        {
            return (ctNombre.Text.Trim().Length == 0 || ctDescripcion.Text.Trim().Length == 0);
        }

        //FUNCION LIMPIAR CAJA DE TEXTO
        private void LimpiarCajas()
        {
            ctId.Clear();
            ctNombre.Clear();
            ctDescripcion.Clear();
        }
        //FUNCION HABILITAR Y DESEBILITAR CONTROLER
        public void Habilitar(bool v)
        {
            ctNombre.Enabled = !v;
            ctDescripcion.Enabled = !v;
            btnNuevo.Enabled = v;
            btnGuardar.Enabled = !v;
            btnCancelar.Enabled = !v;
            btnEditar.Enabled = v;
            btnEliminar.Enabled = v;

        }

        private bool IsEditar = false;

        private void FPresentacion_Load(object sender, EventArgs e)
        {

            Habilitar(true);

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                mensajeError("Todo Lo campos deben estar completos");
                ctNombre.Focus();
                return;
            }
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

                p = new Presentacion(sessionPresentacion);
            }
            else
            {
                p = (Presentacion)gridViewPresentacion.GetFocusedRow();
            }


            p.Nombre = ctNombre.Text;
            p.Descripcion = ctDescripcion.Text;

            p.Save();

            try
            {
                sessionPresentacion.CommitChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            mensajeCorrecto("Registro Guardado Correctamente...!!");
            LimpiarCajas();
            xpPresentacion.Reload();
            IsEditar = false;
            Habilitar(true);
            this.tabControl1.SelectedIndex = 0;
        }




        private void btnEditar_Click(object sender, EventArgs e)
        {
            Presentacion p = (Presentacion)gridViewPresentacion.GetFocusedRow();

            if (p == null)
            {
                mensajeError("Debe selecionar un registro a editar");
                return;
            }

            ctId.Text = p.IdPresentacion.ToString();
            ctNombre.Text = p.Nombre.ToString();
            ctDescripcion.Text = p.Descripcion.ToString();
            IsEditar = true;
            Habilitar(false);

            this.tabControl1.SelectedIndex = 1;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (IsEditar)
            {
                Habilitar(true);
                LimpiarCajas();
                tabControl1.SelectedIndex = 0;
                return;
            }
            Habilitar(true);
            LimpiarCajas();
            return;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Presentacion p = (Presentacion)gridViewPresentacion.GetFocusedRow();

            if (p == null)
            {
                mensajeError("Debe seleccionar un registro a eliminar");
                return;
            }

            var result = MessageBox.Show("Seguro que desea eliminar el registro", "Presentacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.No)
            {

                return;
            }
            p.Delete();
            sessionPresentacion.CommitChanges();

            mensajeCorrecto("El registro fue eliminado correctamente");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            ctNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
