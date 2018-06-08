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


        public Aula aula = new Aula();
        AulaBusiness aulaBusiness = new AulaBusiness();


        public void habilitar()
        {
            txtNmAula.Visible = true;

            btnAnterior.Visible = true;
            btnSiguiente.Visible = true;
            btnPrimero.Visible = true;
            btnUltimo.Visible = true;

            ErrorNombre.Clear();
        }

        public void deshabilitar()
        {
            txtNmAula.Visible = false;
            btnGuardar.Visible = false;

        }

        public void nuevo()
        {
            txtNmAula.Text = "";
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

            txtNmAula.Focus();

            aula.IdAula = 0;
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

            lblNroId.Text = aula.IdAula.ToString();
            txtNmAula.Text = aula.NombreAula;

            btnCerrar.Location = new System.Drawing.Point(186, 87);

            lblNroId.Visible = true;
            lblId.Visible = true;

            btnCancelar.Visible = false;
            btnGuardar.Text = "Modificar";
            btnGuardar.Visible = true;

            if (aula.IdAula < aulaBusiness.obtenerIDMax())
            {
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
            }

            if (aulaBusiness.obtenerIDMin() < aula.IdAula)
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

            txtNmAula.Focus();
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
            aula = aulaBusiness.IrA(0, aula.IdAula);
            rdoBusqueda();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            aula = aulaBusiness.IrA(1, aula.IdAula);
            rdoBusqueda();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            aula = aulaBusiness.IrA(2, aula.IdAula);
            rdoBusqueda();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            aula = aulaBusiness.IrA(3, aula.IdAula);
            rdoBusqueda();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Validar()
        {
            bool ok = true;
            if (txtNmAula.Text == "")
            {
                ErrorNombre.SetError(txtNmAula, "Ingrese Nombre de Aula");
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
                    aula.NombreAula = txtNmAula.Text;

                    if (btnGuardar.Text == "Guardar")
                    {
                        if (aulaBusiness.ValidarIngreso(aula.NombreAula))
                        {
                            aulaBusiness.agregar(aula);

                            MessageBox.Show("Agregado con éxito");
                            nuevo();
                        }
                        else
                        {
                            MessageBox.Show("El Nombre de Aula ya Existe!");

                        }
                    }
                    else // Modificar Persona
                    {
                        aulaBusiness.modificar(aula);

                        MessageBox.Show("Modificado con éxito");
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
                aulaBusiness.eliminar(aula);

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

                lblId.Visible = false;
                lblNroId.Visible = false;

                eliminarToolStripMenuItem.Visible = false;
            }
        }
    }
}
