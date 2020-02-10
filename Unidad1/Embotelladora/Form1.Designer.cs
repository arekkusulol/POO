namespace Embotelladora
{
    partial class frmEmbotelladora
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
            this.lblNivelLlenado = new System.Windows.Forms.Label();
            this.txtNivelLlenado = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNivelLlenado
            // 
            this.lblNivelLlenado.AutoSize = true;
            this.lblNivelLlenado.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelLlenado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNivelLlenado.Location = new System.Drawing.Point(12, 22);
            this.lblNivelLlenado.Name = "lblNivelLlenado";
            this.lblNivelLlenado.Size = new System.Drawing.Size(226, 25);
            this.lblNivelLlenado.TabIndex = 0;
            this.lblNivelLlenado.Text = "Introduce el nivel de llenado:\r\n";
            this.lblNivelLlenado.Click += new System.EventHandler(this.lblNivelLlenado_Click);
            // 
            // txtNivelLlenado
            // 
            this.txtNivelLlenado.Location = new System.Drawing.Point(261, 26);
            this.txtNivelLlenado.Name = "txtNivelLlenado";
            this.txtNivelLlenado.Size = new System.Drawing.Size(134, 20);
            this.txtNivelLlenado.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnVerificar.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerificar.Location = new System.Drawing.Point(27, 148);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(124, 70);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // frmEmbotelladora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(405, 251);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtNivelLlenado);
            this.Controls.Add(this.lblNivelLlenado);
            this.Name = "frmEmbotelladora";
            this.Text = "Embotelladora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNivelLlenado;
        private System.Windows.Forms.TextBox txtNivelLlenado;
        private System.Windows.Forms.Button btnVerificar;
    }
}

