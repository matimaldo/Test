namespace Presentacion
{
    partial class frmAulas
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
            this.lblAula = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gdDisponibilidad = new System.Windows.Forms.GroupBox();
            this.cbxSabado = new System.Windows.Forms.CheckBox();
            this.cbxViernes = new System.Windows.Forms.CheckBox();
            this.cbxJueves = new System.Windows.Forms.CheckBox();
            this.cbxMiercoles = new System.Windows.Forms.CheckBox();
            this.cbxMartes = new System.Windows.Forms.CheckBox();
            this.cbxLunes = new System.Windows.Forms.CheckBox();
            this.lbSabado = new System.Windows.Forms.ListBox();
            this.lbViernes = new System.Windows.Forms.ListBox();
            this.lbJueves = new System.Windows.Forms.ListBox();
            this.lbMiercoles = new System.Windows.Forms.ListBox();
            this.lbMartes = new System.Windows.Forms.ListBox();
            this.lbLunes = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gdDisponibilidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAula
            // 
            this.lblAula.AutoSize = true;
            this.lblAula.Location = new System.Drawing.Point(36, 46);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(50, 13);
            this.lblAula.TabIndex = 0;
            this.lblAula.Text = "Nombre :";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(106, 77);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(32, 20);
            this.txtCantidad.TabIndex = 13;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(35, 80);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 13);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 15;
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
            // gdDisponibilidad
            // 
            this.gdDisponibilidad.Controls.Add(this.cbxSabado);
            this.gdDisponibilidad.Controls.Add(this.cbxViernes);
            this.gdDisponibilidad.Controls.Add(this.cbxJueves);
            this.gdDisponibilidad.Controls.Add(this.cbxMiercoles);
            this.gdDisponibilidad.Controls.Add(this.cbxMartes);
            this.gdDisponibilidad.Controls.Add(this.cbxLunes);
            this.gdDisponibilidad.Controls.Add(this.lbSabado);
            this.gdDisponibilidad.Controls.Add(this.lbViernes);
            this.gdDisponibilidad.Controls.Add(this.lbJueves);
            this.gdDisponibilidad.Controls.Add(this.lbMiercoles);
            this.gdDisponibilidad.Controls.Add(this.lbMartes);
            this.gdDisponibilidad.Controls.Add(this.lbLunes);
            this.gdDisponibilidad.Location = new System.Drawing.Point(18, 112);
            this.gdDisponibilidad.Name = "gdDisponibilidad";
            this.gdDisponibilidad.Size = new System.Drawing.Size(776, 171);
            this.gdDisponibilidad.TabIndex = 16;
            this.gdDisponibilidad.TabStop = false;
            this.gdDisponibilidad.Text = "Disponibilidad";
            // 
            // cbxSabado
            // 
            this.cbxSabado.AutoSize = true;
            this.cbxSabado.Location = new System.Drawing.Point(673, 29);
            this.cbxSabado.Name = "cbxSabado";
            this.cbxSabado.Size = new System.Drawing.Size(63, 17);
            this.cbxSabado.TabIndex = 16;
            this.cbxSabado.Text = "Sabado";
            this.cbxSabado.UseVisualStyleBackColor = true;
            // 
            // cbxViernes
            // 
            this.cbxViernes.AutoSize = true;
            this.cbxViernes.Location = new System.Drawing.Point(545, 29);
            this.cbxViernes.Name = "cbxViernes";
            this.cbxViernes.Size = new System.Drawing.Size(61, 17);
            this.cbxViernes.TabIndex = 15;
            this.cbxViernes.Text = "Viernes";
            this.cbxViernes.UseVisualStyleBackColor = true;
            // 
            // cbxJueves
            // 
            this.cbxJueves.AutoSize = true;
            this.cbxJueves.Location = new System.Drawing.Point(417, 29);
            this.cbxJueves.Name = "cbxJueves";
            this.cbxJueves.Size = new System.Drawing.Size(60, 17);
            this.cbxJueves.TabIndex = 14;
            this.cbxJueves.Text = "Jueves";
            this.cbxJueves.UseVisualStyleBackColor = true;
            // 
            // cbxMiercoles
            // 
            this.cbxMiercoles.AutoSize = true;
            this.cbxMiercoles.Location = new System.Drawing.Point(289, 29);
            this.cbxMiercoles.Name = "cbxMiercoles";
            this.cbxMiercoles.Size = new System.Drawing.Size(71, 17);
            this.cbxMiercoles.TabIndex = 13;
            this.cbxMiercoles.Text = "Miercoles";
            this.cbxMiercoles.UseVisualStyleBackColor = true;
            // 
            // cbxMartes
            // 
            this.cbxMartes.AutoSize = true;
            this.cbxMartes.Location = new System.Drawing.Point(161, 29);
            this.cbxMartes.Name = "cbxMartes";
            this.cbxMartes.Size = new System.Drawing.Size(58, 17);
            this.cbxMartes.TabIndex = 12;
            this.cbxMartes.Text = "Martes";
            this.cbxMartes.UseVisualStyleBackColor = true;
            // 
            // cbxLunes
            // 
            this.cbxLunes.AutoSize = true;
            this.cbxLunes.Location = new System.Drawing.Point(34, 29);
            this.cbxLunes.Name = "cbxLunes";
            this.cbxLunes.Size = new System.Drawing.Size(55, 17);
            this.cbxLunes.TabIndex = 11;
            this.cbxLunes.Text = "Lunes";
            this.cbxLunes.UseVisualStyleBackColor = true;
            // 
            // lbSabado
            // 
            this.lbSabado.FormattingEnabled = true;
            this.lbSabado.Items.AddRange(new object[] {
            "8:00 - 9:00",
            "9:00 - 10:00",
            "10:00 - 11:00",
            "11:00 - 12:00",
            "12:00 - 13:00",
            "16:00 - 17:00",
            "17:00 - 18:00",
            "18:00 - 19:00",
            "19:00 - 20:00",
            "20:00 - 21:00"});
            this.lbSabado.Location = new System.Drawing.Point(646, 62);
            this.lbSabado.Name = "lbSabado";
            this.lbSabado.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSabado.Size = new System.Drawing.Size(120, 95);
            this.lbSabado.TabIndex = 10;
            // 
            // lbViernes
            // 
            this.lbViernes.FormattingEnabled = true;
            this.lbViernes.Items.AddRange(new object[] {
            "8:00 - 9:00",
            "9:00 - 10:00",
            "10:00 - 11:00",
            "11:00 - 12:00",
            "12:00 - 13:00",
            "16:00 - 17:00",
            "17:00 - 18:00",
            "18:00 - 19:00",
            "19:00 - 20:00",
            "20:00 - 21:00"});
            this.lbViernes.Location = new System.Drawing.Point(518, 62);
            this.lbViernes.Name = "lbViernes";
            this.lbViernes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbViernes.Size = new System.Drawing.Size(120, 95);
            this.lbViernes.TabIndex = 4;
            // 
            // lbJueves
            // 
            this.lbJueves.FormattingEnabled = true;
            this.lbJueves.Items.AddRange(new object[] {
            "8:00 - 9:00",
            "9:00 - 10:00",
            "10:00 - 11:00",
            "11:00 - 12:00",
            "12:00 - 13:00",
            "16:00 - 17:00",
            "17:00 - 18:00",
            "18:00 - 19:00",
            "19:00 - 20:00",
            "20:00 - 21:00"});
            this.lbJueves.Location = new System.Drawing.Point(390, 62);
            this.lbJueves.Name = "lbJueves";
            this.lbJueves.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbJueves.Size = new System.Drawing.Size(120, 95);
            this.lbJueves.TabIndex = 3;
            // 
            // lbMiercoles
            // 
            this.lbMiercoles.FormattingEnabled = true;
            this.lbMiercoles.Items.AddRange(new object[] {
            "8:00 - 9:00",
            "9:00 - 10:00",
            "10:00 - 11:00",
            "11:00 - 12:00",
            "12:00 - 13:00",
            "16:00 - 17:00",
            "17:00 - 18:00",
            "18:00 - 19:00",
            "19:00 - 20:00",
            "20:00 - 21:00"});
            this.lbMiercoles.Location = new System.Drawing.Point(262, 62);
            this.lbMiercoles.Name = "lbMiercoles";
            this.lbMiercoles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbMiercoles.Size = new System.Drawing.Size(120, 95);
            this.lbMiercoles.TabIndex = 2;
            // 
            // lbMartes
            // 
            this.lbMartes.FormattingEnabled = true;
            this.lbMartes.Items.AddRange(new object[] {
            "8:00 - 9:00",
            "9:00 - 10:00",
            "10:00 - 11:00",
            "11:00 - 12:00",
            "12:00 - 13:00",
            "16:00 - 17:00",
            "17:00 - 18:00",
            "18:00 - 19:00",
            "19:00 - 20:00",
            "20:00 - 21:00"});
            this.lbMartes.Location = new System.Drawing.Point(134, 62);
            this.lbMartes.Name = "lbMartes";
            this.lbMartes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbMartes.Size = new System.Drawing.Size(120, 95);
            this.lbMartes.TabIndex = 1;
            // 
            // lbLunes
            // 
            this.lbLunes.FormattingEnabled = true;
            this.lbLunes.Items.AddRange(new object[] {
            "8:00 - 9:00",
            "9:00 - 10:00",
            "10:00 - 11:00",
            "11:00 - 12:00",
            "12:00 - 13:00",
            "16:00 - 17:00",
            "17:00 - 18:00",
            "18:00 - 19:00",
            "19:00 - 20:00",
            "20:00 - 21:00"});
            this.lbLunes.Location = new System.Drawing.Point(6, 62);
            this.lbLunes.Name = "lbLunes";
            this.lbLunes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbLunes.Size = new System.Drawing.Size(120, 95);
            this.lbLunes.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(363, 307);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Enabled = false;
            this.btnPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.Location = new System.Drawing.Point(711, 320);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(27, 23);
            this.btnPrimero.TabIndex = 30;
            this.btnPrimero.Text = "<<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            // 
            // btnUltimo
            // 
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Location = new System.Drawing.Point(783, 320);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(27, 23);
            this.btnUltimo.TabIndex = 29;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Location = new System.Drawing.Point(737, 320);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(24, 23);
            this.btnAnterior.TabIndex = 27;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(760, 320);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(24, 23);
            this.btnSiguiente.TabIndex = 28;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // frmAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 345);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gdDisponibilidad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblAula);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAulas";
            this.Text = "Aulas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gdDisponibilidad.ResumeLayout(false);
            this.gdDisponibilidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.GroupBox gdDisponibilidad;
        private System.Windows.Forms.CheckBox cbxSabado;
        private System.Windows.Forms.CheckBox cbxViernes;
        private System.Windows.Forms.CheckBox cbxJueves;
        private System.Windows.Forms.CheckBox cbxMiercoles;
        private System.Windows.Forms.CheckBox cbxMartes;
        private System.Windows.Forms.CheckBox cbxLunes;
        private System.Windows.Forms.ListBox lbSabado;
        private System.Windows.Forms.ListBox lbViernes;
        private System.Windows.Forms.ListBox lbJueves;
        private System.Windows.Forms.ListBox lbMiercoles;
        private System.Windows.Forms.ListBox lbMartes;
        private System.Windows.Forms.ListBox lbLunes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
    }
}