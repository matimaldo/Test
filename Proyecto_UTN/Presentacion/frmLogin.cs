using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(string TipoUsuario)
        {
            InitializeComponent();

            lblTipoUsuario.Text = TipoUsuario.ToUpper();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            imgIdent.Image = global::Presentacion.Properties.Resources.Img_Identificacion;

        }

        int conteo;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                lblMensaje.Visible = false;
                imgIdent.Image = global::Presentacion.Properties.Resources.Img_IdentificacionSI;

                timer1.Start();
            }
            else
            {
                lblMensaje.Visible = true;
                imgIdent.Image = global::Presentacion.Properties.Resources.Img_IdentificacionNO;

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            (this.Owner as frmInicio).iniciar = false;
            Close();
        }

        private void btnVolver_MouseEnter(object sender, EventArgs e)
        {
            btnVolver.BackgroundImage = global::Presentacion.Properties.Resources.BotonVolverSelec;

        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.BackgroundImage = global::Presentacion.Properties.Resources.BotonVolver;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo++;
            if (conteo == 6)
            {
                (this.Owner as frmInicio).iniciar = true;
                Close();
            }
        }

    }
}
