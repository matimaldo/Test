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
    public partial class frmAsistencia : Form
    {
        public frmAsistencia()
        {
            InitializeComponent();
        }
        CursadaBusiness cursadaBusiness = new CursadaBusiness();

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            cboCursada.DataSource = cursadaBusiness.listarxProfesor((this.Owner as frmMenu).usuario.Persona.IdPersona);
            cboCursada.ValueMember = "IdCursada";
            cboCursada.DisplayMember = "ACC";
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Cursada cursada = new Cursada();

            cursada = (Cursada)cboCursada.SelectedItem;

            if(cursadaBusiness.ValidarAsistencia(cursada.IdCursada))
            {
                dgvAsistencia.Visible = true;
                cursadaBusiness.ListarAsistencia(dgvAsistencia, cursada.IdCursada);
                dgvAsistencia.Columns["APNO"].HeaderText = "Apellido y Nombre";
            }
            else
            {
                dgvAsistencia.DataSource = null;

                MessageBox.Show("No se tomo lista para esta Cursada!");
            }

        }

        private void cboCursada_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvAsistencia.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
