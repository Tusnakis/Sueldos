﻿namespace T04P08SUELDOS_Pérez_Aranda_Agustín
{
    partial class Form1
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
            this.sueldos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mostrar = new System.Windows.Forms.TextBox();
            this.anyadir = new System.Windows.Forms.Button();
            this.acum = new System.Windows.Forms.TextBox();
            this.max = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.TextBox();
            this.media = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sueldos
            // 
            this.sueldos.Location = new System.Drawing.Point(51, 59);
            this.sueldos.Name = "sueldos";
            this.sueldos.Size = new System.Drawing.Size(129, 20);
            this.sueldos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduce 4 sueldos";
            // 
            // mostrar
            // 
            this.mostrar.Location = new System.Drawing.Point(237, 44);
            this.mostrar.Multiline = true;
            this.mostrar.Name = "mostrar";
            this.mostrar.ReadOnly = true;
            this.mostrar.Size = new System.Drawing.Size(144, 223);
            this.mostrar.TabIndex = 2;
            // 
            // anyadir
            // 
            this.anyadir.Location = new System.Drawing.Point(105, 99);
            this.anyadir.Name = "anyadir";
            this.anyadir.Size = new System.Drawing.Size(75, 23);
            this.anyadir.TabIndex = 3;
            this.anyadir.Text = "Añadir";
            this.anyadir.UseVisualStyleBackColor = true;
            this.anyadir.Click += new System.EventHandler(this.anyadir_Click);
            // 
            // acum
            // 
            this.acum.Location = new System.Drawing.Point(105, 146);
            this.acum.Name = "acum";
            this.acum.ReadOnly = true;
            this.acum.Size = new System.Drawing.Size(100, 20);
            this.acum.TabIndex = 4;
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(105, 182);
            this.max.Name = "max";
            this.max.ReadOnly = true;
            this.max.Size = new System.Drawing.Size(100, 20);
            this.max.TabIndex = 5;
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(105, 221);
            this.min.Name = "min";
            this.min.ReadOnly = true;
            this.min.Size = new System.Drawing.Size(100, 20);
            this.min.TabIndex = 6;
            // 
            // media
            // 
            this.media.Location = new System.Drawing.Point(105, 258);
            this.media.Name = "media";
            this.media.ReadOnly = true;
            this.media.Size = new System.Drawing.Size(100, 20);
            this.media.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Acumulado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Máximo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mínimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Promedio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 304);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.media);
            this.Controls.Add(this.min);
            this.Controls.Add(this.max);
            this.Controls.Add(this.acum);
            this.Controls.Add(this.anyadir);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sueldos);
            this.Name = "Form1";
            this.Text = "Guarda Sueldos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sueldos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mostrar;
        private System.Windows.Forms.Button anyadir;
        private System.Windows.Forms.TextBox acum;
        private System.Windows.Forms.TextBox max;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.TextBox media;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

