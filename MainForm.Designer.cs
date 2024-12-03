﻿namespace Grafos
{
    partial class MainForm
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
            this.btnAnchura = new System.Windows.Forms.Button();
            this.btnProfundidad = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtRecorrido = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHonduras = new System.Windows.Forms.Button();
            this.btnElSalvador = new System.Windows.Forms.Button();
            this.btnGuatemala = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnchura
            // 
            this.btnAnchura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnchura.Location = new System.Drawing.Point(275, 21);
            this.btnAnchura.Name = "btnAnchura";
            this.btnAnchura.Size = new System.Drawing.Size(97, 27);
            this.btnAnchura.TabIndex = 1;
            this.btnAnchura.Text = "Anchura";
            this.btnAnchura.UseVisualStyleBackColor = true;
            this.btnAnchura.Click += new System.EventHandler(this.btnAnchura_Click);
            // 
            // btnProfundidad
            // 
            this.btnProfundidad.Location = new System.Drawing.Point(275, 54);
            this.btnProfundidad.Name = "btnProfundidad";
            this.btnProfundidad.Size = new System.Drawing.Size(97, 27);
            this.btnProfundidad.TabIndex = 2;
            this.btnProfundidad.Text = "Profundidad";
            this.btnProfundidad.UseVisualStyleBackColor = true;
            this.btnProfundidad.Click += new System.EventHandler(this.btnProfundidad_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(389, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(136, 55);
            this.listBox1.TabIndex = 3;
            // 
            // txtRecorrido
            // 
            this.txtRecorrido.Location = new System.Drawing.Point(9, 41);
            this.txtRecorrido.Name = "txtRecorrido";
            this.txtRecorrido.Size = new System.Drawing.Size(230, 25);
            this.txtRecorrido.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAnchura);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.txtRecorrido);
            this.groupBox1.Controls.Add(this.btnProfundidad);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 89);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recorridos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Departamento inicial del recorrido:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.ForestGreen;
            this.groupBox2.Controls.Add(this.btnHonduras);
            this.groupBox2.Controls.Add(this.btnElSalvador);
            this.groupBox2.Controls.Add(this.btnGuatemala);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(958, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 125);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mapas";
            // 
            // btnHonduras
            // 
            this.btnHonduras.Location = new System.Drawing.Point(6, 90);
            this.btnHonduras.Name = "btnHonduras";
            this.btnHonduras.Size = new System.Drawing.Size(102, 29);
            this.btnHonduras.TabIndex = 2;
            this.btnHonduras.Text = "Honduras";
            this.btnHonduras.UseVisualStyleBackColor = true;
            this.btnHonduras.Click += new System.EventHandler(this.btnHonduras_Click);
            // 
            // btnElSalvador
            // 
            this.btnElSalvador.Location = new System.Drawing.Point(6, 24);
            this.btnElSalvador.Name = "btnElSalvador";
            this.btnElSalvador.Size = new System.Drawing.Size(102, 27);
            this.btnElSalvador.TabIndex = 1;
            this.btnElSalvador.Text = "El Salvador";
            this.btnElSalvador.UseVisualStyleBackColor = true;
            this.btnElSalvador.Click += new System.EventHandler(this.btnElSalvador_Click);
            // 
            // btnGuatemala
            // 
            this.btnGuatemala.Location = new System.Drawing.Point(6, 57);
            this.btnGuatemala.Name = "btnGuatemala";
            this.btnGuatemala.Size = new System.Drawing.Size(103, 27);
            this.btnGuatemala.TabIndex = 0;
            this.btnGuatemala.Text = "Guatemala";
            this.btnGuatemala.UseVisualStyleBackColor = true;
            this.btnGuatemala.Click += new System.EventHandler(this.btnGuatemala_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.ForestGreen;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(831, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 107);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Coordenadas";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1084, 471);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Mapas";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAnchura;
        private System.Windows.Forms.Button btnProfundidad;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtRecorrido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHonduras;
        private System.Windows.Forms.Button btnElSalvador;
        private System.Windows.Forms.Button btnGuatemala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
