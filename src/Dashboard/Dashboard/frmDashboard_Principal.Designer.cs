namespace Dashboard
{
    partial class frmDashboard_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard_Principal));
            pnMenu = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            LblFuncao = new Label();
            lblNome = new Label();
            pictureBox2 = new PictureBox();
            Btn_Sair = new Button();
            panel1 = new Panel();
            lblTurma = new Label();
            Turmas_Direcionamento = new ComboBox();
            Notificacao_Direcionamento = new Button();
            BTN_Relatorio_Direcionamento = new Button();
            Painel_Perfil = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Painel_Diário = new Panel();
            lblDiario = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            Painel_Semanal = new Panel();
            lblSemanal = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            Painel_Mensal = new Panel();
            lblMensal = new Label();
            pictureBox5 = new PictureBox();
            label7 = new Label();
            Painel_Grafico = new Panel();
            pnMenu.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            Painel_Perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Painel_Diário.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Painel_Semanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            Painel_Mensal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.MidnightBlue;
            pnMenu.Controls.Add(panel2);
            pnMenu.Controls.Add(panel1);
            pnMenu.Controls.Add(Painel_Perfil);
            pnMenu.Location = new Point(-1, -2);
            pnMenu.Margin = new Padding(4, 2, 4, 2);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(198, 722);
            pnMenu.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(Btn_Sair);
            panel2.Location = new Point(0, 542);
            panel2.Margin = new Padding(4, 2, 4, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 180);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(LblFuncao);
            panel3.Controls.Add(lblNome);
            panel3.Controls.Add(pictureBox2);
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 2);
            pictureBox2.Margin = new Padding(4, 2, 4, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Btn_Sair
            // 
            Btn_Sair.BackColor = Color.White;
            Btn_Sair.FlatStyle = FlatStyle.Flat;
            Btn_Sair.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Sair.ForeColor = Color.MidnightBlue;
            Btn_Sair.Location = new Point(36, 118);
            Btn_Sair.Margin = new Padding(4, 2, 4, 2);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(118, 42);
            Btn_Sair.TabIndex = 0;
            Btn_Sair.Text = "Sair";
            Btn_Sair.TextAlign = ContentAlignment.TopCenter;
            Btn_Sair.UseVisualStyleBackColor = false;
            Btn_Sair.Click += Btn_Sair_Click;
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
            Turmas_Direcionamento.DrawMode = DrawMode.OwnerDrawFixed;
            Turmas_Direcionamento.DropDownStyle = ComboBoxStyle.DropDownList;
            Turmas_Direcionamento.FlatStyle = FlatStyle.Flat;
            Turmas_Direcionamento.ForeColor = SystemColors.ButtonHighlight;
            Turmas_Direcionamento.FormattingEnabled = true;
            Turmas_Direcionamento.Location = new Point(0, 76);
            Turmas_Direcionamento.Margin = new Padding(0);
            Turmas_Direcionamento.MaxDropDownItems = 3;
            Turmas_Direcionamento.Name = "Turmas_Direcionamento";
            Turmas_Direcionamento.Size = new Size(198, 32);
            Turmas_Direcionamento.TabIndex = 9;
            Turmas_Direcionamento.SelectedIndexChanged += Turmas_Direcionamento_SelectedIndexChanged_1;
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
            BTN_Relatorio_Direcionamento.Margin = new Padding(4, 2, 4, 2);
            BTN_Relatorio_Direcionamento.Name = "BTN_Relatorio_Direcionamento";
            BTN_Relatorio_Direcionamento.Size = new Size(198, 38);
            BTN_Relatorio_Direcionamento.TabIndex = 8;
            BTN_Relatorio_Direcionamento.Text = "Relátorio";
            BTN_Relatorio_Direcionamento.UseVisualStyleBackColor = false;
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
            pictureBox1.Location = new Point(12, -41);
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
            label1.Location = new Point(232, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 32);
            label1.TabIndex = 1;
            label1.Text = "Relatório Geral";
            // 
            // Painel_Diário
            // 
            Painel_Diário.BackColor = Color.FromArgb(136, 170, 238);
            Painel_Diário.Controls.Add(lblDiario);
            Painel_Diário.Controls.Add(label2);
            Painel_Diário.Controls.Add(pictureBox3);
            Painel_Diário.Location = new Point(274, 98);
            Painel_Diário.Margin = new Padding(4, 2, 4, 2);
            Painel_Diário.Name = "Painel_Diário";
            Painel_Diário.Size = new Size(189, 118);
            Painel_Diário.TabIndex = 2;
            // 
            // lblDiario
            // 
            lblDiario.AutoSize = true;
            lblDiario.BackColor = Color.FromArgb(136, 170, 238);
            lblDiario.Enabled = false;
            lblDiario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiario.ForeColor = SystemColors.ActiveCaptionText;
            lblDiario.Location = new Point(28, 48);
            lblDiario.Margin = new Padding(4, 0, 4, 0);
            lblDiario.Name = "lblDiario";
            lblDiario.Size = new Size(49, 38);
            lblDiario.TabIndex = 11;
            lblDiario.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(136, 170, 238);
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(14, 12);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 10;
            label2.Text = "Diário";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(114, 30);
            pictureBox3.Margin = new Padding(4, 2, 4, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // Painel_Semanal
            // 
            Painel_Semanal.BackColor = Color.FromArgb(255, 232, 164);
            Painel_Semanal.Controls.Add(lblSemanal);
            Painel_Semanal.Controls.Add(pictureBox4);
            Painel_Semanal.Controls.Add(label5);
            Painel_Semanal.Location = new Point(594, 98);
            Painel_Semanal.Margin = new Padding(4, 2, 4, 2);
            Painel_Semanal.Name = "Painel_Semanal";
            Painel_Semanal.Size = new Size(189, 118);
            Painel_Semanal.TabIndex = 3;
            // 
            // lblSemanal
            // 
            lblSemanal.AutoSize = true;
            lblSemanal.BackColor = Color.FromArgb(255, 232, 164);
            lblSemanal.Enabled = false;
            lblSemanal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSemanal.ForeColor = SystemColors.ActiveCaptionText;
            lblSemanal.Location = new Point(26, 52);
            lblSemanal.Margin = new Padding(4, 0, 4, 0);
            lblSemanal.Name = "lblSemanal";
            lblSemanal.Size = new Size(49, 38);
            lblSemanal.TabIndex = 14;
            lblSemanal.Text = "00";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(109, 38);
            pictureBox4.Margin = new Padding(4, 2, 4, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 232, 164);
            label5.Enabled = false;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(11, 18);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 13;
            label5.Text = "Semanal";
            // 
            // Painel_Mensal
            // 
            Painel_Mensal.BackColor = Color.FromArgb(238, 136, 136);
            Painel_Mensal.Controls.Add(lblMensal);
            Painel_Mensal.Controls.Add(pictureBox5);
            Painel_Mensal.Controls.Add(label7);
            Painel_Mensal.Location = new Point(921, 95);
            Painel_Mensal.Margin = new Padding(4, 2, 4, 2);
            Painel_Mensal.Name = "Painel_Mensal";
            Painel_Mensal.Size = new Size(189, 118);
            Painel_Mensal.TabIndex = 3;
            // 
            // lblMensal
            // 
            lblMensal.AutoSize = true;
            lblMensal.BackColor = Color.FromArgb(238, 136, 136);
            lblMensal.Enabled = false;
            lblMensal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensal.ForeColor = SystemColors.ActiveCaptionText;
            lblMensal.Location = new Point(26, 52);
            lblMensal.Margin = new Padding(4, 0, 4, 0);
            lblMensal.Name = "lblMensal";
            lblMensal.Size = new Size(49, 38);
            lblMensal.TabIndex = 17;
            lblMensal.Text = "00";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(111, 38);
            pictureBox5.Margin = new Padding(4, 2, 4, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(64, 60);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(238, 136, 136);
            label7.Enabled = false;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(12, 18);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 25);
            label7.TabIndex = 16;
            label7.Text = "Mensal";
            // 
            // Painel_Grafico
            // 
            Painel_Grafico.BackColor = SystemColors.ButtonHighlight;
            Painel_Grafico.Location = new Point(232, 258);
            Painel_Grafico.Margin = new Padding(4, 2, 4, 2);
            Painel_Grafico.Name = "Painel_Grafico";
            Painel_Grafico.Size = new Size(902, 412);
            Painel_Grafico.TabIndex = 4;
            // 
            // frmDashboard_Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1189, 722);
            Controls.Add(Painel_Grafico);
            Controls.Add(Painel_Mensal);
            Controls.Add(Painel_Semanal);
            Controls.Add(Painel_Diário);
            Controls.Add(label1);
            Controls.Add(pnMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 2, 4, 2);
            Name = "frmDashboard_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmDashboard_Principal_Load;
            pnMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Painel_Perfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Painel_Diário.ResumeLayout(false);
            Painel_Diário.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            Painel_Semanal.ResumeLayout(false);
            Painel_Semanal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            Painel_Mensal.ResumeLayout(false);
            Painel_Mensal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnMenu;
        private PictureBox pictureBox1;
        private Label lblTurma;
        private Label label1;
        private Panel Painel_Perfil;
        private Panel panel1;
        private Button Notificacao_Direcionamento;
        private Button BTN_Relatorio_Direcionamento;
        private ComboBox Turmas_Direcionamento;
        private Panel panel2;
        private Button Btn_Sair;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label lblNome;
        private Label LblFuncao;
        private Panel Painel_Diário;
        private Panel Painel_Semanal;
        private Panel Painel_Mensal;
        private PictureBox pictureBox3;
        private Label label2;
        private Label lblDiario;
        private Label lblSemanal;
        private PictureBox pictureBox4;
        private Label label5;
        private Label lblMensal;
        private PictureBox pictureBox5;
        private Label label7;
        private Panel Painel_Grafico;
    }
}
