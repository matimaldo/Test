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
    public partial class frmCursada : Form
    {
        public frmCursada()
        {
            InitializeComponent();
        }

        private void cbxLunes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLunes.Checked == true)
                lbLunes.Visible = true;
            else
            {
                lbLunes.Visible = false;
                for (int i = 0; i < lbLunes.Items.Count; i++)
                    lbLunes.SetSelected(i, false);
            }           
        }

        private void cbxMartes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMartes.Checked == true)
                lbMartes.Visible = true;
            else
            {
                lbMartes.Visible = false;
                for (int i = 0; i < lbMartes.Items.Count; i++)
                    lbMartes.SetSelected(i, false);
            }
        }

        private void cbxMiercoles_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMiercoles.Checked == true)
                lbMiercoles.Visible = true;
            else
            {
                lbMiercoles.Visible = false;
                for (int i = 0; i < lbMiercoles.Items.Count; i++)
                    lbMiercoles.SetSelected(i, false);
            }
        }

        private void cbxJueves_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxJueves.Checked == true)
                lbJueves.Visible = true;
            else
            {
                lbJueves.Visible = false;
                for (int i = 0; i < lbJueves.Items.Count; i++)
                    lbJueves.SetSelected(i, false);
            }
        }

        private void cbxViernes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxViernes.Checked == true)
                lbViernes.Visible = true;
            else
            {
                lbViernes.Visible = false;
                for (int i = 0; i < lbViernes.Items.Count; i++)
                    lbViernes.SetSelected(i, false);
            }
        }

        private void cbxSabado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSabado.Checked == true)
                lbSabado.Visible = true;
            else
            {
                lbSabado.Visible = false;
                for (int i = 0; i < lbSabado.Items.Count; i++)
                    lbSabado.SetSelected(i, false);
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            frmCopiarCursada frm = new frmCopiarCursada();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
