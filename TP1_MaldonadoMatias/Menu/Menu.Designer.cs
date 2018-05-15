namespace Menu
{
    partial class formMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            this.btnCargaPersona = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargaPersona
            // 
            this.btnCargaPersona.Image = ((System.Drawing.Image)(resources.GetObject("btnCargaPersona.Image")));
            this.btnCargaPersona.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargaPersona.Location = new System.Drawing.Point(90, 50);
            this.btnCargaPersona.Name = "btnCargaPersona";
            this.btnCargaPersona.Size = new System.Drawing.Size(166, 44);
            this.btnCargaPersona.TabIndex = 0;
            this.btnCargaPersona.Text = "Carga Persona";
            this.btnCargaPersona.UseVisualStyleBackColor = true;
            this.btnCargaPersona.Click += new System.EventHandler(this.btnCargaPersona_Click);
            // 
            // btnListado
            // 
            this.btnListado.Image = ((System.Drawing.Image)(resources.GetObject("btnListado.Image")));
            this.btnListado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListado.Location = new System.Drawing.Point(90, 100);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(166, 44);
            this.btnListado.TabIndex = 1;
            this.btnListado.Text = "Listado de Objetos";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(90, 230);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(166, 44);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(360, 344);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.btnCargaPersona);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu    (TP1  - MaldonadoMatias)";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnCargaPersona;
        public System.Windows.Forms.Button btnListado;
    }
}

