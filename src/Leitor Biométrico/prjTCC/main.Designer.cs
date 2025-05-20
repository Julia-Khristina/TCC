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
            this.reroll.Location = new System.Drawing.Point(18, 68);
            this.reroll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reroll.Name = "reroll";
            this.reroll.Size = new System.Drawing.Size(178, 117);
            this.reroll.TabIndex = 0;
            this.reroll.Text = "Cadastrar";
            this.reroll.UseVisualStyleBackColor = true;
            this.reroll.Click += new System.EventHandler(this.reroll_Click);
            // 
            // verify
            // 
            this.verify.Location = new System.Drawing.Point(206, 68);
            this.verify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verify.Name = "verify";
            this.verify.Size = new System.Drawing.Size(178, 117);
            this.verify.TabIndex = 1;
            this.verify.Text = "Verificar";
            this.verify.UseVisualStyleBackColor = true;
            this.verify.Click += new System.EventHandler(this.verify_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 269);
            this.Controls.Add(this.verify);
            this.Controls.Add(this.reroll);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reroll;
        private System.Windows.Forms.Button verify;
    }
}

