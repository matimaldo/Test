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
        public frmHorarios()
        {
            InitializeComponent();
        }

        HorarioBusiness horarioBusiness = new HorarioBusiness();
        Horario horario = new Horario();

        private void frmHorarios_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                if(i<10)
                {
                    cboDesdeHora.Items.Add("0" + i);
                    //cboHastaHora.Items.Add("0" + i);
                }
                else
                {
                    cboDesdeHora.Items.Add(i);
                    //cboHastaHora.Items.Add(i);
                }
            }
            for (int i = 0; i < 51; i += 5)
            {
                if (i < 10)
                {
                    cboDesdeMinuto.Items.Add("0" + i);
                }
                else
                {
                    cboDesdeMinuto.Items.Add(i);
                }
            }

            cboDesdeHora.SelectedIndex = 0;
            cboHastaHora.SelectedIndex = 0;
            cboDesdeMinuto.SelectedIndex = 0;
            cboHastaMinuto.SelectedIndex = 0;

            lbHorarios.DataSource = horarioBusiness.listar();
        }

        private void cboDesdeHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboHastaHora.Items.Clear();

            for (int i = Convert.ToInt32(cboDesdeHora.SelectedItem); i < 24; i++)
            {
                if (i < 10)
                {
                    //cboDesdeHora.Items.Add("0" + i);
                    cboHastaHora.Items.Add("0" + i);
                }
                else
                {
                    //cboDesdeHora.Items.Add(i);
                    cboHastaHora.Items.Add(i);
                }
            }
            cboHastaHora.SelectedIndex = 0;
        }

        private void btnCerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboHastaHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboHastaMinuto.Items.Clear();
            int x = 0;
            
            if (cboDesdeHora.SelectedItem.ToString().CompareTo(cboHastaHora.SelectedItem.ToString()) == 0)
            {
                x = Convert.ToInt32(cboDesdeMinuto.SelectedItem)+5;
            }


            for ( int i = x; i < 56; i += 5)
            {
                if (i < 10)
                {
                    cboHastaMinuto.Items.Add("0" + i);
                }
                else
                {
                    cboHastaMinuto.Items.Add(i);
                }
            }
            cboHastaMinuto.SelectedIndex = 0;
        }

        private void cboDesdeMinuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = 0;

            if (cboDesdeHora.SelectedItem.ToString().CompareTo(cboHastaHora.SelectedItem.ToString()) == 0)
            {
                x = Convert.ToInt32(cboDesdeMinuto.SelectedItem) + 5;

                cboHastaMinuto.Items.Clear();

                for (int i = x; i < 56; i += 5)
                {
                    if (i < 10)
                    {
                        cboHastaMinuto.Items.Add("0" + i);
                    }
                    else
                    {
                        cboHastaMinuto.Items.Add(i);
                    }
                }
                cboHastaMinuto.SelectedIndex = 0;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            int dh = Convert.ToInt32(cboDesdeHora.SelectedItem);
            int dm = Convert.ToInt32(cboDesdeMinuto.SelectedItem);
            int hh = Convert.ToInt32(cboHastaHora.SelectedItem);
            int hm = Convert.ToInt32(cboHastaMinuto.SelectedItem);

            horario.Desde = new DateTime(1990, 01, 01, dh, dm, 0);
            horario.Hasta = new DateTime(1990, 01, 01, hh, hm, 0);

            horarioBusiness.agregar(horario);

            lbHorarios.DataSource = horarioBusiness.listar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                horario = (Horario)lbHorarios.SelectedItem;

                horarioBusiness.eliminar(horario);

                lbHorarios.DataSource = horarioBusiness.listar();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("No se puede eliminar porque tiene Cursos Asignados!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
