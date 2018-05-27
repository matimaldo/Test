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
    public partial class frmAulas : Form
    {
        public frmAulas()
        {
            InitializeComponent();
        }


        public Aula curso = new Aula();
        AulaBusiness cursoBusiness = new AulaBusiness();


        public void habilitar()
        {
            txtNmCurso.Visible = true;
            txtCantidad.Visible = true;

            btnAnterior.Visible = true;
            btnSiguiente.Visible = true;
            btnPrimero.Visible = true;
            btnUltimo.Visible = true;

        }

        public void deshabilitar()
        {
            txtNmCurso.Visible = false;
            txtCantidad.Visible = false;
            btnGuardar.Visible = false;

        }

        public void nuevo()
        {
            txtNmCurso.Text = "";
            txtCantidad.Text = "";
            btnAnterior.Visible = false;
            btnSiguiente.Visible = false;
            btnUltimo.Visible = false;
            btnPrimero.Visible = false;

            btnGuardar.Visible = true;
            btnCerrar.Location = new Point(186, 87);
            btnCancelar.Visible = true;

            lblNroId.Visible = false;
            lblId.Visible = false;

            lblNroId.Text = "";

            txtNmCurso.Focus();

            curso.IdAula = 0;
            eliminarToolStripMenuItem.Visible = false;
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmBuscarCurso frm = new frmBuscarCurso();
            //frm.Owner = this;
            //frm.ShowDialog();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            habilitar();
            nuevo();
            btnGuardar.Text = "Guardar";
        }

        public void rdoBusqueda()
        {
            //CursoBusiness cursoBusiness = new CursoBusiness();

            habilitar();

            lblNroId.Text = curso.IdAula.ToString();
            txtNmCurso.Text = curso.NombreAula;
            txtCantidad.Text = curso.Cantidad.ToString();

            btnCerrar.Location = new System.Drawing.Point(186, 87);

            lblNroId.Visible = true;
            lblId.Visible = true;

            btnCancelar.Visible = false;
            btnGuardar.Text = "Modificar";
            btnGuardar.Visible = true;

            if (curso.IdAula < cursoBusiness.obtenerIDMax())
            {
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
            }

            if (cursoBusiness.obtenerIDMin() < curso.IdAula)
            {
                btnAnterior.Enabled = true;
                btnPrimero.Enabled = true;
            }
            else
            {
                btnAnterior.Enabled = false;
                btnPrimero.Enabled = false;
            }

            eliminarToolStripMenuItem.Visible = true;

            txtNmCurso.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitar();
            btnSiguiente.Visible = true;
            btnSiguiente.Enabled = true;
            btnAnterior.Visible = true;
            btnAnterior.Enabled = false;

            btnUltimo.Visible = true;
            btnUltimo.Enabled = true;

            btnPrimero.Visible = true;
            btnPrimero.Enabled = false;

            btnCerrar.Location = new Point(134, 87);
            btnCancelar.Visible = false;
            lblNroId.Text = "0";
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            curso = cursoBusiness.IrA(0, curso.IdAula);
            rdoBusqueda();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            curso = cursoBusiness.IrA(1, curso.IdAula);
            rdoBusqueda();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            curso = cursoBusiness.IrA(2, curso.IdAula);
            rdoBusqueda();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            curso = cursoBusiness.IrA(3, curso.IdAula);
            rdoBusqueda();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                curso.NombreAula = txtNmCurso.Text;
                curso.Cantidad = int.Parse(txtCantidad.Text);

                if (btnGuardar.Text == "Guardar")
                {
                    cursoBusiness.agregar(curso);

                    MessageBox.Show("Agregado con éxito");
                    nuevo();
                }
                else // Modificar Persona
                {
                    cursoBusiness.modificar(curso);

                    MessageBox.Show("Modificado con éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
