namespace Presentacion
{
    partial class frmVehiculo
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
            this.btnPagoAbono = new System.Windows.Forms.Button();
            this.btnPagoDia = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ImgHuella = new System.Windows.Forms.PictureBox();
            this.lblIngrese = new System.Windows.Forms.Label();
            this.btnIgresoDNI = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgHuella)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPagoAbono
            // 
            this.btnPagoAbono.Location = new System.Drawing.Point(0, 252);
            this.btnPagoAbono.Name = "btnPagoAbono";
            this.btnPagoAbono.Size = new System.Drawing.Size(197, 50);
            this.btnPagoAbono.TabIndex = 0;
            this.btnPagoAbono.Text = "Pago Abono";
            this.btnPagoAbono.UseVisualStyleBackColor = true;
            this.btnPagoAbono.Click += new System.EventHandler(this.btnPagoAbono_Click);
            // 
            // btnPagoDia
            // 
            this.btnPagoDia.Location = new System.Drawing.Point(0, 171);
            this.btnPagoDia.Name = "btnPagoDia";
            this.btnPagoDia.Size = new System.Drawing.Size(197, 50);
            this.btnPagoDia.TabIndex = 1;
            this.btnPagoDia.Text = "Pago Dia";
            this.btnPagoDia.UseVisualStyleBackColor = true;
            this.btnPagoDia.Click += new System.EventHandler(this.btnPagoDia_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(0, 333);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(197, 50);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(-7, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(260, 42);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Estacionamiento";
            // 
            // ImgHuella
            // 
            this.ImgHuella.BackColor = System.Drawing.Color.Transparent;
            this.ImgHuella.Image = global::Presentacion.Properties.Resources.HuellaTest;
            this.ImgHuella.Location = new System.Drawing.Point(439, 181);
            this.ImgHuella.Name = "ImgHuella";
            this.ImgHuella.Size = new System.Drawing.Size(199, 189);
            this.ImgHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgHuella.TabIndex = 4;
            this.ImgHuella.TabStop = false;
            this.ImgHuella.Visible = false;
            // 
            // lblIngrese
            // 
            this.lblIngrese.AutoSize = true;
            this.lblIngrese.BackColor = System.Drawing.Color.Transparent;
            this.lblIngrese.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrese.ForeColor = System.Drawing.Color.White;
            this.lblIngrese.Location = new System.Drawing.Point(486, 159);
            this.lblIngrese.Name = "lblIngrese";
            this.lblIngrese.Size = new System.Drawing.Size(95, 19);
            this.lblIngrese.TabIndex = 5;
            this.lblIngrese.Text = "Ingrese Huella";
            this.lblIngrese.Visible = false;
            // 
            // btnIgresoDNI
            // 
            this.btnIgresoDNI.Location = new System.Drawing.Point(466, 376);
            this.btnIgresoDNI.Name = "btnIgresoDNI";
            this.btnIgresoDNI.Size = new System.Drawing.Size(153, 23);
            this.btnIgresoDNI.TabIndex = 6;
            this.btnIgresoDNI.Text = "Ingresar por DNI";
            this.btnIgresoDNI.UseVisualStyleBackColor = true;
            this.btnIgresoDNI.Visible = false;
            this.btnIgresoDNI.Click += new System.EventHandler(this.btnIgresoDNI_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImage = global::Presentacion.Properties.Resources.BotonVolver;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(259, 24);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(56, 44);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(522, 161);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 21);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(522, 183);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(73, 21);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.Visible = false;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblDNI.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.White;
            this.lblDNI.Location = new System.Drawing.Point(522, 210);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(42, 21);
            this.lblDNI.TabIndex = 10;
            this.lblDNI.Text = "DNI";
            this.lblDNI.Visible = false;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.Red;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(516, 352);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 11;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Visible = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.BackColor = System.Drawing.Color.Transparent;
            this.lblMonto.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.White;
            this.lblMonto.Location = new System.Drawing.Point(399, 235);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(303, 109);
            this.lblMonto.TabIndex = 12;
            this.lblMonto.Text = "Monto";
            this.lblMonto.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(516, 381);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Presentacion.Properties.Resources.FondoMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 519);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnIgresoDNI);
            this.Controls.Add(this.lblIngrese);
            this.Controls.Add(this.ImgHuella);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnPagoDia);
            this.Controls.Add(this.btnPagoAbono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.frmVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgHuella)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPagoAbono;
        private System.Windows.Forms.Button btnPagoDia;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox ImgHuella;
        private System.Windows.Forms.Label lblIngrese;
        private System.Windows.Forms.Button btnIgresoDNI;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnCancelar;
    }
}