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

        ExamenBusiness examenBusiness = new ExamenBusiness();
        CursadaBusiness cursadaBusiness = new CursadaBusiness();

        private void frmCargarNotas_Load(object sender, EventArgs e)
        {
            cboExamen.DataSource = examenBusiness.ListarExamen((this.Owner as frmCargarNota).cursada);
            cboExamen.ValueMember = "IdExamen";
            cboExamen.DisplayMember = "NombreExamen";
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (false)
            {
                //MessageBox.Show("Ya se Cargaron las Notas");
            }
            else
            {

                dgvLista.Visible = true;
                //dgvLista.DataSource = null;

                dgvLista.DataSource = cursadaBusiness.listarAlumnos((this.Owner as frmCargarNota).cursada.IdCursada);
                dgvLista.Columns["Apno"].HeaderText = "Alumno";
                dgvLista.Columns["Apno"].Width = 200;
                dgvLista.Columns["Apno"].ReadOnly = true;

                dgvLista.Columns["Telefono"].Visible = false;
                dgvLista.Columns["Estado"].Visible = false;
                dgvLista.Columns["Sexo"].Visible = false;
                dgvLista.Columns["Apellido"].Visible = false;
                dgvLista.Columns["Nombre"].Visible = false;
                dgvLista.Columns["DNI"].Visible = false;
                dgvLista.Columns["FechaNac"].Visible = false;
                dgvLista.Columns["Mail"].Visible = false;
                dgvLista.Columns["IdPersona"].Visible = true;
                dgvLista.Columns["IdPersona"].Width = 200;
                dgvLista.Columns["IdPersona"].ReadOnly = true;


                if (dgvLista.Columns.Contains("Nota"))
                {
                    dgvLista.Columns.RemoveAt(0);
                }

                DataGridViewTextBoxColumn Nota = new DataGridViewTextBoxColumn();

                Nota.HeaderText = "Nota";
                Nota.Name = "Nota";
                dgvLista.Columns.Add(Nota);

                foreach (DataGridViewRow row in dgvLista.Rows)
                {
                    row.Cells["Nota"].Value = "";
                }

            }
        }

        public void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;

            dText.KeyPress -= new KeyPressEventHandler(dText_KeyPress);
            dText.KeyPress += new KeyPressEventHandler(dText_KeyPress);
        }

        void dText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                Examen examen = new Examen();
                examen = (Examen)cboExamen.SelectedItem;
                int IdPersona = (int)row.Cells["IdPersona"].Value;
                int Nota;
                if (row.Cells["Nota"].Value.ToString() == "")
                {
                    Nota = 0;
                }
                else
                {
                    Nota = int.Parse(row.Cells["Nota"].Value.ToString());
                }

                examenBusiness.AgregarNota(examen.IdExamen, IdPersona, Nota);

            }
            MessageBox.Show("Se guardo Correctamente");
            dgvLista.Visible = false;
        }
    }
}
