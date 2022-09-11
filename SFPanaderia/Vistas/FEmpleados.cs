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
    public partial class FEmpleados : Form
    {


        private bool IsEditar = false;
        int valorCargo, valorEstado;

        public FEmpleados()
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
            dateFNacimiento.ResetText();
            searchCargo.ResetText();
            searchEstado.ResetText();
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
            gridViewEmpleados.ActiveFilterString = "[IdEstado.Nombre] = 'activo'";
            

        }
        private bool verificarCedula()
        {
            bool existe = false;

            foreach (Empleado emp in xpEmpleados)
            {
                if (emp.Cedula == ctCedula.Text)
                {
                    existe = true;
                }

            }

            return existe;


        }




        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (CamposVacios())
            {
                mensajeError("Vefique todos los campos son obligatorios...!!");
                ctNombres.Focus();
                return;
            }
            if (!IsEditar)
            {
                if (verificarCedula())
                {
                    mensajeError("Ya existe un cliente con ese numero de cedula..!!");
                    ctCedula.Focus();
                    return;
                }
            }

            if ((MessageBox.Show("Esta Seguro que desea guardar el registro","Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) == DialogResult.No)
            {
                if (IsEditar) {

                    IsEditar = false;
                }
                 
                LimpiarCajas();
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
            emp.FechaNacimiento = DateTime.Parse(dateFNacimiento.Text);
            emp.FechaRegistro = DateTime.Now;

            if (searchCargo.EditValue == null || Convert.ToInt32(searchCargo.EditValue) != valorCargo)
            {

                emp.IdCargo = (Cargo)searchLookUpCargo.GetFocusedRow();


            }
            else
            {
                emp.IdCargo.IdCargo = valorCargo;
            }

            if (searchEstado.EditValue == null || Convert.ToInt32(searchEstado.EditValue) != valorEstado)
            {
                emp.IdEstado = (Estado)searchLookUpEstado.GetFocusedRow();

            }
            else
            {
                emp.IdEstado.IdEstado = valorEstado;
            }



            try
            {
                emp.Save();
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
            gridViewEmpleados.ActiveFilterString = "[IdEstado.Nombre] = 'activo'";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(xpEmpleados.Count == 0)
            {
                mensajeError("Error a un no existe registro...!!");
                return;
            }
            Empleado emp = (Empleado)gridViewEmpleados.GetFocusedRow();

            if (emp == null)
            {
                mensajeError("Debe selecionar un registro a editar..!!");
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

            searchCargo.EditValue = emp.IdCargo.IdCargo;
            valorCargo = emp.IdCargo.IdCargo;

            searchEstado.EditValue = emp.IdEstado.IdEstado;
            valorEstado = emp.IdEstado.IdEstado;
            
            IsEditar = true;
            Habilitar(false);
            //manda al seccion de Mantenimiento
            this.tabEmpleados.SelectedIndex = 1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (xpEmpleados.Count == 0)
            {
                mensajeError("Error a un no existe registro...!!");
                return;
            }

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

        private void ctApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);  
        }

        private void rrActivo_CheckedChanged(object sender, EventArgs e)
        {
            gridViewEmpleados.ActiveFilterString = "[IdEstado.Nombre] = 'activo'";
            xpEmpleados.Reload();
        }

        private void rrInactivos_CheckedChanged(object sender, EventArgs e)
        {
            gridViewEmpleados.ActiveFilterString = "[IdEstado.Nombre] = 'inactivo'";
            xpEmpleados.Reload();
        }

        private void ctNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }



    }
}
