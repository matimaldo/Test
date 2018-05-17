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
    public partial class frmComision : Form
    {
        public frmComision()
        {
            InitializeComponent();
        }

        public Comision comision = new Comision();

        public void habilitar()
        {
            txtNmComision.Visible = true;

            btnAnterior.Visible = true;
            btnSiguiente.Visible = true;
            btnPrimero.Visible = true;
            btnUltimo.Visible = true;

        }

        public void deshabilitar()
        {
            txtNmComision.Visible = false;
            btnGuardar.Visible = false;

        }

        public void nuevo()
        {
            txtNmComision.Text = "";
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

            txtNmComision.Focus();

            comision.IdComision = 0;
            eliminarToolStripMenuItem.Visible = false;
        }

        //private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmBuscarCurso frm = new frmBuscarCurso();
        //    frm.Owner = this;
        //    frm.ShowDialog();
        //}

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            habilitar();
            nuevo();
            btnGuardar.Text = "Guardar";
        }

        public void rdoBusqueda()
        {
            CursoBusiness cursoBusiness = new CursoBusiness();

            habilitar();

            lblNroId.Text = comision.IdComision.ToString();
            txtNmComision.Text = comision.NombreComision;

            btnCerrar.Location = new System.Drawing.Point(186, 87);

            lblNroId.Visible = true;
            lblId.Visible = true;

            btnCancelar.Visible = false;
            btnGuardar.Text = "Modificar";
            btnGuardar.Visible = true;

            if (comision.IdComision < cursoBusiness.obtenerIDMax())
            {
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
            }

            if (cursoBusiness.obtenerIDMin() < comision.IdComision)
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

            txtNmComision.Focus();
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
            ComisionBusiness comisionBusiness = new ComisionBusiness();
            comision = comisionBusiness.IrA(0, comision.IdComision);
            rdoBusqueda();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            ComisionBusiness comisionBusiness = new ComisionBusiness();
            comision = comisionBusiness.IrA(1, comision.IdComision);
            rdoBusqueda();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ComisionBusiness comisionBusiness = new ComisionBusiness();
            comision = comisionBusiness.IrA(2, comision.IdComision);
            rdoBusqueda();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            ComisionBusiness comisionBusiness = new ComisionBusiness();
            comision = comisionBusiness.IrA(3, comision.IdComision);
            rdoBusqueda();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ComisionBusiness comisionBusiness = new ComisionBusiness();

            try
            {
                comision.NombreComision = txtNmComision.Text;

                if (btnGuardar.Text == "Guardar")
                {
                    comisionBusiness.agregar(comision);

                    MessageBox.Show("Agregado con éxito");
                    nuevo();
                }
                else // Modificar Persona
                {
                    comisionBusiness.modificar(comision);

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
