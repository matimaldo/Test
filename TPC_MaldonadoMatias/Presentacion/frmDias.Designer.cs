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
            this.lbxHorarios = new System.Windows.Forms.ListBox();
            this.lbxHorariosDias = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLunes
            // 
            this.btnLunes.Location = new System.Drawing.Point(21, 30);
            this.btnLunes.Name = "btnLunes";
            this.btnLunes.Size = new System.Drawing.Size(75, 23);
            this.btnLunes.TabIndex = 0;
            this.btnLunes.Text = "Lunes";
            this.btnLunes.UseVisualStyleBackColor = true;
            // 
            // btnMartes
            // 
            this.btnMartes.Location = new System.Drawing.Point(122, 30);
            this.btnMartes.Name = "btnMartes";
            this.btnMartes.Size = new System.Drawing.Size(75, 23);
            this.btnMartes.TabIndex = 1;
            this.btnMartes.Text = "Martes";
            this.btnMartes.UseVisualStyleBackColor = true;
            // 
            // btnMiercoles
            // 
            this.btnMiercoles.Location = new System.Drawing.Point(223, 30);
            this.btnMiercoles.Name = "btnMiercoles";
            this.btnMiercoles.Size = new System.Drawing.Size(75, 23);
            this.btnMiercoles.TabIndex = 2;
            this.btnMiercoles.Text = "Miercoles";
            this.btnMiercoles.UseVisualStyleBackColor = true;
            // 
            // btnJueves
            // 
            this.btnJueves.Location = new System.Drawing.Point(324, 30);
            this.btnJueves.Name = "btnJueves";
            this.btnJueves.Size = new System.Drawing.Size(75, 23);
            this.btnJueves.TabIndex = 3;
            this.btnJueves.Text = "Jueves";
            this.btnJueves.UseVisualStyleBackColor = true;
            // 
            // btnViernes
            // 
            this.btnViernes.Location = new System.Drawing.Point(425, 30);
            this.btnViernes.Name = "btnViernes";
            this.btnViernes.Size = new System.Drawing.Size(75, 23);
            this.btnViernes.TabIndex = 4;
            this.btnViernes.Text = "Viernes";
            this.btnViernes.UseVisualStyleBackColor = true;
            // 
            // btnSabado
            // 
            this.btnSabado.Location = new System.Drawing.Point(526, 30);
            this.btnSabado.Name = "btnSabado";
            this.btnSabado.Size = new System.Drawing.Size(75, 23);
            this.btnSabado.TabIndex = 5;
            this.btnSabado.Text = "Sabado";
            this.btnSabado.UseVisualStyleBackColor = true;
            // 
            // lbxHorarios
            // 
            this.lbxHorarios.FormattingEnabled = true;
            this.lbxHorarios.Location = new System.Drawing.Point(74, 72);
            this.lbxHorarios.Name = "lbxHorarios";
            this.lbxHorarios.Size = new System.Drawing.Size(178, 290);
            this.lbxHorarios.TabIndex = 6;
            // 
            // lbxHorariosDias
            // 
            this.lbxHorariosDias.FormattingEnabled = true;
            this.lbxHorariosDias.Location = new System.Drawing.Point(375, 72);
            this.lbxHorariosDias.Name = "lbxHorariosDias";
            this.lbxHorariosDias.Size = new System.Drawing.Size(178, 290);
            this.lbxHorariosDias.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(275, 148);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = ">";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(275, 188);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 9;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(264, 394);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbxHorariosDias);
            this.Controls.Add(this.lbxHorarios);
            this.Controls.Add(this.btnSabado);
            this.Controls.Add(this.btnViernes);
            this.Controls.Add(this.btnJueves);
            this.Controls.Add(this.btnMiercoles);
            this.Controls.Add(this.btnMartes);
            this.Controls.Add(this.btnLunes);
            this.Name = "frmDias";
            this.Text = "Dias";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLunes;
        private System.Windows.Forms.Button btnMartes;
        private System.Windows.Forms.Button btnMiercoles;
        private System.Windows.Forms.Button btnJueves;
        private System.Windows.Forms.Button btnViernes;
        private System.Windows.Forms.Button btnSabado;
        private System.Windows.Forms.ListBox lbxHorarios;
        private System.Windows.Forms.ListBox lbxHorariosDias;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnGuardar;
    }
}