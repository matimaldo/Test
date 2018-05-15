namespace Presentacion
{
    partial class frmTomarLista
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lbComision = new System.Windows.Forms.Label();
            this.lbCurso = new System.Windows.Forms.Label();
            this.lbAnio = new System.Windows.Forms.Label();
            this.cboComision = new System.Windows.Forms.ComboBox();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(286, 363);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 23);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 244);
            this.dataGridView1.TabIndex = 42;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(560, 45);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(80, 23);
            this.btnSeleccionar.TabIndex = 39;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // lbComision
            // 
            this.lbComision.AutoSize = true;
            this.lbComision.Location = new System.Drawing.Point(355, 50);
            this.lbComision.Name = "lbComision";
            this.lbComision.Size = new System.Drawing.Size(55, 13);
            this.lbComision.TabIndex = 38;
            this.lbComision.Text = "Comision :";
            // 
            // lbCurso
            // 
            this.lbCurso.AutoSize = true;
            this.lbCurso.Location = new System.Drawing.Point(173, 50);
            this.lbCurso.Name = "lbCurso";
            this.lbCurso.Size = new System.Drawing.Size(40, 13);
            this.lbCurso.TabIndex = 37;
            this.lbCurso.Text = "Curso :";
            // 
            // lbAnio
            // 
            this.lbAnio.AutoSize = true;
            this.lbAnio.Location = new System.Drawing.Point(62, 50);
            this.lbAnio.Name = "lbAnio";
            this.lbAnio.Size = new System.Drawing.Size(32, 13);
            this.lbAnio.TabIndex = 36;
            this.lbAnio.Text = "Año :";
            // 
            // cboComision
            // 
            this.cboComision.FormattingEnabled = true;
            this.cboComision.Location = new System.Drawing.Point(416, 47);
            this.cboComision.Name = "cboComision";
            this.cboComision.Size = new System.Drawing.Size(96, 21);
            this.cboComision.TabIndex = 35;
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(219, 47);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(121, 21);
            this.cboCurso.TabIndex = 34;
            // 
            // cboAnio
            // 
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Location = new System.Drawing.Point(100, 47);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(59, 21);
            this.cboAnio.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 20);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(61, 19);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(43, 13);
            this.lbFecha.TabIndex = 44;
            this.lbFecha.Text = "Fecha :";
            // 
            // frmTomarLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 400);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lbComision);
            this.Controls.Add(this.lbCurso);
            this.Controls.Add(this.lbAnio);
            this.Controls.Add(this.cboComision);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.cboAnio);
            this.Name = "frmTomarLista";
            this.Text = "Tomar Lista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lbComision;
        private System.Windows.Forms.Label lbCurso;
        private System.Windows.Forms.Label lbAnio;
        private System.Windows.Forms.ComboBox cboComision;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbFecha;
    }
}