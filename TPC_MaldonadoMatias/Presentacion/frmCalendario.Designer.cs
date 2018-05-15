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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mhcCalendario
            // 
            this.mhcCalendario.Location = new System.Drawing.Point(34, 28);
            this.mhcCalendario.Name = "mhcCalendario";
            this.mhcCalendario.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(34, 237);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 225);
            this.listBox1.TabIndex = 1;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(31, 208);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(38, 13);
            this.lblAviso.TabIndex = 2;
            this.lblAviso.Text = "Avisos";
            // 
            // frmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(254, 493);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.mhcCalendario);
            this.Location = new System.Drawing.Point(609, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Calendario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mhcCalendario;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblAviso;
    }
}