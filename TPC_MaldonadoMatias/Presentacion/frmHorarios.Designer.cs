namespace Presentacion
{
    partial class frmHorarios
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblDesde = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lbHorarios = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboDesdeHora = new System.Windows.Forms.ComboBox();
            this.cboDesdeMinuto = new System.Windows.Forms.ComboBox();
            this.cboHastaMinuto = new System.Windows.Forms.ComboBox();
            this.cboHastaHora = new System.Windows.Forms.ComboBox();
            this.btnCerrrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(113, 88);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(26, 27);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(44, 13);
            this.lblDesde.TabIndex = 8;
            this.lblDesde.Text = "Desde :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = ":";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(28, 54);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(41, 13);
            this.lblHasta.TabIndex = 13;
            this.lblHasta.Text = "Hasta :";
            // 
            // lbHorarios
            // 
            this.lbHorarios.FormattingEnabled = true;
            this.lbHorarios.Location = new System.Drawing.Point(31, 127);
            this.lbHorarios.Name = "lbHorarios";
            this.lbHorarios.Size = new System.Drawing.Size(157, 160);
            this.lbHorarios.TabIndex = 17;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(29, 88);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboDesdeHora
            // 
            this.cboDesdeHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesdeHora.FormattingEnabled = true;
            this.cboDesdeHora.Location = new System.Drawing.Point(76, 24);
            this.cboDesdeHora.Name = "cboDesdeHora";
            this.cboDesdeHora.Size = new System.Drawing.Size(40, 21);
            this.cboDesdeHora.TabIndex = 19;
            this.cboDesdeHora.SelectedIndexChanged += new System.EventHandler(this.cboDesdeHora_SelectedIndexChanged);
            // 
            // cboDesdeMinuto
            // 
            this.cboDesdeMinuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesdeMinuto.FormattingEnabled = true;
            this.cboDesdeMinuto.Location = new System.Drawing.Point(133, 24);
            this.cboDesdeMinuto.Name = "cboDesdeMinuto";
            this.cboDesdeMinuto.Size = new System.Drawing.Size(40, 21);
            this.cboDesdeMinuto.TabIndex = 20;
            this.cboDesdeMinuto.SelectedIndexChanged += new System.EventHandler(this.cboDesdeMinuto_SelectedIndexChanged);
            // 
            // cboHastaMinuto
            // 
            this.cboHastaMinuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHastaMinuto.FormattingEnabled = true;
            this.cboHastaMinuto.Location = new System.Drawing.Point(133, 51);
            this.cboHastaMinuto.Name = "cboHastaMinuto";
            this.cboHastaMinuto.Size = new System.Drawing.Size(40, 21);
            this.cboHastaMinuto.TabIndex = 22;
            // 
            // cboHastaHora
            // 
            this.cboHastaHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHastaHora.FormattingEnabled = true;
            this.cboHastaHora.Location = new System.Drawing.Point(76, 51);
            this.cboHastaHora.Name = "cboHastaHora";
            this.cboHastaHora.Size = new System.Drawing.Size(40, 21);
            this.cboHastaHora.TabIndex = 21;
            this.cboHastaHora.SelectedIndexChanged += new System.EventHandler(this.cboHastaHora_SelectedIndexChanged);
            // 
            // btnCerrrar
            // 
            this.btnCerrrar.Location = new System.Drawing.Point(65, 297);
            this.btnCerrrar.Name = "btnCerrrar";
            this.btnCerrrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrrar.TabIndex = 23;
            this.btnCerrrar.Text = "Cerrar";
            this.btnCerrrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrrar.UseVisualStyleBackColor = true;
            this.btnCerrrar.Click += new System.EventHandler(this.btnCerrrar_Click);
            // 
            // frmHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(215, 337);
            this.Controls.Add(this.btnCerrrar);
            this.Controls.Add(this.cboHastaMinuto);
            this.Controls.Add(this.cboHastaHora);
            this.Controls.Add(this.cboDesdeMinuto);
            this.Controls.Add(this.cboDesdeHora);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbHorarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.btnEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horarios";
            this.Load += new System.EventHandler(this.frmHorarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.ListBox lbHorarios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboDesdeHora;
        private System.Windows.Forms.ComboBox cboDesdeMinuto;
        private System.Windows.Forms.ComboBox cboHastaMinuto;
        private System.Windows.Forms.ComboBox cboHastaHora;
        private System.Windows.Forms.Button btnCerrrar;
    }
}