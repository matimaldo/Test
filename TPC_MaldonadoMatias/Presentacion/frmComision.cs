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
        ComisionBusiness comisionBusiness = new ComisionBusiness();


        public void habilitar()
        {
            txtNmComision.Visible = true;

            btnAnterior.Visible = true;
            btnSiguiente.Visible = true;
            btnPrimero.Visible = true;
            btnUltimo.Visible = true;

            ErrorNombre.Clear();
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

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            habilitar();
            nuevo();
            btnGuardar.Text = "Guardar";
        }

        public void rdoBusqueda()
        {
            habilitar();

            lblNroId.Text = comision.IdComision.ToString();
            txtNmComision.Text = comision.NombreComision;

            btnCerrar.Location = new System.Drawing.Point(186, 87);

            lblNroId.Visible = true;
            lblId.Visible = true;

            btnCancelar.Visible = false;
            btnGuardar.Text = "Modificar";
            btnGuardar.Visible = true;

            if (comision.IdComision < comisionBusiness.obtenerIDMax())
            {
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
            }

            if (comisionBusiness.obtenerIDMin() < comision.IdComision)
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
            comision = comisionBusiness.IrA(0, comision.IdComision);
            rdoBusqueda();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            comision = comisionBusiness.IrA(1, comision.IdComision);
            rdoBusqueda();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            comision = comisionBusiness.IrA(2, comision.IdComision);
            rdoBusqueda();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            comision = comisionBusiness.IrA(3, comision.IdComision);
            rdoBusqueda();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Validar()
        {
            bool ok = true;
            if (txtNmComision.Text == "")
            {
                ErrorNombre.SetError(txtNmComision, "Ingrese Nombre de Comision");
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
                    comision.NombreComision = txtNmComision.Text;

                    if (btnGuardar.Text == "Guardar")
                    {
                        if (comisionBusiness.ValidarIngreso(comision.NombreComision))
                        {
                            comisionBusiness.agregar(comision);

                            MessageBox.Show("Agregado con éxito");
                            nuevo();
                        }
                        else
                        {
                            MessageBox.Show("El Nombre de Comisión ya Existe!");

                        }
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
                comisionBusiness.eliminar(comision);

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

                lblId.Visible = false;
                lblNroId.Visible = false;

                eliminarToolStripMenuItem.Visible = false;
            }
        }
    }
}
