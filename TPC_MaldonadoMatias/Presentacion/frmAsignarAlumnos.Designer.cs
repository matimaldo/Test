namespace Presentacion
{
    partial class frmAsignarAlumnos
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
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.cboComision = new System.Windows.Forms.ComboBox();
            this.lbAnio = new System.Windows.Forms.Label();
            this.lbCurso = new System.Windows.Forms.Label();
            this.lbComision = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.lblNoInscriptos = new System.Windows.Forms.Label();
            this.lblInscriptos = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lbMsj = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbDisponible = new System.Windows.Forms.ListBox();
            this.lbEnCurso = new System.Windows.Forms.ListBox();
            this.lblCantEnCurso = new System.Windows.Forms.Label();
            this.lblBarra = new System.Windows.Forms.Label();
            this.lblCantMax = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboAnio
            // 
            this.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Location = new System.Drawing.Point(84, 36);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(59, 21);
            this.cboAnio.TabIndex = 0;
            this.cboAnio.SelectedIndexChanged += new System.EventHandler(this.cboAnio_SelectedIndexChanged);
            this.cboAnio.SelectionChangeCommitted += new System.EventHandler(this.cboAnio_SelectionChangeCommitted);
            // 
            // cboCurso
            // 
            this.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(203, 36);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(121, 21);
            this.cboCurso.TabIndex = 1;
            this.cboCurso.SelectedIndexChanged += new System.EventHandler(this.cboCurso_SelectedIndexChanged);
            this.cboCurso.SelectionChangeCommitted += new System.EventHandler(this.cboCurso_SelectionChangeCommitted);
            // 
            // cboComision
            // 
            this.cboComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComision.FormattingEnabled = true;
            this.cboComision.Location = new System.Drawing.Point(410, 36);
            this.cboComision.Name = "cboComision";
            this.cboComision.Size = new System.Drawing.Size(96, 21);
            this.cboComision.TabIndex = 2;
            this.cboComision.SelectedIndexChanged += new System.EventHandler(this.cboComision_SelectedIndexChanged);
            // 
            // lbAnio
            // 
            this.lbAnio.AutoSize = true;
            this.lbAnio.Location = new System.Drawing.Point(46, 39);
            this.lbAnio.Name = "lbAnio";
            this.lbAnio.Size = new System.Drawing.Size(32, 13);
            this.lbAnio.TabIndex = 3;
            this.lbAnio.Text = "Año :";
            // 
            // lbCurso
            // 
            this.lbCurso.AutoSize = true;
            this.lbCurso.Location = new System.Drawing.Point(157, 39);
            this.lbCurso.Name = "lbCurso";
            this.lbCurso.Size = new System.Drawing.Size(40, 13);
            this.lbCurso.TabIndex = 4;
            this.lbCurso.Text = "Curso :";
            // 
            // lbComision
            // 
            this.lbComision.AutoSize = true;
            this.lbComision.Location = new System.Drawing.Point(339, 39);
            this.lbComision.Name = "lbComision";
            this.lbComision.Size = new System.Drawing.Size(55, 13);
            this.lbComision.TabIndex = 5;
            this.lbComision.Text = "Comision :";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(530, 34);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(80, 23);
            this.btnSeleccionar.TabIndex = 6;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(296, 155);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = ">";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(296, 200);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 8;
            this.btnSacar.Text = "<";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // lblNoInscriptos
            // 
            this.lblNoInscriptos.AutoSize = true;
            this.lblNoInscriptos.Location = new System.Drawing.Point(38, 85);
            this.lblNoInscriptos.Name = "lblNoInscriptos";
            this.lblNoInscriptos.Size = new System.Drawing.Size(69, 13);
            this.lblNoInscriptos.TabIndex = 11;
            this.lblNoInscriptos.Text = "No Inscriptos";
            // 
            // lblInscriptos
            // 
            this.lblInscriptos.AutoSize = true;
            this.lblInscriptos.Location = new System.Drawing.Point(407, 85);
            this.lblInscriptos.Name = "lblInscriptos";
            this.lblInscriptos.Size = new System.Drawing.Size(52, 13);
            this.lblInscriptos.TabIndex = 12;
            this.lblInscriptos.Text = "Inscriptos";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(296, 318);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lbMsj
            // 
            this.lbMsj.AutoSize = true;
            this.lbMsj.Location = new System.Drawing.Point(536, 304);
            this.lbMsj.Name = "lbMsj";
            this.lbMsj.Size = new System.Drawing.Size(32, 13);
            this.lbMsj.TabIndex = 14;
            this.lbMsj.Text = "Cant:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // lbDisponible
            // 
            this.lbDisponible.FormattingEnabled = true;
            this.lbDisponible.Location = new System.Drawing.Point(41, 119);
            this.lbDisponible.Name = "lbDisponible";
            this.lbDisponible.Size = new System.Drawing.Size(213, 173);
            this.lbDisponible.TabIndex = 16;
            // 
            // lbEnCurso
            // 
            this.lbEnCurso.FormattingEnabled = true;
            this.lbEnCurso.Location = new System.Drawing.Point(410, 119);
            this.lbEnCurso.Name = "lbEnCurso";
            this.lbEnCurso.Size = new System.Drawing.Size(213, 173);
            this.lbEnCurso.TabIndex = 17;
            // 
            // lblCantEnCurso
            // 
            this.lblCantEnCurso.AutoSize = true;
            this.lblCantEnCurso.Location = new System.Drawing.Point(575, 304);
            this.lblCantEnCurso.Name = "lblCantEnCurso";
            this.lblCantEnCurso.Size = new System.Drawing.Size(12, 13);
            this.lblCantEnCurso.TabIndex = 18;
            this.lblCantEnCurso.Text = "x";
            // 
            // lblBarra
            // 
            this.lblBarra.AutoSize = true;
            this.lblBarra.Location = new System.Drawing.Point(591, 304);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(12, 13);
            this.lblBarra.TabIndex = 19;
            this.lblBarra.Text = "/";
            // 
            // lblCantMax
            // 
            this.lblCantMax.AutoSize = true;
            this.lblCantMax.Location = new System.Drawing.Point(607, 304);
            this.lblCantMax.Name = "lblCantMax";
            this.lblCantMax.Size = new System.Drawing.Size(12, 13);
            this.lblCantMax.TabIndex = 20;
            this.lblCantMax.Text = "x";
            // 
            // frmAsignarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(664, 354);
            this.Controls.Add(this.lblCantMax);
            this.Controls.Add(this.lblBarra);
            this.Controls.Add(this.lblCantEnCurso);
            this.Controls.Add(this.lbEnCurso);
            this.Controls.Add(this.lbDisponible);
            this.Controls.Add(this.lbMsj);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblInscriptos);
            this.Controls.Add(this.lblNoInscriptos);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lbComision);
            this.Controls.Add(this.lbCurso);
            this.Controls.Add(this.lbAnio);
            this.Controls.Add(this.cboComision);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.cboAnio);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAsignarAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion de Alumnos";
            this.Load += new System.EventHandler(this.frmAsignarAlumnos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.ComboBox cboComision;
        private System.Windows.Forms.Label lbAnio;
        private System.Windows.Forms.Label lbCurso;
        private System.Windows.Forms.Label lbComision;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label lblNoInscriptos;
        private System.Windows.Forms.Label lblInscriptos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lbMsj;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ListBox lbDisponible;
        private System.Windows.Forms.ListBox lbEnCurso;
        private System.Windows.Forms.Label lblCantEnCurso;
        private System.Windows.Forms.Label lblBarra;
        private System.Windows.Forms.Label lblCantMax;
    }
}