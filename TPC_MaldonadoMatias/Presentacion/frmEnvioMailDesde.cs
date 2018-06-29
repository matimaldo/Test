using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class frmEnvioMailDesde : Form
    {
        public frmEnvioMailDesde()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            (this.Owner as frmEnviarMail).Enviar = false;
        }

        public bool validar()
        {
            bool ok = true;
            // AlfaNum@AlfaNum.com
            Regex RX = new Regex("^[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$");

            if (!RX.IsMatch(txtMail.Text))
            {
                ErrorMail.SetError(txtMail, "Ingrese Mail con formato correcto(AlfaNum@AlfaNum.com)");
                ok = false;
            }
            else
            {
                ErrorMail.Clear();
            }

            if (txtClave.Text == "")
            {
                ErrorMail.SetError(txtClave, "Ingrese Contraseña)");
                ok = false;
            }
            else
            {
                ErrorMail.Clear();
            }

            return ok;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                (this.Owner as frmEnviarMail).Desde = txtMail.Text;
                (this.Owner as frmEnviarMail).Clave = txtClave.Text;
                (this.Owner as frmEnviarMail).Enviar = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Complete los Datos Correctamente!");
            }

        }

        private void frmEnvioMailDesde_Load(object sender, EventArgs e)
        {
            (this.Owner as frmEnviarMail).Enviar = false;
        }
    }
}
