using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void btnCargaPersona_Click(object sender, EventArgs e)
        {
            //this.Hide();

            CargaPersona frm = new CargaPersona();
            frm.Owner = this;
            frm.Show();
            btnCargaPersona.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            ListadoObjetos frm = new ListadoObjetos();
            frm.Owner = this;
            frm.Show();
            btnListado.Enabled = false;

        }
    }
}
