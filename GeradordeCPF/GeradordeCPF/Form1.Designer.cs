namespace GeradordeCPF
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDigiteCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnValidarCPF = new System.Windows.Forms.Button();
            this.lblGeradorCPF = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDigiteCPF
            // 
            this.lblDigiteCPF.AutoSize = true;
            this.lblDigiteCPF.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteCPF.Location = new System.Drawing.Point(154, 9);
            this.lblDigiteCPF.Name = "lblDigiteCPF";
            this.lblDigiteCPF.Size = new System.Drawing.Size(164, 45);
            this.lblDigiteCPF.TabIndex = 0;
            this.lblDigiteCPF.Text = "Digite o CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(66, 57);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(341, 49);
            this.txtCPF.TabIndex = 1;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // btnValidarCPF
            // 
            this.btnValidarCPF.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarCPF.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnValidarCPF.Location = new System.Drawing.Point(145, 128);
            this.btnValidarCPF.Name = "btnValidarCPF";
            this.btnValidarCPF.Size = new System.Drawing.Size(194, 43);
            this.btnValidarCPF.TabIndex = 2;
            this.btnValidarCPF.Text = "Validar CPF";
            this.btnValidarCPF.UseVisualStyleBackColor = true;
            this.btnValidarCPF.Click += new System.EventHandler(this.btnValidarCPF_Click);
            // 
            // lblGeradorCPF
            // 
            this.lblGeradorCPF.AutoSize = true;
            this.lblGeradorCPF.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeradorCPF.Location = new System.Drawing.Point(137, 225);
            this.lblGeradorCPF.Name = "lblGeradorCPF";
            this.lblGeradorCPF.Size = new System.Drawing.Size(199, 45);
            this.lblGeradorCPF.TabIndex = 3;
            this.lblGeradorCPF.Text = "Gerador de CPF";
            this.lblGeradorCPF.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(66, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 49);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(145, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Validar CPF";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblGeradorCPF);
            this.Controls.Add(this.btnValidarCPF);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblDigiteCPF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDigiteCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnValidarCPF;
        private System.Windows.Forms.Label lblGeradorCPF;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

