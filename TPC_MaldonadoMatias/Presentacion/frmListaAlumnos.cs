using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class frmListaAlumnos : Form
    {
        public frmListaAlumnos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListaAlumnos_Load(object sender, EventArgs e)
        {
            PersonasBusiness personasBusiness = new PersonasBusiness();

            try
            {
                dgvListaAlumnos.DataSource = personasBusiness.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
