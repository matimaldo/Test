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
            this.lblCursada = new System.Windows.Forms.Label();
            this.lblExamen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(142, 115);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cboCursada
            // 
            this.cboCursada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCursada.FormattingEnabled = true;
            this.cboCursada.Location = new System.Drawing.Point(111, 34);
            this.cboCursada.Name = "cboCursada";
            this.cboCursada.Size = new System.Drawing.Size(190, 21);
            this.cboCursada.TabIndex = 1;
            this.cboCursada.SelectionChangeCommitted += new System.EventHandler(this.cboCursada_SelectionChangeCommitted);
            this.cboCursada.SelectedValueChanged += new System.EventHandler(this.cboCursada_SelectedValueChanged);
            // 
            // cboExamen
            // 
            this.cboExamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExamen.FormattingEnabled = true;
            this.cboExamen.Location = new System.Drawing.Point(111, 74);
            this.cboExamen.Name = "cboExamen";
            this.cboExamen.Size = new System.Drawing.Size(190, 21);
            this.cboExamen.TabIndex = 2;
            // 
            // lblCursada
            // 
            this.lblCursada.AutoSize = true;
            this.lblCursada.Location = new System.Drawing.Point(26, 37);
            this.lblCursada.Name = "lblCursada";
            this.lblCursada.Size = new System.Drawing.Size(52, 13);
            this.lblCursada.TabIndex = 3;
            this.lblCursada.Text = "Cursada :";
            // 
            // lblExamen
            // 
            this.lblExamen.AutoSize = true;
            this.lblExamen.Location = new System.Drawing.Point(26, 77);
            this.lblExamen.Name = "lblExamen";
            this.lblExamen.Size = new System.Drawing.Size(51, 13);
            this.lblExamen.TabIndex = 4;
            this.lblExamen.Text = "Examen :";
            // 
            // frmEnvioNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(343, 163);
            this.Controls.Add(this.lblExamen);
            this.Controls.Add(this.lblCursada);
            this.Controls.Add(this.cboExamen);
            this.Controls.Add(this.cboCursada);
            this.Controls.Add(this.btnEnviar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEnvioNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio Notas";
            this.Load += new System.EventHandler(this.frmEnvioNotas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cboCursada;
        private System.Windows.Forms.ComboBox cboExamen;
        private System.Windows.Forms.Label lblCursada;
        private System.Windows.Forms.Label lblExamen;
    }
}