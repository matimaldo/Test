namespace Presentacion
{
    partial class frmAtajoAdministrativo
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
            this.btn_CrearExamen = new System.Windows.Forms.Button();
            this.btn_TomarLista = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CrearExamen
            // 
            this.btn_CrearExamen.BackColor = System.Drawing.Color.Green;
            this.btn_CrearExamen.FlatAppearance.BorderSize = 0;
            this.btn_CrearExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearExamen.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CrearExamen.ForeColor = System.Drawing.Color.White;
            this.btn_CrearExamen.Location = new System.Drawing.Point(62, 96);
            this.btn_CrearExamen.Name = "btn_CrearExamen";
            this.btn_CrearExamen.Size = new System.Drawing.Size(162, 44);
            this.btn_CrearExamen.TabIndex = 29;
            this.btn_CrearExamen.Text = "Alta Alumno";
            this.btn_CrearExamen.UseVisualStyleBackColor = false;
            this.btn_CrearExamen.Click += new System.EventHandler(this.btn_CrearExamen_Click);
            // 
            // btn_TomarLista
            // 
            this.btn_TomarLista.BackColor = System.Drawing.Color.Green;
            this.btn_TomarLista.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_TomarLista.FlatAppearance.BorderSize = 0;
            this.btn_TomarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TomarLista.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TomarLista.ForeColor = System.Drawing.Color.White;
            this.btn_TomarLista.Location = new System.Drawing.Point(62, 46);
            this.btn_TomarLista.Name = "btn_TomarLista";
            this.btn_TomarLista.Size = new System.Drawing.Size(162, 44);
            this.btn_TomarLista.TabIndex = 27;
            this.btn_TomarLista.Text = "Alta Profesor";
            this.btn_TomarLista.UseVisualStyleBackColor = false;
            this.btn_TomarLista.Click += new System.EventHandler(this.btn_TomarLista_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(249, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(20, 20);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "X";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAtajoAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Presentacion.Properties.Resources.pizarron;
            this.ClientSize = new System.Drawing.Size(287, 191);
            this.Controls.Add(this.btn_CrearExamen);
            this.Controls.Add(this.btn_TomarLista);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(50, 250);
            this.Name = "frmAtajoAdministrativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmAtajoAdministrativo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CrearExamen;
        private System.Windows.Forms.Button btn_TomarLista;
        public System.Windows.Forms.Button btnCancelar;
    }
}