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
    public partial class frmHorarios : Form
    {
        HorarioBusiness horarioBusiness = new HorarioBusiness();
        Horario horario = new Horario();

        public frmHorarios()
        {
            InitializeComponent();
        }

        private void frmHorarios_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 22; i++)
            {
                if (i < 10)
                {
                    cboDesdeHora.Items.Add("0" + i + ":00");
                }
                else
                {
                    cboDesdeHora.Items.Add(i + ":00");
                }
            }
            cboDesdeHora.SelectedIndex = 0;
            cboHastaHora.SelectedIndex = 0;

            lbHorario.DataSource = horarioBusiness.listar();
            lbHorario.SelectedIndex = -1;

        }

        private void cboDesdeHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboHastaHora.Items.Clear();
            int hora = DateTime.Parse(cboDesdeHora.SelectedItem.ToString()).Hour+1;

            //for (int i = hora + 1; i < 24; i++)
            //{
            if (hora < 10)
            {
                cboHastaHora.Items.Add("0"+ hora +":00");
            }
            else
            {
                cboHastaHora.Items.Add(hora +":00");
            }
            //}
            cboHastaHora.SelectedIndex = 0;
        }

        public bool validar(DateTime horaDesde)
        {
            foreach (Horario item in horarioBusiness.listar())
            {
                if (horaDesde == item.Desde)
                    return false;
            }
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            horario.Desde = new DateTime(1990, 01, 01, DateTime.Parse(cboDesdeHora.SelectedItem.ToString()).Hour, 0, 0);
            horario.Hasta = new DateTime(1990, 01, 01, DateTime.Parse(cboHastaHora.SelectedItem.ToString()).Hour, 0, 0);

            if (validar(horario.Desde))
                horarioBusiness.agregar(horario);
            else
                MessageBox.Show("Este Horario ya existe!");

            lbHorario.DataSource = horarioBusiness.listar();
            lbHorario.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lbHorario.SelectedIndex != -1)
            {
                try
                {
                    horario = (Horario)lbHorario.SelectedItem;

                    horarioBusiness.eliminar(horario);

                    lbHorario.DataSource = horarioBusiness.listar();
                    lbHorario.SelectedIndex = -1;
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                        MessageBox.Show("No se puede eliminar porque esta siendo utilizado!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
                MessageBox.Show("Selecciones un Horario");
        }

        private void btnCerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            habilitar();
        }

        public void habilitar()
        {
            lblDesde.Visible = true;
            lblHasta.Visible = true;
            cboDesdeHora.Visible = true;
            cboHastaHora.Visible = true;
            btnAgregar.Visible = true;
            btnEliminar.Visible = true;
            lbHorario.Location = new System.Drawing.Point(205, 44);
            lbHorario.Size = new System.Drawing.Size(89, 121);
            btnCancelar.Visible = true;

            lbHorario.DataSource = horarioBusiness.listar();
            lbHorario.SelectedIndex = -1;

        }

        public void deshabilitar()
        {
            lblDesde.Visible = false;
            lblHasta.Visible = false;
            cboDesdeHora.Visible = false;
            cboHastaHora.Visible = false;
            btnAgregar.Visible = false;
            btnEliminar.Visible = false;
            lbHorario.Location = new System.Drawing.Point(20, 44);
            lbHorario.Size = new System.Drawing.Size(278, 121);
            btnCancelar.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitar();
        }
    }
}