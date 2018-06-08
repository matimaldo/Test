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
    public partial class frmEnviarMail : Form
    {
        public frmEnviarMail()
        {
            InitializeComponent();
        }

        CursadaBusiness cursadaBusiness = new CursadaBusiness();

        private void rbtnCurso_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnCurso.Checked == true)
            {
                cboCursada.Enabled = true;
            }
            else
            {
                cboCursada.Enabled = false;
            }
        }

        private void frmEnviarMail_Load(object sender, EventArgs e)
        {
            cboCursada.DataSource = cursadaBusiness.listar();
            cboCursada.ValueMember = "IdCursada";
            cboCursada.DisplayMember = "ACC";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se Envio Correctamente!");
            txtAsunto.Text = "";
            txtDetalle.Text = "";
        }
    }
}
