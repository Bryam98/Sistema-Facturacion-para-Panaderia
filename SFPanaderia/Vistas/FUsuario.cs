using SFPanaderia.PanaderiaBD;
using SFPanaderia.Servicios;
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
    public partial class FUsuario : Form
    {


        private bool IsEditar = false;
        int valorEmpleado = 0;
        Usuario user;

        public FUsuario()
        {
            InitializeComponent();
        }
        private void mensajesDeAyuda()
        {
            this.ttMensaje.SetToolTip(this.ctId, "Codigo del Usuario");
            this.ttMensaje.SetToolTip(this.ctUsuario, "Ingrese el Nombre de Usuario");
            this.ttMensaje.SetToolTip(this.ctCorfirmacion, "Ingrese la clave");
            this.ttMensaje.SetToolTip(this.ctClave, "Vuelva ingresar la clave");
            this.ttMensaje.SetToolTip(this.searchEmpleado, "Seleccione un empleado");
           

        }

        private void mensajeCorrecto(string mensaje)
        {

            MessageBox.Show(mensaje, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void mensajeError(string mensaje)
        {

            MessageBox.Show(mensaje, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //Verificar si estan vacias la cajas
        private bool CamposVacios()
        {
            return (
                    ctUsuario.Text.Trim().Length == 0 ||
                    ctCorfirmacion.Text.Trim().Length == 0 ||
                    ctClave.Text.Trim().Length == 0 ||
                   searchEmpleado.Text.Trim().Length == 0 || searchEmpleado.Text.Equals("[Vacío]")

                   );
        }

        //FUNCION LIMPIAR CAJA DE TEXTO
        private void LimpiarCajas()
        {
            ctId.Clear();
            ctUsuario.Clear();
            ctCorfirmacion.Clear();
            ctClave.Clear();
            searchEmpleado.EditValue = null;

    
        }
        //FUNCION HABILITAR Y DESEBILITAR CONTROLER
        public void Habilitar(bool v)
        {
            //Text desactivados
            ctUsuario.Enabled = !v;
            ctCorfirmacion.Enabled = !v;
            ctClave.Enabled = !v;
            CkMostrar.Enabled = !v;
            searchEmpleado.Enabled = !v;

            btnNuevo.Enabled = v;
            btnGuardar.Enabled = !v;
            btnCancelar.Enabled = !v;
            btnEditar.Enabled = v;
            btnEliminar.Enabled = v;
            btnSalir.Enabled = v;
        }

        private void FUsuario_Load(object sender, EventArgs e)
        {
            Habilitar(true);
            gridViewUsuarios.ActiveFilterString = "[IdEmpleado.IdEstado.Nombre] = 'activo'";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            ctUsuario.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (CamposVacios())
            {
                mensajeError("Todos los campos deben estar completos");
                ctUsuario.Focus();
                return;
            }

            if (!IsEditar)
            {
                if (verificarExistenciaBD())
                {
                    mensajeError("Error el empleado seleccionado ya tiene un usuario");
                    searchEmpleado.Focus();
                    return;
                }
            }

            if (!ctCorfirmacion.Text.Equals(ctClave.Text))
            {
                mensajeError("Las claves introducidas no coinciden");
                ctCorfirmacion.Focus();
                return;
            }
  
            if (!IsEditar)
            {
                user = new Usuario(sessionUsuarios);

                user.Login = ctUsuario.Text;
                user.Clave = ctCorfirmacion.Text;
                user.FechaRegistro = DateTime.Now.Date;
                user.IdEmpleado = (Empleado)searchViewEmpleados.GetFocusedRow();
            }
            else
            {
                user = (Usuario)gridViewUsuarios.GetFocusedRow();
                user.Login = ctUsuario.Text;
                user.Clave = ctCorfirmacion.Text;

                if (searchEmpleado.EditValue == null || Convert.ToInt32(searchEmpleado.EditValue) != valorEmpleado)
                {
                    user.IdEmpleado = (Empleado)searchViewEmpleados.GetFocusedRow();

                }
                else
                {
                    user.IdEmpleado.IdEmpleado = valorEmpleado;

                }
            }

           
            try
            {
                user.Save();
                sessionUsuarios.CommitChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            mensajeCorrecto("Registro Guardado Correctamente");
            LimpiarCajas();
            xpUsuarios.Reload();
            IsEditar = false;
            Habilitar(true);
            //manda al seccion de Mantenimiento
            this.tabControlUsuarios.SelectedIndex = 0;

        }

      
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario user = (Usuario)gridViewUsuarios.GetFocusedRow();

            if (user == null)
            {
                mensajeError("Debe selecionar un registro a editar");
                return;
            }

            ctId.Text = user.IdUsuario.ToString();
            ctUsuario.Text = user.Login.ToString();
            ctClave.Text = user.Clave.ToString();
            ctCorfirmacion.Text = user.Clave.ToString();
            searchEmpleado.EditValue = user.IdEmpleado.IdEmpleado;
            valorEmpleado = user.IdEmpleado.IdEmpleado;

          
            IsEditar = true;
            Habilitar(false);
            searchEmpleado.Enabled = false;

            //manda al seccion de Mantenimiento
            this.tabControlUsuarios.SelectedIndex = 1;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario user = (Usuario)gridViewUsuarios.GetFocusedRow();

            if (user == null)
            {

                mensajeError("Debe seleccionar un registro a eliminar");
                return;
            }

            var result = MessageBox.Show("Seguro que desea eliminar el registro", "Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.No)
            {

                return;
            }
            user.Delete();
            sessionUsuarios.CommitChanges();

            mensajeCorrecto("El registro fue eliminado correctamente");
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (IsEditar)
            {
                Habilitar(true);
                LimpiarCajas();
                CkMostrar.Checked = false;
                tabControlUsuarios.SelectedIndex = 0;
               
            }
            else
            {
                Habilitar(true);
                LimpiarCajas();
                CkMostrar.Checked = false;
                return;
            }


        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool verificarExistenciaBD()
        {

            bool existe = false;
            Empleado emp = (Empleado)searchViewEmpleados.GetFocusedRow();

            if (!IsEditar)
            {
                foreach (Usuario userExistente in xpUsuarios)
                {
                    if (userExistente.IdEmpleado.IdEmpleado == emp.IdEmpleado)
                    {

                        existe = true;

                    }
                }
            }
   
            return existe;
        }

        //funcion Encargada de mostrar las claves
        private void CkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (CkMostrar.Checked == true)
            {
                ctCorfirmacion.PasswordChar = '\0';
                ctClave.PasswordChar = '\0';
            }
            else
            {
                ctCorfirmacion.PasswordChar = '*';
                ctClave.PasswordChar = '*';
            }

        }

        private bool verificarUsuario()
        {
            bool existe = false;

            foreach(Usuario user in xpUsuarios)
            {
                if(user.Login == ctUsuario.Text)
                {
                    existe = true;
                }
            }

            return existe;
        }

        private void rrActivo_CheckedChanged(object sender, EventArgs e)
        {
            gridViewUsuarios.ActiveFilterString = "[IdEmpleado.IdEstado.Nombre] = 'activo'";
            xpUsuarios.Reload();
        }

        private void rrInactivos_CheckedChanged(object sender, EventArgs e)
        {
            gridViewUsuarios.ActiveFilterString = "[IdEmpleado.IdEstado.Nombre] = 'inactivo'";
            xpUsuarios.Reload();
        }

        //funcion aplica fitros a los xpEmpleados
        private void searchEmpleado_Popup(object sender, EventArgs e)
        {
            searchViewEmpleados.ActiveFilterString = "[IdEstado.Nombre] = 'activo'";
            
        }
    }
}
