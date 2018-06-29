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
    public partial class frmAtajosProfesor : Form
    {
        public frmAtajosProfesor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TomarLista_Click(object sender, EventArgs e)
        {
            frmTomarLista frm = new frmTomarLista((this.MdiParent as frmMenu).usuario.Persona.IdPersona);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btn_CrearExamen_Click(object sender, EventArgs e)
        {
            frmExamen frm = new frmExamen();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnCargarNota_Click(object sender, EventArgs e)
        {
            frmCargarNota frm = new frmCargarNota((this.MdiParent as frmMenu).usuario.Persona.IdPersona);
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
