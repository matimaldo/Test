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

namespace Presentacion
{
    public partial class frmCalendario : Form
    {
        public frmCalendario()
        {
            InitializeComponent();
        }

        CalendarioBusiness calendarioBusiness = new CalendarioBusiness();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarCumpleaños()
        {
            foreach (DateTime fecha in calendarioBusiness.listar())
            {
                mhcCalendario.AddAnnuallyBoldedDate(fecha);
            }
        }

        public void cargarAvisos()
        {   
            lbxAvisos.DataSource = calendarioBusiness.Avisos(mhcCalendario.SelectionStart);
        }

        private void frmCalendario_Load(object sender, EventArgs e)
        {
            lblAviso.Text = "Avisos para " + DateTime.Today.ToString("dd/MM/yyyy");
            cargarCumpleaños();
            cargarAvisos();
            mhcCalendario.UpdateBoldedDates();
            

            //mhcCalendario.;
        }

        private void mhcCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblAviso.Text = "Avisos para " + mhcCalendario.SelectionStart.ToString("dd/MM/yyyy");
            cargarCumpleaños();
            cargarAvisos();

        }
    }
}
