using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using System.Threading;

namespace Presentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        LoginBusiness loginBusiness = new LoginBusiness();
        bool ok = false;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (loginBusiness.ingresar(tbUsuario.Text, tbClave.Text))
            {
                ok = true;
                lblMensaje.Visible = false;
                imgIdent.Image = global::Presentacion.Properties.Resources.Img_IdentificacionSI;
                
                this.Close();
            }
            else
            {
                lblMensaje.Visible = true;
                imgIdent.Image = global::Presentacion.Properties.Resources.Img_IdentificacionNO;

            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!ok)
            {
                Application.Exit();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Thread.Sleep(2000);
        }
    }
}
