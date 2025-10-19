namespace EstructuraDinamica
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
            this.btnPilas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPilas
            // 
            this.btnPilas.Location = new System.Drawing.Point(38, 57);
            this.btnPilas.Name = "btnPilas";
            this.btnPilas.Size = new System.Drawing.Size(206, 73);
            this.btnPilas.TabIndex = 0;
            this.btnPilas.Text = "Pilas";
            this.btnPilas.UseVisualStyleBackColor = true;
            this.btnPilas.Click += new System.EventHandler(this.btnPilas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pila 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPilas);
            this.Name = "Form1";
            this.Text = "Estructuras Dinamicas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPilas;
        private System.Windows.Forms.Button button1;
    }
}

