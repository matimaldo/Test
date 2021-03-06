﻿using System;
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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        public Alumno alumno = new Alumno();
        PersonasBusiness personasBusiness = new PersonasBusiness();
        TelefonoBusiness telefonoBusiness = new TelefonoBusiness();


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
            txtNumero.Visible = true;
            txtContacto.Visible = true;

            btnAnterior.Visible = true;
            btnSiguiente.Visible = true;
            btnPrimero.Visible = true;
            btnUltimo.Visible = true;
            buscarToolStripMenuItem.Visible = true;

            ErrorNombre.Clear();
            ErrorApellido.Clear();
            ErrorDNI.Clear();
            ErrorFecha.Clear();
            ErrorMail.Clear();
            ErrorTipo.Clear();


            TipoTelefonoBusiness TipoTelefonoBusiness = new TipoTelefonoBusiness();
            try
            {
                cboTipoTelefono.DataSource = TipoTelefonoBusiness.listar();
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

            btnAnterior.Visible = false;
            btnSiguiente.Visible = false;
            buscarToolStripMenuItem.Visible = true;
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
            cbxActivo.Visible = false;
            btnAnterior.Visible = false;
            btnSiguiente.Visible = false;
            btnUltimo.Visible = false;
            btnPrimero.Visible = false;
            buscarToolStripMenuItem.Visible = false;

            btnSalir.Location = new Point(164, 370);

            lblNroId.Visible = false;
            lblId.Visible = false;
            lblNroId.Text = "";
            btnCancelar.Visible = true;

            txtNombre.Focus();

            alumno.IdPersona = 0;
            eliminarToolStripMenuItem.Visible = false;

        }

        public void rdoBusqueda()
        {
            PersonasBusiness personasBusiness = new PersonasBusiness();

            habilitar();

            lblNroId.Text = alumno.IdPersona.ToString();
            txtNombre.Text = alumno.Nombre;
            txtApellido.Text = alumno.Apellido;
            txtDni.Text = alumno.Dni;
            dtpFechaNac.Value = alumno.FechaNac;
            txtNumero.Text = alumno.Telefono.Numero;
            cbxActivo.Checked = alumno.Estado;
            cboTipoTelefono.SelectedIndex = alumno.Telefono.TipoTelefono.IdTipoTelefono - 1;
            cboTipoTelefono.Text = alumno.Telefono.TipoTelefono.NombreTipoTelefono;
            txtMail.Text = alumno.Mail;
            txtContacto.Text = alumno.Telefono.Contacto;
            btnSalir.Location = new System.Drawing.Point(164, 370);

            if (String.Compare(alumno.Sexo, "M") >= 0)
            { rbtnHombre.Checked = true; }
            else { rbtnMujer.Checked = true; }

            lblNroId.Visible = true;
            lblId.Visible = true;

            btnSiguiente.Visible = true;
            btnAnterior.Visible = true;


            txtNombre.Focus();

            btnCancelar.Visible = false;
            btnGuardar.Text = "Modificar";

            if (alumno.IdPersona < personasBusiness.obtenerIDMax())
            {
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
            }

            if (personasBusiness.obtenerIDMin() < alumno.IdPersona)
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
            frmBuscarAlumno frm= new frmBuscarAlumno();
            frm.Owner = this;
            frm.ShowDialog();
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

            // AlfaNum@AlfaNum.com
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

            return ok;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Validar())
            {

            try
            {
                alumno.Nombre = txtNombre.Text;
                alumno.Apellido = txtApellido.Text;
                alumno.Dni = txtDni.Text;
                alumno.FechaNac = dtpFechaNac.Value;
                alumno.Mail = txtMail.Text;
                alumno.Estado = cbxActivo.Checked;
                if (rbtnHombre.Checked) { alumno.Sexo="M"; } else { alumno.Sexo="F"; };

                alumno.Telefono.TipoTelefono = (TipoTelefono)cboTipoTelefono.SelectedItem;
                alumno.Telefono.Numero = txtNumero.Text;
                alumno.Telefono.Contacto = txtContacto.Text;

                if (btnGuardar.Text == "Guardar")
                {   
                    if(personasBusiness.ValidarIngreso(alumno.Dni))
                        {
                            personasBusiness.agregar(alumno);

                            if (alumno.Telefono.Numero != "")
                            {
                                telefonoBusiness.agregar(alumno.Telefono, personasBusiness.obtenerIDPersona(alumno.Dni)); // Manejo con DNI porque no tengo ID (new)
                            }

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
                    personasBusiness.modificar(alumno);

                    if (alumno.Telefono.IdTelefono != 0) // Modifica Telefono si tiene
                    {
                        telefonoBusiness.modificar(alumno.Telefono, alumno.IdPersona);
                    }
                    else if (alumno.Telefono.IdTelefono == 0  && alumno.Telefono.Numero != "") // Agrega Telefono a Persona Existente
                    {
                        telefonoBusiness.agregar(alumno.Telefono, alumno.IdPersona);
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
            PersonasBusiness personasBusiness = new PersonasBusiness();
            alumno = personasBusiness.IrA(0, alumno.IdPersona);
            rdoBusqueda();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            PersonasBusiness personasBusiness = new PersonasBusiness();
            alumno = personasBusiness.IrA(1, alumno.IdPersona);
            rdoBusqueda();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            PersonasBusiness personasBusiness = new PersonasBusiness();
            alumno = personasBusiness.IrA(2, alumno.IdPersona);
            rdoBusqueda();

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            PersonasBusiness personasBusiness = new PersonasBusiness();
            alumno = personasBusiness.IrA(3, alumno.IdPersona);
            rdoBusqueda();

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

            btnSalir.Location = new Point(107, 370);
            btnCancelar.Visible = false;
            lblNroId.Text = "0";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //if (validar())
            //    MessageBox.Show("Desea Guardar los cambios?", "Salir", MessageBoxButtons.YesNo);
            this.Close();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =  MessageBox.Show("¿Esta Seguro que desea Eliminar?", "Eliminar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (personasBusiness.ctrl_eliminar(alumno) == 0)
                {
                    personasBusiness.eliminar(alumno);
                    deshabilitar();
                    btnSiguiente.Visible = true;
                    btnSiguiente.Enabled = true;
                    btnAnterior.Visible = true;
                    btnAnterior.Enabled = false;

                    btnUltimo.Visible = true;
                    btnUltimo.Enabled = true;

                    btnPrimero.Visible = true;
                    btnPrimero.Enabled = false;

                    btnSalir.Location = new Point(107, 370);
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

    }
}
