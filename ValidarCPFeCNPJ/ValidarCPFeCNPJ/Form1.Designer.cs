﻿namespace ValidarCPFeCNPJ
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
            this.lblCpfouCnpj = new System.Windows.Forms.Label();
            this.rdCpf = new System.Windows.Forms.RadioButton();
            this.rdCNPJ = new System.Windows.Forms.RadioButton();
            this.txtCPFouCNPJ = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.geradorDeCPFECNPJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCpfouCnpj
            // 
            this.lblCpfouCnpj.AutoSize = true;
            this.lblCpfouCnpj.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfouCnpj.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCpfouCnpj.Location = new System.Drawing.Point(113, 49);
            this.lblCpfouCnpj.Name = "lblCpfouCnpj";
            this.lblCpfouCnpj.Size = new System.Drawing.Size(410, 42);
            this.lblCpfouCnpj.TabIndex = 0;
            this.lblCpfouCnpj.Text = "Valide seu CPF ou CNPJ:";
            this.lblCpfouCnpj.Click += new System.EventHandler(this.lblCpfouCnpj_Click);
            // 
            // rdCpf
            // 
            this.rdCpf.AutoSize = true;
            this.rdCpf.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCpf.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rdCpf.Location = new System.Drawing.Point(194, 105);
            this.rdCpf.Name = "rdCpf";
            this.rdCpf.Size = new System.Drawing.Size(84, 40);
            this.rdCpf.TabIndex = 1;
            this.rdCpf.TabStop = true;
            this.rdCpf.Text = "CPF";
            this.rdCpf.UseVisualStyleBackColor = true;
            // 
            // rdCNPJ
            // 
            this.rdCNPJ.AutoSize = true;
            this.rdCNPJ.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCNPJ.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rdCNPJ.Location = new System.Drawing.Point(332, 105);
            this.rdCNPJ.Name = "rdCNPJ";
            this.rdCNPJ.Size = new System.Drawing.Size(105, 40);
            this.rdCNPJ.TabIndex = 2;
            this.rdCNPJ.TabStop = true;
            this.rdCNPJ.Text = "CNPJ";
            this.rdCNPJ.UseVisualStyleBackColor = true;
            // 
            // txtCPFouCNPJ
            // 
            this.txtCPFouCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPFouCNPJ.Location = new System.Drawing.Point(76, 151);
            this.txtCPFouCNPJ.Name = "txtCPFouCNPJ";
            this.txtCPFouCNPJ.Size = new System.Drawing.Size(477, 44);
            this.txtCPFouCNPJ.TabIndex = 3;
            this.txtCPFouCNPJ.TextChanged += new System.EventHandler(this.txtCPFouCNPJ_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(273, 265);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 40);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(235, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(159, 41);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geradorDeCPFECNPJToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // geradorDeCPFECNPJToolStripMenuItem
            // 
            this.geradorDeCPFECNPJToolStripMenuItem.Name = "geradorDeCPFECNPJToolStripMenuItem";
            this.geradorDeCPFECNPJToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.geradorDeCPFECNPJToolStripMenuItem.Text = "Gerador de CPF e CNPJ";
            this.geradorDeCPFECNPJToolStripMenuItem.Click += new System.EventHandler(this.geradorDeCPFECNPJToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtCPFouCNPJ);
            this.Controls.Add(this.rdCNPJ);
            this.Controls.Add(this.rdCpf);
            this.Controls.Add(this.lblCpfouCnpj);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCpfouCnpj;
        private System.Windows.Forms.RadioButton rdCpf;
        private System.Windows.Forms.RadioButton rdCNPJ;
        private System.Windows.Forms.TextBox txtCPFouCNPJ;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem geradorDeCPFECNPJToolStripMenuItem;
    }
}

