namespace Presentacion
{
    partial class frmCalendario
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
            this.mhcCalendario = new System.Windows.Forms.MonthCalendar();
            this.lbxAvisos = new System.Windows.Forms.ListBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mhcCalendario
            // 
            this.mhcCalendario.Location = new System.Drawing.Point(42, 39);
            this.mhcCalendario.MaxSelectionCount = 1;
            this.mhcCalendario.Name = "mhcCalendario";
            this.mhcCalendario.TabIndex = 0;
            this.mhcCalendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mhcCalendario_DateSelected);
            // 
            // lbxAvisos
            // 
            this.lbxAvisos.FormattingEnabled = true;
            this.lbxAvisos.Location = new System.Drawing.Point(34, 237);
            this.lbxAvisos.Name = "lbxAvisos";
            this.lbxAvisos.Size = new System.Drawing.Size(217, 251);
            this.lbxAvisos.TabIndex = 1;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(31, 214);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(38, 13);
            this.lblAviso.TabIndex = 2;
            this.lblAviso.Text = "Avisos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(238, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(20, 20);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "X";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(270, 531);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.lbxAvisos);
            this.Controls.Add(this.mhcCalendario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(609, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Calendario";
            this.Load += new System.EventHandler(this.frmCalendario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbxAvisos;
        private System.Windows.Forms.Label lblAviso;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.MonthCalendar mhcCalendario;
    }
}