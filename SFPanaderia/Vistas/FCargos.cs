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
    public partial class FCargos : Form
    {

        Cargo cargo;
        public FCargos()
        {
            InitializeComponent();
            this.mensajesDeAyuda();
        }
        private void mensajesDeAyuda()
        {
            this.ttMensaje.SetToolTip(this.ctId, "Codigo del Cargo");
            this.ttMensaje.SetToolTip(this.ctNombre, "Ingrese Nombre del Cargo");
            this.ttMensaje.SetToolTip(this.ctDescripcion, "Ingrese Descripcion del Cargo");

        }

        private void mensajeCorrecto(string mensaje)
        {

            MessageBox.Show(mensaje, "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void mensajeError(string mensaje)
        {

            MessageBox.Show(mensaje, "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void FCargos_Load(object sender, EventArgs e)
        {
            Habilitar(true);
            
        }

        private bool IsEditar = false;

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

                cargo = new Cargo(sessionCargos);
            }
            else
            {
                cargo = (Cargo)gridViewCargos.GetFocusedRow();
            }

            
            cargo.Nombre = ctNombre.Text;
            cargo.Descripcion = ctDescripcion.Text;

            cargo.Save();

            try
            {
                sessionCargos.CommitChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            mensajeCorrecto("Registro Guardado Correctamente");
            LimpiarCajas();
            xpCargos.Reload();
            IsEditar = false;
            Habilitar(true);

            //Nos cambia a la seccion de Listado de Categorias
            this.tabControl1.SelectedIndex = 0;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            ctNombre.Focus();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cargo cargo = (Cargo)gridViewCargos.GetFocusedRow();

            if (cargo == null)
            {
                mensajeError("Debe selecionar un registro a editar");
                return;
            }

            ctId.Text = cargo.IdCargo.ToString();
            ctNombre.Text = cargo.Nombre.ToString();
            ctDescripcion.Text = cargo.Descripcion.ToString();
            IsEditar = true;
            Habilitar(false);

            this.tabControl1.SelectedIndex = 1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cargo cargo = (Cargo)gridViewCargos.GetFocusedRow();

            if (cargo == null)
            {
                mensajeError("Debe seleccionar un registro a eliminar");
                return;
            }

            var result = MessageBox.Show("Seguro que desea eliminar el registro", "Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.No)
            {

                return;
            }
            cargo.Delete();
            sessionCargos.CommitChanges();

            mensajeCorrecto("El registro fue eliminado correctamente");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
