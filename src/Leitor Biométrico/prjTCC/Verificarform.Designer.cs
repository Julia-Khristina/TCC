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
            this.grpAluno.Location = new System.Drawing.Point(11, 30);
            this.grpAluno.Name = "grpAluno";
            this.grpAluno.Size = new System.Drawing.Size(257, 87);
            this.grpAluno.TabIndex = 0;
            this.grpAluno.TabStop = false;
            this.grpAluno.Text = "Informações do Aluno";
            // 
            // lblNomeValor
            // 
            this.lblNomeValor.AutoSize = true;
            this.lblNomeValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNomeValor.Location = new System.Drawing.Point(60, 30);
            this.lblNomeValor.Name = "lblNomeValor";
            this.lblNomeValor.Size = new System.Drawing.Size(23, 17);
            this.lblNomeValor.TabIndex = 1;
            this.lblNomeValor.Text = "---";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // pbDedo
            // 
            this.pbDedo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDedo.Location = new System.Drawing.Point(283, 30);
            this.pbDedo.Name = "pbDedo";
            this.pbDedo.Size = new System.Drawing.Size(109, 161);
            this.pbDedo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDedo.TabIndex = 1;
            this.pbDedo.TabStop = false;
            this.pbDedo.Click += new System.EventHandler(this.pbDedo_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(14, 134);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(126, 30);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar Verificação";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(148, 134);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(120, 30);
            this.btnParar.TabIndex = 3;
            this.btnParar.Text = "Parar Verificação";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Blue;
            this.lblStatus.Location = new System.Drawing.Point(11, 178);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(104, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Aguardando digital...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Verificarform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.pbDedo);
            this.Controls.Add(this.grpAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Verificarform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificação de Aluno";
            this.Load += new System.EventHandler(this.Verificarform_Load);
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
