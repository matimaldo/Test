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
    public partial class frmBuscarAlumno : Form
    {
        public frmBuscarAlumno()
        {
            InitializeComponent();
        }

        private void frmBuscarAlumno_Load(object sender, EventArgs e)
        {
            cboFiltro.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PersonasBusiness personasBusiness = new PersonasBusiness();
            try
            {
                dgvBusqueda.DataSource = personasBusiness.listar(cboFiltro.SelectedIndex,txtBuscar.Text);
                dgvBusqueda.Columns[0].Visible = false;
                dgvBusqueda.Columns[4].Visible = false;
                dgvBusqueda.Columns[5].Visible = false;
                dgvBusqueda.Columns[8].Visible = false;

                dgvBusqueda.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                (this.Owner as frmAlumnos).alumno = (Alumno)dgvBusqueda.CurrentRow.DataBoundItem;
                (this.Owner as frmAlumnos).rdoBusqueda();
 
                this.Close();
            }

            catch (System.NullReferenceException)
            {
                MessageBox.Show("Seleccione un Alumno");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }

        }
    }
}
