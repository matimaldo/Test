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
    public partial class frmAvisos : Form
    {
        public frmAvisos()
        {
            InitializeComponent();
        }

        AvisosBusiness avisosBusiness = new AvisosBusiness(); 

        private void frmAvisos_Load(object sender, EventArgs e)
        {
            txtCreador.Text = (this.Owner as frmMenu).usuario.Persona.Apno;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            avisosBusiness.agregar(dtpFecha.Value, (this.Owner as frmMenu).usuario.IdUsuario, txtAsunto.Text, txtDetalle.Text);

            MessageBox.Show("Se guardo con Exito!");
        }
    }
}
