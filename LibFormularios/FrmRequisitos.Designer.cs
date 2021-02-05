namespace LibFormularios
{
    partial class FrmRequisitos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CodRequisito = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Requisitos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Requisitos)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.Text = "REGISTRO DE REQUISITOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código de requisito ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // CodRequisito
            // 
            this.CodRequisito.Location = new System.Drawing.Point(311, 114);
            this.CodRequisito.Name = "CodRequisito";
            this.CodRequisito.Size = new System.Drawing.Size(100, 20);
            this.CodRequisito.TabIndex = 9;
            this.CodRequisito.Leave += new System.EventHandler(this.CodRequisito_Leave);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(311, 140);
            this.Nombre.Multiline = true;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(221, 20);
            this.Nombre.TabIndex = 10;
            // 
            // Requisitos
            // 
            this.Requisitos.AllowUserToAddRows = false;
            this.Requisitos.AllowUserToDeleteRows = false;
            this.Requisitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Requisitos.Location = new System.Drawing.Point(13, 206);
            this.Requisitos.Name = "Requisitos";
            this.Requisitos.ReadOnly = true;
            this.Requisitos.Size = new System.Drawing.Size(732, 174);
            this.Requisitos.TabIndex = 11;
            // 
            // FrmRequisitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.Requisitos);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.CodRequisito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRequisitos";
            this.Load += new System.EventHandler(this.FrmRequisitos_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.CodRequisito, 0);
            this.Controls.SetChildIndex(this.Nombre, 0);
            this.Controls.SetChildIndex(this.Requisitos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Requisitos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodRequisito;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.DataGridView Requisitos;
    }
}
