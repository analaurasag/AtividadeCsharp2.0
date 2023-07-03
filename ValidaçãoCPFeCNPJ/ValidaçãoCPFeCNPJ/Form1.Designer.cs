namespace ValidaçãoCPFeCNPJ
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
            this.lblValidarCPFouCNPJ = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.txtCPFeCNPJ = new System.Windows.Forms.TextBox();
            this.rdbCNPJ = new System.Windows.Forms.RadioButton();
            this.rdbCPF = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblValidarCPFouCNPJ
            // 
            this.lblValidarCPFouCNPJ.AutoSize = true;
            this.lblValidarCPFouCNPJ.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarCPFouCNPJ.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblValidarCPFouCNPJ.Location = new System.Drawing.Point(186, 28);
            this.lblValidarCPFouCNPJ.Name = "lblValidarCPFouCNPJ";
            this.lblValidarCPFouCNPJ.Size = new System.Drawing.Size(208, 46);
            this.lblValidarCPFouCNPJ.TabIndex = 0;
            this.lblValidarCPFouCNPJ.Text = "Valide seu:";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOK.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(249, 243);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 52);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCANCELAR.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCELAR.Location = new System.Drawing.Point(194, 319);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(189, 47);
            this.btnCANCELAR.TabIndex = 6;
            this.btnCANCELAR.Text = "CANCELAR";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            // 
            // txtCPFeCNPJ
            // 
            this.txtCPFeCNPJ.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCPFeCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPFeCNPJ.Location = new System.Drawing.Point(60, 157);
            this.txtCPFeCNPJ.Name = "txtCPFeCNPJ";
            this.txtCPFeCNPJ.Size = new System.Drawing.Size(467, 38);
            this.txtCPFeCNPJ.TabIndex = 3;
            // 
            // rdbCNPJ
            // 
            this.rdbCNPJ.AutoSize = true;
            this.rdbCNPJ.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCNPJ.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rdbCNPJ.Location = new System.Drawing.Point(352, 112);
            this.rdbCNPJ.Name = "rdbCNPJ";
            this.rdbCNPJ.Size = new System.Drawing.Size(101, 39);
            this.rdbCNPJ.TabIndex = 7;
            this.rdbCNPJ.TabStop = true;
            this.rdbCNPJ.Text = "CNPJ";
            this.rdbCNPJ.UseVisualStyleBackColor = true;
            // 
            // rdbCPF
            // 
            this.rdbCPF.AutoSize = true;
            this.rdbCPF.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCPF.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.rdbCPF.Location = new System.Drawing.Point(110, 112);
            this.rdbCPF.Name = "rdbCPF";
            this.rdbCPF.Size = new System.Drawing.Size(82, 39);
            this.rdbCPF.TabIndex = 8;
            this.rdbCPF.TabStop = true;
            this.rdbCPF.Text = "CPF";
            this.rdbCPF.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.rdbCPF);
            this.Controls.Add(this.rdbCNPJ);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCPFeCNPJ);
            this.Controls.Add(this.lblValidarCPFouCNPJ);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValidarCPFouCNPJ;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.TextBox txtCPFeCNPJ;
        private System.Windows.Forms.RadioButton rdbCNPJ;
        private System.Windows.Forms.RadioButton rdbCPF;
    }
}

