namespace LibFormularios
{
    partial class FrmRequisitoTramite
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
            this.Solicitud = new System.Windows.Forms.ComboBox();
            this.dgvRequisitos = new System.Windows.Forms.DataGridView();
            this.dgvRequisitosSolicitud = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CodSolicitud = new System.Windows.Forms.TextBox();
            this.CodRequisito = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitosSolicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.Text = "REGISTRO DE REQUISITOS POR TRAMITE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Solicitud";
            // 
            // Solicitud
            // 
            this.Solicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Solicitud.FormattingEnabled = true;
            this.Solicitud.Items.AddRange(new object[] {
            "Solicitud de evaluacion de plan de tesis",
            "Solicitud de evaluacion de tesis",
            "Solicitud de sustentacion oral"});
            this.Solicitud.Location = new System.Drawing.Point(508, 147);
            this.Solicitud.Name = "Solicitud";
            this.Solicitud.Size = new System.Drawing.Size(210, 21);
            this.Solicitud.TabIndex = 8;
            // 
            // dgvRequisitos
            // 
            this.dgvRequisitos.AllowUserToAddRows = false;
            this.dgvRequisitos.AllowUserToDeleteRows = false;
            this.dgvRequisitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisitos.Location = new System.Drawing.Point(12, 200);
            this.dgvRequisitos.Name = "dgvRequisitos";
            this.dgvRequisitos.ReadOnly = true;
            this.dgvRequisitos.Size = new System.Drawing.Size(732, 101);
            this.dgvRequisitos.TabIndex = 9;
            // 
            // dgvRequisitosSolicitud
            // 
            this.dgvRequisitosSolicitud.AllowUserToAddRows = false;
            this.dgvRequisitosSolicitud.AllowUserToDeleteRows = false;
            this.dgvRequisitosSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisitosSolicitud.Location = new System.Drawing.Point(15, 320);
            this.dgvRequisitosSolicitud.Name = "dgvRequisitosSolicitud";
            this.dgvRequisitosSolicitud.ReadOnly = true;
            this.dgvRequisitosSolicitud.Size = new System.Drawing.Size(732, 88);
            this.dgvRequisitosSolicitud.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Requisitos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Requisitos de Solicitud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Codigo";
            // 
            // CodSolicitud
            // 
            this.CodSolicitud.Location = new System.Drawing.Point(508, 121);
            this.CodSolicitud.Name = "CodSolicitud";
            this.CodSolicitud.Size = new System.Drawing.Size(109, 20);
            this.CodSolicitud.TabIndex = 14;
            // 
            // CodRequisito
            // 
            this.CodRequisito.Location = new System.Drawing.Point(138, 125);
            this.CodRequisito.Name = "CodRequisito";
            this.CodRequisito.Size = new System.Drawing.Size(109, 20);
            this.CodRequisito.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Codigo de Requisito";
            // 
            // FrmRequisitoTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.CodRequisito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CodSolicitud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRequisitosSolicitud);
            this.Controls.Add(this.dgvRequisitos);
            this.Controls.Add(this.Solicitud);
            this.Controls.Add(this.label1);
            this.Name = "FrmRequisitoTramite";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Solicitud, 0);
            this.Controls.SetChildIndex(this.dgvRequisitos, 0);
            this.Controls.SetChildIndex(this.dgvRequisitosSolicitud, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.CodSolicitud, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.CodRequisito, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitosSolicitud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Solicitud;
        private System.Windows.Forms.DataGridView dgvRequisitos;
        private System.Windows.Forms.DataGridView dgvRequisitosSolicitud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CodSolicitud;
        private System.Windows.Forms.TextBox CodRequisito;
        private System.Windows.Forms.Label label5;
    }
}
