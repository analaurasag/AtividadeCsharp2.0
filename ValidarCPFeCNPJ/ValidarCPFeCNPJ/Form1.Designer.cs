namespace ValidarCPFeCNPJ
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
            this.validarCPFECNPJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geradorDeCPFECNPJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGeradorCPFeCNPJ = new System.Windows.Forms.Label();
            this.rdbGeradorCPF = new System.Windows.Forms.RadioButton();
            this.rdbGeradorCNPJ = new System.Windows.Forms.RadioButton();
            this.txtGeradorCPFeCNPJ = new System.Windows.Forms.TextBox();
            this.btnGeradorOK = new System.Windows.Forms.Button();
            this.btnGeradorCancelar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCpfouCnpj
            // 
            this.lblCpfouCnpj.AutoSize = true;
            this.lblCpfouCnpj.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfouCnpj.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCpfouCnpj.Location = new System.Drawing.Point(42, 11);
            this.lblCpfouCnpj.Name = "lblCpfouCnpj";
            this.lblCpfouCnpj.Size = new System.Drawing.Size(410, 42);
            this.lblCpfouCnpj.TabIndex = 0;
            this.lblCpfouCnpj.Text = "Valide seu CPF ou CNPJ:";
            // 
            // rdCpf
            // 
            this.rdCpf.AutoSize = true;
            this.rdCpf.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCpf.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rdCpf.Location = new System.Drawing.Point(126, 78);
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
            this.rdCNPJ.Checked = true;
            this.rdCNPJ.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCNPJ.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rdCNPJ.Location = new System.Drawing.Point(295, 78);
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
            this.txtCPFouCNPJ.Location = new System.Drawing.Point(20, 124);
            this.txtCPFouCNPJ.Name = "txtCPFouCNPJ";
            this.txtCPFouCNPJ.Size = new System.Drawing.Size(477, 44);
            this.txtCPFouCNPJ.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(197, 243);
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
            this.btnCancel.Location = new System.Drawing.Point(155, 319);
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
            this.validarCPFECNPJToolStripMenuItem,
            this.geradorDeCPFECNPJToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // validarCPFECNPJToolStripMenuItem
            // 
            this.validarCPFECNPJToolStripMenuItem.Name = "validarCPFECNPJToolStripMenuItem";
            this.validarCPFECNPJToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.validarCPFECNPJToolStripMenuItem.Text = "Validar CPF e CNPJ";
            this.validarCPFECNPJToolStripMenuItem.Click += new System.EventHandler(this.validarCPFECNPJToolStripMenuItem_Click);
            // 
            // geradorDeCPFECNPJToolStripMenuItem
            // 
            this.geradorDeCPFECNPJToolStripMenuItem.Name = "geradorDeCPFECNPJToolStripMenuItem";
            this.geradorDeCPFECNPJToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.geradorDeCPFECNPJToolStripMenuItem.Text = "Gerador de CPF e CNPJ";
            this.geradorDeCPFECNPJToolStripMenuItem.Click += new System.EventHandler(this.geradorDeCPFECNPJToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lblCpfouCnpj);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.rdCNPJ);
            this.panel1.Controls.Add(this.txtCPFouCNPJ);
            this.panel1.Controls.Add(this.rdCpf);
            this.panel1.Location = new System.Drawing.Point(48, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 380);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGeradorCancelar);
            this.panel2.Controls.Add(this.btnGeradorOK);
            this.panel2.Controls.Add(this.txtGeradorCPFeCNPJ);
            this.panel2.Controls.Add(this.rdbGeradorCNPJ);
            this.panel2.Controls.Add(this.rdbGeradorCPF);
            this.panel2.Controls.Add(this.lblGeradorCPFeCNPJ);
            this.panel2.Location = new System.Drawing.Point(48, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 380);
            this.panel2.TabIndex = 4;
            // 
            // lblGeradorCPFeCNPJ
            // 
            this.lblGeradorCPFeCNPJ.AutoSize = true;
            this.lblGeradorCPFeCNPJ.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeradorCPFeCNPJ.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblGeradorCPFeCNPJ.Location = new System.Drawing.Point(42, 36);
            this.lblGeradorCPFeCNPJ.Name = "lblGeradorCPFeCNPJ";
            this.lblGeradorCPFeCNPJ.Size = new System.Drawing.Size(426, 42);
            this.lblGeradorCPFeCNPJ.TabIndex = 1;
            this.lblGeradorCPFeCNPJ.Text = "Gerador de CPF ou CNPJ:";
            // 
            // rdbGeradorCPF
            // 
            this.rdbGeradorCPF.AutoSize = true;
            this.rdbGeradorCPF.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGeradorCPF.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rdbGeradorCPF.Location = new System.Drawing.Point(65, 110);
            this.rdbGeradorCPF.Name = "rdbGeradorCPF";
            this.rdbGeradorCPF.Size = new System.Drawing.Size(84, 40);
            this.rdbGeradorCPF.TabIndex = 7;
            this.rdbGeradorCPF.TabStop = true;
            this.rdbGeradorCPF.Text = "CPF";
            this.rdbGeradorCPF.UseVisualStyleBackColor = true;
            // 
            // rdbGeradorCNPJ
            // 
            this.rdbGeradorCNPJ.AutoSize = true;
            this.rdbGeradorCNPJ.Checked = true;
            this.rdbGeradorCNPJ.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGeradorCNPJ.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rdbGeradorCNPJ.Location = new System.Drawing.Point(295, 110);
            this.rdbGeradorCNPJ.Name = "rdbGeradorCNPJ";
            this.rdbGeradorCNPJ.Size = new System.Drawing.Size(105, 40);
            this.rdbGeradorCNPJ.TabIndex = 8;
            this.rdbGeradorCNPJ.TabStop = true;
            this.rdbGeradorCNPJ.Text = "CNPJ";
            this.rdbGeradorCNPJ.UseVisualStyleBackColor = true;
            // 
            // txtGeradorCPFeCNPJ
            // 
            this.txtGeradorCPFeCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeradorCPFeCNPJ.Location = new System.Drawing.Point(20, 177);
            this.txtGeradorCPFeCNPJ.Name = "txtGeradorCPFeCNPJ";
            this.txtGeradorCPFeCNPJ.Size = new System.Drawing.Size(477, 44);
            this.txtGeradorCPFeCNPJ.TabIndex = 9;
            // 
            // btnGeradorOK
            // 
            this.btnGeradorOK.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeradorOK.Location = new System.Drawing.Point(206, 257);
            this.btnGeradorOK.Name = "btnGeradorOK";
            this.btnGeradorOK.Size = new System.Drawing.Size(75, 40);
            this.btnGeradorOK.TabIndex = 10;
            this.btnGeradorOK.Text = "OK";
            this.btnGeradorOK.UseVisualStyleBackColor = true;
            // 
            // btnGeradorCancelar
            // 
            this.btnGeradorCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeradorCancelar.Location = new System.Drawing.Point(175, 322);
            this.btnGeradorCancelar.Name = "btnGeradorCancelar";
            this.btnGeradorCancelar.Size = new System.Drawing.Size(159, 41);
            this.btnGeradorCancelar.TabIndex = 11;
            this.btnGeradorCancelar.Text = "Cancelar";
            this.btnGeradorCancelar.UseVisualStyleBackColor = true;
            this.btnGeradorCancelar.Click += new System.EventHandler(this.btnGeradorCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem validarCPFECNPJToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGeradorCancelar;
        private System.Windows.Forms.Button btnGeradorOK;
        private System.Windows.Forms.TextBox txtGeradorCPFeCNPJ;
        private System.Windows.Forms.RadioButton rdbGeradorCNPJ;
        private System.Windows.Forms.RadioButton rdbGeradorCPF;
        private System.Windows.Forms.Label lblGeradorCPFeCNPJ;
    }
}

