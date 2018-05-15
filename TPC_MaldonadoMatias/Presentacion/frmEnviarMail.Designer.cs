namespace Presentacion
{
    partial class frmEnviarMail
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbFecha = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lbAsunto = new System.Windows.Forms.Label();
            this.lbDetalle = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lbDe = new System.Windows.Forms.Label();
            this.rbtnAcademia = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 20);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(25, 28);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(43, 13);
            this.lbFecha.TabIndex = 46;
            this.lbFecha.Text = "Fecha :";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(98, 93);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(272, 20);
            this.txtAsunto.TabIndex = 49;
            // 
            // lbAsunto
            // 
            this.lbAsunto.AutoSize = true;
            this.lbAsunto.Location = new System.Drawing.Point(25, 93);
            this.lbAsunto.Name = "lbAsunto";
            this.lbAsunto.Size = new System.Drawing.Size(46, 13);
            this.lbAsunto.TabIndex = 48;
            this.lbAsunto.Text = "Asunto :";
            // 
            // lbDetalle
            // 
            this.lbDetalle.AutoSize = true;
            this.lbDetalle.Location = new System.Drawing.Point(25, 131);
            this.lbDetalle.Name = "lbDetalle";
            this.lbDetalle.Size = new System.Drawing.Size(46, 13);
            this.lbDetalle.TabIndex = 51;
            this.lbDetalle.Text = "Detalle :";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(28, 157);
            this.txtDetalle.MaxLength = 250;
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(429, 96);
            this.txtDetalle.TabIndex = 50;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(220, 259);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 52;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // lbDe
            // 
            this.lbDe.AutoSize = true;
            this.lbDe.Location = new System.Drawing.Point(25, 58);
            this.lbDe.Name = "lbDe";
            this.lbDe.Size = new System.Drawing.Size(27, 13);
            this.lbDe.TabIndex = 53;
            this.lbDe.Text = "De :";
            // 
            // rbtnAcademia
            // 
            this.rbtnAcademia.AutoSize = true;
            this.rbtnAcademia.Location = new System.Drawing.Point(98, 58);
            this.rbtnAcademia.Name = "rbtnAcademia";
            this.rbtnAcademia.Size = new System.Drawing.Size(72, 17);
            this.rbtnAcademia.TabIndex = 54;
            this.rbtnAcademia.TabStop = true;
            this.rbtnAcademia.Text = "Academia";
            this.rbtnAcademia.UseVisualStyleBackColor = true;
            // 
            // frmEnviarMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 304);
            this.Controls.Add(this.rbtnAcademia);
            this.Controls.Add(this.lbDe);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lbDetalle);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.lbAsunto);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbFecha);
            this.Name = "frmEnviarMail";
            this.Text = "Enviar Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label lbAsunto;
        private System.Windows.Forms.Label lbDetalle;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lbDe;
        private System.Windows.Forms.RadioButton rbtnAcademia;
    }
}