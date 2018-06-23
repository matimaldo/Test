namespace Presentacion
{
    partial class frmEnviarMail
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbFecha = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lbAsunto = new System.Windows.Forms.Label();
            this.lbDetalle = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.rbtnAcademia = new System.Windows.Forms.RadioButton();
            this.gbDe = new System.Windows.Forms.GroupBox();
            this.rbtnProfesor = new System.Windows.Forms.RadioButton();
            this.gbPara = new System.Windows.Forms.GroupBox();
            this.cboCursada = new System.Windows.Forms.ComboBox();
            this.rbtnCurso = new System.Windows.Forms.RadioButton();
            this.rbtnTodos = new System.Windows.Forms.RadioButton();
            this.gbDe.SuspendLayout();
            this.gbPara.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 20);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(20, 28);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(43, 13);
            this.lbFecha.TabIndex = 46;
            this.lbFecha.Text = "Fecha :";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(83, 155);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(142, 20);
            this.txtAsunto.TabIndex = 49;
            // 
            // lbAsunto
            // 
            this.lbAsunto.AutoSize = true;
            this.lbAsunto.Location = new System.Drawing.Point(31, 158);
            this.lbAsunto.Name = "lbAsunto";
            this.lbAsunto.Size = new System.Drawing.Size(46, 13);
            this.lbAsunto.TabIndex = 48;
            this.lbAsunto.Text = "Asunto :";
            // 
            // lbDetalle
            // 
            this.lbDetalle.AutoSize = true;
            this.lbDetalle.Location = new System.Drawing.Point(31, 186);
            this.lbDetalle.Name = "lbDetalle";
            this.lbDetalle.Size = new System.Drawing.Size(46, 13);
            this.lbDetalle.TabIndex = 51;
            this.lbDetalle.Text = "Detalle :";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(12, 212);
            this.txtDetalle.MaxLength = 250;
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(429, 96);
            this.txtDetalle.TabIndex = 50;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(161, 314);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 52;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar1_Click);
            // 
            // rbtnAcademia
            // 
            this.rbtnAcademia.AutoSize = true;
            this.rbtnAcademia.Checked = true;
            this.rbtnAcademia.Location = new System.Drawing.Point(35, 14);
            this.rbtnAcademia.Name = "rbtnAcademia";
            this.rbtnAcademia.Size = new System.Drawing.Size(72, 17);
            this.rbtnAcademia.TabIndex = 54;
            this.rbtnAcademia.TabStop = true;
            this.rbtnAcademia.Text = "Academia";
            this.rbtnAcademia.UseVisualStyleBackColor = true;
            // 
            // gbDe
            // 
            this.gbDe.Controls.Add(this.rbtnProfesor);
            this.gbDe.Controls.Add(this.rbtnAcademia);
            this.gbDe.Location = new System.Drawing.Point(23, 57);
            this.gbDe.Name = "gbDe";
            this.gbDe.Size = new System.Drawing.Size(418, 41);
            this.gbDe.TabIndex = 55;
            this.gbDe.TabStop = false;
            this.gbDe.Text = "De:";
            // 
            // rbtnProfesor
            // 
            this.rbtnProfesor.AutoSize = true;
            this.rbtnProfesor.Location = new System.Drawing.Point(138, 14);
            this.rbtnProfesor.Name = "rbtnProfesor";
            this.rbtnProfesor.Size = new System.Drawing.Size(64, 17);
            this.rbtnProfesor.TabIndex = 55;
            this.rbtnProfesor.Text = "Profesor";
            this.rbtnProfesor.UseVisualStyleBackColor = true;
            // 
            // gbPara
            // 
            this.gbPara.Controls.Add(this.cboCursada);
            this.gbPara.Controls.Add(this.rbtnCurso);
            this.gbPara.Controls.Add(this.rbtnTodos);
            this.gbPara.Location = new System.Drawing.Point(23, 104);
            this.gbPara.Name = "gbPara";
            this.gbPara.Size = new System.Drawing.Size(418, 41);
            this.gbPara.TabIndex = 56;
            this.gbPara.TabStop = false;
            this.gbPara.Text = "Para:";
            // 
            // cboCursada
            // 
            this.cboCursada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCursada.Enabled = false;
            this.cboCursada.FormattingEnabled = true;
            this.cboCursada.Location = new System.Drawing.Point(218, 14);
            this.cboCursada.Name = "cboCursada";
            this.cboCursada.Size = new System.Drawing.Size(167, 21);
            this.cboCursada.TabIndex = 56;
            // 
            // rbtnCurso
            // 
            this.rbtnCurso.AutoSize = true;
            this.rbtnCurso.Location = new System.Drawing.Point(138, 14);
            this.rbtnCurso.Name = "rbtnCurso";
            this.rbtnCurso.Size = new System.Drawing.Size(52, 17);
            this.rbtnCurso.TabIndex = 55;
            this.rbtnCurso.Text = "Curso";
            this.rbtnCurso.UseVisualStyleBackColor = true;
            this.rbtnCurso.CheckedChanged += new System.EventHandler(this.rbtnCurso_CheckedChanged);
            // 
            // rbtnTodos
            // 
            this.rbtnTodos.AutoSize = true;
            this.rbtnTodos.Checked = true;
            this.rbtnTodos.Location = new System.Drawing.Point(35, 14);
            this.rbtnTodos.Name = "rbtnTodos";
            this.rbtnTodos.Size = new System.Drawing.Size(55, 17);
            this.rbtnTodos.TabIndex = 54;
            this.rbtnTodos.TabStop = true;
            this.rbtnTodos.Text = "Todos";
            this.rbtnTodos.UseVisualStyleBackColor = true;
            // 
            // frmEnviarMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(452, 346);
            this.Controls.Add(this.gbPara);
            this.Controls.Add(this.gbDe);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lbDetalle);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.lbAsunto);
            this.Controls.Add(this.lbFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEnviarMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar Mail";
            this.Load += new System.EventHandler(this.frmEnviarMail_Load);
            this.gbDe.ResumeLayout(false);
            this.gbDe.PerformLayout();
            this.gbPara.ResumeLayout(false);
            this.gbPara.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label lbAsunto;
        private System.Windows.Forms.Label lbDetalle;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.RadioButton rbtnAcademia;
        private System.Windows.Forms.GroupBox gbDe;
        private System.Windows.Forms.RadioButton rbtnProfesor;
        private System.Windows.Forms.GroupBox gbPara;
        private System.Windows.Forms.ComboBox cboCursada;
        private System.Windows.Forms.RadioButton rbtnCurso;
        private System.Windows.Forms.RadioButton rbtnTodos;
    }
}