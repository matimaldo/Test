using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
        Usuario usuario = new Usuario();

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            usuario = usuarioBusiness.obtener((this.Owner as frmEmpleados).empleado.IdPersona);
            usuario.Persona = (this.Owner as frmEmpleados).empleado;

            txtNombre.Text = usuario.Persona.Apellido.ToString() + ", " + usuario.Persona.Nombre.ToString();

            txtUsuario.Text = usuario.NMUsuario;
            txtClave.Text = usuario.Clave;

            if(usuario.IdUsuario != 0)
            {
                btnGuardar.Text = "Modificar";
                txtUsuario.Enabled = false;
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtClave.PasswordChar == '*')
            {
                txtClave.PasswordChar = '\0';
                btnMostrar.Image = global::Presentacion.Properties.Resources.Img_Visible;
            }
            else
            {
                txtClave.PasswordChar = '*';
                btnMostrar.Image = global::Presentacion.Properties.Resources.Img_Candado;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (btnGuardar.Text == "Guardar")
            {
                usuario.NMUsuario = txtUsuario.Text;
                usuario.Clave = txtClave.Text;
                usuarioBusiness.agregar(usuario);
                MessageBox.Show("Se Creo Usuario Correctamente");
                btnGuardar.Text = "Modificar";
            }
            else
            {
                usuario.NMUsuario = txtUsuario.Text;
                usuario.Clave = txtClave.Text;
                usuarioBusiness.modificar(usuario);
                MessageBox.Show("Se Modifica Clave Correctamente");

            }
            
        }
    }
}
