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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verificarform));
            this.grpAluno = new System.Windows.Forms.GroupBox();
            this.lblSituacaoValor = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblAtrasoValor = new System.Windows.Forms.Label();
            this.lblAtrasos = new System.Windows.Forms.Label();
            this.lblCursoValor = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblTurmaValor = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            this.lblNomeValor = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pbDedo = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDedo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAluno
            // 
            this.grpAluno.Controls.Add(this.lblSituacaoValor);
            this.grpAluno.Controls.Add(this.pbDedo);
            this.grpAluno.Controls.Add(this.lblSituacao);
            this.grpAluno.Controls.Add(this.lblAtrasoValor);
            this.grpAluno.Controls.Add(this.lblAtrasos);
            this.grpAluno.Controls.Add(this.lblCursoValor);
            this.grpAluno.Controls.Add(this.lblCurso);
            this.grpAluno.Controls.Add(this.lblTurmaValor);
            this.grpAluno.Controls.Add(this.lblTurma);
            this.grpAluno.Controls.Add(this.lblNomeValor);
            this.grpAluno.Controls.Add(this.lblNome);
            this.grpAluno.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAluno.Location = new System.Drawing.Point(184, 67);
            this.grpAluno.Name = "grpAluno";
            this.grpAluno.Size = new System.Drawing.Size(325, 209);
            this.grpAluno.TabIndex = 0;
            this.grpAluno.TabStop = false;
            this.grpAluno.Text = "Informações do Aluno";
            // 
            // lblSituacaoValor
            // 
            this.lblSituacaoValor.AutoSize = true;
            this.lblSituacaoValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSituacaoValor.Location = new System.Drawing.Point(68, 184);
            this.lblSituacaoValor.Name = "lblSituacaoValor";
            this.lblSituacaoValor.Size = new System.Drawing.Size(23, 17);
            this.lblSituacaoValor.TabIndex = 11;
            this.lblSituacaoValor.Text = "---";
            this.lblSituacaoValor.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(6, 182);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(62, 24);
            this.lblSituacao.TabIndex = 10;
            this.lblSituacao.Text = "Situação";
            this.lblSituacao.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAtrasoValor
            // 
            this.lblAtrasoValor.AutoSize = true;
            this.lblAtrasoValor.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtrasoValor.Location = new System.Drawing.Point(66, 106);
            this.lblAtrasoValor.Name = "lblAtrasoValor";
            this.lblAtrasoValor.Size = new System.Drawing.Size(25, 23);
            this.lblAtrasoValor.TabIndex = 7;
            this.lblAtrasoValor.Text = "---";
            // 
            // lblAtrasos
            // 
            this.lblAtrasos.AutoSize = true;
            this.lblAtrasos.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtrasos.Location = new System.Drawing.Point(13, 106);
            this.lblAtrasos.Name = "lblAtrasos";
            this.lblAtrasos.Size = new System.Drawing.Size(57, 23);
            this.lblAtrasos.TabIndex = 6;
            this.lblAtrasos.Text = "Atrasos:";
            // 
            // lblCursoValor
            // 
            this.lblCursoValor.AutoSize = true;
            this.lblCursoValor.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursoValor.Location = new System.Drawing.Point(60, 79);
            this.lblCursoValor.Name = "lblCursoValor";
            this.lblCursoValor.Size = new System.Drawing.Size(25, 23);
            this.lblCursoValor.TabIndex = 5;
            this.lblCursoValor.Text = "---";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(13, 79);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(47, 23);
            this.lblCurso.TabIndex = 4;
            this.lblCurso.Text = "Curso:";
            // 
            // lblTurmaValor
            // 
            this.lblTurmaValor.AutoSize = true;
            this.lblTurmaValor.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurmaValor.Location = new System.Drawing.Point(60, 55);
            this.lblTurmaValor.Name = "lblTurmaValor";
            this.lblTurmaValor.Size = new System.Drawing.Size(25, 23);
            this.lblTurmaValor.TabIndex = 3;
            this.lblTurmaValor.Text = "---";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurma.Location = new System.Drawing.Point(13, 55);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(50, 23);
            this.lblTurma.TabIndex = 2;
            this.lblTurma.Text = "Turma:";
            // 
            // lblNomeValor
            // 
            this.lblNomeValor.AutoSize = true;
            this.lblNomeValor.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeValor.Location = new System.Drawing.Point(60, 30);
            this.lblNomeValor.Name = "lblNomeValor";
            this.lblNomeValor.Size = new System.Drawing.Size(25, 23);
            this.lblNomeValor.TabIndex = 1;
            this.lblNomeValor.Text = "---";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(13, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 23);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // pbDedo
            // 
            this.pbDedo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDedo.Location = new System.Drawing.Point(199, 19);
            this.pbDedo.Name = "pbDedo";
            this.pbDedo.Size = new System.Drawing.Size(109, 161);
            this.pbDedo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDedo.TabIndex = 1;
            this.pbDedo.TabStop = false;
            this.pbDedo.Click += new System.EventHandler(this.pbDedo_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.LightGreen;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(366, 305);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(126, 30);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar Verificação";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.LightCoral;
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.Location = new System.Drawing.Point(200, 305);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(126, 30);
            this.btnParar.TabIndex = 3;
            this.btnParar.Text = "Parar Verificação";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(503, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 389);
            this.panel1.TabIndex = 12;
            // 
            // Verificarform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Verificarform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificação de Aluno";
            this.Load += new System.EventHandler(this.Verificarform_Load);
            this.grpAluno.ResumeLayout(false);
            this.grpAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDedo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.GroupBox grpAluno;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNomeValor;
        private System.Windows.Forms.PictureBox pbDedo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAtrasoValor;
        private System.Windows.Forms.Label lblAtrasos;
        private System.Windows.Forms.Label lblCursoValor;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblTurmaValor;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Label lblSituacaoValor;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
