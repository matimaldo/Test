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
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lbComision = new System.Windows.Forms.Label();
            this.lbCurso = new System.Windows.Forms.Label();
            this.lbAnio = new System.Windows.Forms.Label();
            this.cboComision = new System.Windows.Forms.ComboBox();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.gbTipoExamen = new System.Windows.Forms.GroupBox();
            this.rbtnFinal = new System.Windows.Forms.RadioButton();
            this.rbtnRecuperatorio = new System.Windows.Forms.RadioButton();
            this.rbtnParcial = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbRecuperatorio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboRecuperatorio = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
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
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(503, 88);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(80, 23);
            this.btnSeleccionar.TabIndex = 13;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // lbComision
            // 
            this.lbComision.AutoSize = true;
            this.lbComision.Location = new System.Drawing.Point(312, 93);
            this.lbComision.Name = "lbComision";
            this.lbComision.Size = new System.Drawing.Size(55, 13);
            this.lbComision.TabIndex = 12;
            this.lbComision.Text = "Comision :";
            // 
            // lbCurso
            // 
            this.lbCurso.AutoSize = true;
            this.lbCurso.Location = new System.Drawing.Point(130, 93);
            this.lbCurso.Name = "lbCurso";
            this.lbCurso.Size = new System.Drawing.Size(40, 13);
            this.lbCurso.TabIndex = 11;
            this.lbCurso.Text = "Curso :";
            // 
            // lbAnio
            // 
            this.lbAnio.AutoSize = true;
            this.lbAnio.Location = new System.Drawing.Point(19, 93);
            this.lbAnio.Name = "lbAnio";
            this.lbAnio.Size = new System.Drawing.Size(32, 13);
            this.lbAnio.TabIndex = 10;
            this.lbAnio.Text = "Año :";
            // 
            // cboComision
            // 
            this.cboComision.FormattingEnabled = true;
            this.cboComision.Location = new System.Drawing.Point(373, 90);
            this.cboComision.Name = "cboComision";
            this.cboComision.Size = new System.Drawing.Size(96, 21);
            this.cboComision.TabIndex = 9;
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(176, 90);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(121, 21);
            this.cboCurso.TabIndex = 8;
            // 
            // cboAnio
            // 
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Location = new System.Drawing.Point(57, 90);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(59, 21);
            this.cboAnio.TabIndex = 7;
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
            // 
            // rbtnParcial
            // 
            this.rbtnParcial.AutoSize = true;
            this.rbtnParcial.Location = new System.Drawing.Point(23, 19);
            this.rbtnParcial.Name = "rbtnParcial";
            this.rbtnParcial.Size = new System.Drawing.Size(57, 17);
            this.rbtnParcial.TabIndex = 0;
            this.rbtnParcial.TabStop = true;
            this.rbtnParcial.Text = "Parcial";
            this.rbtnParcial.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(455, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(52, 137);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(50, 13);
            this.lbNombre.TabIndex = 16;
            this.lbNombre.Text = "Nombre :";
            // 
            // lbRecuperatorio
            // 
            this.lbRecuperatorio.AutoSize = true;
            this.lbRecuperatorio.Location = new System.Drawing.Point(262, 137);
            this.lbRecuperatorio.Name = "lbRecuperatorio";
            this.lbRecuperatorio.Size = new System.Drawing.Size(95, 13);
            this.lbRecuperatorio.TabIndex = 17;
            this.lbRecuperatorio.Text = "Recuperatorio de :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 134);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.Text = "Parcial 1";
            // 
            // cboRecuperatorio
            // 
            this.cboRecuperatorio.FormattingEnabled = true;
            this.cboRecuperatorio.Location = new System.Drawing.Point(373, 134);
            this.cboRecuperatorio.Name = "cboRecuperatorio";
            this.cboRecuperatorio.Size = new System.Drawing.Size(107, 21);
            this.cboRecuperatorio.TabIndex = 19;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(250, 175);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(601, 210);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboRecuperatorio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbRecuperatorio);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gbTipoExamen);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lbComision);
            this.Controls.Add(this.lbCurso);
            this.Controls.Add(this.lbAnio);
            this.Controls.Add(this.cboComision);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.cboAnio);
            this.Controls.Add(this.lbFecha);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExamen";
            this.Text = "Examen";
            this.gbTipoExamen.ResumeLayout(false);
            this.gbTipoExamen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lbComision;
        private System.Windows.Forms.Label lbCurso;
        private System.Windows.Forms.Label lbAnio;
        private System.Windows.Forms.ComboBox cboComision;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.GroupBox gbTipoExamen;
        private System.Windows.Forms.RadioButton rbtnFinal;
        private System.Windows.Forms.RadioButton rbtnRecuperatorio;
        private System.Windows.Forms.RadioButton rbtnParcial;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbRecuperatorio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboRecuperatorio;
        private System.Windows.Forms.Button btnGuardar;
    }
}