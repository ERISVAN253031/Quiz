namespace Quiz
{
    partial class FrmP9
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
            this.btnProximo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.btnCerta = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnProximo.Location = new System.Drawing.Point(815, 465);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(5);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(131, 50);
            this.btnProximo.TabIndex = 14;
            this.btnProximo.Text = "Proximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.UseWaitCursor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.rbtn3);
            this.groupBox1.Controls.Add(this.rbtn2);
            this.groupBox1.Controls.Add(this.rbtn1);
            this.groupBox1.Controls.Add(this.btnCerta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.groupBox1.Location = new System.Drawing.Point(24, 93);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(922, 349);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // rbtn3
            // 
            this.rbtn3.AutoSize = true;
            this.rbtn3.Location = new System.Drawing.Point(66, 277);
            this.rbtn3.Margin = new System.Windows.Forms.Padding(5);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(810, 62);
            this.rbtn3.TabIndex = 4;
            this.rbtn3.TabStop = true;
            this.rbtn3.Text = "D- Propriedades em C# são elementos usados exclusivamente para fins \r\nde depuraçã" +
    "o.";
            this.rbtn3.UseVisualStyleBackColor = true;
            this.rbtn3.UseWaitCursor = true;
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Location = new System.Drawing.Point(66, 207);
            this.rbtn2.Margin = new System.Windows.Forms.Padding(5);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(831, 62);
            this.rbtn2.TabIndex = 0;
            this.rbtn2.TabStop = true;
            this.rbtn2.Text = "C-Propriedades em C# são variáveis globais acessíveis de qualquer lugar \r\nno prog" +
    "rama.";
            this.rbtn2.UseVisualStyleBackColor = true;
            this.rbtn2.UseWaitCursor = true;
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Location = new System.Drawing.Point(70, 138);
            this.rbtn1.Margin = new System.Windows.Forms.Padding(5);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(842, 62);
            this.rbtn1.TabIndex = 2;
            this.rbtn1.TabStop = true;
            this.rbtn1.Text = "B-  Propriedades em C# são métodos estáticos usados para criar instâncias\r\n de um" +
    "a classe.";
            this.rbtn1.UseVisualStyleBackColor = true;
            this.rbtn1.UseWaitCursor = true;
            // 
            // btnCerta
            // 
            this.btnCerta.AutoSize = true;
            this.btnCerta.Location = new System.Drawing.Point(66, 37);
            this.btnCerta.Margin = new System.Windows.Forms.Padding(5);
            this.btnCerta.Name = "btnCerta";
            this.btnCerta.Size = new System.Drawing.Size(753, 91);
            this.btnCerta.TabIndex = 1;
            this.btnCerta.TabStop = true;
            this.btnCerta.Text = "A-  Propriedades em C# são membros de classe que fornecem um \r\nmecanismo para ler" +
    ", gravar ou calcular o valor de um campo\r\n particular. ";
            this.btnCerta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(922, 80);
            this.label1.TabIndex = 15;
            this.label1.Text = "O que são propriedades em C#?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            // 
            // FrmP9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(971, 522);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmP9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmP9";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.RadioButton btnCerta;
        private System.Windows.Forms.Label label1;
    }
}