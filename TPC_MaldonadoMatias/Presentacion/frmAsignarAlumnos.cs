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
    public partial class frmAsignarAlumnos : Form
    {
        public frmAsignarAlumnos()
        {
            InitializeComponent();
        }

        AsignarAlumnosBusiness asignarAlumnosBusiness = new AsignarAlumnosBusiness();

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarCursada frm = new frmBuscarCursada();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void frmAsignarAlumnos_Load(object sender, EventArgs e)
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

            if (cboComision.SelectedIndex ==-1)
                return false;

            return true;
        }

        Cursada cursada = new Cursada();


        public void Actualizar ()
        {
            lbDisponible.DataSource = asignarAlumnosBusiness.listarAlumnosDisponibles();
            lbDisponible.ValueMember = "IdPersona";
            lbDisponible.DisplayMember = "Apno";

            lbEnCurso.DataSource = asignarAlumnosBusiness.listarAlumnosEnCurso(cursada.IdCursada);
            lbEnCurso.ValueMember = "IdPersona";
            lbEnCurso.DisplayMember = "Apno";

            lblCantEnCurso.Text = lbEnCurso.Items.Count.ToString();
            lblCantMax.Text = cursada.CantidadMaxima.ToString();

            if (lbEnCurso.Items.Count == cursada.CantidadMaxima)
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(ValidarSeleccion())
            {
                cursada = asignarAlumnosBusiness.ObtenerIDCursada((AnioLectivo)cboAnio.SelectedItem, (Curso)cboCurso.SelectedItem, (Comision)cboComision.SelectedItem);
                Actualizar();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar Año, Curso y Comisión");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lbDisponible.SelectedItems.Count > 0)
            {
                asignarAlumnosBusiness.Agregar(cursada.IdCursada, (Alumno)lbDisponible.SelectedItem);
                Actualizar();
            }
            else
                MessageBox.Show("Debe Seleccionar un Alumno");



        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (lbEnCurso.SelectedItems.Count > 0)
            {
                asignarAlumnosBusiness.Eliminar(cursada.IdCursada, (Alumno)lbEnCurso.SelectedItem);
                Actualizar();
            }
            else
                MessageBox.Show("Debe Seleccionar un Alumno");
                

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDisponible.DataSource = null;
            lbEnCurso.DataSource = null;
        }

        private void cboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDisponible.DataSource = null;
            lbEnCurso.DataSource = null;
        }

        private void cboComision_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDisponible.DataSource = null;
            lbEnCurso.DataSource = null;
        }
    }
}
