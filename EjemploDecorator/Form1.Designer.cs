
namespace EjemploDecorator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSolo = new System.Windows.Forms.Button();
            this.btnExpreso = new System.Windows.Forms.Button();
            this.btnSinCafeina = new System.Windows.Forms.Button();
            this.btnTe = new System.Windows.Forms.Button();
            this.btnAzucar = new System.Windows.Forms.Button();
            this.btnEdulcorante = new System.Windows.Forms.Button();
            this.btnCrema = new System.Windows.Forms.Button();
            this.btnleche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(407, 285);
            this.textBox1.TabIndex = 0;
            // 
            // btnSolo
            // 
            this.btnSolo.Location = new System.Drawing.Point(425, 12);
            this.btnSolo.Name = "btnSolo";
            this.btnSolo.Size = new System.Drawing.Size(103, 23);
            this.btnSolo.TabIndex = 1;
            this.btnSolo.Text = "Solo";
            this.btnSolo.UseVisualStyleBackColor = true;
            this.btnSolo.Click += new System.EventHandler(this.btnSolo_Click);
            // 
            // btnExpreso
            // 
            this.btnExpreso.Location = new System.Drawing.Point(425, 41);
            this.btnExpreso.Name = "btnExpreso";
            this.btnExpreso.Size = new System.Drawing.Size(103, 23);
            this.btnExpreso.TabIndex = 2;
            this.btnExpreso.Text = "Expreso";
            this.btnExpreso.UseVisualStyleBackColor = true;
            this.btnExpreso.Click += new System.EventHandler(this.btnExpreso_Click);
            // 
            // btnSinCafeina
            // 
            this.btnSinCafeina.Location = new System.Drawing.Point(425, 70);
            this.btnSinCafeina.Name = "btnSinCafeina";
            this.btnSinCafeina.Size = new System.Drawing.Size(103, 23);
            this.btnSinCafeina.TabIndex = 3;
            this.btnSinCafeina.Text = "Sin cafeina";
            this.btnSinCafeina.UseVisualStyleBackColor = true;
            this.btnSinCafeina.Click += new System.EventHandler(this.btnSinCafeina_Click);
            // 
            // btnTe
            // 
            this.btnTe.Location = new System.Drawing.Point(425, 99);
            this.btnTe.Name = "btnTe";
            this.btnTe.Size = new System.Drawing.Size(103, 23);
            this.btnTe.TabIndex = 4;
            this.btnTe.Text = "Te tradicional";
            this.btnTe.UseVisualStyleBackColor = true;
            this.btnTe.Click += new System.EventHandler(this.btnTe_Click);
            // 
            // btnAzucar
            // 
            this.btnAzucar.Location = new System.Drawing.Point(425, 274);
            this.btnAzucar.Name = "btnAzucar";
            this.btnAzucar.Size = new System.Drawing.Size(103, 23);
            this.btnAzucar.TabIndex = 8;
            this.btnAzucar.Text = "Azucar";
            this.btnAzucar.UseVisualStyleBackColor = true;
            this.btnAzucar.Click += new System.EventHandler(this.btnAzucar_Click);
            // 
            // btnEdulcorante
            // 
            this.btnEdulcorante.Location = new System.Drawing.Point(425, 245);
            this.btnEdulcorante.Name = "btnEdulcorante";
            this.btnEdulcorante.Size = new System.Drawing.Size(103, 23);
            this.btnEdulcorante.TabIndex = 7;
            this.btnEdulcorante.Text = "Edulcorante";
            this.btnEdulcorante.UseVisualStyleBackColor = true;
            this.btnEdulcorante.Click += new System.EventHandler(this.btnEdulcorante_Click);
            // 
            // btnCrema
            // 
            this.btnCrema.Location = new System.Drawing.Point(425, 216);
            this.btnCrema.Name = "btnCrema";
            this.btnCrema.Size = new System.Drawing.Size(103, 23);
            this.btnCrema.TabIndex = 6;
            this.btnCrema.Text = "Crema";
            this.btnCrema.UseVisualStyleBackColor = true;
            this.btnCrema.Click += new System.EventHandler(this.btnCrema_Click);
            // 
            // btnleche
            // 
            this.btnleche.Location = new System.Drawing.Point(425, 187);
            this.btnleche.Name = "btnleche";
            this.btnleche.Size = new System.Drawing.Size(103, 23);
            this.btnleche.TabIndex = 5;
            this.btnleche.Text = "Leche";
            this.btnleche.UseVisualStyleBackColor = true;
            this.btnleche.Click += new System.EventHandler(this.btnleche_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 306);
            this.Controls.Add(this.btnAzucar);
            this.Controls.Add(this.btnEdulcorante);
            this.Controls.Add(this.btnCrema);
            this.Controls.Add(this.btnleche);
            this.Controls.Add(this.btnTe);
            this.Controls.Add(this.btnSinCafeina);
            this.Controls.Add(this.btnExpreso);
            this.Controls.Add(this.btnSolo);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSolo;
        private System.Windows.Forms.Button btnExpreso;
        private System.Windows.Forms.Button btnSinCafeina;
        private System.Windows.Forms.Button btnTe;
        private System.Windows.Forms.Button btnAzucar;
        private System.Windows.Forms.Button btnEdulcorante;
        private System.Windows.Forms.Button btnCrema;
        private System.Windows.Forms.Button btnleche;
    }
}

