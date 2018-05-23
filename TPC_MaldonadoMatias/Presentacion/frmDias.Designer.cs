namespace Presentacion
{
    partial class frmDias
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
            this.btnLunes = new System.Windows.Forms.Button();
            this.btnMartes = new System.Windows.Forms.Button();
            this.btnMiercoles = new System.Windows.Forms.Button();
            this.btnJueves = new System.Windows.Forms.Button();
            this.btnViernes = new System.Windows.Forms.Button();
            this.btnSabado = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnSacarTodo = new System.Windows.Forms.Button();
            this.lblHorarios = new System.Windows.Forms.Label();
            this.lblDisponibilidad = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgvDiaxHorario = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVolver = new System.Windows.Forms.Button();
            this.mlbHorarios = new Negocio.MListBox();
            this.mlbHorariosCargado = new Negocio.MListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaxHorario)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLunes
            // 
            this.btnLunes.BackColor = System.Drawing.Color.Transparent;
            this.btnLunes.Location = new System.Drawing.Point(21, 30);
            this.btnLunes.Name = "btnLunes";
            this.btnLunes.Size = new System.Drawing.Size(75, 23);
            this.btnLunes.TabIndex = 0;
            this.btnLunes.Text = "Lunes";
            this.btnLunes.UseVisualStyleBackColor = false;
            this.btnLunes.Visible = false;
            this.btnLunes.Click += new System.EventHandler(this.btnLunes_Click);
            // 
            // btnMartes
            // 
            this.btnMartes.BackColor = System.Drawing.Color.Transparent;
            this.btnMartes.Location = new System.Drawing.Point(102, 30);
            this.btnMartes.Name = "btnMartes";
            this.btnMartes.Size = new System.Drawing.Size(75, 23);
            this.btnMartes.TabIndex = 1;
            this.btnMartes.Text = "Martes";
            this.btnMartes.UseVisualStyleBackColor = false;
            this.btnMartes.Click += new System.EventHandler(this.btnMartes_Click);
            // 
            // btnMiercoles
            // 
            this.btnMiercoles.BackColor = System.Drawing.Color.Transparent;
            this.btnMiercoles.Location = new System.Drawing.Point(183, 30);
            this.btnMiercoles.Name = "btnMiercoles";
            this.btnMiercoles.Size = new System.Drawing.Size(75, 23);
            this.btnMiercoles.TabIndex = 2;
            this.btnMiercoles.Text = "Miercoles";
            this.btnMiercoles.UseVisualStyleBackColor = false;
            this.btnMiercoles.Click += new System.EventHandler(this.btnMiercoles_Click);
            // 
            // btnJueves
            // 
            this.btnJueves.BackColor = System.Drawing.Color.Transparent;
            this.btnJueves.Location = new System.Drawing.Point(264, 30);
            this.btnJueves.Name = "btnJueves";
            this.btnJueves.Size = new System.Drawing.Size(75, 23);
            this.btnJueves.TabIndex = 3;
            this.btnJueves.Text = "Jueves";
            this.btnJueves.UseVisualStyleBackColor = false;
            this.btnJueves.Click += new System.EventHandler(this.btnJueves_Click);
            // 
            // btnViernes
            // 
            this.btnViernes.BackColor = System.Drawing.Color.Transparent;
            this.btnViernes.Location = new System.Drawing.Point(345, 30);
            this.btnViernes.Name = "btnViernes";
            this.btnViernes.Size = new System.Drawing.Size(75, 23);
            this.btnViernes.TabIndex = 4;
            this.btnViernes.Text = "Viernes";
            this.btnViernes.UseVisualStyleBackColor = false;
            this.btnViernes.Click += new System.EventHandler(this.btnViernes_Click);
            // 
            // btnSabado
            // 
            this.btnSabado.BackColor = System.Drawing.Color.Transparent;
            this.btnSabado.Location = new System.Drawing.Point(426, 30);
            this.btnSabado.Name = "btnSabado";
            this.btnSabado.Size = new System.Drawing.Size(75, 23);
            this.btnSabado.TabIndex = 5;
            this.btnSabado.Text = "Sabado";
            this.btnSabado.UseVisualStyleBackColor = false;
            this.btnSabado.Visible = false;
            this.btnSabado.Click += new System.EventHandler(this.btnSabado_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(220, 133);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = ">";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(220, 173);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 9;
            this.btnSacar.Text = "<";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(211, 296);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSacarTodo
            // 
            this.btnSacarTodo.Location = new System.Drawing.Point(220, 213);
            this.btnSacarTodo.Name = "btnSacarTodo";
            this.btnSacarTodo.Size = new System.Drawing.Size(75, 23);
            this.btnSacarTodo.TabIndex = 13;
            this.btnSacarTodo.Text = "Sacar Todo";
            this.btnSacarTodo.UseVisualStyleBackColor = true;
            this.btnSacarTodo.Click += new System.EventHandler(this.btnSacarTodo_Click);
            // 
            // lblHorarios
            // 
            this.lblHorarios.AutoSize = true;
            this.lblHorarios.Location = new System.Drawing.Point(96, 74);
            this.lblHorarios.Name = "lblHorarios";
            this.lblHorarios.Size = new System.Drawing.Size(84, 13);
            this.lblHorarios.TabIndex = 14;
            this.lblHorarios.Text = "Horarios Habiles";
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.AutoSize = true;
            this.lblDisponibilidad.Location = new System.Drawing.Point(346, 74);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(70, 13);
            this.lblDisponibilidad.TabIndex = 15;
            this.lblDisponibilidad.Text = "Disponiblidad";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dgvDiaxHorario
            // 
            this.dgvDiaxHorario.AllowUserToAddRows = false;
            this.dgvDiaxHorario.AllowUserToDeleteRows = false;
            this.dgvDiaxHorario.AllowUserToResizeColumns = false;
            this.dgvDiaxHorario.AllowUserToResizeRows = false;
            this.dgvDiaxHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiaxHorario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDiaxHorario.Location = new System.Drawing.Point(13, 25);
            this.dgvDiaxHorario.MultiSelect = false;
            this.dgvDiaxHorario.Name = "dgvDiaxHorario";
            this.dgvDiaxHorario.ReadOnly = true;
            this.dgvDiaxHorario.RowHeadersVisible = false;
            this.dgvDiaxHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiaxHorario.Size = new System.Drawing.Size(492, 265);
            this.dgvDiaxHorario.TabIndex = 17;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(520, 24);
            this.menuStrip2.TabIndex = 18;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Red;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(494, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(20, 20);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.Text = "X";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // mlbHorarios
            // 
            this.mlbHorarios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mlbHorarios.FormattingEnabled = true;
            this.mlbHorarios.Location = new System.Drawing.Point(77, 90);
            this.mlbHorarios.Name = "mlbHorarios";
            this.mlbHorarios.Size = new System.Drawing.Size(120, 199);
            this.mlbHorarios.TabIndex = 20;
            // 
            // mlbHorariosCargado
            // 
            this.mlbHorariosCargado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mlbHorariosCargado.FormattingEnabled = true;
            this.mlbHorariosCargado.Location = new System.Drawing.Point(321, 90);
            this.mlbHorariosCargado.Name = "mlbHorariosCargado";
            this.mlbHorariosCargado.Size = new System.Drawing.Size(120, 199);
            this.mlbHorariosCargado.TabIndex = 21;
            // 
            // frmDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(520, 323);
            this.Controls.Add(this.dgvDiaxHorario);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblDisponibilidad);
            this.Controls.Add(this.lblHorarios);
            this.Controls.Add(this.btnSacarTodo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSabado);
            this.Controls.Add(this.btnViernes);
            this.Controls.Add(this.btnJueves);
            this.Controls.Add(this.btnMiercoles);
            this.Controls.Add(this.btnMartes);
            this.Controls.Add(this.btnLunes);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.mlbHorarios);
            this.Controls.Add(this.mlbHorariosCargado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dias";
            this.Load += new System.EventHandler(this.frmDias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaxHorario)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLunes;
        private System.Windows.Forms.Button btnMartes;
        private System.Windows.Forms.Button btnMiercoles;
        private System.Windows.Forms.Button btnJueves;
        private System.Windows.Forms.Button btnViernes;
        private System.Windows.Forms.Button btnSabado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnSacarTodo;
        private System.Windows.Forms.Label lblHorarios;
        private System.Windows.Forms.Label lblDisponibilidad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgvDiaxHorario;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private Negocio.MListBox mlbHorarios;
        private Negocio.MListBox mlbHorariosCargado;
        public System.Windows.Forms.Button btnVolver;
    }
}