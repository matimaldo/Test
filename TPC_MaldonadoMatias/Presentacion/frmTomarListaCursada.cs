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
    public partial class frmTomarListaCursada : Form
    {
        public frmTomarListaCursada()
        {
            InitializeComponent();
        }

        CursadaBusiness cursadaBusiness = new CursadaBusiness();
        DataGridViewCheckBoxColumn Presente = new DataGridViewCheckBoxColumn();

        private void frmTomarListaCursada_Load(object sender, EventArgs e)
        {

        }

        public void conf_dgv()
        {
            dgvLista.Visible = true;
            //dgvLista.DataSource = null;

            dgvLista.DataSource = cursadaBusiness.listarAlumnos((this.Owner as frmTomarLista).cursada.IdCursada);
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
            dgvLista.Columns["IdPersona"].ReadOnly = true;
            dgvLista.Columns["IdPersona"].HeaderText = "ID";
            dgvLista.Columns["IdPersona"].Width = 30;

            if (dgvLista.Columns.Contains("Presente"))
            {
                dgvLista.Columns.RemoveAt(0);
            }

            DataGridViewCheckBoxColumn Presente = new DataGridViewCheckBoxColumn();


            Presente.HeaderText = "Presente";
            Presente.Name = "Presente";
            dgvLista.Columns.Add(Presente);
        }


        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            btnGuardar.Text = "Guardar";
            dgvLista.Visible = false;

            if (cursadaBusiness.SeTomoLista((this.Owner as frmTomarLista).cursada.IdCursada, DateTime.Parse(dtpDia.Text)))
            {
                DialogResult dialogResult = MessageBox.Show("Ya se Paso la Asistencia. Desea Editar?", "Editar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    conf_dgv();
                    btnGuardar.Text = "Modificar";

                    foreach (DataGridViewRow row in dgvLista.Rows)
                    {
                        row.Cells["Presente"].Value = cursadaBusiness.TraerAsistencia((this.Owner as frmTomarLista).cursada.IdCursada, (int)row.Cells["IdPersona"].Value, DateTime.Parse(dtpDia.Text));
                    }

                }
            }
            else
            {

                conf_dgv();

            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                row.Cells["Presente"].Value = false;
            }

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                int IdCursada = (this.Owner as frmTomarLista).cursada.IdCursada;
                int IdPersona = (int)row.Cells["IdPersona"].Value;
                DateTime Dia = DateTime.Parse(dtpDia.Text);
                bool Presente = (bool)row.Cells["Presente"].Value;

                if (btnGuardar.Text == "Guardar")
                {
                    cursadaBusiness.TomarLista(IdCursada, IdPersona, Dia, Presente);
                }
                else
                {
                    cursadaBusiness.ActualizarLista(IdCursada, IdPersona, Dia, Presente);
                }
            }
            MessageBox.Show("Se guardo Correctamente");
            btnGuardar.Text = "Guardar";
            dgvLista.Visible = false;
        }

        private void dtpDia_ValueChanged(object sender, EventArgs e)
        {
            dgvLista.Visible = false;
        }
    }
}
