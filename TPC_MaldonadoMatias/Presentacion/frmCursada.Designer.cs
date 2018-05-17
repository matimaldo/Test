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
            this.gbDia = new System.Windows.Forms.GroupBox();
            this.cbxSabado = new System.Windows.Forms.CheckBox();
            this.cbxViernes = new System.Windows.Forms.CheckBox();
            this.cbxJueves = new System.Windows.Forms.CheckBox();
            this.cbxMiercoles = new System.Windows.Forms.CheckBox();
            this.cbxMartes = new System.Windows.Forms.CheckBox();
            this.cbxLunes = new System.Windows.Forms.CheckBox();
            this.lbSabado = new System.Windows.Forms.ListBox();
            this.lbViernes = new System.Windows.Forms.ListBox();
            this.lbJueves = new System.Windows.Forms.ListBox();
            this.lbMiercoles = new System.Windows.Forms.ListBox();
            this.lbMartes = new System.Windows.Forms.ListBox();
            this.lbLunes = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.cboAula = new System.Windows.Forms.ComboBox();
            this.lblAula = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbDia.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
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
            this.lblCurso.Location = new System.Drawing.Point(161, 51);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(40, 13);
            this.lblCurso.TabIndex = 1;
            this.lblCurso.Text = "Curso :";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(161, 78);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(70, 13);
            this.lblAnio.TabIndex = 2;
            this.lblAnio.Text = "Año Lectivo :";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(161, 105);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(52, 13);
            this.lblProfesor.TabIndex = 3;
            this.lblProfesor.Text = "Profesor :";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(440, 51);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(55, 13);
            this.lblComision.TabIndex = 5;
            this.lblComision.Text = "Comisión :";
            // 
            // cboCurso
            // 
            this.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(273, 48);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(121, 21);
            this.cboCurso.TabIndex = 8;
            // 
            // cboAnio
            // 
            this.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Location = new System.Drawing.Point(273, 75);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(121, 21);
            this.cboAnio.TabIndex = 9;
            // 
            // cboProfesor
            // 
            this.cboProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfesor.FormattingEnabled = true;
            this.cboProfesor.Location = new System.Drawing.Point(273, 102);
            this.cboProfesor.Name = "cboProfesor";
            this.cboProfesor.Size = new System.Drawing.Size(121, 21);
            this.cboProfesor.TabIndex = 10;
            // 
            // cboComision
            // 
            this.cboComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComision.FormattingEnabled = true;
            this.cboComision.Location = new System.Drawing.Point(512, 48);
            this.cboComision.Name = "cboComision";
            this.cboComision.Size = new System.Drawing.Size(121, 21);
            this.cboComision.TabIndex = 12;
            // 
            // gbDia
            // 
            this.gbDia.Controls.Add(this.cbxSabado);
            this.gbDia.Controls.Add(this.cbxViernes);
            this.gbDia.Controls.Add(this.cbxJueves);
            this.gbDia.Controls.Add(this.cbxMiercoles);
            this.gbDia.Controls.Add(this.cbxMartes);
            this.gbDia.Controls.Add(this.cbxLunes);
            this.gbDia.Controls.Add(this.lbSabado);
            this.gbDia.Controls.Add(this.lbViernes);
            this.gbDia.Controls.Add(this.lbJueves);
            this.gbDia.Controls.Add(this.lbMiercoles);
            this.gbDia.Controls.Add(this.lbMartes);
            this.gbDia.Controls.Add(this.lbLunes);
            this.gbDia.Location = new System.Drawing.Point(12, 143);
            this.gbDia.Name = "gbDia";
            this.gbDia.Size = new System.Drawing.Size(776, 171);
            this.gbDia.TabIndex = 13;
            this.gbDia.TabStop = false;
            this.gbDia.Text = "Dias Cursada";
            // 
            // cbxSabado
            // 
            this.cbxSabado.AutoSize = true;
            this.cbxSabado.Location = new System.Drawing.Point(670, 29);
            this.cbxSabado.Name = "cbxSabado";
            this.cbxSabado.Size = new System.Drawing.Size(63, 17);
            this.cbxSabado.TabIndex = 16;
            this.cbxSabado.Text = "Sabado";
            this.cbxSabado.UseVisualStyleBackColor = true;
            this.cbxSabado.CheckedChanged += new System.EventHandler(this.cbxSabado_CheckedChanged);
            // 
            // cbxViernes
            // 
            this.cbxViernes.AutoSize = true;
            this.cbxViernes.Location = new System.Drawing.Point(542, 29);
            this.cbxViernes.Name = "cbxViernes";
            this.cbxViernes.Size = new System.Drawing.Size(61, 17);
            this.cbxViernes.TabIndex = 15;
            this.cbxViernes.Text = "Viernes";
            this.cbxViernes.UseVisualStyleBackColor = true;
            this.cbxViernes.CheckedChanged += new System.EventHandler(this.cbxViernes_CheckedChanged);
            // 
            // cbxJueves
            // 
            this.cbxJueves.AutoSize = true;
            this.cbxJueves.Location = new System.Drawing.Point(414, 29);
            this.cbxJueves.Name = "cbxJueves";
            this.cbxJueves.Size = new System.Drawing.Size(60, 17);
            this.cbxJueves.TabIndex = 14;
            this.cbxJueves.Text = "Jueves";
            this.cbxJueves.UseVisualStyleBackColor = true;
            this.cbxJueves.CheckedChanged += new System.EventHandler(this.cbxJueves_CheckedChanged);
            // 
            // cbxMiercoles
            // 
            this.cbxMiercoles.AutoSize = true;
            this.cbxMiercoles.Location = new System.Drawing.Point(286, 29);
            this.cbxMiercoles.Name = "cbxMiercoles";
            this.cbxMiercoles.Size = new System.Drawing.Size(71, 17);
            this.cbxMiercoles.TabIndex = 13;
            this.cbxMiercoles.Text = "Miercoles";
            this.cbxMiercoles.UseVisualStyleBackColor = true;
            this.cbxMiercoles.CheckedChanged += new System.EventHandler(this.cbxMiercoles_CheckedChanged);
            // 
            // cbxMartes
            // 
            this.cbxMartes.AutoSize = true;
            this.cbxMartes.Location = new System.Drawing.Point(158, 29);
            this.cbxMartes.Name = "cbxMartes";
            this.cbxMartes.Size = new System.Drawing.Size(58, 17);
            this.cbxMartes.TabIndex = 12;
            this.cbxMartes.Text = "Martes";
            this.cbxMartes.UseVisualStyleBackColor = true;
            this.cbxMartes.CheckedChanged += new System.EventHandler(this.cbxMartes_CheckedChanged);
            // 
            // cbxLunes
            // 
            this.cbxLunes.AutoSize = true;
            this.cbxLunes.Location = new System.Drawing.Point(31, 29);
            this.cbxLunes.Name = "cbxLunes";
            this.cbxLunes.Size = new System.Drawing.Size(55, 17);
            this.cbxLunes.TabIndex = 11;
            this.cbxLunes.Text = "Lunes";
            this.cbxLunes.UseVisualStyleBackColor = true;
            this.cbxLunes.CheckedChanged += new System.EventHandler(this.cbxLunes_CheckedChanged);
            // 
            // lbSabado
            // 
            this.lbSabado.FormattingEnabled = true;
            this.lbSabado.Items.AddRange(new object[] {
            "8:00 - 9:00",
            "9:00 - 10:00",
            "10:00 - 11:00",
            "11:00 - 12:00",
            "12:00 - 13:00",
            "16:00 - 17:00",
            "17:00 - 18:00",
            "18:00 - 19:00",
            "19:00 - 20:00",
            "20:00 - 21:00"});
            this.lbSabado.Location = new System.Drawing.Point(646, 62);
            this.lbSabado.Name = "lbSabado";
            this.lbSabado.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSabado.Size = new System.Drawing.Size(120, 95);
            this.lbSabado.TabIndex = 10;
            this.lbSabado.Visible = false;
            // 
            // lbViernes
            // 
            this.lbViernes.FormattingEnabled = true;
            this.lbViernes.Items.AddRange(new object[] {
            "8:00 - 9:00",
            "9:00 - 10:00",
            "10:00 - 11:00",
            "11:00 - 12:00",
            "12:00 - 13:00",
            "16:00 - 17:00",
            "17:00 - 18:00",
            "18:00 - 19:00",
            "19:00 - 20:00",
            "20:00 - 21:00"});
            this.lbViernes.Location = new System.Drawing.Point(518, 62);
            this.lbViernes.Name = "lbViernes";
            this.lbViernes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbViernes.Size = new System.Drawing.Size(120, 95);
            this.lbViernes.TabIndex = 4;
            this.lbViernes.Visible = false;
            // 
            // lbJueves
            // 
            this.lbJueves.FormattingEnabled = true;
            this.lbJueves.Items.AddRange(new object[] {
            "8:00 - 9:00",
            "9:00 - 10:00",
            "10:00 - 11:00",
            "11:00 - 12:00",
            "12:00 - 13:00",
            "16:00 - 17:00",
            "17:00 - 18:00",
            "18:00 - 19:00",
            "19:00 - 20:00",
            "20:00 - 21:00"});
            this.lbJueves.Location = new System.Drawing.Point(390, 62);
            this.lbJueves.Name = "lbJueves";
            this.lbJueves.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbJueves.Size = new System.Drawing.Size(120, 95);
            this.lbJueves.TabIndex = 3;
            this.lbJueves.Visible = false;
            // 
            // lbMiercoles
            // 
            this.lbMiercoles.FormattingEnabled = true;
            this.lbMiercoles.Items.AddRange(new object[] {
            "8:00 - 9:00",
            "9:00 - 10:00",
            "10:00 - 11:00",
            "11:00 - 12:00",
            "12:00 - 13:00",
            "16:00 - 17:00",
            "17:00 - 18:00",
            "18:00 - 19:00",
            "19:00 - 20:00",
            "20:00 - 21:00"});
            this.lbMiercoles.Location = new System.Drawing.Point(262, 62);
            this.lbMiercoles.Name = "lbMiercoles";
            this.lbMiercoles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbMiercoles.Size = new System.Drawing.Size(120, 95);
            this.lbMiercoles.TabIndex = 2;
            this.lbMiercoles.Visible = false;
            // 
            // lbMartes
            // 
            this.lbMartes.FormattingEnabled = true;
            this.lbMartes.Items.AddRange(new object[] {
            "8:00 - 9:00",
            "9:00 - 10:00",
            "10:00 - 11:00",
            "11:00 - 12:00",
            "12:00 - 13:00",
            "16:00 - 17:00",
            "17:00 - 18:00",
            "18:00 - 19:00",
            "19:00 - 20:00",
            "20:00 - 21:00"});
            this.lbMartes.Location = new System.Drawing.Point(134, 62);
            this.lbMartes.Name = "lbMartes";
            this.lbMartes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbMartes.Size = new System.Drawing.Size(120, 95);
            this.lbMartes.TabIndex = 1;
            this.lbMartes.Visible = false;
            // 
            // lbLunes
            // 
            this.lbLunes.FormattingEnabled = true;
            this.lbLunes.Items.AddRange(new object[] {
            "8:00 - 9:00",
            "9:00 - 10:00",
            "10:00 - 11:00",
            "11:00 - 12:00",
            "12:00 - 13:00",
            "16:00 - 17:00",
            "17:00 - 18:00",
            "18:00 - 19:00",
            "19:00 - 20:00",
            "20:00 - 21:00"});
            this.lbLunes.Location = new System.Drawing.Point(6, 62);
            this.lbLunes.Name = "lbLunes";
            this.lbLunes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbLunes.Size = new System.Drawing.Size(120, 95);
            this.lbLunes.TabIndex = 0;
            this.lbLunes.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(341, 320);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(703, 27);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 23);
            this.btnCopiar.TabIndex = 15;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // cboAula
            // 
            this.cboAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAula.FormattingEnabled = true;
            this.cboAula.Location = new System.Drawing.Point(512, 75);
            this.cboAula.Name = "cboAula";
            this.cboAula.Size = new System.Drawing.Size(121, 21);
            this.cboAula.TabIndex = 17;
            // 
            // lblAula
            // 
            this.lblAula.AutoSize = true;
            this.lblAula.Location = new System.Drawing.Point(441, 78);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(34, 13);
            this.lblAula.TabIndex = 16;
            this.lblAula.Text = "Aula :";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(441, 105);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad :";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(512, 102);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(32, 20);
            this.txtCantidad.TabIndex = 11;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(662, 105);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(83, 23);
            this.btnSeleccionar.TabIndex = 18;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // frmCursada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.cboAula);
            this.Controls.Add(this.lblAula);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbDia);
            this.Controls.Add(this.cboComision);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cboProfesor);
            this.Controls.Add(this.cboAnio);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCursada";
            this.Text = "Cursada";
            this.Load += new System.EventHandler(this.frmCursada_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbDia.ResumeLayout(false);
            this.gbDia.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbDia;
        private System.Windows.Forms.ListBox lbSabado;
        private System.Windows.Forms.ListBox lbViernes;
        private System.Windows.Forms.ListBox lbJueves;
        private System.Windows.Forms.ListBox lbMiercoles;
        private System.Windows.Forms.ListBox lbMartes;
        private System.Windows.Forms.ListBox lbLunes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox cbxSabado;
        private System.Windows.Forms.CheckBox cbxViernes;
        private System.Windows.Forms.CheckBox cbxJueves;
        private System.Windows.Forms.CheckBox cbxMiercoles;
        private System.Windows.Forms.CheckBox cbxMartes;
        private System.Windows.Forms.CheckBox cbxLunes;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.ComboBox cboAula;
        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}