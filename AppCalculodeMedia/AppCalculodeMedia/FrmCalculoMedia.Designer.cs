namespace AppCalculodeMedia
{
    partial class FrmCalculoMedia
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
            this.LblNota1 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.LblNota2 = new System.Windows.Forms.Label();
            this.LblNota3 = new System.Windows.Forms.Label();
            this.LblNota4 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.LblMedia = new System.Windows.Forms.Label();
            this.LblResultadoMedia = new System.Windows.Forms.Label();
            this.LblSituacao = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNota1
            // 
            this.LblNota1.AutoSize = true;
            this.LblNota1.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota1.Location = new System.Drawing.Point(28, 22);
            this.LblNota1.Name = "LblNota1";
            this.LblNota1.Size = new System.Drawing.Size(69, 22);
            this.LblNota1.TabIndex = 0;
            this.LblNota1.Text = "Nota 1";
            this.LblNota1.Click += new System.EventHandler(this.LblNota1_Click);
            // 
            // txtNota1
            // 
            this.txtNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota1.Location = new System.Drawing.Point(32, 47);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(168, 29);
            this.txtNota1.TabIndex = 1;
            // 
            // LblNota2
            // 
            this.LblNota2.AutoSize = true;
            this.LblNota2.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota2.Location = new System.Drawing.Point(28, 92);
            this.LblNota2.Name = "LblNota2";
            this.LblNota2.Size = new System.Drawing.Size(69, 22);
            this.LblNota2.TabIndex = 2;
            this.LblNota2.Text = "Nota 2";
            this.LblNota2.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblNota3
            // 
            this.LblNota3.AutoSize = true;
            this.LblNota3.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota3.Location = new System.Drawing.Point(28, 163);
            this.LblNota3.Name = "LblNota3";
            this.LblNota3.Size = new System.Drawing.Size(69, 22);
            this.LblNota3.TabIndex = 3;
            this.LblNota3.Text = "Nota 3";
            // 
            // LblNota4
            // 
            this.LblNota4.AutoSize = true;
            this.LblNota4.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota4.Location = new System.Drawing.Point(28, 235);
            this.LblNota4.Name = "LblNota4";
            this.LblNota4.Size = new System.Drawing.Size(69, 22);
            this.LblNota4.TabIndex = 4;
            this.LblNota4.Text = "Nota 4";
            // 
            // txtNota2
            // 
            this.txtNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota2.Location = new System.Drawing.Point(32, 117);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(168, 29);
            this.txtNota2.TabIndex = 5;
            // 
            // txtNota3
            // 
            this.txtNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota3.Location = new System.Drawing.Point(32, 188);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(168, 29);
            this.txtNota3.TabIndex = 6;
            // 
            // txtNota4
            // 
            this.txtNota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota4.Location = new System.Drawing.Point(32, 260);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(168, 29);
            this.txtNota4.TabIndex = 7;
            // 
            // LblMedia
            // 
            this.LblMedia.AutoSize = true;
            this.LblMedia.Font = new System.Drawing.Font("News701 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedia.Location = new System.Drawing.Point(321, 73);
            this.LblMedia.Name = "LblMedia";
            this.LblMedia.Size = new System.Drawing.Size(99, 32);
            this.LblMedia.TabIndex = 8;
            this.LblMedia.Text = "Média";
            // 
            // LblResultadoMedia
            // 
            this.LblResultadoMedia.AutoSize = true;
            this.LblResultadoMedia.Font = new System.Drawing.Font("Microsoft JhengHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultadoMedia.Location = new System.Drawing.Point(353, 117);
            this.LblResultadoMedia.Name = "LblResultadoMedia";
            this.LblResultadoMedia.Size = new System.Drawing.Size(56, 61);
            this.LblResultadoMedia.TabIndex = 11;
            this.LblResultadoMedia.Text = "7";
            this.LblResultadoMedia.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LblSituacao
            // 
            this.LblSituacao.AutoSize = true;
            this.LblSituacao.Font = new System.Drawing.Font("News701 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSituacao.Location = new System.Drawing.Point(261, 188);
            this.LblSituacao.Name = "LblSituacao";
            this.LblSituacao.Size = new System.Drawing.Size(232, 26);
            this.LblSituacao.TabIndex = 13;
            this.LblSituacao.Text = "Situação:  Aprovado";
            this.LblSituacao.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("News701 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(327, 220);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(107, 37);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AccessibleName = "FrmCalculoMedia";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 337);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.LblSituacao);
            this.Controls.Add(this.LblResultadoMedia);
            this.Controls.Add(this.LblMedia);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.LblNota4);
            this.Controls.Add(this.LblNota3);
            this.Controls.Add(this.LblNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.LblNota1);
            this.Name = "Form1";
            this.Text = "Calculo de Media";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNota1;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label LblNota2;
        private System.Windows.Forms.Label LblNota3;
        private System.Windows.Forms.Label LblNota4;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Label LblMedia;
        private System.Windows.Forms.Label LblResultadoMedia;
        private System.Windows.Forms.Label LblSituacao;
        private System.Windows.Forms.Button btnCalcular;
    }
}

