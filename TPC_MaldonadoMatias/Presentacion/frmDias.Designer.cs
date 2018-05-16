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
            this.lbHorarios = new System.Windows.Forms.ListBox();
            this.lbHorariosCargado = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnSacarTodo = new System.Windows.Forms.Button();
            this.btnDefecto = new System.Windows.Forms.Button();
            this.lblHorarios = new System.Windows.Forms.Label();
            this.lblDisponibilidad = new System.Windows.Forms.Label();
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
            this.btnLunes.Click += new System.EventHandler(this.btnLunes_Click);
            // 
            // btnMartes
            // 
            this.btnMartes.BackColor = System.Drawing.Color.Transparent;
            this.btnMartes.Location = new System.Drawing.Point(122, 30);
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
            this.btnMiercoles.Location = new System.Drawing.Point(223, 30);
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
            this.btnJueves.Location = new System.Drawing.Point(324, 30);
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
            this.btnViernes.Location = new System.Drawing.Point(425, 30);
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
            this.btnSabado.Location = new System.Drawing.Point(526, 30);
            this.btnSabado.Name = "btnSabado";
            this.btnSabado.Size = new System.Drawing.Size(75, 23);
            this.btnSabado.TabIndex = 5;
            this.btnSabado.Text = "Sabado";
            this.btnSabado.UseVisualStyleBackColor = false;
            this.btnSabado.Click += new System.EventHandler(this.btnSabado_Click);
            // 
            // lbHorarios
            // 
            this.lbHorarios.FormattingEnabled = true;
            this.lbHorarios.Location = new System.Drawing.Point(62, 90);
            this.lbHorarios.Name = "lbHorarios";
            this.lbHorarios.Size = new System.Drawing.Size(178, 251);
            this.lbHorarios.TabIndex = 6;
            // 
            // lbHorariosCargado
            // 
            this.lbHorariosCargado.FormattingEnabled = true;
            this.lbHorariosCargado.Location = new System.Drawing.Point(379, 90);
            this.lbHorariosCargado.Name = "lbHorariosCargado";
            this.lbHorariosCargado.Size = new System.Drawing.Size(178, 251);
            this.lbHorariosCargado.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(275, 148);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = ">";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(275, 188);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 9;
            this.btnSacar.Text = "<";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(275, 357);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSacarTodo
            // 
            this.btnSacarTodo.Location = new System.Drawing.Point(275, 228);
            this.btnSacarTodo.Name = "btnSacarTodo";
            this.btnSacarTodo.Size = new System.Drawing.Size(75, 23);
            this.btnSacarTodo.TabIndex = 13;
            this.btnSacarTodo.Text = "Sacar Todo";
            this.btnSacarTodo.UseVisualStyleBackColor = true;
            this.btnSacarTodo.Click += new System.EventHandler(this.btnSacarTodo_Click);
            // 
            // btnDefecto
            // 
            this.btnDefecto.Location = new System.Drawing.Point(275, 108);
            this.btnDefecto.Name = "btnDefecto";
            this.btnDefecto.Size = new System.Drawing.Size(75, 23);
            this.btnDefecto.TabIndex = 12;
            this.btnDefecto.Text = "Por Defecto";
            this.btnDefecto.UseVisualStyleBackColor = true;
            // 
            // lblHorarios
            // 
            this.lblHorarios.AutoSize = true;
            this.lblHorarios.Location = new System.Drawing.Point(110, 65);
            this.lblHorarios.Name = "lblHorarios";
            this.lblHorarios.Size = new System.Drawing.Size(84, 13);
            this.lblHorarios.TabIndex = 14;
            this.lblHorarios.Text = "Horarios Habiles";
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.AutoSize = true;
            this.lblDisponibilidad.Location = new System.Drawing.Point(435, 65);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(70, 13);
            this.lblDisponibilidad.TabIndex = 15;
            this.lblDisponibilidad.Text = "Disponiblidad";
            // 
            // frmDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 390);
            this.Controls.Add(this.lblDisponibilidad);
            this.Controls.Add(this.lblHorarios);
            this.Controls.Add(this.btnSacarTodo);
            this.Controls.Add(this.btnDefecto);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbHorariosCargado);
            this.Controls.Add(this.lbHorarios);
            this.Controls.Add(this.btnSabado);
            this.Controls.Add(this.btnViernes);
            this.Controls.Add(this.btnJueves);
            this.Controls.Add(this.btnMiercoles);
            this.Controls.Add(this.btnMartes);
            this.Controls.Add(this.btnLunes);
            this.Name = "frmDias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dias";
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
        private System.Windows.Forms.ListBox lbHorarios;
        private System.Windows.Forms.ListBox lbHorariosCargado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnSacarTodo;
        private System.Windows.Forms.Button btnDefecto;
        private System.Windows.Forms.Label lblHorarios;
        private System.Windows.Forms.Label lblDisponibilidad;
    }
}