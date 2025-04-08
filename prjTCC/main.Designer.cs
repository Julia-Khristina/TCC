namespace prjTCC
{
    partial class main
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
            this.reroll = new System.Windows.Forms.Button();
            this.verify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reroll
            // 
            this.reroll.Location = new System.Drawing.Point(268, 232);
            this.reroll.Name = "reroll";
            this.reroll.Size = new System.Drawing.Size(283, 163);
            this.reroll.TabIndex = 0;
            this.reroll.Text = "Cadastrar";
            this.reroll.UseVisualStyleBackColor = true;
            this.reroll.Click += new System.EventHandler(this.reroll_Click);
            // 
            // verify
            // 
            this.verify.Location = new System.Drawing.Point(268, 12);
            this.verify.Name = "verify";
            this.verify.Size = new System.Drawing.Size(283, 163);
            this.verify.TabIndex = 1;
            this.verify.Text = "Verificar";
            this.verify.UseVisualStyleBackColor = true;
            this.verify.Click += new System.EventHandler(this.verify_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.verify);
            this.Controls.Add(this.reroll);
            this.Name = "main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reroll;
        private System.Windows.Forms.Button verify;
    }
}

