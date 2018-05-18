namespace Presentacion
{
    partial class frmEnvioNotas
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cboCursada = new System.Windows.Forms.ComboBox();
            this.cboExamen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(94, 116);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // cboCursada
            // 
            this.cboCursada.FormattingEnabled = true;
            this.cboCursada.Location = new System.Drawing.Point(73, 34);
            this.cboCursada.Name = "cboCursada";
            this.cboCursada.Size = new System.Drawing.Size(121, 21);
            this.cboCursada.TabIndex = 1;
            // 
            // cboExamen
            // 
            this.cboExamen.FormattingEnabled = true;
            this.cboExamen.Location = new System.Drawing.Point(73, 74);
            this.cboExamen.Name = "cboExamen";
            this.cboExamen.Size = new System.Drawing.Size(121, 21);
            this.cboExamen.TabIndex = 2;
            // 
            // frmEnvioNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(262, 163);
            this.Controls.Add(this.cboExamen);
            this.Controls.Add(this.cboCursada);
            this.Controls.Add(this.btnEnviar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEnvioNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio Notas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cboCursada;
        private System.Windows.Forms.ComboBox cboExamen;
    }
}