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
            lbHorarios.DataSource = diasBusiness.listarDisponible(dia);
            lbHorariosCargado.DataSource = diasBusiness.listarCargado(dia);
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
            diasBusiness.agregar(dia, (Horario)lbHorarios.SelectedItem);
            if(dia != 0)
            {
                listar();
            }

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            diasBusiness.eliminar(dia, (Horario)lbHorariosCargado.SelectedItem);
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
    }
}
