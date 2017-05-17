namespace ListasFIFO
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.txtProcedimiento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 67);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtReporte
            // 
            this.txtReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReporte.Location = new System.Drawing.Point(12, 5);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.Size = new System.Drawing.Size(384, 96);
            this.txtReporte.TabIndex = 1;
            // 
            // txtProcedimiento
            // 
            this.txtProcedimiento.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedimiento.Location = new System.Drawing.Point(402, 5);
            this.txtProcedimiento.Multiline = true;
            this.txtProcedimiento.Name = "txtProcedimiento";
            this.txtProcedimiento.Size = new System.Drawing.Size(366, 298);
            this.txtProcedimiento.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 315);
            this.Controls.Add(this.txtProcedimiento);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.TextBox txtProcedimiento;
    }
}

