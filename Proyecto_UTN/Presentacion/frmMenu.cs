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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVehiculo frmVehiculo = new frmVehiculo();
            frmVehiculo.Owner = this;
            frmVehiculo.ShowDialog();
            this.Show();
        }

        private void btnBajarPersonas_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescPersonas.Visible = true;
            btnSubirPersonas.Visible = true;
            btnBajarPersonas.Visible = false;
        }

        private void btnSubirPersonas_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescPersonas.Visible = false;
            btnSubirPersonas.Visible = false;
            btnBajarPersonas.Visible = true;
        }

        private void btnBajarVehiculos_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescVehiculos.Visible = true;
            btnSubirVehiculos.Visible = true;
            btnBajarVehiculos.Visible = false;
        }

        private void btnSubirVehiculos_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescVehiculos.Visible = false;
            btnSubirVehiculos.Visible = false;
            btnBajarVehiculos.Visible = true;
        }

        private void btnBajarCaja_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescCaja.Visible = true;
            btnSubirCaja.Visible = true;
            btnBajarCaja.Visible = false;
        }

        private void btnSubirCaja_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescCaja.Visible = false;
            btnSubirCaja.Visible = false;
            btnBajarCaja.Visible = true;
        }

        private void btnBajarAjustes_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescAjustes.Visible = true;
            btnSubirAjustes.Visible = true;
            btnBajarAjustes.Visible = false;
        }

        private void btnSubirAjustes_MouseMove(object sender, MouseEventArgs e)
        {
            lblDescAjustes.Visible = false;
            btnSubirAjustes.Visible = false;
            btnBajarAjustes.Visible = true;
        }
    }
}
