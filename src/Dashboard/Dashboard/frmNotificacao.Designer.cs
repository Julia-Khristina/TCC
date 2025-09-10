namespace Dashboard
{
    partial class frmNotificacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotificacao));
            panel2 = new Panel();
            Btn_Voltar = new Button();
            panel3 = new Panel();
            LblFuncao = new Label();
            lblNome = new Label();
            imgPerfil = new PictureBox();
            pnMenu = new Panel();
            panel1 = new Panel();
            lblTurma = new Label();
            Turmas_Direcionamento = new ComboBox();
            Notificacao_Direcionamento = new Button();
            BTN_Relatorio_Direcionamento = new Button();
            Painel_Perfil = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Painel_Grafico = new Panel();
            pictureBox3 = new PictureBox();
            lblDescricao_Notificacao = new Label();
            lblTitulo_Notificacao = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgPerfil).BeginInit();
            pnMenu.SuspendLayout();
            panel1.SuspendLayout();
            Painel_Perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Painel_Grafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(Btn_Voltar);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 542);
            panel2.Margin = new Padding(4, 2, 4, 2);
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
            Btn_Voltar.Location = new Point(39, 122);
            Btn_Voltar.Margin = new Padding(4, 4, 4, 4);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(118, 41);
            Btn_Voltar.TabIndex = 3;
            Btn_Voltar.Text = "Voltar";
            Btn_Voltar.TextAlign = ContentAlignment.TopCenter;
            Btn_Voltar.UseVisualStyleBackColor = false;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(LblFuncao);
            panel3.Controls.Add(lblNome);
            panel3.Controls.Add(imgPerfil);
            panel3.Location = new Point(16, 28);
            panel3.Margin = new Padding(4, 2, 4, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(162, 70);
            panel3.TabIndex = 2;
            // 
            // LblFuncao
            // 
            LblFuncao.AutoSize = true;
            LblFuncao.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblFuncao.ForeColor = Color.FromArgb(224, 224, 224);
            LblFuncao.Location = new Point(78, 38);
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
            lblNome.Location = new Point(74, 12);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 25);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            lblNome.Click += lblNome_Click;
            // 
            // imgPerfil
            // 
            imgPerfil.Image = (Image)resources.GetObject("imgPerfil.Image");
            imgPerfil.Location = new Point(4, 2);
            imgPerfil.Margin = new Padding(4, 2, 4, 2);
            imgPerfil.Name = "imgPerfil";
            imgPerfil.Size = new Size(64, 60);
            imgPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPerfil.TabIndex = 1;
            imgPerfil.TabStop = false;
            imgPerfil.Click += pictureBox2_Click;
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.MidnightBlue;
            pnMenu.Controls.Add(panel2);
            pnMenu.Controls.Add(panel1);
            pnMenu.Controls.Add(Painel_Perfil);
            pnMenu.Location = new Point(0, -1);
            pnMenu.Margin = new Padding(4, 2, 4, 2);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(198, 722);
            pnMenu.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTurma);
            panel1.Controls.Add(Turmas_Direcionamento);
            panel1.Controls.Add(Notificacao_Direcionamento);
            panel1.Controls.Add(BTN_Relatorio_Direcionamento);
            panel1.Location = new Point(4, 98);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 112);
            panel1.TabIndex = 8;
            // 
            // lblTurma
            // 
            lblTurma.AutoSize = true;
            lblTurma.BackColor = Color.MidnightBlue;
            lblTurma.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTurma.ForeColor = SystemColors.ButtonHighlight;
            lblTurma.Location = new Point(51, 78);
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
            Turmas_Direcionamento.Location = new Point(0, 76);
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
            Notificacao_Direcionamento.Location = new Point(0, 38);
            Notificacao_Direcionamento.Margin = new Padding(4, 2, 4, 2);
            Notificacao_Direcionamento.Name = "Notificacao_Direcionamento";
            Notificacao_Direcionamento.Size = new Size(198, 38);
            Notificacao_Direcionamento.TabIndex = 9;
            Notificacao_Direcionamento.Text = "Notificação";
            Notificacao_Direcionamento.UseVisualStyleBackColor = false;
            // 
            // BTN_Relatorio_Direcionamento
            // 
            BTN_Relatorio_Direcionamento.BackColor = Color.MidnightBlue;
            BTN_Relatorio_Direcionamento.Dock = DockStyle.Top;
            BTN_Relatorio_Direcionamento.FlatAppearance.BorderSize = 0;
            BTN_Relatorio_Direcionamento.FlatStyle = FlatStyle.Flat;
            BTN_Relatorio_Direcionamento.ForeColor = SystemColors.ButtonHighlight;
            BTN_Relatorio_Direcionamento.Location = new Point(0, 0);
            BTN_Relatorio_Direcionamento.Margin = new Padding(4, 2, 4, 2);
            BTN_Relatorio_Direcionamento.Name = "BTN_Relatorio_Direcionamento";
            BTN_Relatorio_Direcionamento.Size = new Size(198, 38);
            BTN_Relatorio_Direcionamento.TabIndex = 8;
            BTN_Relatorio_Direcionamento.Text = "Relátorio";
            BTN_Relatorio_Direcionamento.UseVisualStyleBackColor = false;
            BTN_Relatorio_Direcionamento.Click += BTN_Relatorio_Direcionamento_Click;
            // 
            // Painel_Perfil
            // 
            Painel_Perfil.Controls.Add(pictureBox1);
            Painel_Perfil.Location = new Point(0, 0);
            Painel_Perfil.Margin = new Padding(4, 2, 4, 2);
            Painel_Perfil.Name = "Painel_Perfil";
            Painel_Perfil.Size = new Size(198, 98);
            Painel_Perfil.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, -42);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 32);
            label1.TabIndex = 2;
            label1.Text = "Notificação";
            // 
            // Painel_Grafico
            // 
            Painel_Grafico.BackColor = SystemColors.ButtonHighlight;
            Painel_Grafico.Controls.Add(pictureBox3);
            Painel_Grafico.Controls.Add(lblDescricao_Notificacao);
            Painel_Grafico.Controls.Add(lblTitulo_Notificacao);
            Painel_Grafico.Location = new Point(231, 98);
            Painel_Grafico.Margin = new Padding(4, 2, 4, 2);
            Painel_Grafico.Name = "Painel_Grafico";
            Painel_Grafico.Size = new Size(902, 90);
            Painel_Grafico.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(844, 21);
            pictureBox3.Margin = new Padding(4, 2, 4, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // lblDescricao_Notificacao
            // 
            lblDescricao_Notificacao.AutoSize = true;
            lblDescricao_Notificacao.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao_Notificacao.Location = new Point(42, 36);
            lblDescricao_Notificacao.Margin = new Padding(4, 0, 4, 0);
            lblDescricao_Notificacao.Name = "lblDescricao_Notificacao";
            lblDescricao_Notificacao.Size = new Size(613, 25);
            lblDescricao_Notificacao.TabIndex = 4;
            lblDescricao_Notificacao.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
            // 
            // lblTitulo_Notificacao
            // 
            lblTitulo_Notificacao.AutoSize = true;
            lblTitulo_Notificacao.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo_Notificacao.Location = new Point(22, 10);
            lblTitulo_Notificacao.Margin = new Padding(4, 0, 4, 0);
            lblTitulo_Notificacao.Name = "lblTitulo_Notificacao";
            lblTitulo_Notificacao.Size = new Size(211, 30);
            lblTitulo_Notificacao.TabIndex = 3;
            lblTitulo_Notificacao.Text = "Título da Notificação";
            // 
            // frmNotificacao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 722);
            Controls.Add(Painel_Grafico);
            Controls.Add(label1);
            Controls.Add(pnMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "frmNotificacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNotificacao";
            Load += frmNotificacao_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgPerfil).EndInit();
            pnMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Painel_Perfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Painel_Grafico.ResumeLayout(false);
            Painel_Grafico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Label LblFuncao;
        private Label lblNome;
        private PictureBox imgPerfil;
        private Panel pnMenu;
        private Panel panel1;
        private Label lblTurma;
        private ComboBox Turmas_Direcionamento;
        private Button Notificacao_Direcionamento;
        private Button BTN_Relatorio_Direcionamento;
        private Panel Painel_Perfil;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel Painel_Grafico;
        private Label lblTitulo_Notificacao;
        private Label lblDescricao_Notificacao;
        private PictureBox pictureBox3;
        private Button Btn_Voltar;
    }
}