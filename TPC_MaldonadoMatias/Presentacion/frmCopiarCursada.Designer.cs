namespace Presentacion
{
    partial class frmCopiarCursada
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
            this.lbCurso = new System.Windows.Forms.Label();
            this.lbAnio = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.lbComision = new System.Windows.Forms.Label();
            this.cboComision = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbCurso
            // 
            this.lbCurso.AutoSize = true;
            this.lbCurso.Location = new System.Drawing.Point(68, 31);
            this.lbCurso.Name = "lbCurso";
            this.lbCurso.Size = new System.Drawing.Size(40, 13);
            this.lbCurso.TabIndex = 0;
            this.lbCurso.Text = "Curso :";
            // 
            // lbAnio
            // 
            this.lbAnio.AutoSize = true;
            this.lbAnio.Location = new System.Drawing.Point(68, 64);
            this.lbAnio.Name = "lbAnio";
            this.lbAnio.Size = new System.Drawing.Size(32, 13);
            this.lbAnio.TabIndex = 1;
            this.lbAnio.Text = "Año :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Crear Cursada";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtCurso
            // 
            this.txtCurso.Enabled = false;
            this.txtCurso.Location = new System.Drawing.Point(137, 31);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(121, 20);
            this.txtCurso.TabIndex = 3;
            // 
            // cboAnio
            // 
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Location = new System.Drawing.Point(137, 64);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(121, 21);
            this.cboAnio.TabIndex = 4;
            // 
            // lbComision
            // 
            this.lbComision.AutoSize = true;
            this.lbComision.Location = new System.Drawing.Point(68, 98);
            this.lbComision.Name = "lbComision";
            this.lbComision.Size = new System.Drawing.Size(55, 13);
            this.lbComision.TabIndex = 5;
            this.lbComision.Text = "Comision :";
            // 
            // cboComision
            // 
            this.cboComision.FormattingEnabled = true;
            this.cboComision.Location = new System.Drawing.Point(137, 95);
            this.cboComision.Name = "cboComision";
            this.cboComision.Size = new System.Drawing.Size(121, 21);
            this.cboComision.TabIndex = 6;
            // 
            // frmCopiarCursada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(340, 204);
            this.Controls.Add(this.cboComision);
            this.Controls.Add(this.lbComision);
            this.Controls.Add(this.cboAnio);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbAnio);
            this.Controls.Add(this.lbCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCopiarCursada";
            this.Text = "Copiar Cursada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCurso;
        private System.Windows.Forms.Label lbAnio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.Label lbComision;
        private System.Windows.Forms.ComboBox cboComision;
    }
}