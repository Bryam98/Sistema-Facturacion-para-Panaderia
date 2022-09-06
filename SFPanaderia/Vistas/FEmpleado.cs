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
    public partial class FEmpleado : Form
    {
        public FEmpleado()
        {
            InitializeComponent();
            this.mensajesDeAyuda();
        }


        private void mensajesDeAyuda()
        {
            this.tMensaje.SetToolTip(this.ctId, "Codigo del Empleado");
            this.tMensaje.SetToolTip(this.ctNombres, "Ingrese Nombres del Empleado");
            this.tMensaje.SetToolTip(this.ctApellidos, "Ingrese Apellidos del Empleado");
            this.tMensaje.SetToolTip(this.ctDireccion, "Ingrese La Direcion del Empleado");
            this.tMensaje.SetToolTip(this.ctCedula, "Ingrese la Identificacion del Empleado");
            this.tMensaje.SetToolTip(this.ctTelefono, "Ingrese el Telefono del Empleado");
            this.tMensaje.SetToolTip(this.cbSexo, "Ingrese el Genero del Empleado");
            this.tMensaje.SetToolTip(this.dateFNacimiento, "Ingrese la fecha de nacimiento del Empleado");
            this.tMensaje.SetToolTip(this.searchCargo, "Ingrese el Cargo del Empleado");
            this.tMensaje.SetToolTip(this.searchEstado, "Ingrese el Estado Empleado");


        }

        private void mensajeCorrecto(string mensaje)
        {

            MessageBox.Show(mensaje, "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void mensajeError(string mensaje)
        {

            MessageBox.Show(mensaje, "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //Verificar si estan vacias la cajas
        private bool CamposVacios()
        {
            return (
                    ctNombres.Text.Trim().Length == 0 ||
                    ctApellidos.Text.Trim().Length == 0 ||
                    ctDireccion.Text.Trim().Length == 0 ||
                    ctCedula.Text.Trim().Length == 0 ||
                    ctTelefono.Text.Trim().Length == 0 ||
                    dateFNacimiento.Text.Trim().Length == 0||
                    searchEstado.Text.Trim().Length == 0 ||
                    searchEstado.Text.Equals("[Vacío]") ||
                    searchCargo.Text.Trim().Length == 0 ||
                    searchCargo.Text.Equals("[Vacío]")

                   );
        }

        //FUNCION LIMPIAR CAJA DE TEXTO
        private void LimpiarCajas()
        {
            ctId.Clear();
            ctNombres.Clear();
            ctApellidos.Clear();
            ctCedula.Clear();
            ctDireccion.Clear();
            ctTelefono.Clear();
            cbSexo.Text = string.Empty;
            dateFNacimiento.Reset();

        }
        //FUNCION HABILITAR Y DESEBILITAR CONTROLER
        public void Habilitar(bool v)
        {
            //Text desactivados
            ctNombres.Enabled = !v;
            ctApellidos.Enabled = !v;
            ctCedula.Enabled = !v;
            ctDireccion.Enabled = !v;
            ctTelefono.Enabled = !v;
            cbSexo.Enabled = !v;
            dateFNacimiento.Enabled = !v;
            searchCargo.Enabled = !v;
            searchEstado.Enabled = !v;

            btnNuevo.Enabled = v;
            btnGuardar.Enabled = !v;
            btnCancelar.Enabled = !v;
            btnEditar.Enabled = v;
            //btnEliminar.Enabled = v;

        }

    
        private void FEmpleado_Load(object sender, EventArgs e)
        {
            Habilitar(true);

          

        }

        /// <summary>
        /// Variable para ver si el estado es guardar o editar
        /// </summary>
        private bool IsEditar = false;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                mensajeError("Todo Lo campos deben estar completos");
                ctNombres.Focus();
                return;
            }

           Empleado emp;


            if (!IsEditar)
            {

                emp = new Empleado(sessionEmpleados);
            }
            else
            {
                emp = (Empleado)gridViewEmpleados.GetFocusedRow();

            }


            emp.Nombres = ctNombres.Text;
            emp.Apellidos = ctApellidos.Text;
            emp.Cedula = ctCedula.Text;
            if (cbSexo.Text == "Femenino")
                emp.Sexo = 'F';
            else
                emp.Sexo = 'M';
            emp.Direccion = ctDireccion.Text;
            emp.Telefono = ctTelefono.Text;
            emp.FechaNacimiento = dateFNacimiento.DateTime;
            emp.FechaRegistro = DateTime.Now;
            emp.IdCargo = (Cargo)searchLookUpCargo.GetFocusedRow();
            emp.IdEstado = (Estado) searchLookUpEstado.GetFocusedRow();
            emp.Save();

            try
            {
                sessionEmpleados.CommitChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            mensajeCorrecto("Registro Guardado Correctamente");
            LimpiarCajas();
            xpEmpleados.Reload();
            IsEditar = false;
            Habilitar(true);
            //manda al seccion de Mantenimiento
            this.tabEmpleados.SelectedIndex = 0;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            ctNombres.Focus();

        }

        private void FClientes_Load(object sender, EventArgs e)
        {
            Habilitar(true);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Empleado emp = (Empleado)gridViewEmpleados.GetFocusedRow();

            if (emp == null)
            {
                mensajeError("Debe selecionar un registro a editar");
                return;
            }

            ctId.Text = emp.IdEmpleado.ToString();
            ctNombres.Text = emp.Nombres.ToString();
            ctApellidos.Text = emp.Apellidos.ToString();
            ctCedula.Text = emp.Cedula.ToString();
            if (emp.Sexo.ToString().Equals("F"))
                cbSexo.Text = "Femenino";
            else
                cbSexo.Text = "Masculino";
            ctDireccion.Text = emp.Direccion.ToString();
            ctTelefono.Text = emp.Telefono.ToString();
            dateFNacimiento.Text = emp.FechaNacimiento.ToString();


            IsEditar = true;
            Habilitar(false);
            //manda al seccion de Mantenimiento
            this.tabEmpleados.SelectedIndex = 1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Empleado emp = (Empleado)gridViewEmpleados.GetFocusedRow();
            
            if (emp == null)
            {

                mensajeError("Debe seleccionar un registro a eliminar");
                return;
            }

            var result = MessageBox.Show("Seguro que desea eliminar el registro", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.No)
            {

                return;
            }
            emp.Delete();
            sessionEmpleados.CommitChanges();

            mensajeCorrecto("El registro fue eliminado correctamente");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (IsEditar)
            {
                Habilitar(true);
                LimpiarCajas();
                tabEmpleados.SelectedIndex = 0;
                return;
            }

            Habilitar(true);
            LimpiarCajas();
            return;
        }

       
    }
}
