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
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        public Empleado empleado = new Empleado();
        public Rol rol = new Rol();

        EmpleadoBusiness empleadoBusiness = new EmpleadoBusiness();
        TelefonoBusiness telefonoBusiness = new TelefonoBusiness();
        RolBusinness rolBusinness = new RolBusinness();

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            frm.Owner = this;
            frm.ShowDialog();
        }
                
        public void habilitar()
        {
            txtNombre.Visible = true;
            txtApellido.Visible = true;
            txtDni.Visible = true;
            txtMail.Visible = true;
            cbxActivo.Visible = true;
            rbtnHombre.Enabled = true;
            rbtnHombre.Checked = true;
            rbtnMujer.Enabled = true;
            btnGuardar.Visible = true;
            dtpFechaNac.Visible = true;
            cboTipoTelefono.Visible = true;
            cboRol.Visible = true;
            txtNumero.Visible = true;
            txtContacto.Visible = true;

            btnAnterior.Visible = true;
            btnSiguiente.Visible = true;
            btnPrimero.Visible = true;
            btnUltimo.Visible = true;
            usuarioToolStripMenuItem.Visible = true;

            ErrorNombre.Clear();
            ErrorApellido.Clear();
            ErrorDNI.Clear();
            ErrorFecha.Clear();
            ErrorMail.Clear();
            ErrorTipo.Clear();
            ErrorTE.Clear();

            TipoTelefonoBusiness TipoTelefonoBusiness = new TipoTelefonoBusiness();
            try
            {
                cboTipoTelefono.DataSource = TipoTelefonoBusiness.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            RolBusinness rolBusinness = new RolBusinness();
            try
            {
                cboRol.DataSource = rolBusinness.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void deshabilitar()
        {
            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtDni.Visible = false;
            txtMail.Visible = false;
            cbxActivo.Visible = false;
            rbtnHombre.Enabled = false;
            rbtnHombre.Checked = false;
            rbtnMujer.Enabled = false;
            btnGuardar.Visible = false;
            dtpFechaNac.Visible = false;
            cboTipoTelefono.Visible = false;
            txtNumero.Visible = false;
            txtContacto.Visible = false;
            cboRol.Visible = false;

            btnAnterior.Visible = false;
            btnSiguiente.Visible = false;
        }

        private void nuevo()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtMail.Text = "";
            cbxActivo.Enabled = true;
            cbxActivo.Checked = true;
            rbtnHombre.Enabled = true;
            rbtnHombre.Checked = true;
            rbtnMujer.Enabled = true;
            btnGuardar.Visible = true;
            dtpFechaNac.Value = DateTime.Today;
            txtNumero.Text = "";
            txtContacto.Text = "";
            cboTipoTelefono.Text = "";
            cboTipoTelefono.SelectedIndex = -1;
            cboRol.SelectedIndex = -1;
            cbxActivo.Visible = false;
            btnAnterior.Visible = false;
            btnSiguiente.Visible = false;
            btnUltimo.Visible = false;
            btnPrimero.Visible = false;

            btnSalir.Location = new Point(164, 398);

            lblNroId.Visible = false;
            lblId.Visible = false;
            lblNroId.Text = "";
            btnCancelar.Visible = true;

            txtNombre.Focus();

            empleado.IdPersona = 0;
            eliminarToolStripMenuItem.Visible = false;
            buscarToolStripMenuItem.Visible = false;
            usuarioToolStripMenuItem.Visible = false;
        }

        public void rdoBusqueda()
        {
            EmpleadoBusiness empleadoBusiness = new EmpleadoBusiness();

            habilitar();

            lblNroId.Text = empleado.IdPersona.ToString();
            txtNombre.Text = empleado.Nombre;
            txtApellido.Text = empleado.Apellido;
            txtDni.Text = empleado.Dni;
            dtpFechaNac.Value = empleado.FechaNac;
            txtNumero.Text = empleado.Telefono.Numero;
            cbxActivo.Checked = empleado.Estado;
            cboTipoTelefono.SelectedIndex = empleado.Telefono.TipoTelefono.IdTipoTelefono - 1;
            cboTipoTelefono.Text = empleado.Telefono.TipoTelefono.NombreTipoTelefono;
            txtMail.Text = empleado.Mail;
            txtContacto.Text = empleado.Telefono.Contacto;
            btnSalir.Location = new System.Drawing.Point(164, 398);


            RolBusinness rolBusinness = new RolBusinness();
            cboRol.SelectedIndex = rolBusinness.obtenerRol(empleado.IdPersona)-2;

            if (String.Compare(empleado.Sexo, "M") >= 0)
            { rbtnHombre.Checked = true; }
            else { rbtnMujer.Checked = true; }

            lblNroId.Visible = true;
            lblId.Visible = true;

            btnSiguiente.Visible = true;
            btnAnterior.Visible = true;


            txtNombre.Focus();

            btnCancelar.Visible = false;
            btnGuardar.Text = "Modificar";

            if (empleado.IdPersona < empleadoBusiness.obtenerIDMax())
            {
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
            }

            if (empleadoBusiness.obtenerIDMin() < empleado.IdPersona)
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


        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            habilitar();
            nuevo();
            btnGuardar.Text = "Guardar";

        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleado frm = new frmBuscarEmpleado();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {

                try
            {
                empleado.Nombre = txtNombre.Text;
                empleado.Apellido = txtApellido.Text;
                empleado.Dni = txtDni.Text;
                empleado.FechaNac = dtpFechaNac.Value;
                empleado.Mail = txtMail.Text;
                empleado.Estado = cbxActivo.Checked;
                if (rbtnHombre.Checked) { empleado.Sexo = "M"; } else { empleado.Sexo = "F"; };

                empleado.Telefono.TipoTelefono = (TipoTelefono)cboTipoTelefono.SelectedItem;
                empleado.Telefono.Numero = txtNumero.Text;
                empleado.Telefono.Contacto = txtContacto.Text;

                rol = (Rol)cboRol.SelectedItem;

                    if (empleadoBusiness.ValidarIngreso(empleado.Dni))
                    {

                        if (btnGuardar.Text == "Guardar")
                        {
                            empleadoBusiness.agregar(empleado);

                            if (empleado.Telefono.Numero != "")
                            {
                                telefonoBusiness.agregar(empleado.Telefono, empleadoBusiness.obtenerIDPersona(empleado.Dni)); // Manejo con DNI porque no tengo ID (new)
                            }

                            rolBusinness.agregar(rol.IdRol, empleadoBusiness.obtenerIDPersona(empleado.Dni));

                            MessageBox.Show("Agregado con éxito");
                            nuevo();

                        }

                        else
                        {
                            MessageBox.Show("El Numero de DNI ya Existe!");

                        }
                    }
                else // Modificar Persona
                {
                    empleadoBusiness.modificar(empleado);
                    rolBusinness.modificar(rol.IdRol, empleado.IdPersona);

                    if (empleado.Telefono.IdTelefono != 0) // Modifica Telefono si tiene
                    {
                        telefonoBusiness.modificar(empleado.Telefono, empleado.IdPersona);
                        

                    }
                    else if (empleado.Telefono.IdTelefono == 0 && empleado.Telefono.Numero != "") // Agrega Telefono a Persona Existente
                    {
                        telefonoBusiness.agregar(empleado.Telefono, empleado.IdPersona);
                    }

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

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            empleado = empleadoBusiness.empleadoIrA(0, empleado.IdPersona);
            rdoBusqueda();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            empleado = empleadoBusiness.empleadoIrA(1, empleado.IdPersona);
            rdoBusqueda();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            empleado = empleadoBusiness.empleadoIrA(2, empleado.IdPersona);
            rdoBusqueda();

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            empleado = empleadoBusiness.empleadoIrA(3, empleado.IdPersona);
            rdoBusqueda();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitar();
            

            btnSiguiente.Visible = true;
            
            btnAnterior.Visible = true;
            btnAnterior.Enabled = false;

            btnUltimo.Visible = true;

            if (empleadoBusiness.obtenerIDMax() == 0)
            {
                btnUltimo.Enabled = false;
                btnSiguiente.Enabled = false;
            }
            else
            {
                btnUltimo.Enabled = true;
                btnSiguiente.Enabled = true;
            }

            btnPrimero.Visible = true;
            btnPrimero.Enabled = false;

            btnSalir.Location = new Point(107, 398);
            btnCancelar.Visible = false;
            lblNroId.Text = "0";
            buscarToolStripMenuItem.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            if (empleadoBusiness.obtenerIDMax() == 0)
            {
                btnUltimo.Enabled = false;
                btnSiguiente.Enabled = false;
            }
            else
            {
                btnUltimo.Enabled = true;
                btnSiguiente.Enabled = true;
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta Seguro que desea Eliminar?", "Eliminar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (empleadoBusiness.ctrl_eliminar(empleado) == 0)
                {
                    empleadoBusiness.eliminar(empleado);

                    deshabilitar();
                    btnSiguiente.Visible = true;
                    btnSiguiente.Enabled = true;
                    btnAnterior.Visible = true;
                    btnAnterior.Enabled = false;

                    btnUltimo.Visible = true;
                    btnUltimo.Enabled = true;

                    btnPrimero.Visible = true;
                    btnPrimero.Enabled = false;

                    btnSalir.Location = new Point(107, 398);
                    btnCancelar.Visible = false;
                    lblNroId.Text = "0";

                    lblId.Visible = false;
                    lblNroId.Visible = false;

                    eliminarToolStripMenuItem.Visible = false;

                }
                else
                {
                    MessageBox.Show("No se puede Eliminar porque esta en Uso!");
                }
            }
        }

        public bool Validar()
        {
            bool ok = true;
            if (txtNombre.Text == "")
            {
                ErrorNombre.SetError(txtNombre, "Ingrese Nombre");
                ok = false;
            }
            else
            {
                ErrorNombre.Clear();
            }

            if (txtApellido.Text == "")
            {
                ErrorApellido.SetError(txtApellido, "Ingrese Apellido");
                ok = false;
            }
            else
            {
                ErrorApellido.Clear();
            }

            if (txtDni.Text == "")
            {
                ErrorDNI.SetError(txtDni, "Ingrese DNI");
                ok = false;
            }
            else
            {
                ErrorDNI.Clear();
            }

            if (dtpFechaNac.Value >= DateTime.Today)
            {
                ErrorFecha.SetError(dtpFechaNac, "Ingrese Fecha Nacimento menor a Hoy");
                ok = false;
            }
            else
            {
                ErrorFecha.Clear();
            }

            Regex RX = new Regex("^[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$");

            if (!RX.IsMatch(txtMail.Text))
            {
                ErrorMail.SetError(txtMail, "Ingrese Mail con formato correcto(AlfaNum@AlfaNum.com)");
                ok = false;
            }
            else
            {
                ErrorMail.Clear();
            }

            if (txtNumero.Text != "" && cboTipoTelefono.SelectedIndex == -1)
            {
                ErrorTipo.SetError(cboTipoTelefono, "Ingrese Tipo de Telefono");
                ok = false;
            }
            else
            {
                ErrorTipo.Clear();
            }

            if (cboRol.SelectedIndex == -1)
            {
                ErrorTE.SetError(cboRol, "Seleccione un Rol");
                ok = false;
            }
            else
            {
                ErrorTipo.Clear();
            }

            return ok;
        }
    }
}
