namespace Presentacion
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNroId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.gbTelefono = new System.Windows.Forms.GroupBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.cboTipoTelefono = new System.Windows.Forms.ComboBox();
            this.lblTipoTelefono = new System.Windows.Forms.Label();
            this.txtContacto = new Negocio.MTextBox();
            this.txtNumero = new Negocio.MTextBox();
            this.txtMail = new Negocio.MTextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtDni = new Negocio.MTextBox();
            this.txtApellido = new Negocio.MTextBox();
            this.txtNombre = new Negocio.MTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbxActivo = new System.Windows.Forms.CheckBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMujer = new System.Windows.Forms.RadioButton();
            this.rbtnHombre = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbFechaNac = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.lblTipoEmpleado = new System.Windows.Forms.Label();
            this.ErrorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorDNI = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorFecha = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorTipo = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorTE = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbTelefono.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTE)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrimero
            // 
            this.btnPrimero.Enabled = false;
            this.btnPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.Location = new System.Drawing.Point(208, 440);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(27, 23);
            this.btnPrimero.TabIndex = 45;
            this.btnPrimero.Text = "<<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Location = new System.Drawing.Point(280, 440);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(27, 23);
            this.btnUltimo.TabIndex = 44;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(284, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(20, 20);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "X";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNroId
            // 
            this.lblNroId.AutoSize = true;
            this.lblNroId.Location = new System.Drawing.Point(39, 27);
            this.lblNroId.Name = "lblNroId";
            this.lblNroId.Size = new System.Drawing.Size(13, 13);
            this.lblNroId.TabIndex = 42;
            this.lblNroId.Text = "0";
            this.lblNroId.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 41;
            this.lblId.Text = "ID:";
            this.lblId.Visible = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Location = new System.Drawing.Point(234, 440);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(24, 23);
            this.btnAnterior.TabIndex = 39;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(257, 440);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(24, 23);
            this.btnSiguiente.TabIndex = 40;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // gbTelefono
            // 
            this.gbTelefono.Controls.Add(this.lblContacto);
            this.gbTelefono.Controls.Add(this.lblNumero);
            this.gbTelefono.Controls.Add(this.cboTipoTelefono);
            this.gbTelefono.Controls.Add(this.lblTipoTelefono);
            this.gbTelefono.Controls.Add(this.txtContacto);
            this.gbTelefono.Controls.Add(this.txtNumero);
            this.gbTelefono.Location = new System.Drawing.Point(54, 225);
            this.gbTelefono.Name = "gbTelefono";
            this.gbTelefono.Size = new System.Drawing.Size(219, 100);
            this.gbTelefono.TabIndex = 33;
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
            // lblTipoTelefono
            // 
            this.lblTipoTelefono.AutoSize = true;
            this.lblTipoTelefono.Location = new System.Drawing.Point(41, 23);
            this.lblTipoTelefono.Name = "lblTipoTelefono";
            this.lblTipoTelefono.Size = new System.Drawing.Size(34, 13);
            this.lblTipoTelefono.TabIndex = 20;
            this.lblTipoTelefono.Text = "Tipo :";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(94, 68);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(100, 20);
            this.txtContacto.TabIndex = 8;
            this.txtContacto.TextboxEstado = Negocio.MTextBox.Estados.Solo_letras;
            this.txtContacto.Visible = false;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(94, 42);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 7;
            this.txtNumero.TextboxEstado = Negocio.MTextBox.Estados.Solo_numeros;
            this.txtNumero.Visible = false;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(155, 167);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 32;
            this.txtMail.TextboxEstado = Negocio.MTextBox.Estados.Defecto;
            this.txtMail.Visible = false;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(155, 140);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaNac.TabIndex = 30;
            this.dtpFechaNac.Visible = false;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(155, 112);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 28;
            this.txtDni.TextboxEstado = Negocio.MTextBox.Estados.Solo_numeros;
            this.txtDni.Visible = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(155, 84);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 25;
            this.txtApellido.TextboxEstado = Negocio.MTextBox.Estados.Solo_letras;
            this.txtApellido.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(155, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 24;
            this.txtNombre.TextboxEstado = Negocio.MTextBox.Estados.Solo_letras;
            this.txtNombre.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(107, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 27);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cbxActivo
            // 
            this.cbxActivo.AutoSize = true;
            this.cbxActivo.Location = new System.Drawing.Point(247, 27);
            this.cbxActivo.Name = "cbxActivo";
            this.cbxActivo.Size = new System.Drawing.Size(56, 17);
            this.cbxActivo.TabIndex = 38;
            this.cbxActivo.Text = "Activo";
            this.cbxActivo.UseVisualStyleBackColor = true;
            this.cbxActivo.Visible = false;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbtnMujer);
            this.gbSexo.Controls.Add(this.rbtnHombre);
            this.gbSexo.Location = new System.Drawing.Point(54, 340);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(185, 47);
            this.gbSexo.TabIndex = 34;
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
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(63, 398);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 27);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Location = new System.Drawing.Point(51, 168);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(35, 13);
            this.lbMail.TabIndex = 31;
            this.lbMail.Text = "Mail : ";
            // 
            // lbFechaNac
            // 
            this.lbFechaNac.AutoSize = true;
            this.lbFechaNac.Location = new System.Drawing.Point(51, 140);
            this.lbFechaNac.Name = "lbFechaNac";
            this.lbFechaNac.Size = new System.Drawing.Size(69, 13);
            this.lbFechaNac.TabIndex = 29;
            this.lbFechaNac.Text = "Fecha Nac. :";
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Location = new System.Drawing.Point(51, 112);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(32, 13);
            this.lbDni.TabIndex = 27;
            this.lbDni.Text = "DNI :";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(51, 84);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(50, 13);
            this.lbApellido.TabIndex = 26;
            this.lbApellido.Text = "Apellido :";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(51, 56);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(50, 13);
            this.lbNombre.TabIndex = 23;
            this.lbNombre.Text = "Nombre :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(310, 24);
            this.menuStrip1.TabIndex = 36;
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
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Visible = false;
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Visible = false;
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // cboRol
            // 
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(155, 193);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(100, 21);
            this.cboRol.TabIndex = 46;
            this.cboRol.Visible = false;
            // 
            // lblTipoEmpleado
            // 
            this.lblTipoEmpleado.AutoSize = true;
            this.lblTipoEmpleado.Location = new System.Drawing.Point(51, 196);
            this.lblTipoEmpleado.Name = "lblTipoEmpleado";
            this.lblTipoEmpleado.Size = new System.Drawing.Size(96, 13);
            this.lblTipoEmpleado.TabIndex = 47;
            this.lblTipoEmpleado.Text = "Tipo de Empleado:";
            // 
            // ErrorNombre
            // 
            this.ErrorNombre.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorNombre.ContainerControl = this;
            this.ErrorNombre.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorNombre.Icon")));
            // 
            // ErrorApellido
            // 
            this.ErrorApellido.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorApellido.ContainerControl = this;
            this.ErrorApellido.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorApellido.Icon")));
            // 
            // ErrorDNI
            // 
            this.ErrorDNI.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorDNI.ContainerControl = this;
            this.ErrorDNI.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorDNI.Icon")));
            // 
            // ErrorFecha
            // 
            this.ErrorFecha.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorFecha.ContainerControl = this;
            this.ErrorFecha.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorFecha.Icon")));
            // 
            // ErrorMail
            // 
            this.ErrorMail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorMail.ContainerControl = this;
            this.ErrorMail.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorMail.Icon")));
            // 
            // ErrorTipo
            // 
            this.ErrorTipo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorTipo.ContainerControl = this;
            this.ErrorTipo.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorTipo.Icon")));
            // 
            // ErrorTE
            // 
            this.ErrorTE.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorTE.ContainerControl = this;
            this.ErrorTE.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorTE.Icon")));
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(310, 469);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.lblTipoEmpleado);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.gbTelefono.ResumeLayout(false);
            this.gbTelefono.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorTE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnUltimo;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Label lblNroId;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.GroupBox gbTelefono;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblNumero;
        public System.Windows.Forms.ComboBox cboTipoTelefono;
        private System.Windows.Forms.Label lblTipoTelefono;
        public Negocio.MTextBox txtContacto;
        public Negocio.MTextBox txtNumero;
        public Negocio.MTextBox txtMail;
        public System.Windows.Forms.DateTimePicker dtpFechaNac;
        public Negocio.MTextBox txtDni;
        public Negocio.MTextBox txtApellido;
        public Negocio.MTextBox txtNombre;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.CheckBox cbxActivo;
        private System.Windows.Forms.GroupBox gbSexo;
        public System.Windows.Forms.RadioButton rbtnMujer;
        public System.Windows.Forms.RadioButton rbtnHombre;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbFechaNac;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        public System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Label lblTipoEmpleado;
        private System.Windows.Forms.ErrorProvider ErrorNombre;
        private System.Windows.Forms.ErrorProvider ErrorApellido;
        private System.Windows.Forms.ErrorProvider ErrorDNI;
        private System.Windows.Forms.ErrorProvider ErrorFecha;
        private System.Windows.Forms.ErrorProvider ErrorMail;
        private System.Windows.Forms.ErrorProvider ErrorTipo;
        private System.Windows.Forms.ErrorProvider ErrorTE;
    }
}