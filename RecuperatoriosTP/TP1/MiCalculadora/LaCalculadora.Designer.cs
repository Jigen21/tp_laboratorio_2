namespace MiCalculadora
{
    partial class LaCalculadora
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Operar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.ConvertirABinario = new System.Windows.Forms.Button();
            this.ConvertirADecimal = new System.Windows.Forms.Button();
            this.Operador = new System.Windows.Forms.ComboBox();
            this.Numero1 = new System.Windows.Forms.TextBox();
            this.Numero2 = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Operar
            // 
            this.Operar.Location = new System.Drawing.Point(12, 97);
            this.Operar.Name = "Operar";
            this.Operar.Size = new System.Drawing.Size(75, 23);
            this.Operar.TabIndex = 0;
            this.Operar.Text = "Operar";
            this.Operar.UseVisualStyleBackColor = true;
            this.Operar.Click += new System.EventHandler(this.Operar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(106, 97);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 1;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(197, 97);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 2;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // ConvertirABinario
            // 
            this.ConvertirABinario.Location = new System.Drawing.Point(12, 126);
            this.ConvertirABinario.Name = "ConvertirABinario";
            this.ConvertirABinario.Size = new System.Drawing.Size(120, 23);
            this.ConvertirABinario.TabIndex = 3;
            this.ConvertirABinario.Text = "Convertir a Binario";
            this.ConvertirABinario.UseVisualStyleBackColor = true;
            this.ConvertirABinario.Click += new System.EventHandler(this.ConvertirABinario_Click);
            // 
            // ConvertirADecimal
            // 
            this.ConvertirADecimal.Location = new System.Drawing.Point(138, 126);
            this.ConvertirADecimal.Name = "ConvertirADecimal";
            this.ConvertirADecimal.Size = new System.Drawing.Size(134, 23);
            this.ConvertirADecimal.TabIndex = 4;
            this.ConvertirADecimal.Text = "Convertir a Decimal";
            this.ConvertirADecimal.UseVisualStyleBackColor = true;
            this.ConvertirADecimal.Click += new System.EventHandler(this.ConvertirADecimal_Click);
            // 
            // Operador
            // 
            this.Operador.FormattingEnabled = true;
            this.Operador.Location = new System.Drawing.Point(118, 60);
            this.Operador.Name = "Operador";
            this.Operador.Size = new System.Drawing.Size(48, 21);
            this.Operador.TabIndex = 5;
            // 
            // Numero1
            // 
            this.Numero1.Location = new System.Drawing.Point(12, 60);
            this.Numero1.Name = "Numero1";
            this.Numero1.Size = new System.Drawing.Size(100, 20);
            this.Numero1.TabIndex = 6;
            // 
            // Numero2
            // 
            this.Numero2.Location = new System.Drawing.Point(172, 60);
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(100, 20);
            this.Numero2.TabIndex = 7;
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(225, 9);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(0, 13);
            this.Resultado.TabIndex = 8;
            // 
            // LaCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 253);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Numero2);
            this.Controls.Add(this.Numero1);
            this.Controls.Add(this.Operador);
            this.Controls.Add(this.ConvertirADecimal);
            this.Controls.Add(this.ConvertirABinario);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Operar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LaCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Axel Francisco Quinteros 2A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Operar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button ConvertirABinario;
        private System.Windows.Forms.Button ConvertirADecimal;
        private System.Windows.Forms.ComboBox Operador;
        private System.Windows.Forms.TextBox Numero1;
        private System.Windows.Forms.TextBox Numero2;
        private System.Windows.Forms.Label Resultado;
    }
}

