﻿
namespace MoAnSo_Molinorte
{
    partial class Consulta_Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(299, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 561);
            this.dataGridView1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F);
            this.button3.Location = new System.Drawing.Point(50, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 39);
            this.button3.TabIndex = 106;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F);
            this.textBox2.Location = new System.Drawing.Point(50, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 29);
            this.textBox2.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 104;
            this.label1.Text = "Codigo Cliente";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F);
            this.button2.Location = new System.Drawing.Point(50, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 39);
            this.button2.TabIndex = 108;
            this.button2.Text = "Eliminar ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F);
            this.button1.Location = new System.Drawing.Point(50, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 39);
            this.button1.TabIndex = 107;
            this.button1.Text = "Mostrar Todo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F);
            this.button4.Location = new System.Drawing.Point(50, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 39);
            this.button4.TabIndex = 109;
            this.button4.Text = "Ordenar Frecuentes";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Consulta_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Consulta_Clientes";
            this.Text = "Consulta_Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}