namespace Presentacion
{
    partial class frmCargarNotas
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
            this.cboExamen = new System.Windows.Forms.ComboBox();
            this.lbExamen = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lbComision = new System.Windows.Forms.Label();
            this.lbCurso = new System.Windows.Forms.Label();
            this.lbAnio = new System.Windows.Forms.Label();
            this.cboComision = new System.Windows.Forms.ComboBox();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnGuardarEnviar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboExamen
            // 
            this.cboExamen.FormattingEnabled = true;
            this.cboExamen.Location = new System.Drawing.Point(183, 63);
            this.cboExamen.Name = "cboExamen";
            this.cboExamen.Size = new System.Drawing.Size(107, 21);
            this.cboExamen.TabIndex = 30;
            // 
            // lbExamen
            // 
            this.lbExamen.AutoSize = true;
            this.lbExamen.Location = new System.Drawing.Point(72, 66);
            this.lbExamen.Name = "lbExamen";
            this.lbExamen.Size = new System.Drawing.Size(51, 13);
            this.lbExamen.TabIndex = 28;
            this.lbExamen.Text = "Examen :";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(517, 74);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(80, 23);
            this.btnSeleccionar.TabIndex = 26;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // lbComision
            // 
            this.lbComision.AutoSize = true;
            this.lbComision.Location = new System.Drawing.Point(319, 27);
            this.lbComision.Name = "lbComision";
            this.lbComision.Size = new System.Drawing.Size(55, 13);
            this.lbComision.TabIndex = 25;
            this.lbComision.Text = "Comision :";
            // 
            // lbCurso
            // 
            this.lbCurso.AutoSize = true;
            this.lbCurso.Location = new System.Drawing.Point(137, 27);
            this.lbCurso.Name = "lbCurso";
            this.lbCurso.Size = new System.Drawing.Size(40, 13);
            this.lbCurso.TabIndex = 24;
            this.lbCurso.Text = "Curso :";
            // 
            // lbAnio
            // 
            this.lbAnio.AutoSize = true;
            this.lbAnio.Location = new System.Drawing.Point(26, 27);
            this.lbAnio.Name = "lbAnio";
            this.lbAnio.Size = new System.Drawing.Size(32, 13);
            this.lbAnio.TabIndex = 23;
            this.lbAnio.Text = "Año :";
            // 
            // cboComision
            // 
            this.cboComision.FormattingEnabled = true;
            this.cboComision.Location = new System.Drawing.Point(380, 24);
            this.cboComision.Name = "cboComision";
            this.cboComision.Size = new System.Drawing.Size(96, 21);
            this.cboComision.TabIndex = 22;
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(183, 24);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(121, 21);
            this.cboCurso.TabIndex = 21;
            // 
            // cboAnio
            // 
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Location = new System.Drawing.Point(64, 24);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(59, 21);
            this.cboAnio.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 244);
            this.dataGridView1.TabIndex = 31;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(140, 395);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 23);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarEnviar
            // 
            this.btnGuardarEnviar.Location = new System.Drawing.Point(239, 395);
            this.btnGuardarEnviar.Name = "btnGuardarEnviar";
            this.btnGuardarEnviar.Size = new System.Drawing.Size(107, 23);
            this.btnGuardarEnviar.TabIndex = 33;
            this.btnGuardarEnviar.Text = "Guardar y Enviar";
            this.btnGuardarEnviar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(365, 395);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(80, 23);
            this.btnEnviar.TabIndex = 34;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // frmCargarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(622, 430);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnGuardarEnviar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboExamen);
            this.Controls.Add(this.lbExamen);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lbComision);
            this.Controls.Add(this.lbCurso);
            this.Controls.Add(this.lbAnio);
            this.Controls.Add(this.cboComision);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.cboAnio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCargarNotas";
            this.Text = "Cargar Notas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboExamen;
        private System.Windows.Forms.Label lbExamen;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lbComision;
        private System.Windows.Forms.Label lbCurso;
        private System.Windows.Forms.Label lbAnio;
        private System.Windows.Forms.ComboBox cboComision;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnGuardarEnviar;
        private System.Windows.Forms.Button btnEnviar;
    }
}