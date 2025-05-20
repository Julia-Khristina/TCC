namespace prjTCC
{
    partial class Verificarform
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

        private void InitializeComponent()
        {
            this.grpAluno = new System.Windows.Forms.GroupBox();
            this.lblNomeValor = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pbDedo = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDedo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAluno
            // 
            this.grpAluno.Controls.Add(this.lblNomeValor);
            this.grpAluno.Controls.Add(this.lblNome);
            this.grpAluno.Location = new System.Drawing.Point(16, 46);
            this.grpAluno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAluno.Name = "grpAluno";
            this.grpAluno.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAluno.Size = new System.Drawing.Size(386, 134);
            this.grpAluno.TabIndex = 0;
            this.grpAluno.TabStop = false;
            this.grpAluno.Text = "Informações do Aluno";
            // 
            // lblNomeValor
            // 
            this.lblNomeValor.AutoSize = true;
            this.lblNomeValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNomeValor.Location = new System.Drawing.Point(90, 46);
            this.lblNomeValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeValor.Name = "lblNomeValor";
            this.lblNomeValor.Size = new System.Drawing.Size(36, 28);
            this.lblNomeValor.TabIndex = 1;
            this.lblNomeValor.Text = "---";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 46);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // pbDedo
            // 
            this.pbDedo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDedo.Location = new System.Drawing.Point(424, 46);
            this.pbDedo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbDedo.Name = "pbDedo";
            this.pbDedo.Size = new System.Drawing.Size(162, 247);
            this.pbDedo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDedo.TabIndex = 1;
            this.pbDedo.TabStop = false;
            this.pbDedo.Click += new System.EventHandler(this.pbDedo_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(21, 206);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(189, 46);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar Verificação";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(222, 206);
            this.btnParar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(180, 46);
            this.btnParar.TabIndex = 3;
            this.btnParar.Text = "Parar Verificação";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Blue;
            this.lblStatus.Location = new System.Drawing.Point(16, 274);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(154, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Aguardando digital...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, -2);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Verificarform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.pbDedo);
            this.Controls.Add(this.grpAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Verificarform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificação de Aluno";
            this.grpAluno.ResumeLayout(false);
            this.grpAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDedo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.GroupBox grpAluno;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNomeValor;
        private System.Windows.Forms.PictureBox pbDedo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button button1;
    }
}
