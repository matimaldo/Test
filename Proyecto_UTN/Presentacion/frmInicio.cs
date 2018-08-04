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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        public bool iniciar = false;

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        public void iniciarSesion(string tipousuario)
        {
            frmLogin frmLogin = new frmLogin(tipousuario);
            frmLogin.Owner = this;
            frmLogin.ShowDialog();

            if (iniciar)
            {
                this.Hide();
                frmMenu frmMenu = new frmMenu();
                frmMenu.Owner = this;
                frmMenu.ShowDialog();
                this.Show();
            }
        }

        private void btnRecepcionista_Click(object sender, EventArgs e)
        {
            iniciarSesion("RECEPCIONISTA");           
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            iniciarSesion("SEGURIDAD");
        }

        private void btnSupervisor_Click(object sender, EventArgs e)
        {
            iniciarSesion("SUPERVISOR");
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            iniciarSesion("ADMINISTRADOR");
        }

        private void btnRecepcionista_MouseEnter(object sender, EventArgs e)
        {
            btnRecepcionista.BackgroundImage = global::Presentacion.Properties.Resources.BotonRecepSelec;
        }

        private void btnRecepcionista_MouseLeave(object sender, EventArgs e)
        {
            btnRecepcionista.BackgroundImage = global::Presentacion.Properties.Resources.BotonRecep;
        }

        private void btnSeguridad_MouseEnter(object sender, EventArgs e)
        {
            btnSeguridad.BackgroundImage = global::Presentacion.Properties.Resources.BotonSegSelec;

        }

        private void btnSeguridad_MouseLeave(object sender, EventArgs e)
        {
            btnSeguridad.BackgroundImage = global::Presentacion.Properties.Resources.BotonSeg;
        }

        private void btnSupervisor_MouseEnter(object sender, EventArgs e)
        {
            btnSupervisor.BackgroundImage = global::Presentacion.Properties.Resources.BotonSupervSelec;
        }

        private void btnSupervisor_MouseLeave(object sender, EventArgs e)
        {
            btnSupervisor.BackgroundImage = global::Presentacion.Properties.Resources.BotonSuperv;
        }

        private void btnAdministrador_MouseEnter(object sender, EventArgs e)
        {
            btnAdministrador.BackgroundImage = global::Presentacion.Properties.Resources.BotonAdmSelec;
        }

        private void btnAdministrador_MouseLeave(object sender, EventArgs e)
        {
            btnAdministrador.BackgroundImage = global::Presentacion.Properties.Resources.BotonAdm;
        }

    }
}
