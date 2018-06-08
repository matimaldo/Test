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
    public partial class frmCursos : Form
    {
        public frmCursos()
        {
            InitializeComponent();
        }

        public Curso curso = new Curso();
        CursoBusiness cursoBusiness = new CursoBusiness();


        public void habilitar()
        {
            txtNmCurso.Visible = true;

            btnAnterior.Visible = true;
            btnSiguiente.Visible = true;
            btnPrimero.Visible = true;
            btnUltimo.Visible = true;

            ErrorNombre.Clear();


        }

        public void deshabilitar()
        {
            txtNmCurso.Visible = false;
            btnGuardar.Visible = false;

        }

        public void nuevo()
        {
            txtNmCurso.Text = "";
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

            curso.IdCurso = 0;
            eliminarToolStripMenuItem.Visible = false;
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarCurso frm = new frmBuscarCurso();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            habilitar();
            nuevo();
            btnGuardar.Text = "Guardar";
        }

        public void rdoBusqueda()
        {

            habilitar();

            lblNroId.Text = curso.IdCurso.ToString();
            txtNmCurso.Text = curso.NombreCurso;
            
            btnCerrar.Location = new System.Drawing.Point(186, 87);

            lblNroId.Visible = true;
            lblId.Visible = true;

            btnCancelar.Visible = false;
            btnGuardar.Text = "Modificar";
            btnGuardar.Visible = true;

            if (curso.IdCurso < cursoBusiness.obtenerIDMax())
            {
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
            }

            if (cursoBusiness.obtenerIDMin() < curso.IdCurso)
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

            btnCerrar.Location = new Point(132, 86);
            btnCancelar.Visible = false;
            lblNroId.Text = "0";
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            curso = cursoBusiness.IrA(0, curso.IdCurso);
            rdoBusqueda();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            curso = cursoBusiness.IrA(1, curso.IdCurso);
            rdoBusqueda();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            curso = cursoBusiness.IrA(2, curso.IdCurso);
            rdoBusqueda();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            curso = cursoBusiness.IrA(3, curso.IdCurso);
            rdoBusqueda();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Validar()
        {
            bool ok = true;
            if (txtNmCurso.Text == "")
            {
                ErrorNombre.SetError(txtNmCurso, "Ingrese Nombre de Curso");
                ok = false;
            }
            else
            {
                ErrorNombre.Clear();
            }
            return ok;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                try
                {
                    curso.NombreCurso = txtNmCurso.Text;

                    if (btnGuardar.Text == "Guardar")
                    {
                        if (cursoBusiness.ValidarIngreso(curso.NombreCurso))
                        {
                            cursoBusiness.agregar(curso);

                            MessageBox.Show("Agregado con éxito");
                            nuevo();
                        }
                        else
                        {
                            MessageBox.Show("El Nombre de Curso ya Existe!");

                        }
                    }
                    else // Modificar Persona
                        {
                        //if (cursoBusiness.ValidarIngreso(curso.NombreCurso))
                        //{
                            cursoBusiness.modificar(curso);

                            MessageBox.Show("Modificado con éxito");
                        //}
                        //else
                        //{
                        //    MessageBox.Show("El Nombre de Curso ya Existe!");

                        //}
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Complete Datos minimos");
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta Seguro que desea Eliminar?", "Eliminar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cursoBusiness.eliminar(curso);

                deshabilitar();
                btnSiguiente.Visible = true;
                btnSiguiente.Enabled = true;
                btnAnterior.Visible = true;
                btnAnterior.Enabled = false;

                btnUltimo.Visible = true;
                btnUltimo.Enabled = true;

                btnPrimero.Visible = true;
                btnPrimero.Enabled = false;

                //btnSalir.Location = new Point(107, 370);
                btnCancelar.Visible = false;
                lblNroId.Text = "0";

                lblId.Visible = false;
                lblNroId.Visible = false;

                eliminarToolStripMenuItem.Visible = false;
            }
        }
    }  
}
