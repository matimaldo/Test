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
    public partial class frmAtajoAdministrativo : Form
    {
        public frmAtajoAdministrativo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TomarLista_Click(object sender, EventArgs e)
        {
            frmAlumnos frm = new frmAlumnos();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btn_CrearExamen_Click(object sender, EventArgs e)
        {
            frmEmpleados frm = new frmEmpleados();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
