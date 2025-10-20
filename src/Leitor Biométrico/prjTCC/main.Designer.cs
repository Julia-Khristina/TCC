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
            this.verify = new System.Windows.Forms.Button();
            this.btnBarra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.image_sair = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // verify
            // 
            this.verify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.verify.Location = new System.Drawing.Point(414, 260);
            this.verify.Name = "verify";
            this.verify.Size = new System.Drawing.Size(135, 49);
            this.verify.TabIndex = 1;
            this.verify.Text = "Verificar";
            this.verify.UseVisualStyleBackColor = true;
            this.verify.Click += new System.EventHandler(this.verify_Click);
            // 
            // btnBarra
            // 
            this.btnBarra.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBarra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarra.Location = new System.Drawing.Point(-446, -19);
            this.btnBarra.Name = "btnBarra";
            this.btnBarra.Size = new System.Drawing.Size(734, 481);
            this.btnBarra.TabIndex = 2;
            this.btnBarra.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(309, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seja bem vindo(a) ao Pontualize!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(341, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Este painel permite confirmar a identidade\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(322, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "e registrar o horário de entrada dos estudantes.";
            // 
            // image_sair
            // 
            this.image_sair.Image = global::prjTCC.Properties.Resources.cancelar1;
            this.image_sair.Location = new System.Drawing.Point(656, 12);
            this.image_sair.Name = "image_sair";
            this.image_sair.Size = new System.Drawing.Size(29, 28);
            this.image_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_sair.TabIndex = 7;
            this.image_sair.TabStop = false;
            this.image_sair.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjTCC.Properties.Resources.Login_Etec1;
            this.pictureBox1.Location = new System.Drawing.Point(-78, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(699, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.image_sair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBarra);
            this.Controls.Add(this.verify);
            this.ForeColor = System.Drawing.Color.GhostWhite;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button verify;
        private System.Windows.Forms.Button btnBarra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox image_sair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

