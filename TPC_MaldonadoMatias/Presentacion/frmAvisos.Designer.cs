﻿namespace Presentacion
{
    partial class frmAvisos
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
            this.lbAsunto = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbCreador = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCreador = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.lbDetalle = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(42, 41);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(43, 13);
            this.lbFecha.TabIndex = 0;
            this.lbFecha.Text = "Fecha :";
            // 
            // lbAsunto
            // 
            this.lbAsunto.AutoSize = true;
            this.lbAsunto.Location = new System.Drawing.Point(42, 69);
            this.lbAsunto.Name = "lbAsunto";
            this.lbAsunto.Size = new System.Drawing.Size(46, 13);
            this.lbAsunto.TabIndex = 1;
            this.lbAsunto.Text = "Asunto :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(512, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // lbCreador
            // 
            this.lbCreador.AutoSize = true;
            this.lbCreador.Location = new System.Drawing.Point(265, 41);
            this.lbCreador.Name = "lbCreador";
            this.lbCreador.Size = new System.Drawing.Size(65, 13);
            this.lbCreador.TabIndex = 3;
            this.lbCreador.Text = "Creado por :";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(111, 38);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(106, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // txtCreador
            // 
            this.txtCreador.Enabled = false;
            this.txtCreador.Location = new System.Drawing.Point(336, 38);
            this.txtCreador.Name = "txtCreador";
            this.txtCreador.Size = new System.Drawing.Size(145, 20);
            this.txtCreador.TabIndex = 5;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(111, 67);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(272, 20);
            this.txtAsunto.TabIndex = 6;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(45, 123);
            this.txtDetalle.MaxLength = 250;
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(429, 96);
            this.txtDetalle.TabIndex = 7;
            // 
            // lbDetalle
            // 
            this.lbDetalle.AutoSize = true;
            this.lbDetalle.Location = new System.Drawing.Point(42, 97);
            this.lbDetalle.Name = "lbDetalle";
            this.lbDetalle.Size = new System.Drawing.Size(46, 13);
            this.lbDetalle.TabIndex = 8;
            this.lbDetalle.Text = "Detalle :";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(221, 235);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmAvisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(512, 277);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbDetalle);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtCreador);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lbCreador);
            this.Controls.Add(this.lbAsunto);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAvisos";
            this.Text = "Avisos";
            this.Load += new System.EventHandler(this.frmAvisos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbAsunto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbCreador;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCreador;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label lbDetalle;
        private System.Windows.Forms.Button btnGuardar;
    }
}