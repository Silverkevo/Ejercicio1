namespace EjercicioTarea1
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
            this.CalcularButton = new System.Windows.Forms.Button();
            this.IngreseLabel = new System.Windows.Forms.Label();
            this.IngreseTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(220, 169);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 23);
            this.CalcularButton.TabIndex = 0;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // IngreseLabel
            // 
            this.IngreseLabel.AutoSize = true;
            this.IngreseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngreseLabel.Location = new System.Drawing.Point(87, 128);
            this.IngreseLabel.Name = "IngreseLabel";
            this.IngreseLabel.Size = new System.Drawing.Size(217, 20);
            this.IngreseLabel.TabIndex = 1;
            this.IngreseLabel.Text = "Ingrese un numero entero";
            // 
            // IngreseTextBox
            // 
            this.IngreseTextBox.Location = new System.Drawing.Point(324, 128);
            this.IngreseTextBox.Name = "IngreseTextBox";
            this.IngreseTextBox.Size = new System.Drawing.Size(100, 20);
            this.IngreseTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IngreseTextBox);
            this.Controls.Add(this.IngreseLabel);
            this.Controls.Add(this.CalcularButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Label IngreseLabel;
        private System.Windows.Forms.TextBox IngreseTextBox;
    }
}

