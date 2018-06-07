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
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Cursada cursada = new Cursada();

            cursada = (Cursada)cboCursada.SelectedItem;

            if(cursadaBusiness.ValidarAsistencia(cursada.IdCursada))
            {
                cursadaBusiness.ListarAsistencia(dgvAsistencia, cursada.IdCursada);
                dgvAsistencia.Columns["APNO"].HeaderText = "Apellido y Nombre";
            }
            else
            {
                dgvAsistencia.DataSource = null;

                MessageBox.Show("No se tomo lista para esta Cursada!");
            }

        }
    }
}
