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
    public partial class frmExamen : Form
    {
        public frmExamen()
        {
            InitializeComponent();
        }

        AsignarAlumnosBusiness asignarAlumnosBusiness = new AsignarAlumnosBusiness();
        TipoExamen tipoExamen = new TipoExamen();
        Examen examen = new Examen();
        ExamenBusiness examenBusiness = new ExamenBusiness();

        private void frmExamen_Load(object sender, EventArgs e)
        {
            cboAnio.DataSource = asignarAlumnosBusiness.listarAnio();
            cboAnio.ValueMember = "IdAnio";
            cboAnio.DisplayMember = "Anio";
            cboAnio.SelectedIndex = -1;

            tipoExamen.IdTipoExamen = 1;
            tipoExamen.NombreTipoExamen = "Parcial";
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

        Cursada cursada = new Cursada();

        public void Actualizar()
        {
            if(rbtnParcial.Checked == true)
            {
                lbNombre.Visible = true;
                txtNombre.Visible = true;
                lbRecuperatorio.Visible = false;
                cboRecuperatorio.Visible = false;

                tipoExamen.IdTipoExamen = 1;
                tipoExamen.NombreTipoExamen = "Parcial";
            }
            else
            if (rbtnRecuperatorio.Checked == true)
            {
                lbNombre.Visible = false;
                txtNombre.Visible = false;
                lbRecuperatorio.Visible = true;
                cboRecuperatorio.Visible = true;

                tipoExamen.IdTipoExamen = 2;
                tipoExamen.NombreTipoExamen = "Recuperatorio";
            }
            else
            if (rbtnFinal.Checked == true)
            {
                lbNombre.Visible = true;
                txtNombre.Visible = true;
                lbRecuperatorio.Visible = false;
                cboRecuperatorio.Visible = false;

                tipoExamen.IdTipoExamen = 3;
                tipoExamen.NombreTipoExamen = "Final";
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccion())
            {
                cursada = asignarAlumnosBusiness.ObtenerIDCursada((AnioLectivo)cboAnio.SelectedItem, (Curso)cboCurso.SelectedItem, (Comision)cboComision.SelectedItem);
                Actualizar();
                txtNombre.Text = "";

                if (rbtnRecuperatorio.Checked == true)
                {
                    cboRecuperatorio.DataSource = examenBusiness.ListarExamenRecuperar(cursada);
                    cboRecuperatorio.ValueMember = "IdExamen";
                    cboRecuperatorio.DisplayMember = "NombreExamen";
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar Año, Curso y Comisión");
            }
        }

        private void cboAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNombre.Visible = false;
            txtNombre.Visible = false;
            lbRecuperatorio.Visible = false;
            cboRecuperatorio.Visible = false;
            txtNombre.Text = "";
        }

        private void cboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNombre.Visible = false;
            txtNombre.Visible = false;
            lbRecuperatorio.Visible = false;
            cboRecuperatorio.Visible = false;
            txtNombre.Text = "";
        }

        private void cboComision_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNombre.Visible = false;
            txtNombre.Visible = false;
            lbRecuperatorio.Visible = false;
            cboRecuperatorio.Visible = false;
            txtNombre.Text = "";
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            lbNombre.Visible = false;
            txtNombre.Visible = false;
            lbRecuperatorio.Visible = false;
            cboRecuperatorio.Visible = false;

        }

        public bool Validar()
        {
            if (cboRecuperatorio.Items.Count == 0 && rbtnRecuperatorio.Checked == true)
            {
                return false;
            }
            else
            if (txtNombre.Text == "" && rbtnParcial.Checked == true)
            {
                return false;
            }
            else
            if (txtNombre.Text == "" && rbtnFinal.Checked == true)
            {
                return false;
            };
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (rbtnRecuperatorio.Checked == true)
                {
                    Examen aux = null;
                    aux = new Examen();

                    aux = (Examen)cboRecuperatorio.SelectedItem;
                    txtNombre.Text = "Rec " + aux.NombreExamen;
                }

                examen.NombreExamen = txtNombre.Text;
                examen.Cursada = cursada;
                examen.Fecha = dtpFecha.Value;
                examen.TipoExamen = tipoExamen;

                examenBusiness.Agregar(examen);

                lbNombre.Visible = false;
                txtNombre.Visible = false;
                lbRecuperatorio.Visible = false;
                cboRecuperatorio.Visible = false;
                txtNombre.Text = "";

            }
            else
            {
                MessageBox.Show("No se pudo Guardar!");
            }
        }
    }
}
