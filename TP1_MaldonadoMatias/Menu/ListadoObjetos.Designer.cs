namespace Menu
{
    partial class ListadoObjetos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoObjetos));
            this.lblItem = new System.Windows.Forms.Label();
            this.txtNewItem = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.clbIzquierda = new System.Windows.Forms.CheckedListBox();
            this.clbDerecha = new System.Windows.Forms.CheckedListBox();
            this.btnTrasAll = new System.Windows.Forms.Button();
            this.btnTrasDer = new System.Windows.Forms.Button();
            this.btnTrasIzq = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(145, 27);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(68, 13);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Ingrese Item:";
            // 
            // txtNewItem
            // 
            this.txtNewItem.Location = new System.Drawing.Point(222, 24);
            this.txtNewItem.Name = "txtNewItem";
            this.txtNewItem.Size = new System.Drawing.Size(118, 20);
            this.txtNewItem.TabIndex = 1;
            this.txtNewItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewItem_KeyDown);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(372, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // clbIzquierda
            // 
            this.clbIzquierda.CheckOnClick = true;
            this.clbIzquierda.FormattingEnabled = true;
            this.clbIzquierda.Location = new System.Drawing.Point(20, 62);
            this.clbIzquierda.Name = "clbIzquierda";
            this.clbIzquierda.Size = new System.Drawing.Size(223, 184);
            this.clbIzquierda.TabIndex = 3;
            // 
            // clbDerecha
            // 
            this.clbDerecha.CheckOnClick = true;
            this.clbDerecha.FormattingEnabled = true;
            this.clbDerecha.Location = new System.Drawing.Point(355, 62);
            this.clbDerecha.Name = "clbDerecha";
            this.clbDerecha.Size = new System.Drawing.Size(223, 184);
            this.clbDerecha.TabIndex = 6;
            // 
            // btnTrasAll
            // 
            this.btnTrasAll.Location = new System.Drawing.Point(261, 91);
            this.btnTrasAll.Name = "btnTrasAll";
            this.btnTrasAll.Size = new System.Drawing.Size(75, 23);
            this.btnTrasAll.TabIndex = 4;
            this.btnTrasAll.Text = ">>";
            this.btnTrasAll.UseVisualStyleBackColor = true;
            this.btnTrasAll.Click += new System.EventHandler(this.btnTrasAll_Click);
            // 
            // btnTrasDer
            // 
            this.btnTrasDer.Location = new System.Drawing.Point(261, 120);
            this.btnTrasDer.Name = "btnTrasDer";
            this.btnTrasDer.Size = new System.Drawing.Size(75, 23);
            this.btnTrasDer.TabIndex = 5;
            this.btnTrasDer.Text = ">";
            this.btnTrasDer.UseVisualStyleBackColor = true;
            this.btnTrasDer.Click += new System.EventHandler(this.btnTrasDer_Click);
            // 
            // btnTrasIzq
            // 
            this.btnTrasIzq.Location = new System.Drawing.Point(261, 149);
            this.btnTrasIzq.Name = "btnTrasIzq";
            this.btnTrasIzq.Size = new System.Drawing.Size(75, 23);
            this.btnTrasIzq.TabIndex = 7;
            this.btnTrasIzq.Text = "<";
            this.btnTrasIzq.UseVisualStyleBackColor = true;
            this.btnTrasIzq.Click += new System.EventHandler(this.btnTrasIzq_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(261, 178);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "...";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(261, 261);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // ListadoObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(604, 296);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnTrasIzq);
            this.Controls.Add(this.btnTrasDer);
            this.Controls.Add(this.btnTrasAll);
            this.Controls.Add(this.clbDerecha);
            this.Controls.Add(this.clbIzquierda);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNewItem);
            this.Controls.Add(this.lblItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListadoObjetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Objetos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListadoObjetos_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtNewItem;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckedListBox clbIzquierda;
        private System.Windows.Forms.CheckedListBox clbDerecha;
        private System.Windows.Forms.Button btnTrasAll;
        private System.Windows.Forms.Button btnTrasDer;
        private System.Windows.Forms.Button btnTrasIzq;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCerrar;
    }
}