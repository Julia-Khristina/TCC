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
            pnMenu.BackColor = Color.FromArgb(98, 114, 255);
            pnMenu.Controls.Add(panel2);
            pnMenu.Controls.Add(panel1);
            pnMenu.Controls.Add(Painel_Perfil);
            pnMenu.Location = new Point(0, -1);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(158, 579);
            pnMenu.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(Btn_Voltar);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 435);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 144);
            panel2.TabIndex = 9;
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.BackColor = Color.White;
            Btn_Voltar.FlatStyle = FlatStyle.Flat;
            Btn_Voltar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Voltar.ForeColor = Color.FromArgb(98, 114, 255);
            Btn_Voltar.Location = new Point(31, 96);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(95, 33);
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
            panel3.Location = new Point(13, 21);
            panel3.Name = "panel3";
            panel3.Size = new Size(130, 56);
            panel3.TabIndex = 2;
            // 
            // LblFuncao
            // 
            LblFuncao.AutoSize = true;
            LblFuncao.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblFuncao.ForeColor = Color.FromArgb(224, 224, 224);
            LblFuncao.Location = new Point(62, 29);
            LblFuncao.Name = "LblFuncao";
            LblFuncao.Size = new Size(49, 17);
            LblFuncao.TabIndex = 3;
            LblFuncao.Text = "Função";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = SystemColors.ButtonHighlight;
            lblNome.Location = new Point(59, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 48);
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
            panel1.Location = new Point(3, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 91);
            panel1.TabIndex = 8;
            // 
            // lblTurma
            // 
            lblTurma.AutoSize = true;
            lblTurma.BackColor = Color.FromArgb(98, 114, 255);
            lblTurma.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTurma.ForeColor = SystemColors.ButtonHighlight;
            lblTurma.Location = new Point(41, 61);
            lblTurma.Name = "lblTurma";
            lblTurma.Size = new Size(51, 20);
            lblTurma.TabIndex = 7;
            lblTurma.Text = "Turma";
            // 
            // Turmas_Direcionamento
            // 
            Turmas_Direcionamento.AllowDrop = true;
            Turmas_Direcionamento.BackColor = Color.FromArgb(98, 114, 255);
            Turmas_Direcionamento.Dock = DockStyle.Top;
            Turmas_Direcionamento.DrawMode = DrawMode.OwnerDrawFixed;
            Turmas_Direcionamento.DropDownStyle = ComboBoxStyle.DropDownList;
            Turmas_Direcionamento.FlatStyle = FlatStyle.Flat;
            Turmas_Direcionamento.ForeColor = SystemColors.ButtonHighlight;
            Turmas_Direcionamento.FormattingEnabled = true;
            Turmas_Direcionamento.Location = new Point(0, 58);
            Turmas_Direcionamento.Margin = new Padding(0);
            Turmas_Direcionamento.MaxDropDownItems = 3;
            Turmas_Direcionamento.Name = "Turmas_Direcionamento";
            Turmas_Direcionamento.Size = new Size(158, 28);
            Turmas_Direcionamento.TabIndex = 9;
            // 
            // Notificacao_Direcionamento
            // 
            Notificacao_Direcionamento.BackColor = Color.FromArgb(98, 114, 255);
            Notificacao_Direcionamento.Dock = DockStyle.Top;
            Notificacao_Direcionamento.FlatAppearance.BorderSize = 0;
            Notificacao_Direcionamento.FlatStyle = FlatStyle.Flat;
            Notificacao_Direcionamento.ForeColor = SystemColors.ButtonHighlight;
            Notificacao_Direcionamento.Location = new Point(0, 29);
            Notificacao_Direcionamento.Name = "Notificacao_Direcionamento";
            Notificacao_Direcionamento.Size = new Size(158, 29);
            Notificacao_Direcionamento.TabIndex = 9;
            Notificacao_Direcionamento.Text = "Notificação";
            Notificacao_Direcionamento.UseVisualStyleBackColor = false;
            Notificacao_Direcionamento.Click += Notificacao_Direcionamento_Click;
            // 
            // BTN_Relatorio_Direcionamento
            // 
            BTN_Relatorio_Direcionamento.BackColor = Color.FromArgb(98, 114, 255);
            BTN_Relatorio_Direcionamento.Dock = DockStyle.Top;
            BTN_Relatorio_Direcionamento.FlatAppearance.BorderSize = 0;
            BTN_Relatorio_Direcionamento.FlatStyle = FlatStyle.Flat;
            BTN_Relatorio_Direcionamento.ForeColor = SystemColors.ButtonHighlight;
            BTN_Relatorio_Direcionamento.Location = new Point(0, 0);
            BTN_Relatorio_Direcionamento.Name = "BTN_Relatorio_Direcionamento";
            BTN_Relatorio_Direcionamento.Size = new Size(158, 29);
            BTN_Relatorio_Direcionamento.TabIndex = 8;
            BTN_Relatorio_Direcionamento.Text = "Relátorio";
            BTN_Relatorio_Direcionamento.UseVisualStyleBackColor = false;
            BTN_Relatorio_Direcionamento.Click += BTN_Relatorio_Direcionamento_Click;
            // 
            // Painel_Perfil
            // 
            Painel_Perfil.Controls.Add(pictureBox1);
            Painel_Perfil.Location = new Point(0, 0);
            Painel_Perfil.Name = "Painel_Perfil";
            Painel_Perfil.Size = new Size(158, 77);
            Painel_Perfil.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, -35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(98, 114, 255);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(823, 525);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(101, 37);
            btnSair.TabIndex = 14;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // btnAddAuxiliar
            // 
            btnAddAuxiliar.BackColor = Color.FromArgb(98, 114, 255);
            btnAddAuxiliar.FlatStyle = FlatStyle.Flat;
            btnAddAuxiliar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddAuxiliar.ForeColor = Color.White;
            btnAddAuxiliar.Location = new Point(311, 367);
            btnAddAuxiliar.Name = "btnAddAuxiliar";
            btnAddAuxiliar.Size = new Size(153, 37);
            btnAddAuxiliar.TabIndex = 15;
            btnAddAuxiliar.Text = "Adicionar Auxiliar";
            btnAddAuxiliar.UseVisualStyleBackColor = false;
            // 
            // btnAddAluno
            // 
            btnAddAluno.BackColor = Color.FromArgb(98, 114, 255);
            btnAddAluno.FlatStyle = FlatStyle.Flat;
            btnAddAluno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddAluno.ForeColor = Color.White;
            btnAddAluno.Location = new Point(657, 367);
            btnAddAluno.Name = "btnAddAluno";
            btnAddAluno.Size = new Size(143, 37);
            btnAddAluno.TabIndex = 16;
            btnAddAluno.Text = "Cadastrar Aluno";
            btnAddAluno.UseVisualStyleBackColor = false;
            btnAddAluno.Click += btnAddAluno_Click;
            // 
            // lblnm
            // 
            lblnm.AutoSize = true;
            lblnm.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnm.Location = new Point(511, 205);
            lblnm.Name = "lblnm";
            lblnm.Size = new Size(90, 37);
            lblnm.TabIndex = 17;
            lblnm.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(480, 248);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 18;
            label1.Text = "Função exercida";
            // 
            // FrmPerfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 577);
            Controls.Add(label1);
            Controls.Add(lblnm);
            Controls.Add(btnAddAluno);
            Controls.Add(btnAddAuxiliar);
            Controls.Add(btnSair);
            Controls.Add(pnMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "FrmPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRelatorio";
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