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
    public partial class FUsuario : Form
    {


        private bool IsEditar = false;
        int valorEmpleado;

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
            this.ttMensaje.SetToolTip(this.searchLookEmpleado, "Eliga el nombre del Empleado");
           

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
                    searchLookEmpleado.Text.Trim().Length == 0 ||
                    searchLookEmpleado.Text.Equals("[Vacío]")

                   );
        }

        //FUNCION LIMPIAR CAJA DE TEXTO
        private void LimpiarCajas()
        {
            ctId.Clear();
            ctUsuario.Clear();
            ctCorfirmacion.Clear();
            ctClave.Clear();
    
        }
        //FUNCION HABILITAR Y DESEBILITAR CONTROLER
        public void Habilitar(bool v)
        {
            //Text desactivados
            ctUsuario.Enabled = !v;
            ctCorfirmacion.Enabled = !v;
            ctClave.Enabled = !v;
            searchLookEmpleado.Enabled = !v;
            CkMostrar.Enabled = !v;
            
            btnNuevo.Enabled = v;
            btnGuardar.Enabled = !v;
            btnCancelar.Enabled = !v;
            btnEditar.Enabled = v;
            btnEliminar.Enabled = v;

        }


        private void FUsuario_Load(object sender, EventArgs e)
        {
            Habilitar(true);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            ctUsuario.Focus();
        }

        private void CkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if(CkMostrar.Checked == true)
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
   
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           

            if (CamposVacios())
            {
                mensajeError("Todo Lo campos deben estar completos");
                ctUsuario.Focus();
                return;
            }
            if (verificarExistenciaBD())
            {
                mensajeError("Error el empleado seleccionado ya tiene un usuario");
                return;
            }

            if (!ctCorfirmacion.Text.Equals(ctClave.Text))
            {
                mensajeError("Las claves que intruducio no conciden");
                ctCorfirmacion.Focus();
                return;
            }
             
                

            Usuario user;


            if (!IsEditar)
            {

                user = new Usuario(sessionUsuarios);
            }
            else
            {
                user = (Usuario)gridViewUsuarios.GetFocusedRow();

            }

            if (searchLookEmpleado.EditValue == null || Convert.ToInt32(searchLookEmpleado.EditValue) != valorEmpleado)
            {
                user.IdEmpleado = (Empleado)searchLookUpEmpleados.GetFocusedRow();
            }
            else
            {
                user.IdEmpleado.IdEmpleado = valorEmpleado;
            }

            user.Login = ctUsuario.Text;
            user.Clave = ctCorfirmacion.Text;
            user.FechaRegistro = DateTime.Now;

            user.Save();

            try
            {
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

        public bool verificarExistenciaBD()
        {

           var emp = (Empleado) searchLookUpEmpleados.GetFocusedRow();

            bool existe = false;

            foreach(Usuario userExistente in xpUsuarios)
            {
                if( userExistente.IdEmpleado.IdEmpleado ==  emp.IdEmpleado)
                {
                    existe = true;
                  
                }
            }

            return existe;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (IsEditar)
            {
                Habilitar(true);
                LimpiarCajas();
                tabControlUsuarios.SelectedIndex = 0;
                return;
            }


            Habilitar(true);
            LimpiarCajas();
            return;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
            searchLookEmpleado.EditValue = user.IdEmpleado.IdEmpleado;
            valorEmpleado = user.IdEmpleado.IdEmpleado;
          

            IsEditar = true;
            Habilitar(false);
            //manda al seccion de Mantenimiento
            this.tabControlUsuarios.SelectedIndex = 1;
        }

       
    }
}
