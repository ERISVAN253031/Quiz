namespace Quiz
{
    partial class FrmP1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.btnCerta = new System.Windows.Forms.RadioButton();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.btnProximo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(886, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "O que é C#?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn3);
            this.groupBox1.Controls.Add(this.btnCerta);
            this.groupBox1.Controls.Add(this.rbtn2);
            this.groupBox1.Controls.Add(this.rbtn1);
            this.groupBox1.Location = new System.Drawing.Point(52, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 280);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rbtn3
            // 
            this.rbtn3.AutoSize = true;
            this.rbtn3.Location = new System.Drawing.Point(36, 210);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(843, 33);
            this.rbtn3.TabIndex = 4;
            this.rbtn3.TabStop = true;
            this.rbtn3.Text = "D- C# é uma linguagem de programação exclusiva para dispositivos móveis";
            this.rbtn3.UseVisualStyleBackColor = true;
            this.rbtn3.UseWaitCursor = true;
            // 
            // btnCerta
            // 
            this.btnCerta.AutoSize = true;
            this.btnCerta.Location = new System.Drawing.Point(36, 158);
            this.btnCerta.Name = "btnCerta";
            this.btnCerta.Size = new System.Drawing.Size(687, 33);
            this.btnCerta.TabIndex = 3;
            this.btnCerta.TabStop = true;
            this.btnCerta.Text = "C- C# é uma linguagem de programação orientada a objetos.\r\n";
            this.btnCerta.UseVisualStyleBackColor = true;
            this.btnCerta.UseWaitCursor = true;
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Location = new System.Drawing.Point(36, 105);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(609, 33);
            this.rbtn2.TabIndex = 2;
            this.rbtn2.TabStop = true;
            this.rbtn2.Text = "B- C# é uma linguagem de programação interpretada.";
            this.rbtn2.UseVisualStyleBackColor = true;
            this.rbtn2.UseWaitCursor = true;
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Location = new System.Drawing.Point(36, 48);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(689, 33);
            this.rbtn1.TabIndex = 1;
            this.rbtn1.TabStop = true;
            this.rbtn1.Text = "A- C# é uma linguagem de programação orientada a eventos.";
            this.rbtn1.UseVisualStyleBackColor = true;
            // 
            // btnProximo
            // 
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Location = new System.Drawing.Point(808, 416);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(123, 46);
            this.btnProximo.TabIndex = 0;
            this.btnProximo.Text = "Proximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.UseWaitCursor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // FrmP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(971, 522);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmP1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmP1";
            this.Load += new System.EventHandler(this.FrmP1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.RadioButton btnCerta;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.RadioButton rbtn1;
    }
}