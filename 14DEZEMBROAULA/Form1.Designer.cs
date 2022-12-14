namespace _14DEZEMBROAULA
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
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.senha = new System.Windows.Forms.TextBox();
            this.label1Mensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botaoLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botaoLimpar.Location = new System.Drawing.Point(351, 62);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(75, 26);
            this.botaoLimpar.TabIndex = 0;
            this.botaoLimpar.Text = "limpar";
            this.botaoLimpar.UseVisualStyleBackColor = false;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(55, 62);
            this.senha.Multiline = true;
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(274, 23);
            this.senha.TabIndex = 1;
            this.senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VerificaCaracter);
            // 
            // label1Mensagem
            // 
            this.label1Mensagem.AutoSize = true;
            this.label1Mensagem.Location = new System.Drawing.Point(52, 140);
            this.label1Mensagem.Name = "label1Mensagem";
            this.label1Mensagem.Size = new System.Drawing.Size(35, 13);
            this.label1Mensagem.TabIndex = 2;
            this.label1Mensagem.Text = "label1";
            this.label1Mensagem.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 201);
            this.Controls.Add(this.label1Mensagem);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.botaoLimpar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Label label1Mensagem;
    }
}

