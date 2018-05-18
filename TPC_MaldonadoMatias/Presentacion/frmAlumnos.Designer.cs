namespace Presentacion
{
    partial class frmAlumnos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnos));
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            this.lbFechaNac = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMujer = new System.Windows.Forms.RadioButton();
            this.rbtnHombre = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxActivo = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new Negocio.TextBoxValida();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblTipoTelefono = new System.Windows.Forms.Label();
            this.cboTipoTelefono = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.gbTelefono = new System.Windows.Forms.GroupBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNroId = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.ePerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbSexo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbTelefono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePerror)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(51, 52);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(50, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre :";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(51, 80);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(50, 13);
            this.lbApellido.TabIndex = 1;
            this.lbApellido.Text = "Apellido :";
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Location = new System.Drawing.Point(51, 108);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(32, 13);
            this.lbDni.TabIndex = 2;
            this.lbDni.Text = "DNI :";
            // 
            // lbFechaNac
            // 
            this.lbFechaNac.AutoSize = true;
            this.lbFechaNac.Location = new System.Drawing.Point(51, 136);
            this.lbFechaNac.Name = "lbFechaNac";
            this.lbFechaNac.Size = new System.Drawing.Size(69, 13);
            this.lbFechaNac.TabIndex = 3;
            this.lbFechaNac.Text = "Fecha Nac. :";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Location = new System.Drawing.Point(51, 164);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(35, 13);
            this.lbMail.TabIndex = 4;
            this.lbMail.Text = "Mail : ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(63, 370);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 27);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbtnMujer);
            this.gbSexo.Controls.Add(this.rbtnHombre);
            this.gbSexo.Location = new System.Drawing.Point(54, 312);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(185, 47);
            this.gbSexo.TabIndex = 9;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbtnMujer
            // 
            this.rbtnMujer.AutoSize = true;
            this.rbtnMujer.Enabled = false;
            this.rbtnMujer.Location = new System.Drawing.Point(119, 19);
            this.rbtnMujer.Name = "rbtnMujer";
            this.rbtnMujer.Size = new System.Drawing.Size(51, 17);
            this.rbtnMujer.TabIndex = 11;
            this.rbtnMujer.Text = "Mujer";
            this.rbtnMujer.UseVisualStyleBackColor = true;
            // 
            // rbtnHombre
            // 
            this.rbtnHombre.AutoSize = true;
            this.rbtnHombre.Enabled = false;
            this.rbtnHombre.Location = new System.Drawing.Point(22, 19);
            this.rbtnHombre.Name = "rbtnHombre";
            this.rbtnHombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnHombre.TabIndex = 10;
            this.rbtnHombre.Text = "Hombre";
            this.rbtnHombre.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(310, 24);
            this.menuStrip1.TabIndex = 12;
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
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Visible = false;
            // 
            // cbxActivo
            // 
            this.cbxActivo.AutoSize = true;
            this.cbxActivo.Location = new System.Drawing.Point(247, 27);
            this.cbxActivo.Name = "cbxActivo";
            this.cbxActivo.Size = new System.Drawing.Size(56, 17);
            this.cbxActivo.TabIndex = 14;
            this.cbxActivo.Text = "Activo";
            this.cbxActivo.UseVisualStyleBackColor = true;
            this.cbxActivo.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(107, 370);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 27);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Cerrar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(155, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Visible = false;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(155, 80);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.Visible = false;
            this.txtApellido.Validating += new System.ComponentModel.CancelEventHandler(this.txtApellido_Validating);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(155, 108);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 2;
            this.txtDni.TextboxEstado = Negocio.TextBoxValida.Estados.Solo_numeros;
            this.txtDni.Visible = false;
            this.txtDni.Validating += new System.ComponentModel.CancelEventHandler(this.txtDni_Validating);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(155, 136);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaNac.TabIndex = 3;
            this.dtpFechaNac.Visible = false;
            this.dtpFechaNac.Validating += new System.ComponentModel.CancelEventHandler(this.dtpFechaNac_Validating);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(155, 163);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 4;
            this.txtMail.Visible = false;
            this.txtMail.Validating += new System.ComponentModel.CancelEventHandler(this.txtMail_Validating);
            // 
            // lblTipoTelefono
            // 
            this.lblTipoTelefono.AutoSize = true;
            this.lblTipoTelefono.Location = new System.Drawing.Point(41, 23);
            this.lblTipoTelefono.Name = "lblTipoTelefono";
            this.lblTipoTelefono.Size = new System.Drawing.Size(34, 13);
            this.lblTipoTelefono.TabIndex = 20;
            this.lblTipoTelefono.Text = "Tipo :";
            // 
            // cboTipoTelefono
            // 
            this.cboTipoTelefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoTelefono.FormattingEnabled = true;
            this.cboTipoTelefono.Location = new System.Drawing.Point(94, 15);
            this.cboTipoTelefono.Name = "cboTipoTelefono";
            this.cboTipoTelefono.Size = new System.Drawing.Size(100, 21);
            this.cboTipoTelefono.TabIndex = 6;
            this.cboTipoTelefono.Visible = false;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(94, 42);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 7;
            this.txtNumero.Visible = false;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(94, 68);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(100, 20);
            this.txtContacto.TabIndex = 8;
            this.txtContacto.Visible = false;
            // 
            // gbTelefono
            // 
            this.gbTelefono.Controls.Add(this.lblContacto);
            this.gbTelefono.Controls.Add(this.lblNumero);
            this.gbTelefono.Controls.Add(this.cboTipoTelefono);
            this.gbTelefono.Controls.Add(this.lblTipoTelefono);
            this.gbTelefono.Controls.Add(this.txtContacto);
            this.gbTelefono.Controls.Add(this.txtNumero);
            this.gbTelefono.Location = new System.Drawing.Point(54, 197);
            this.gbTelefono.Name = "gbTelefono";
            this.gbTelefono.Size = new System.Drawing.Size(219, 100);
            this.gbTelefono.TabIndex = 5;
            this.gbTelefono.TabStop = false;
            this.gbTelefono.Text = "Telefono";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(32, 71);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(56, 13);
            this.lblContacto.TabIndex = 25;
            this.lblContacto.Text = "Contacto :";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(41, 45);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(25, 13);
            this.lblNumero.TabIndex = 24;
            this.lblNumero.Text = "Nº :";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(257, 412);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(24, 23);
            this.btnSiguiente.TabIndex = 16;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Location = new System.Drawing.Point(234, 412);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(24, 23);
            this.btnAnterior.TabIndex = 15;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "ID:";
            this.lblId.Visible = false;
            // 
            // lblNroId
            // 
            this.lblNroId.AutoSize = true;
            this.lblNroId.Location = new System.Drawing.Point(39, 27);
            this.lblNroId.Name = "lblNroId";
            this.lblNroId.Size = new System.Drawing.Size(13, 13);
            this.lblNroId.TabIndex = 19;
            this.lblNroId.Text = "0";
            this.lblNroId.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(284, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(20, 20);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "X";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Location = new System.Drawing.Point(280, 412);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(27, 23);
            this.btnUltimo.TabIndex = 21;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Enabled = false;
            this.btnPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.Location = new System.Drawing.Point(208, 412);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(27, 23);
            this.btnPrimero.TabIndex = 22;
            this.btnPrimero.Text = "<<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // ePerror
            // 
            this.ePerror.ContainerControl = this;
            this.ePerror.Icon = ((System.Drawing.Icon)(resources.GetObject("ePerror.Icon")));
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(310, 437);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblNroId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.gbTelefono);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cbxActivo);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.lbFechaNac);
            this.Controls.Add(this.lbDni);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Alumnos";
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbTelefono.ResumeLayout(false);
            this.gbTelefono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePerror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbFechaNac;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.Label lblTipoTelefono;
        private System.Windows.Forms.GroupBox gbTelefono;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblNumero;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtApellido;
        private Negocio.TextBoxValida txtDni;
        public System.Windows.Forms.DateTimePicker dtpFechaNac;
        public System.Windows.Forms.TextBox txtMail;
        public System.Windows.Forms.TextBox txtNumero;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.RadioButton rbtnMujer;
        public System.Windows.Forms.RadioButton rbtnHombre;
        public System.Windows.Forms.ComboBox cboTipoTelefono;
        public System.Windows.Forms.TextBox txtContacto;
        public System.Windows.Forms.CheckBox cbxActivo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Label lblNroId;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.ErrorProvider ePerror;
    }
}