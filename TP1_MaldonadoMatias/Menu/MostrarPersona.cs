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
    public partial class MostrarPersona : Form
    {
        public MostrarPersona()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarPersona_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as CargaPersona).btnAceptar.Enabled = true;
            (this.Owner as CargaPersona).btnBorrar.Enabled = true;
        }
    }
}
