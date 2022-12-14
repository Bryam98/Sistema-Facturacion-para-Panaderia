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
    public partial class FClientes : Form
    {


        private bool IsEditar = false;
        int valorEstado;
        Cliente c;

        public FClientes()
        {
            InitializeComponent();
            this.mensajesDeAyuda();
           
        }

        private void mensajesDeAyuda()
        {
            this.ttMensaje.SetToolTip(this.ctId, "Codigo del Cliente");
            this.ttMensaje.SetToolTip(this.ctNombres, "Ingrese Nombres del Cliente");
            this.ttMensaje.SetToolTip(this.ctApellidos, "Ingrese Apellidos del Cliente");
            this.ttMensaje.SetToolTip(this.ctDireccion, "Ingrese La Direcion del Cliente");
            this.ttMensaje.SetToolTip(this.ctCedula, "Ingrese la Identificacion del Cliente");
            this.ttMensaje.SetToolTip(this.ctTelefono, "Ingrese el Telefono del Cliente");
            this.ttMensaje.SetToolTip(this.cbSexo, "Ingrese el Genero del Cliente");
            this.ttMensaje.SetToolTip(this.searchLookEstado, "Ingrese el Estado Cliente");


        }

        private void mensajeCorrecto(string mensaje)
        {

            MessageBox.Show(mensaje, "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void mensajeError(string mensaje)
        {

            MessageBox.Show(mensaje, "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    searchLookEstado.Text.Trim().Length == 0 ||
                    searchLookEstado.Text.Equals("[Vacío]")

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
            searchLookEstado.EditValue = 1;

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
            

            btnNuevo.Enabled = v;
            btnGuardar.Enabled = !v;
            btnCancelar.Enabled = !v;
            btnEditar.Enabled = v;
            btnEliminar.Enabled = v;
            btnSalir.Enabled = v;
        }

        private bool verificarCedula()
        {
            bool existe = false;

            foreach(Cliente cli in xpClientes)
            {
                if(cli.Cedula == ctCedula.Text)
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
                mensajeError("Todo Lo campos deben estar completos");
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
            


            if (!IsEditar)
            {

                c = new Cliente(sessionClientes);
                c.Nombres = ctNombres.Text;
                c.Apellidos = ctApellidos.Text;
                c.Cedula = ctCedula.Text;
                if (cbSexo.Text == "Femenino")
                    c.Sexo = 'F';
                else
                    c.Sexo = 'M';
                c.Direccion = ctDireccion.Text;
                c.Telefono = ctTelefono.Text;
                c.FechaRegistro = DateTime.Now.Date;

                //asignamos id por defecto
                foreach (Estado estado in xpEstado)
                {
                    if (estado.IdEstado == 1)
                        c.IdEstado = estado;

                }

            }
            else
            {
                c = (Cliente)gridViewClientes.GetFocusedRow();

                if (searchLookEstado.EditValue == null || Convert.ToInt32(searchLookEstado.EditValue) != valorEstado)
                {
                    c.IdEstado = (Estado)searchLookUpEstado.GetFocusedRow();
                }
                else
                {
                    c.IdEstado.IdEstado = valorEstado;
                }

                c.Nombres = ctNombres.Text;
                c.Apellidos = ctApellidos.Text;
                c.Cedula = ctCedula.Text;
                if (cbSexo.Text == "Femenino")
                    c.Sexo = 'F';
                else
                    c.Sexo = 'M';
                c.Direccion = ctDireccion.Text;
                c.Telefono = ctTelefono.Text;
      

                //aplico filtro activo por si se activo un cliente inactivo
                rrActivo.Checked = true;
            }

            try
            {
                c.Save();
                sessionClientes.CommitChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            mensajeCorrecto("Registro Guardado Correctamente");
            LimpiarCajas();
            xpClientes.Reload();
            IsEditar = false;
            Habilitar(true);
            //manda al seccion de Mantenimiento
            this.tabControl1.SelectedIndex = 0;

        }

      
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            ctNombres.Focus();

        }

        private void FClientes_Load(object sender, EventArgs e)
        {
            Habilitar(true);
            gridViewClientes.ActiveFilterString = "[IdEstado.Nombre] = 'Activo'";

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            Cliente cliente = (Cliente)gridViewClientes.GetFocusedRow();

            if (cliente == null)
            {
                mensajeError("Debe selecionar un registro a editar");
                return;
            }

            ctId.Text = cliente.IdCliente.ToString();
            ctNombres.Text = cliente.Nombres.ToString();
            ctApellidos.Text = cliente.Apellidos.ToString();
            ctCedula.Text = cliente.Cedula.ToString();
            if (cliente.Sexo.ToString().Equals("F"))
                cbSexo.Text = "Femenino";
            else
                cbSexo.Text = "Masculino";
            ctDireccion.Text = cliente.Direccion.ToString();
            ctTelefono.Text = cliente.Telefono.ToString();

            searchLookEstado.EditValue = cliente.IdEstado.IdEstado;
            valorEstado = cliente.IdEstado.IdEstado;


            IsEditar = true;
            Habilitar(false);
            searchLookEstado.Enabled = true;
            //manda al seccion de Mantenimiento
            this.tabControl1.SelectedIndex = 1;
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
                tabControl1.SelectedIndex = 0;
               
            }
            else
            {
                Habilitar(true);
                searchLookEstado.Enabled = false;
                LimpiarCajas();
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)gridViewClientes.GetFocusedRow();

            if ( cliente == null)
            {

                mensajeError("Debe seleccionar un registro a eliminar");
                return;
            }

            var result = MessageBox.Show("Seguro que desea eliminar el registro", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.No)
            {

                return;
            }
            cliente.Delete();
            sessionClientes.CommitChanges();

            mensajeCorrecto("El registro fue eliminado correctamente");
        }
        
        private void ctNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void ctApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void ctTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }


        private void rrActivo_CheckedChanged(object sender, EventArgs e)
        {
            gridViewClientes.ActiveFilterString = "[IdEstado.Nombre] = 'Activo'";
            xpClientes.Reload();
        }

        private void rrInactivos_CheckedChanged(object sender, EventArgs e)
        {
            gridViewClientes.ActiveFilterString = "[IdEstado.Nombre] = 'Inactivo'";
            xpClientes.Reload();
        }
    }
}
