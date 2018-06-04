namespace Presentacion
{
    partial class frmCursada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.cboProfesor = new System.Windows.Forms.ComboBox();
            this.cboComision = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboAula = new System.Windows.Forms.ComboBox();
            this.lblAula = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAgregarHorario = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboDia = new System.Windows.Forms.ComboBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.cboHorario = new System.Windows.Forms.ComboBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.btnEliminarHorario = new System.Windows.Forms.Button();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnBajar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNroId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtCantidad = new Negocio.MTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(21, 49);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(40, 13);
            this.lblCurso.TabIndex = 1;
            this.lblCurso.Text = "Curso :";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(343, 49);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(70, 13);
            this.lblAnio.TabIndex = 2;
            this.lblAnio.Text = "Año Lectivo :";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(83, 81);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(52, 13);
            this.lblProfesor.TabIndex = 3;
            this.lblProfesor.Text = "Profesor :";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(193, 49);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(55, 13);
            this.lblComision.TabIndex = 5;
            this.lblComision.Text = "Comisión :";
            // 
            // cboCurso
            // 
            this.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(67, 46);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(105, 21);
            this.cboCurso.TabIndex = 8;
            this.cboCurso.Visible = false;
            // 
            // cboAnio
            // 
            this.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Location = new System.Drawing.Point(419, 46);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(63, 21);
            this.cboAnio.TabIndex = 9;
            this.cboAnio.Visible = false;
            // 
            // cboProfesor
            // 
            this.cboProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfesor.FormattingEnabled = true;
            this.cboProfesor.Location = new System.Drawing.Point(141, 78);
            this.cboProfesor.Name = "cboProfesor";
            this.cboProfesor.Size = new System.Drawing.Size(137, 21);
            this.cboProfesor.TabIndex = 10;
            this.cboProfesor.Visible = false;
            this.cboProfesor.SelectedIndexChanged += new System.EventHandler(this.cboProfesor_SelectedIndexChanged);
            // 
            // cboComision
            // 
            this.cboComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComision.FormattingEnabled = true;
            this.cboComision.Location = new System.Drawing.Point(254, 46);
            this.cboComision.Name = "cboComision";
            this.cboComision.Size = new System.Drawing.Size(83, 21);
            this.cboComision.TabIndex = 12;
            this.cboComision.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(158, 114);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboAula
            // 
            this.cboAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAula.FormattingEnabled = true;
            this.cboAula.Location = new System.Drawing.Point(142, 136);
            this.cboAula.Name = "cboAula";
            this.cboAula.Size = new System.Drawing.Size(91, 21);
            this.cboAula.TabIndex = 17;
            this.cboAula.Visible = false;
            this.cboAula.SelectedIndexChanged += new System.EventHandler(this.cboAula_SelectedIndexChanged);
            // 
            // lblAula
            // 
            this.lblAula.AutoSize = true;
            this.lblAula.Location = new System.Drawing.Point(102, 139);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(34, 13);
            this.lblAula.TabIndex = 16;
            this.lblAula.Text = "Aula :";
            this.lblAula.Visible = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(298, 81);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad :";
            // 
            // btnAgregarHorario
            // 
            this.btnAgregarHorario.Location = new System.Drawing.Point(107, 173);
            this.btnAgregarHorario.Name = "btnAgregarHorario";
            this.btnAgregarHorario.Size = new System.Drawing.Size(126, 23);
            this.btnAgregarHorario.TabIndex = 18;
            this.btnAgregarHorario.Text = "Agregar Horario";
            this.btnAgregarHorario.UseVisualStyleBackColor = true;
            this.btnAgregarHorario.Visible = false;
            this.btnAgregarHorario.Click += new System.EventHandler(this.btnAgregarHorario_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 202);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(467, 124);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.Visible = false;
            // 
            // cboDia
            // 
            this.cboDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDia.FormattingEnabled = true;
            this.cboDia.Location = new System.Drawing.Point(306, 112);
            this.cboDia.Name = "cboDia";
            this.cboDia.Size = new System.Drawing.Size(71, 21);
            this.cboDia.TabIndex = 21;
            this.cboDia.Visible = false;
            this.cboDia.SelectedIndexChanged += new System.EventHandler(this.cboDia_SelectedIndexChanged);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(275, 115);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(29, 13);
            this.lblDia.TabIndex = 20;
            this.lblDia.Text = "Dia :";
            this.lblDia.Visible = false;
            // 
            // cboHorario
            // 
            this.cboHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHorario.FormattingEnabled = true;
            this.cboHorario.Location = new System.Drawing.Point(306, 136);
            this.cboHorario.Name = "cboHorario";
            this.cboHorario.Size = new System.Drawing.Size(100, 21);
            this.cboHorario.TabIndex = 23;
            this.cboHorario.Visible = false;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(257, 139);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(47, 13);
            this.lblHorario.TabIndex = 22;
            this.lblHorario.Text = "Horario :";
            this.lblHorario.Visible = false;
            // 
            // btnEliminarHorario
            // 
            this.btnEliminarHorario.Location = new System.Drawing.Point(266, 173);
            this.btnEliminarHorario.Name = "btnEliminarHorario";
            this.btnEliminarHorario.Size = new System.Drawing.Size(126, 23);
            this.btnEliminarHorario.TabIndex = 24;
            this.btnEliminarHorario.Text = "Eliminar Horario";
            this.btnEliminarHorario.UseVisualStyleBackColor = true;
            this.btnEliminarHorario.Visible = false;
            this.btnEliminarHorario.Click += new System.EventHandler(this.btnEliminarHorario_Click);
            // 
            // cboTurno
            // 
            this.cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Location = new System.Drawing.Point(142, 109);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(94, 21);
            this.cboTurno.TabIndex = 26;
            this.cboTurno.Visible = false;
            this.cboTurno.SelectedIndexChanged += new System.EventHandler(this.cboTurno_SelectedIndexChanged);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(95, 112);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(41, 13);
            this.lblTurno.TabIndex = 25;
            this.lblTurno.Text = "Turno :";
            this.lblTurno.Visible = false;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Enabled = false;
            this.btnPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.Location = new System.Drawing.Point(389, 139);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(27, 23);
            this.btnPrimero.TabIndex = 31;
            this.btnPrimero.Text = "<<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Location = new System.Drawing.Point(461, 139);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(27, 23);
            this.btnUltimo.TabIndex = 30;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Location = new System.Drawing.Point(415, 139);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(24, 23);
            this.btnAnterior.TabIndex = 28;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(438, 139);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(24, 23);
            this.btnSiguiente.TabIndex = 29;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnBajar
            // 
            this.btnBajar.Location = new System.Drawing.Point(1, 139);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(24, 23);
            this.btnBajar.TabIndex = 32;
            this.btnBajar.Text = "+";
            this.btnBajar.UseVisualStyleBackColor = true;
            this.btnBajar.Visible = false;
            this.btnBajar.Click += new System.EventHandler(this.btnBajar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(240, 114);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 33;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(473, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(20, 20);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "X";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNroId
            // 
            this.lblNroId.AutoSize = true;
            this.lblNroId.Location = new System.Drawing.Point(36, 24);
            this.lblNroId.Name = "lblNroId";
            this.lblNroId.Size = new System.Drawing.Size(13, 13);
            this.lblNroId.TabIndex = 36;
            this.lblNroId.Text = "0";
            this.lblNroId.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(9, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 35;
            this.lblId.Text = "ID:";
            this.lblId.Visible = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(359, 78);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(33, 20);
            this.txtCantidad.TabIndex = 37;
            this.txtCantidad.TextboxEstado = Negocio.MTextBox.Estados.Solo_numeros;
            this.txtCantidad.Visible = false;
            // 
            // frmCursada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(496, 167);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblNroId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBajar);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.cboTurno);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.btnEliminarHorario);
            this.Controls.Add(this.cboHorario);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.cboDia);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAgregarHorario);
            this.Controls.Add(this.cboAula);
            this.Controls.Add(this.lblAula);
            this.Controls.Add(this.cboComision);
            this.Controls.Add(this.cboProfesor);
            this.Controls.Add(this.cboAnio);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCursada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursada";
            this.Load += new System.EventHandler(this.frmCursada_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.ComboBox cboProfesor;
        private System.Windows.Forms.ComboBox cboComision;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cboAula;
        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnAgregarHorario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboDia;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.ComboBox cboHorario;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Button btnEliminarHorario;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnBajar;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Label lblNroId;
        public System.Windows.Forms.Label lblId;
        private Negocio.MTextBox txtCantidad;
    }
}