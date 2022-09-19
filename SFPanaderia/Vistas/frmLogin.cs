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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool CamposVacios()
        {
            return (ctUsuario.Text.Trim().Length == 0 || ctClave.Text.Trim().Length == 0);
        }

        //FUNCION LIMPIAR CAJA DE TEXTO
        private void LimpiarCajas()
        {
            ctUsuario.Clear();
            ctClave.Clear();
         
        }

       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Usuario user in xpLogin)
            {
                if (user.Login.Equals(ctUsuario.Text))
                {
                    if (user.Clave.Equals(ctClave.Text))
                    {
                        FrmPrincipal frmPrincipal = new FrmPrincipal(user);
                        frmPrincipal.Show();
                        this.Hide();
                        LimpiarCajas();
                        return;
                    }
                   
                }


            }
            MessageBox.Show("Usuario o contraseña incorrecta.",
                        "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ctUsuario.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void ctClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
