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
    public partial class frmCursada : Form
    {
        public frmCursada()
        {
            InitializeComponent();
        }

        CursoBusiness cursoBusiness = new CursoBusiness();
        AnioLectivoBusiness anioLectivoBusiness = new AnioLectivoBusiness();
        ComisionBusiness comisionBusiness = new ComisionBusiness();
        AulaBusiness aulaBusiness = new AulaBusiness();
        DiasBusiness diasBusiness = new DiasBusiness();
        EmpleadoBusiness empleadoBusiness = new EmpleadoBusiness();
        TurnoBusiness turnoBusiness = new TurnoBusiness();
        CursadaBusiness cursadaBusiness = new CursadaBusiness();

        Dia dia = new Dia();
        Aula aula = new Aula();
        Empleado empleado = new Empleado();
        Turno turno = new Turno();
        Cursada cursada = new Cursada();
        Horario horario = new Horario();


        private void btnCopiar_Click(object sender, EventArgs e)
        {
            frmCopiarCursada frm = new frmCopiarCursada();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void frmCursada_Load(object sender, EventArgs e)
        {
            cboCurso.DataSource = cursoBusiness.listar();
            cboCurso.ValueMember = "IdCurso";
            cboCurso.DisplayMember = "NombreCurso";

            cboAnio.DataSource = anioLectivoBusiness.listar();
            cboAnio.ValueMember = "IdAnio";
            cboAnio.DisplayMember = "Anio";

            cboComision.DataSource = comisionBusiness.listar();
            cboComision.ValueMember = "IdComision";
            cboComision.DisplayMember = "NombreComision";

            cboAula.DataSource = aulaBusiness.listar();
            cboAula.ValueMember = "IdAula";
            cboAula.DisplayMember = "NombreAula";

            cboDia.DataSource = diasBusiness.listar();

            cboProfesor.DataSource = empleadoBusiness.listar();
            cboProfesor.ValueMember = "IdPersona";
            cboProfesor.DisplayMember = "Apellido"; //ver de agregar NOmbre

            cboTurno.DataSource = turnoBusiness.listar();
            cboTurno.ValueMember = "IdTurno";
            cboTurno.DisplayMember = "NombreTurno";

            //cboHorario.SelectedItem = -1;
            //cboProfesor.SelectedItem = -1;
            //cboDia.SelectedItem = -1;

            cursada.IdCursada = 0;

        }

        public void actualizar()
        {
            if(cboDia.SelectedItem != null & cboProfesor.SelectedItem != null & cboAula.SelectedItem != null & cboTurno.SelectedItem != null)
            { 
                dia = (Dia)cboDia.SelectedItem;
                aula = (Aula)cboAula.SelectedItem;
                empleado = (Empleado)cboProfesor.SelectedItem;
                turno = (Turno)cboTurno.SelectedItem;
                cboHorario.DataSource = diasBusiness.listarLibres(dia.IdDia, aula.IdAula, empleado.IdPersona, turno.IdTurno);
            }
        }

        private void cboDia_SelectedIndexChanged(object sender, EventArgs e)
        {
                actualizar();
        }

        private void cboProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
                actualizar();
        }

        private void cboAula_SelectedIndexChanged(object sender, EventArgs e)
        {
                actualizar();
        }

        public void habilitar()
        {
            cboAnio.Visible = true;
            cboCurso.Visible = true;
            cboComision.Visible = true;
            cboProfesor.Visible = true;
            txtCantidad.Visible = true;

            cboAnio.SelectedIndex = -1;
            cboCurso.SelectedIndex = -1;
            cboComision.SelectedIndex = -1;
            btnGuardar.Visible = true;

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            habilitar();
            nuevo();
            btnGuardar.Text = "Guardar";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //CursadaBusiness cursadaBusiness = new CursadaBusiness();

            try
            {
                cursada.Anio = (AnioLectivo)cboAnio.SelectedItem;
                cursada.Curso = (Curso)cboCurso.SelectedItem;
                cursada.Comision = (Comision)cboComision.SelectedItem;
                cursada.Profesor = (Empleado)cboProfesor.SelectedItem;
                cursada.CantidadMaxima = int.Parse(txtCantidad.Text);

                if (btnGuardar.Text == "Guardar")
                {
                    //    cursoBusiness.agregar(curso);
                    cursadaBusiness.agregar(cursada);

                    MessageBox.Show("Agregado con éxito");
                    nuevo();
                }
                else // Modificar Persona
                {
                //    cursoBusiness.modificar(curso);

                //    MessageBox.Show("Modificado con éxito");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            cursada = cursadaBusiness.cursadaIrA(0, cursada.IdCursada);
            rdoBusqueda();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            cursada = cursadaBusiness.cursadaIrA(1, cursada.IdCursada);
            rdoBusqueda();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            cursada = cursadaBusiness.cursadaIrA(2, cursada.IdCursada);
            rdoBusqueda();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            cursada = cursadaBusiness.cursadaIrA(3, cursada.IdCursada);
            rdoBusqueda();
        }


        public void rdoBusqueda()
        {
            habilitar();
            lblNroId.Text = cursada.IdCursada.ToString();
            cboAnio.SelectedValue = cursada.Anio.IdAnio;
            cboCurso.SelectedValue = cursada.Curso.IdCurso;
            cboComision.SelectedValue = cursada.Comision.IdComision;
            cboProfesor.SelectedValue = cursada.Profesor.IdPersona;
            //cboTurno.SelectedValue = cursada.Turno.IdTurno;
            //cboAula.SelectedValue = cursada.Aula.IdAula;
            txtCantidad.Text = cursada.CantidadMaxima.ToString();

            cursadaBusiness.agregarDgv(dataGridView1, cursada.IdCursada);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;

            ValidarHorario();

            cboDia.SelectedIndex = -1;
            cboTurno.SelectedIndex = -1;
            cboAula.SelectedIndex = -1;

            cboAnio.Enabled = false;
            cboCurso.Enabled = false;
            cboComision.Enabled = false;

            lblNroId.Visible = true;
            lblId.Visible = true;

            btnSiguiente.Visible = true;
            btnAnterior.Visible = true;
            

            btnGuardar.Text = "Modificar";

            if (cursada.IdCursada < cursadaBusiness.obtenerIDMax())
            {
                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;
            }

            if (cursadaBusiness.obtenerIDMin() < cursada.IdCursada)
            {
                btnAnterior.Enabled = true;
                btnPrimero.Enabled = true;
            }
            else
            {
                btnAnterior.Enabled = false;
                btnPrimero.Enabled = false;
            }
        }

        private void nuevo()
        {
            lblNroId.Visible = false;
            lblId.Visible = false;
            lblNroId.Text = "";
            btnCancelar.Visible = true;
            txtCantidad.Text = "";

            cboAnio.Enabled = true;
            cboCurso.Enabled = true;
            cboComision.Enabled = true;

            cursada.IdCursada = 0;
            buscarToolStripMenuItem.Visible = false;

            btnAnterior.Visible = false;
            btnSiguiente.Visible = false;
            btnUltimo.Visible = false;
            btnPrimero.Visible = false;

            cboAula.SelectedIndex = -1;
            cboTurno.SelectedIndex = -1;
            cboProfesor.SelectedIndex = -1;
            cboDia.SelectedIndex = -1;
            cboHorario.SelectedIndex = -1;

            cboAnio.SelectedIndex = -1;
            cboCurso.SelectedIndex = -1;
            cboComision.SelectedIndex = -1;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnSiguiente.Visible = true;
            btnAnterior.Visible = true;
            btnAnterior.Enabled = false;

            cboAnio.Visible = false;
            cboCurso.Visible = false;
            cboComision.Visible = false;
            btnGuardar.Visible = false;
            cboProfesor.Visible = false;
            txtCantidad.Visible = false;

            btnUltimo.Visible = true;

            if (cursadaBusiness.obtenerIDMax() == 0)
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

            btnCancelar.Visible = false;
            lblNroId.Text = "0";
            buscarToolStripMenuItem.Visible = true;
        }

        private void cboTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnAgregarHorario_Click(object sender, EventArgs e)
        {
            dia = (Dia)cboDia.SelectedItem;
            aula = (Aula)cboAula.SelectedItem;
            horario = (Horario)cboHorario.SelectedItem;
            cursada.Profesor = (Empleado)cboProfesor.SelectedItem;

            if (cboHorario.Items.Count != 0)
            {
                cursadaBusiness.agregarHorario(cursada.IdCursada, dia.IdDia, horario.IdHorario, aula.IdAula);

                if(cboProfesor.Enabled == true)
                {
                    //UPDATE
                    //MessageBox.Show("Actualiza Profesor");

                    cursadaBusiness.actualizarProfesor(cursada);
                }
            }
            else
                MessageBox.Show("Debe Seleccionar un Horario");

            cursadaBusiness.agregarDgv(dataGridView1, cursada.IdCursada);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            actualizar();

            ValidarHorario();


        }

        private void btnEliminarHorario_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
                MessageBox.Show("No hay Horarios para eliminar");
            else
            {
            try
            {
                int Id_Cursada = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
                int Id_Dia = int.Parse(dataGridView1.SelectedCells[1].Value.ToString());
                int Id_Horario = int.Parse(dataGridView1.SelectedCells[2].Value.ToString());
                int Id_Aula = int.Parse(dataGridView1.SelectedCells[3].Value.ToString());

                cursadaBusiness.eliminarHorario(Id_Cursada, Id_Dia, Id_Horario, Id_Aula);

                    cursadaBusiness.agregarDgv(dataGridView1, cursada.IdCursada);
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = false;
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[3].Visible = false;
                    actualizar();

                    ValidarHorario();
                }

            catch (System.NullReferenceException)
            {
                MessageBox.Show("Seleccione un Horario");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
            }

            }

        }

        public void ValidarHorario()
        {
            if(dataGridView1.RowCount == 0)
            {
                cboProfesor.Enabled = true;
            }
            else
            {
                cboProfesor.Enabled = false;
            }
        }
    }
}
