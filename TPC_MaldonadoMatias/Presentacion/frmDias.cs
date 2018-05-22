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
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class frmDias : Form
    {
        public frmDias()
        {
            InitializeComponent();
        }

        DiasBusiness diasBusiness = new DiasBusiness();
        int dia;

        //Pendiente configurar el por defecto

        public void listar()
        {
            mlbHorarios.DataSource = diasBusiness.listarDisponible(dia);
            mlbHorariosCargado.DataSource = diasBusiness.listarCargado(dia);
        }

        private void btnLunes_Click(object sender, EventArgs e)
        {
            dia = 1;
            btnLunes.BackColor = Color.Tomato ;
            btnMartes.BackColor = Color.Transparent;
            btnMiercoles.BackColor = Color.Transparent;
            btnJueves.BackColor = Color.Transparent;
            btnViernes.BackColor = Color.Transparent;
            btnSabado.BackColor = Color.Transparent;

            listar();
        }

        private void btnMartes_Click(object sender, EventArgs e)
        {
            dia = 2;
            btnLunes.BackColor = Color.Transparent;
            btnMartes.BackColor = Color.Tomato;
            btnMiercoles.BackColor = Color.Transparent;
            btnJueves.BackColor = Color.Transparent;
            btnViernes.BackColor = Color.Transparent;
            btnSabado.BackColor = Color.Transparent;

            listar();
        }

        private void btnMiercoles_Click(object sender, EventArgs e)
        {
            dia = 3;
            btnLunes.BackColor = Color.Transparent;
            btnMartes.BackColor = Color.Transparent;
            btnMiercoles.BackColor = Color.Tomato;
            btnJueves.BackColor = Color.Transparent;
            btnViernes.BackColor = Color.Transparent;
            btnSabado.BackColor = Color.Transparent;

            listar();
        }

        private void btnJueves_Click(object sender, EventArgs e)
        {
            dia = 4;
            btnLunes.BackColor = Color.Transparent;
            btnMartes.BackColor = Color.Transparent;
            btnMiercoles.BackColor = Color.Transparent;
            btnJueves.BackColor = Color.Tomato;
            btnViernes.BackColor = Color.Transparent;
            btnSabado.BackColor = Color.Transparent;

            listar();
        }

        private void btnViernes_Click(object sender, EventArgs e)
        {
            dia = 5;
            btnLunes.BackColor = Color.Transparent;
            btnMartes.BackColor = Color.Transparent;
            btnMiercoles.BackColor = Color.Transparent;
            btnJueves.BackColor = Color.Transparent;
            btnViernes.BackColor = Color.Tomato;
            btnSabado.BackColor = Color.Transparent;

            listar();
        }

        private void btnSabado_Click(object sender, EventArgs e)
        {
            dia = 6;
            btnLunes.BackColor = Color.Transparent;
            btnMartes.BackColor = Color.Transparent;
            btnMiercoles.BackColor = Color.Transparent;
            btnJueves.BackColor = Color.Transparent;
            btnViernes.BackColor = Color.Transparent;
            btnSabado.BackColor = Color.Tomato;

            listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            diasBusiness.agregar(dia, (Horario)mlbHorarios.SelectedItem);
            if(dia != 0)
            {
                listar();
            }

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            diasBusiness.eliminar(dia, (Horario)mlbHorariosCargado.SelectedItem);
            if (dia != 0)
            {
                listar();
            }
        }

        private void btnSacarTodo_Click(object sender, EventArgs e)
        {
            if (dia != 0)
            {
                diasBusiness.eliminarTodo(dia);
                listar();
            }
            else
            {
                MessageBox.Show("No hay Horarios Disponibles para Sacar");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDias_Load(object sender, EventArgs e)
        {
            diasBusiness.agregarDgv(dgvDiaxHorario);

            dgvDiaxHorario.Columns["Martes"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDiaxHorario.Columns["Miercoles"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDiaxHorario.Columns["Lunes"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDiaxHorario.Columns["Jueves"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDiaxHorario.Columns["Viernes"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDiaxHorario.Columns["Sabado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDiaxHorario.Columns["Desde"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDiaxHorario.Columns["Hasta"].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvDiaxHorario.AutoResizeColumns();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvDiaxHorario.Visible = false;
            btnVolver.Visible = true;
            btnLunes.Visible = true;
            btnSabado.Visible = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            btnLunes.Visible = false;
            btnSabado.Visible = false;
            dgvDiaxHorario.Visible = true;
            diasBusiness.agregarDgv(dgvDiaxHorario);
            btnVolver.Visible = false;
        }
    }
}
