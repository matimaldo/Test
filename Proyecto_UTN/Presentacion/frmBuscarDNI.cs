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
using Dominio;

namespace Presentacion
{
    public partial class frmBuscarDNI : Form
    {
        public frmBuscarDNI()
        {
            InitializeComponent();
        }

        PersonaBusiness PersonaBusiness = new PersonaBusiness();
        Persona aux = new Persona();

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            aux = PersonaBusiness.Obtener(int.Parse(txtDNI.Text));

            if (aux.IdPersona != 0)
            {
                (this.Owner as frmVehiculo).persona = aux;
                (this.Owner as frmVehiculo).ocultar(false);
                (this.Owner as frmVehiculo).BusquedaOK =true;
                Close();
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void frmBuscarDNI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //(this.Owner as frmVehiculo).BusquedaOK = true;
        }
    }
}
