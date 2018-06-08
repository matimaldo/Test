namespace Presentacion
{
    partial class frmListarEmpleados
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
            this.dgvListarEmpleado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarEmpleado
            // 
            this.dgvListarEmpleado.AllowUserToAddRows = false;
            this.dgvListarEmpleado.AllowUserToDeleteRows = false;
            this.dgvListarEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarEmpleado.Location = new System.Drawing.Point(64, 54);
            this.dgvListarEmpleado.MultiSelect = false;
            this.dgvListarEmpleado.Name = "dgvListarEmpleado";
            this.dgvListarEmpleado.ReadOnly = true;
            this.dgvListarEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarEmpleado.Size = new System.Drawing.Size(589, 309);
            this.dgvListarEmpleado.TabIndex = 0;
            // 
            // frmListarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(727, 420);
            this.Controls.Add(this.dgvListarEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmListarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Empleados";
            this.Load += new System.EventHandler(this.frmListarEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarEmpleado;
    }
}