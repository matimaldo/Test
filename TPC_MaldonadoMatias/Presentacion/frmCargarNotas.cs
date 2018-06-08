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
    public partial class frmCargarNotas : Form
    {
        public frmCargarNotas()
        {
            InitializeComponent();
        }

        AsignarAlumnosBusiness asignarAlumnosBusiness = new AsignarAlumnosBusiness();


        private void frmCargarNotas_Load(object sender, EventArgs e)
        {
            cboAnio.DataSource = asignarAlumnosBusiness.listarAnio();
            cboAnio.ValueMember = "IdAnio";
            cboAnio.DisplayMember = "Anio";
            cboAnio.SelectedIndex = -1;
        }

        private void cboAnio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboCurso.DataSource = asignarAlumnosBusiness.listarCurso((AnioLectivo)cboAnio.SelectedItem);
            cboCurso.ValueMember = "IdCurso";
            cboCurso.DisplayMember = "NombreCurso";
            cboCurso.SelectedIndex = -1;
            cboComision.DataSource = null;
            cboComision.SelectedIndex = -1;

        }

        private void cboCurso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboComision.DataSource = asignarAlumnosBusiness.listarComision((AnioLectivo)cboAnio.SelectedItem, (Curso)cboCurso.SelectedItem);
            cboComision.ValueMember = "IdComision";
            cboComision.DisplayMember = "NombreComision";
            cboComision.SelectedIndex = -1;
        }

        public bool ValidarSeleccion()
        {
            if (cboAnio.SelectedIndex == -1)
                return false;

            if (cboCurso.SelectedIndex == -1)
                return false;

            if (cboComision.SelectedIndex == -1)
                return false;

            return true;
        }


        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccion())
            {
                //cursada = asignarAlumnosBusiness.ObtenerIDCursada((AnioLectivo)cboAnio.SelectedItem, (Curso)cboCurso.SelectedItem, (Comision)cboComision.SelectedItem);
                //Actualizar();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar Año, Curso y Comisión");
            }
        }
    }
}
