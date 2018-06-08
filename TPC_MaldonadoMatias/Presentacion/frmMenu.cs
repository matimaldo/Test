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

namespace Presentacion
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        public Usuario usuario = new Usuario();
        public bool CambioUsuario = false;

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Owner = this;
            frm.ShowDialog();
            academiaToolStripMenuItem.Visible = false;

            frmCalendario frmCalendario = new frmCalendario();
            frmCalendario.MdiParent = this;
            frmCalendario.Show();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos frm = new frmAlumnos();
            frm.Owner = this;
            frm.ShowDialog();

            //alumnoToolStripMenuItem.Enabled = false;
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados frm = new frmEmpleados();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void cursadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCursada frm = new frmCursada();
            frm.Owner = this;
            frm.Show();
        }

        private void cursoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCursos frm = new frmCursos();
            frm.Owner = this;
            frm.Show();
        }

        private void avisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAvisos frm = new frmAvisos();
            frm.Owner = this;
            frm.Show();
        }

        private void asignacionAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignarAlumnos frm = new frmAsignarAlumnos();
            frm.Owner = this;
            frm.Show();
        }

        private void academiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcademia frm = new frmAcademia();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void añosLectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnioLectivo frm = new frmAnioLectivo();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void aulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAulas frm = new frmAulas();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void diaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDias frm = new frmDias();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void horarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHorarios frm = new frmHorarios();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void tomarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTomarLista frm = new frmTomarLista();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void examenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExamen frm = new frmExamen();
            frm.Owner = this;
            frm.ShowDialog();

        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarNotas frm = new frmCargarNotas();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void envioMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnviarMail frm = new frmEnviarMail();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaAlumnos frm = new frmListaAlumnos();
            frm.Owner = this;
            frm.ShowDialog();

        }

        private void envioNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnvioNotas frm = new frmEnvioNotas();
            frm.Owner = this;
            frm.ShowDialog();

        }

        private void comisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComision frm = new frmComision();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void turnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTurno frm = new frmTurno();
            frm.Owner = this;
            frm.ShowDialog();

        }

        private void calendarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(frmCalendario))
                {
                    MessageBox.Show("El Calendario esta abierto");
                    abierto = true;
                    break;
                }
            }

            if (!abierto)
            {
                frmCalendario frmCalendario = new frmCalendario();
                frmCalendario.MdiParent = this;
                frmCalendario.Show();
            }
        }

        public void Actualizar()
        {
            string msjUsuario = usuario.Persona.Apellido + ", " + usuario.Persona.Nombre + " (" + usuario.NMUsuario + ") - " + usuario.Rol.NMRol;
            toolStripStatusLabel1.Text = msjUsuario;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Owner = this;
            frm.ShowDialog();

        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsistencia frm = new frmAsistencia();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarEmpleados frm = new frmListarEmpleados();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
