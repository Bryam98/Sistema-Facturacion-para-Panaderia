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
    public partial class FRoles : Form
    {
        public FRoles()
        {
            InitializeComponent();
        }

        private void mensajesDeAyuda()
        {
            this.ttMensaje.SetToolTip(this.ctId, "Codigo de Rol");
            this.ttMensaje.SetToolTip(this.ctNombre, "Ingrese Nombre del Rol");
            this.ttMensaje.SetToolTip(this.ctDescripcion, "Ingrese la Descripcion del Rol");

        }

        private void mensajeCorrecto(string mensaje)
        {

            MessageBox.Show(mensaje, "Roles", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void mensajeError(string mensaje)
        {

            MessageBox.Show(mensaje, "Roles", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                mensajeError("Todo Lo campos deben estar completos");
                ctNombre.Focus();
                return;
            }

            Rol rol;

            if (!IsEditar)
            {

                rol = new Rol(sessionRol);
            }
            else
            {
                rol = (Rol)gridViewRol.GetFocusedRow();
            }


            rol.Nombre = ctNombre.Text;
            rol.Descripcion = ctDescripcion.Text;

            rol.Save();

            try
            {
                sessionRol.CommitChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            mensajeCorrecto("Registro Guardado Correctamente");
            LimpiarCajas();
            xpRoles.Reload();
            IsEditar = false;
            Habilitar(true);

            //Nos cambia a la seccion de Listado de Categorias
            this.tabControl1.SelectedIndex = 0;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            ctNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            LimpiarCajas();
            return;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Rol rol = (Rol)gridViewRol.GetFocusedRow();

            if (rol == null)
            {
                mensajeError("Debe selecionar un registro a editar");
                return;
            }

            ctId.Text = rol.IdRol.ToString();
            ctNombre.Text = rol.Nombre.ToString();
            ctDescripcion.Text = rol.Descripcion.ToString();
            IsEditar = true;
            Habilitar(false);

            this.tabControl1.SelectedIndex = 1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Rol rol = (Rol)gridViewRol.GetFocusedRow();

            if (rol == null)
            {
                mensajeError("Debe seleccionar un registro a eliminar");
                return;
            }

            var result = MessageBox.Show("Seguro que desea eliminar el registro", "Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.No)
            {

                return;
            }
            rol.Delete();
            sessionRol.CommitChanges();

            mensajeCorrecto("El registro fue eliminado correctamente");
        }

    }
}
