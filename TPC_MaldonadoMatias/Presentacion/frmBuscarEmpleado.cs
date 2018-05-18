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
    public partial class frmBuscarEmpleado : Form
    {
        public frmBuscarEmpleado()
        {
            InitializeComponent();
        }

        private void frmBuscarAlumno_Load(object sender, EventArgs e)
        {
            cboFiltro.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            EmpleadoBusiness empleadoBusiness = new EmpleadoBusiness();
            try
            {
                dgvBusqueda.DataSource = empleadoBusiness.listar(cboFiltro.SelectedIndex, txtBuscar.Text);
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
                (this.Owner as frmEmpleados).empleado = (Empleado)dgvBusqueda.CurrentRow.DataBoundItem;
                (this.Owner as frmEmpleados).rdoBusqueda();

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
