namespace Presentacion
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cursadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tomarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.academiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añosLectivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.cursoToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.avisosToolStripMenuItem,
            this.listaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem,
            this.profesorToolStripMenuItem});
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.crearToolStripMenuItem.Text = "Personas";
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.alumnoToolStripMenuItem.Text = "Alumnos";
            this.alumnoToolStripMenuItem.Click += new System.EventHandler(this.alumnoToolStripMenuItem_Click);
            // 
            // profesorToolStripMenuItem
            // 
            this.profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            this.profesorToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.profesorToolStripMenuItem.Text = "Empleados";
            this.profesorToolStripMenuItem.Click += new System.EventHandler(this.profesorToolStripMenuItem_Click);
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursoToolStripMenuItem1,
            this.cursadaToolStripMenuItem,
            this.asignacionAlumnosToolStripMenuItem});
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.cursoToolStripMenuItem.Text = "Curso";
            // 
            // cursoToolStripMenuItem1
            // 
            this.cursoToolStripMenuItem1.Name = "cursoToolStripMenuItem1";
            this.cursoToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.cursoToolStripMenuItem1.Text = "Curso";
            this.cursoToolStripMenuItem1.Click += new System.EventHandler(this.cursoToolStripMenuItem1_Click);
            // 
            // cursadaToolStripMenuItem
            // 
            this.cursadaToolStripMenuItem.Name = "cursadaToolStripMenuItem";
            this.cursadaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cursadaToolStripMenuItem.Text = "Cursada";
            this.cursadaToolStripMenuItem.Click += new System.EventHandler(this.cursadaToolStripMenuItem_Click);
            // 
            // asignacionAlumnosToolStripMenuItem
            // 
            this.asignacionAlumnosToolStripMenuItem.Name = "asignacionAlumnosToolStripMenuItem";
            this.asignacionAlumnosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.asignacionAlumnosToolStripMenuItem.Text = "Asignacion Alumnos";
            this.asignacionAlumnosToolStripMenuItem.Click += new System.EventHandler(this.asignacionAlumnosToolStripMenuItem_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tomarListaToolStripMenuItem,
            this.examenToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.envioMailToolStripMenuItem,
            this.envioNotasToolStripMenuItem});
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            // 
            // tomarListaToolStripMenuItem
            // 
            this.tomarListaToolStripMenuItem.Name = "tomarListaToolStripMenuItem";
            this.tomarListaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.tomarListaToolStripMenuItem.Text = "Tomar Lista";
            this.tomarListaToolStripMenuItem.Click += new System.EventHandler(this.tomarListaToolStripMenuItem_Click);
            // 
            // examenToolStripMenuItem
            // 
            this.examenToolStripMenuItem.Name = "examenToolStripMenuItem";
            this.examenToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.examenToolStripMenuItem.Text = "Examen";
            this.examenToolStripMenuItem.Click += new System.EventHandler(this.examenToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.notasToolStripMenuItem.Text = "Notas";
            this.notasToolStripMenuItem.Click += new System.EventHandler(this.notasToolStripMenuItem_Click);
            // 
            // envioMailToolStripMenuItem
            // 
            this.envioMailToolStripMenuItem.Name = "envioMailToolStripMenuItem";
            this.envioMailToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.envioMailToolStripMenuItem.Text = "Envio Mail";
            this.envioMailToolStripMenuItem.Click += new System.EventHandler(this.envioMailToolStripMenuItem_Click);
            // 
            // envioNotasToolStripMenuItem
            // 
            this.envioNotasToolStripMenuItem.Name = "envioNotasToolStripMenuItem";
            this.envioNotasToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.envioNotasToolStripMenuItem.Text = "Envio Notas";
            this.envioNotasToolStripMenuItem.Click += new System.EventHandler(this.envioNotasToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.academiaToolStripMenuItem,
            this.añosLectivoToolStripMenuItem,
            this.aulasToolStripMenuItem,
            this.calendarioToolStripMenuItem,
            this.diaToolStripMenuItem,
            this.horarioToolStripMenuItem,
            this.comisionToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // academiaToolStripMenuItem
            // 
            this.academiaToolStripMenuItem.Name = "academiaToolStripMenuItem";
            this.academiaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.academiaToolStripMenuItem.Text = "Academia";
            this.academiaToolStripMenuItem.Click += new System.EventHandler(this.academiaToolStripMenuItem_Click);
            // 
            // añosLectivoToolStripMenuItem
            // 
            this.añosLectivoToolStripMenuItem.Name = "añosLectivoToolStripMenuItem";
            this.añosLectivoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.añosLectivoToolStripMenuItem.Text = "Años Lectivo";
            this.añosLectivoToolStripMenuItem.Click += new System.EventHandler(this.añosLectivoToolStripMenuItem_Click);
            // 
            // aulasToolStripMenuItem
            // 
            this.aulasToolStripMenuItem.Name = "aulasToolStripMenuItem";
            this.aulasToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.aulasToolStripMenuItem.Text = "Aulas";
            this.aulasToolStripMenuItem.Click += new System.EventHandler(this.aulasToolStripMenuItem_Click);
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.calendarioToolStripMenuItem_Click);
            // 
            // diaToolStripMenuItem
            // 
            this.diaToolStripMenuItem.Name = "diaToolStripMenuItem";
            this.diaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.diaToolStripMenuItem.Text = "Dia";
            this.diaToolStripMenuItem.Click += new System.EventHandler(this.diaToolStripMenuItem_Click);
            // 
            // horarioToolStripMenuItem
            // 
            this.horarioToolStripMenuItem.Name = "horarioToolStripMenuItem";
            this.horarioToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.horarioToolStripMenuItem.Text = "Horario";
            this.horarioToolStripMenuItem.Click += new System.EventHandler(this.horarioToolStripMenuItem_Click);
            // 
            // comisionToolStripMenuItem
            // 
            this.comisionToolStripMenuItem.Name = "comisionToolStripMenuItem";
            this.comisionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.comisionToolStripMenuItem.Text = "Comision";
            this.comisionToolStripMenuItem.Click += new System.EventHandler(this.comisionToolStripMenuItem_Click);
            // 
            // avisosToolStripMenuItem
            // 
            this.avisosToolStripMenuItem.Name = "avisosToolStripMenuItem";
            this.avisosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.avisosToolStripMenuItem.Text = "Avisos";
            this.avisosToolStripMenuItem.Click += new System.EventHandler(this.avisosToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.listaToolStripMenuItem.Text = "Lista";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cursadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem academiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añosLectivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tomarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comisionToolStripMenuItem;
    }
}