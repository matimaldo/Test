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
    public partial class CargaPersona : Form
    {
        public CargaPersona()
        {
            InitializeComponent();
        }

        private void CargaPersona_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as formMenu).btnCargaPersona.Enabled = true;    
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MostrarPersona frm = new MostrarPersona();
            frm.txtNombre.Text = txtNombre.Text;
            frm.txtApellido.Text = txtApellido.Text;
            frm.txtEdad.Text = txtNombre.Text;

            DateTime fecha = dtpFecha.Value;
            int anios = System.DateTime.Now.Year - fecha.Year;
            if (System.DateTime.Now.Subtract(fecha.AddYears(anios)).TotalDays < 0)
                frm.txtEdad.Text = Convert.ToString(anios - 1);
            else
                frm.txtEdad.Text = Convert.ToString(anios);

            frm.txtFecha.Text = dtpFecha.Value.ToShortDateString();

            frm.txtSexo.Text = (string)(rbtnHombre.Checked ? "Hombre" : "Mujer");
            
            foreach (string musica in clbMusica.CheckedItems)
            {
                frm.txtMusica.Text += musica + "\r\n";
            }

            frm.txtColor.Text = cbxColor.Text;

            frm.Owner = this;
            frm.Show();
            btnAceptar.Enabled = false;
            btnBorrar.Enabled = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpFecha.Value = System.DateTime.Now;

            rbtnHombre.Checked = true;
            rbtnMujer.Checked = false;

            for (int i = 0; i < clbMusica.Items.Count; i++)
            {
                clbMusica.SetItemChecked(i, false);
            }

            cbxColor.Text ="";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
