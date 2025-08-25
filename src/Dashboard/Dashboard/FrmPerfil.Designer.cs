namespace Dashboard
{
    partial class FrmPerfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfil));
            pnMenu = new Panel();
            panel2 = new Panel();
            Btn_Voltar = new Button();
            panel3 = new Panel();
            LblFuncao = new Label();
            lblNome = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            lblTurma = new Label();
            Turmas_Direcionamento = new ComboBox();
            Notificacao_Direcionamento = new Button();
            BTN_Relatorio_Direcionamento = new Button();
            Painel_Perfil = new Panel();
            pictureBox1 = new PictureBox();
            btnSair = new Button();
            btnAddAuxiliar = new Button();
            btnAddAluno = new Button();
            lblnm = new Label();
            label1 = new Label();
            pnMenu.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            Painel_Perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.MidnightBlue;
            pnMenu.Controls.Add(panel2);
            pnMenu.Controls.Add(panel1);
            pnMenu.Controls.Add(Painel_Perfil);
            pnMenu.Location = new Point(0, -1);
            pnMenu.Margin = new Padding(4, 4, 4, 4);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(198, 724);
            pnMenu.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(Btn_Voltar);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 544);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 180);
            panel2.TabIndex = 9;
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.BackColor = Color.White;
            Btn_Voltar.FlatStyle = FlatStyle.Flat;
            Btn_Voltar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Voltar.ForeColor = Color.MidnightBlue;
            Btn_Voltar.Location = new Point(39, 120);
            Btn_Voltar.Margin = new Padding(4, 4, 4, 4);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(119, 41);
            Btn_Voltar.TabIndex = 4;
            Btn_Voltar.Text = "Voltar";
            Btn_Voltar.TextAlign = ContentAlignment.TopCenter;
            Btn_Voltar.UseVisualStyleBackColor = false;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(LblFuncao);
            panel3.Controls.Add(lblNome);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(16, 26);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(162, 70);
            panel3.TabIndex = 2;
            // 
            // LblFuncao
            // 
            LblFuncao.AutoSize = true;
            LblFuncao.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblFuncao.ForeColor = Color.FromArgb(224, 224, 224);
            LblFuncao.Location = new Point(78, 36);
            LblFuncao.Margin = new Padding(4, 0, 4, 0);
            LblFuncao.Name = "LblFuncao";
            LblFuncao.Size = new Size(56, 20);
            LblFuncao.TabIndex = 3;
            LblFuncao.Text = "Função";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = SystemColors.ButtonHighlight;
            lblNome.Location = new Point(74, 11);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 25);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 4);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTurma);
            panel1.Controls.Add(Turmas_Direcionamento);
            panel1.Controls.Add(Notificacao_Direcionamento);
            panel1.Controls.Add(BTN_Relatorio_Direcionamento);
            panel1.Location = new Point(4, 99);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 114);
            panel1.TabIndex = 8;
            // 
            // lblTurma
            // 
            lblTurma.AutoSize = true;
            lblTurma.BackColor = Color.MidnightBlue;
            lblTurma.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTurma.ForeColor = SystemColors.ButtonHighlight;
            lblTurma.Location = new Point(51, 76);
            lblTurma.Margin = new Padding(4, 0, 4, 0);
            lblTurma.Name = "lblTurma";
            lblTurma.Size = new Size(62, 25);
            lblTurma.TabIndex = 7;
            lblTurma.Text = "Turma";
            // 
            // Turmas_Direcionamento
            // 
            Turmas_Direcionamento.AllowDrop = true;
            Turmas_Direcionamento.BackColor = Color.MidnightBlue;
            Turmas_Direcionamento.Dock = DockStyle.Top;
            Turmas_Direcionamento.DropDownStyle = ComboBoxStyle.DropDownList;
            Turmas_Direcionamento.FlatStyle = FlatStyle.Flat;
            Turmas_Direcionamento.ForeColor = SystemColors.ButtonHighlight;
            Turmas_Direcionamento.FormattingEnabled = true;
            Turmas_Direcionamento.Location = new Point(0, 72);
            Turmas_Direcionamento.Margin = new Padding(0);
            Turmas_Direcionamento.MaxDropDownItems = 3;
            Turmas_Direcionamento.Name = "Turmas_Direcionamento";
            Turmas_Direcionamento.Size = new Size(198, 33);
            Turmas_Direcionamento.TabIndex = 9;
            // 
            // Notificacao_Direcionamento
            // 
            Notificacao_Direcionamento.BackColor = Color.MidnightBlue;
            Notificacao_Direcionamento.Dock = DockStyle.Top;
            Notificacao_Direcionamento.FlatAppearance.BorderSize = 0;
            Notificacao_Direcionamento.FlatStyle = FlatStyle.Flat;
            Notificacao_Direcionamento.ForeColor = SystemColors.ButtonHighlight;
            Notificacao_Direcionamento.Location = new Point(0, 36);
            Notificacao_Direcionamento.Margin = new Padding(4, 4, 4, 4);
            Notificacao_Direcionamento.Name = "Notificacao_Direcionamento";
            Notificacao_Direcionamento.Size = new Size(198, 36);
            Notificacao_Direcionamento.TabIndex = 9;
            Notificacao_Direcionamento.Text = "Notificação";
            Notificacao_Direcionamento.UseVisualStyleBackColor = false;
            Notificacao_Direcionamento.Click += Notificacao_Direcionamento_Click;
            // 
            // BTN_Relatorio_Direcionamento
            // 
            BTN_Relatorio_Direcionamento.BackColor = Color.MidnightBlue;
            BTN_Relatorio_Direcionamento.Dock = DockStyle.Top;
            BTN_Relatorio_Direcionamento.FlatAppearance.BorderSize = 0;
            BTN_Relatorio_Direcionamento.FlatStyle = FlatStyle.Flat;
            BTN_Relatorio_Direcionamento.ForeColor = SystemColors.ButtonHighlight;
            BTN_Relatorio_Direcionamento.Location = new Point(0, 0);
            BTN_Relatorio_Direcionamento.Margin = new Padding(4, 4, 4, 4);
            BTN_Relatorio_Direcionamento.Name = "BTN_Relatorio_Direcionamento";
            BTN_Relatorio_Direcionamento.Size = new Size(198, 36);
            BTN_Relatorio_Direcionamento.TabIndex = 8;
            BTN_Relatorio_Direcionamento.Text = "Relátorio";
            BTN_Relatorio_Direcionamento.UseVisualStyleBackColor = false;
            BTN_Relatorio_Direcionamento.Click += BTN_Relatorio_Direcionamento_Click;
            // 
            // Painel_Perfil
            // 
            Painel_Perfil.Controls.Add(pictureBox1);
            Painel_Perfil.Location = new Point(0, 0);
            Painel_Perfil.Margin = new Padding(4, 4, 4, 4);
            Painel_Perfil.Name = "Painel_Perfil";
            Painel_Perfil.Size = new Size(198, 96);
            Painel_Perfil.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, -44);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.MidnightBlue;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(1029, 656);
            btnSair.Margin = new Padding(4, 4, 4, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(126, 46);
            btnSair.TabIndex = 14;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // btnAddAuxiliar
            // 
            btnAddAuxiliar.BackColor = Color.MidnightBlue;
            btnAddAuxiliar.FlatStyle = FlatStyle.Flat;
            btnAddAuxiliar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddAuxiliar.ForeColor = Color.White;
            btnAddAuxiliar.Location = new Point(389, 459);
            btnAddAuxiliar.Margin = new Padding(4, 4, 4, 4);
            btnAddAuxiliar.Name = "btnAddAuxiliar";
            btnAddAuxiliar.Size = new Size(191, 46);
            btnAddAuxiliar.TabIndex = 15;
            btnAddAuxiliar.Text = "Adicionar Auxiliar";
            btnAddAuxiliar.UseVisualStyleBackColor = false;
            // 
            // btnAddAluno
            // 
            btnAddAluno.BackColor = Color.MidnightBlue;
            btnAddAluno.FlatStyle = FlatStyle.Flat;
            btnAddAluno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddAluno.ForeColor = Color.White;
            btnAddAluno.Location = new Point(821, 459);
            btnAddAluno.Margin = new Padding(4, 4, 4, 4);
            btnAddAluno.Name = "btnAddAluno";
            btnAddAluno.Size = new Size(179, 46);
            btnAddAluno.TabIndex = 16;
            btnAddAluno.Text = "Cadastrar Aluno";
            btnAddAluno.UseVisualStyleBackColor = false;
            btnAddAluno.Click += btnAddAluno_Click;
            // 
            // lblnm
            // 
            lblnm.AutoSize = true;
            lblnm.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnm.Location = new Point(639, 256);
            lblnm.Margin = new Padding(4, 0, 4, 0);
            lblnm.Name = "lblnm";
            lblnm.Size = new Size(108, 45);
            lblnm.TabIndex = 17;
            lblnm.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(600, 310);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 18;
            label1.Text = "Função exercida";
            // 
            // FrmPerfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 721);
            Controls.Add(label1);
            Controls.Add(lblnm);
            Controls.Add(btnAddAluno);
            Controls.Add(btnAddAuxiliar);
            Controls.Add(btnSair);
            Controls.Add(pnMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 4, 2, 4);
            Name = "FrmPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRelatorio";
            Load += FrmPerfil_Load;
            pnMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Painel_Perfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnMenu;
        private Panel panel2;
        private Panel panel3;
        private Label LblFuncao;
        private Label lblNome;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label lblTurma;
        private ComboBox Turmas_Direcionamento;
        private Button Notificacao_Direcionamento;
        private Button BTN_Relatorio_Direcionamento;
        private Panel Painel_Perfil;
        private PictureBox pictureBox1;
        private Button Btn_Voltar;
        private Button btnSair;
        private Button btnAddAuxiliar;
        private Button btnAddAluno;
        private Label lblnm;
        private Label label1;
    }
}