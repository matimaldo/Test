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
    public partial class frmTurno : Form
    {
        public frmTurno()
        {
            InitializeComponent();
        }

        HorarioBusiness horarioBusiness = new HorarioBusiness();
        TurnoBusiness turnoBusiness = new TurnoBusiness();
        Horario horario = new Horario();
        Turno turno = new Turno();
       
        private void frmTurno_Load(object sender, EventArgs e)
        {
            turnoBusiness.agregarDgv(dataGridView1);
            dataGridView1.Columns[1].Visible = false;

            cboTurnos.DataSource = turnoBusiness.listar();
            cboTurnos.SelectedIndex = -1;


            dataGridView1.Columns["Desde"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Hasta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Nm_Turno"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["Desde"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Hasta"].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGridView1.AutoResizeColumns();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                lblDesde.Text = dataGridView1.CurrentRow.Cells[2].EditedFormattedValue.ToString();
                lblHasta.Text = dataGridView1.CurrentRow.Cells[3].EditedFormattedValue.ToString();
            }

            catch (System.NullReferenceException)
            {
                lblDesde.Text = "";
                lblHasta.Text = "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            turno = (Turno)cboTurnos.SelectedItem;

            int IDHorario = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].EditedFormattedValue.ToString());

            if (turnoBusiness.Existe(IDHorario))
            {
                turnoBusiness.modificarTurnox(turno.IdTurno, IDHorario);
            }
            else
            {
                turnoBusiness.agregarTurnox(turno.IdTurno, IDHorario);
            }

            turnoBusiness.agregarDgv(dataGridView1);
            dataGridView1.Columns[1].Visible = false;

            cboTurnos.SelectedIndex = -1;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(363, 376);
            btnCerrar.Location = new System.Drawing.Point(152, 348);
            habilitar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(239, 376);
            btnCerrar.Location = new System.Drawing.Point(76, 348);
            deshabilitar();
        }

        public void habilitar()
        {
            btnCancelar.Visible = true;
            lblHorario.Visible = true;
            lblDesde.Visible = true;
            lblHasta.Visible = true;
            btnGuardar.Visible = true;
            cboTurnos.Visible = true;
        }

        public void deshabilitar()
        {
            btnCancelar.Visible = false;
            lblHorario.Visible = false;
            lblDesde.Visible = false;
            lblHasta.Visible = false;
            btnGuardar.Visible = false;
            cboTurnos.Visible = false;
        }
    }
}
