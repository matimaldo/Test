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
    public partial class frmVehiculo : Form
    {
        public frmVehiculo()
        {
            InitializeComponent();
        }

        public Persona persona = new Persona();
        AbonoBusiness abonoBusiness = new AbonoBusiness();

        int opcion;
        public bool BusquedaOK;

        private void frmVehiculo_Load(object sender, EventArgs e)
        {
            opcion = 0;
            BusquedaOK = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ocultar (bool opcion)
        {
            lblIngrese.Visible = opcion;
            ImgHuella.Visible = opcion;
            btnIgresoDNI.Visible = opcion;

            lblNombre.Visible = !opcion;
            lblApellido.Visible = !opcion;
            lblDNI.Visible = !opcion;
            lblMonto.Visible = false;
            btnPagar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void opciones(int opcion, bool BusquedaOK)
        {
            if(BusquedaOK)
            {
                lblNombre.Visible = true;
                lblNombre.Text = persona.Nombre;

                lblApellido.Visible = true;
                lblApellido.Text = persona.Apellido;

                lblDNI.Visible = true;
                lblDNI.Text = persona.Dni.ToString();

                switch (opcion)
                {
                    case 1:
                        lblMonto.Visible = true;
                        btnPagar.Visible = true;
                        btnCancelar.Visible = true;
                        lblMonto.Text = "$ "+abonoBusiness.ObtenerPercioDia();
                        break;
                    case 2:
                        btnPagar.Visible = true;
                        btnCancelar.Visible = true;
                        break;
                    case 3:
                        break;

                }
            }  
        }

        private void btnIgresoDNI_Click(object sender, EventArgs e)
        {
            BusquedaOK = false;

            frmBuscarDNI frmBuscarDNI = new frmBuscarDNI();
            frmBuscarDNI.Owner = this;
            frmBuscarDNI.ShowDialog();
            opciones(opcion, BusquedaOK);
        }

        private void btnPagoDia_Click(object sender, EventArgs e)
        {
            ocultar(true);
            opcion = 1;
        }

        private void btnPagoAbono_Click(object sender, EventArgs e)
        {
            ocultar(true);
            opcion = 2;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ocultar(true);
            opcion = 3;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            ocultar(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ocultar(true);
        }
    }
}
