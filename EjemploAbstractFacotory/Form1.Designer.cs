﻿
namespace EjemploAbstractFacotory
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
            this.cboPizzerias = new System.Windows.Forms.ComboBox();
            this.cboEmpanadas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPizzas = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 280);
            this.textBox1.TabIndex = 3;
            // 
            // cboPizzerias
            // 
            this.cboPizzerias.FormattingEnabled = true;
            this.cboPizzerias.Location = new System.Drawing.Point(384, 31);
            this.cboPizzerias.Name = "cboPizzerias";
            this.cboPizzerias.Size = new System.Drawing.Size(209, 21);
            this.cboPizzerias.TabIndex = 4;
            // 
            // cboEmpanadas
            // 
            this.cboEmpanadas.FormattingEnabled = true;
            this.cboEmpanadas.Location = new System.Drawing.Point(384, 92);
            this.cboEmpanadas.Name = "cboEmpanadas";
            this.cboEmpanadas.Size = new System.Drawing.Size(209, 21);
            this.cboEmpanadas.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pizzeria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Empanadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pizzas";
            // 
            // cboPizzas
            // 
            this.cboPizzas.FormattingEnabled = true;
            this.cboPizzas.Location = new System.Drawing.Point(384, 137);
            this.cboPizzas.Name = "cboPizzas";
            this.cboPizzas.Size = new System.Drawing.Size(209, 21);
            this.cboPizzas.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboPizzas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEmpanadas);
            this.Controls.Add(this.cboPizzerias);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboPizzerias;
        private System.Windows.Forms.ComboBox cboEmpanadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPizzas;
        private System.Windows.Forms.Button button1;
    }
}

