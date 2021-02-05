namespace LibFormularios
{
    partial class FrmTramites
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
            this.CodTramite = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tramites = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Tramites)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.Text = "REGISTRO DE TRAMITES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código de Trámite";
            // 
            // CodTramite
            // 
            this.CodTramite.Location = new System.Drawing.Point(341, 110);
            this.CodTramite.Name = "CodTramite";
            this.CodTramite.Size = new System.Drawing.Size(100, 20);
            this.CodTramite.TabIndex = 8;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(341, 136);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(224, 20);
            this.Nombre.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // Tramites
            // 
            this.Tramites.AllowUserToAddRows = false;
            this.Tramites.AllowUserToDeleteRows = false;
            this.Tramites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tramites.Location = new System.Drawing.Point(13, 202);
            this.Tramites.Name = "Tramites";
            this.Tramites.ReadOnly = true;
            this.Tramites.Size = new System.Drawing.Size(732, 180);
            this.Tramites.TabIndex = 11;
            // 
            // FrmTramites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.Tramites);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.CodTramite);
            this.Controls.Add(this.label1);
            this.Name = "FrmTramites";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.CodTramite, 0);
            this.Controls.SetChildIndex(this.Nombre, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Tramites, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Tramites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodTramite;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Tramites;
    }
}
