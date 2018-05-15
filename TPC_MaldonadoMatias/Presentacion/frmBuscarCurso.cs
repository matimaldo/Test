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
    public partial class frmBuscarCurso : Form
    {
        public frmBuscarCurso()
        {
            InitializeComponent();
        }

        private void frmBuscarCurso_Load(object sender, EventArgs e)
        {
            cboFiltro.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CursoBusiness cursoBusiness = new CursoBusiness();
            try
            {

                dgvBusqueda.DataSource = cursoBusiness.listar(cboFiltro.SelectedIndex, txtBuscar.Text);

                dgvBusqueda.Columns[0].Width = 40;
                dgvBusqueda.Columns[1].Width = 227;
                dgvBusqueda.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                (this.Owner as frmCursos).curso = (Curso)dgvBusqueda.CurrentRow.DataBoundItem;
                (this.Owner as frmCursos).rdoBusqueda();

                this.Close();
            }

            catch (System.NullReferenceException)
            {
                MessageBox.Show("Seleccione un Curso");
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
