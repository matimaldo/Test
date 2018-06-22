namespace Presentacion
{
    partial class frmExamen
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
            this.lbFecha = new System.Windows.Forms.Label();
            this.gbTipoExamen = new System.Windows.Forms.GroupBox();
            this.rbtnFinal = new System.Windows.Forms.RadioButton();
            this.rbtnRecuperatorio = new System.Windows.Forms.RadioButton();
            this.rbtnParcial = new System.Windows.Forms.RadioButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbRecuperatorio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboRecuperatorio = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lbComision = new System.Windows.Forms.Label();
            this.lbCurso = new System.Windows.Forms.Label();
            this.lbAnio = new System.Windows.Forms.Label();
            this.cboComision = new System.Windows.Forms.ComboBox();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.gbTipoExamen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(372, 41);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(43, 13);
            this.lbFecha.TabIndex = 0;
            this.lbFecha.Text = "Fecha :";
            // 
            // gbTipoExamen
            // 
            this.gbTipoExamen.Controls.Add(this.rbtnFinal);
            this.gbTipoExamen.Controls.Add(this.rbtnRecuperatorio);
            this.gbTipoExamen.Controls.Add(this.rbtnParcial);
            this.gbTipoExamen.Location = new System.Drawing.Point(29, 20);
            this.gbTipoExamen.Name = "gbTipoExamen";
            this.gbTipoExamen.Size = new System.Drawing.Size(301, 50);
            this.gbTipoExamen.TabIndex = 14;
            this.gbTipoExamen.TabStop = false;
            this.gbTipoExamen.Text = "Tipo de Examen";
            // 
            // rbtnFinal
            // 
            this.rbtnFinal.AutoSize = true;
            this.rbtnFinal.Location = new System.Drawing.Point(232, 19);
            this.rbtnFinal.Name = "rbtnFinal";
            this.rbtnFinal.Size = new System.Drawing.Size(47, 17);
            this.rbtnFinal.TabIndex = 2;
            this.rbtnFinal.TabStop = true;
            this.rbtnFinal.Text = "Final";
            this.rbtnFinal.UseVisualStyleBackColor = true;
            this.rbtnFinal.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbtnRecuperatorio
            // 
            this.rbtnRecuperatorio.AutoSize = true;
            this.rbtnRecuperatorio.Location = new System.Drawing.Point(110, 19);
            this.rbtnRecuperatorio.Name = "rbtnRecuperatorio";
            this.rbtnRecuperatorio.Size = new System.Drawing.Size(92, 17);
            this.rbtnRecuperatorio.TabIndex = 1;
            this.rbtnRecuperatorio.TabStop = true;
            this.rbtnRecuperatorio.Text = "Recuperatorio";
            this.rbtnRecuperatorio.UseVisualStyleBackColor = true;
            this.rbtnRecuperatorio.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbtnParcial
            // 
            this.rbtnParcial.AutoSize = true;
            this.rbtnParcial.Checked = true;
            this.rbtnParcial.Location = new System.Drawing.Point(23, 19);
            this.rbtnParcial.Name = "rbtnParcial";
            this.rbtnParcial.Size = new System.Drawing.Size(57, 17);
            this.rbtnParcial.TabIndex = 0;
            this.rbtnParcial.TabStop = true;
            this.rbtnParcial.Text = "Parcial";
            this.rbtnParcial.UseVisualStyleBackColor = true;
            this.rbtnParcial.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(455, 35);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(83, 20);
            this.dtpFecha.TabIndex = 15;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(233, 133);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(50, 13);
            this.lbNombre.TabIndex = 16;
            this.lbNombre.Text = "Nombre :";
            this.lbNombre.Visible = false;
            // 
            // lbRecuperatorio
            // 
            this.lbRecuperatorio.AutoSize = true;
            this.lbRecuperatorio.Location = new System.Drawing.Point(188, 133);
            this.lbRecuperatorio.Name = "lbRecuperatorio";
            this.lbRecuperatorio.Size = new System.Drawing.Size(95, 13);
            this.lbRecuperatorio.TabIndex = 17;
            this.lbRecuperatorio.Text = "Recuperatorio de :";
            this.lbRecuperatorio.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(295, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.Visible = false;
            // 
            // cboRecuperatorio
            // 
            this.cboRecuperatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRecuperatorio.FormattingEnabled = true;
            this.cboRecuperatorio.Location = new System.Drawing.Point(295, 129);
            this.cboRecuperatorio.Name = "cboRecuperatorio";
            this.cboRecuperatorio.Size = new System.Drawing.Size(107, 21);
            this.cboRecuperatorio.TabIndex = 19;
            this.cboRecuperatorio.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(250, 175);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(505, 87);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(80, 23);
            this.btnSeleccionar.TabIndex = 27;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lbComision
            // 
            this.lbComision.AutoSize = true;
            this.lbComision.Location = new System.Drawing.Point(314, 92);
            this.lbComision.Name = "lbComision";
            this.lbComision.Size = new System.Drawing.Size(55, 13);
            this.lbComision.TabIndex = 26;
            this.lbComision.Text = "Comision :";
            // 
            // lbCurso
            // 
            this.lbCurso.AutoSize = true;
            this.lbCurso.Location = new System.Drawing.Point(132, 92);
            this.lbCurso.Name = "lbCurso";
            this.lbCurso.Size = new System.Drawing.Size(40, 13);
            this.lbCurso.TabIndex = 25;
            this.lbCurso.Text = "Curso :";
            // 
            // lbAnio
            // 
            this.lbAnio.AutoSize = true;
            this.lbAnio.Location = new System.Drawing.Point(21, 92);
            this.lbAnio.Name = "lbAnio";
            this.lbAnio.Size = new System.Drawing.Size(32, 13);
            this.lbAnio.TabIndex = 24;
            this.lbAnio.Text = "Año :";
            // 
            // cboComision
            // 
            this.cboComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComision.FormattingEnabled = true;
            this.cboComision.Location = new System.Drawing.Point(385, 89);
            this.cboComision.Name = "cboComision";
            this.cboComision.Size = new System.Drawing.Size(96, 21);
            this.cboComision.TabIndex = 23;
            this.cboComision.SelectedIndexChanged += new System.EventHandler(this.cboComision_SelectedIndexChanged);
            // 
            // cboCurso
            // 
            this.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(178, 89);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(121, 21);
            this.cboCurso.TabIndex = 22;
            this.cboCurso.SelectedIndexChanged += new System.EventHandler(this.cboCurso_SelectedIndexChanged);
            this.cboCurso.SelectionChangeCommitted += new System.EventHandler(this.cboCurso_SelectionChangeCommitted);
            // 
            // cboAnio
            // 
            this.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Location = new System.Drawing.Point(59, 89);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(59, 21);
            this.cboAnio.TabIndex = 21;
            this.cboAnio.SelectedIndexChanged += new System.EventHandler(this.cboAnio_SelectedIndexChanged);
            this.cboAnio.SelectionChangeCommitted += new System.EventHandler(this.cboAnio_SelectionChangeCommitted);
            // 
            // frmExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(601, 210);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lbComision);
            this.Controls.Add(this.lbCurso);
            this.Controls.Add(this.lbAnio);
            this.Controls.Add(this.cboComision);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.cboAnio);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.gbTipoExamen);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbRecuperatorio);
            this.Controls.Add(this.cboRecuperatorio);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examen";
            this.Load += new System.EventHandler(this.frmExamen_Load);
            this.gbTipoExamen.ResumeLayout(false);
            this.gbTipoExamen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.GroupBox gbTipoExamen;
        private System.Windows.Forms.RadioButton rbtnFinal;
        private System.Windows.Forms.RadioButton rbtnRecuperatorio;
        private System.Windows.Forms.RadioButton rbtnParcial;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbRecuperatorio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboRecuperatorio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lbComision;
        private System.Windows.Forms.Label lbCurso;
        private System.Windows.Forms.Label lbAnio;
        private System.Windows.Forms.ComboBox cboComision;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.ComboBox cboAnio;
    }
}