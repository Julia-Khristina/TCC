
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
            label3 = new Label();
            btnSolicitarAdvertencia = new Button();
            button1 = new Button();
            label6 = new Label();
            Painel_Perfil = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblTurma = new Label();
            Turmas_Direcionamento = new ComboBox();
            Notificacao_Direcionamento = new Button();
            BTN_Relatorio_Direcionamento = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            LblFuncao = new Label();
            lblNome = new Label();
            pictureBox2 = new PictureBox();
            Btn_Sair = new Button();
            pnMenu = new Panel();
            pnConteudo = new Panel();
            panelWelcome = new Panel();
            flowLayoutPanelReports = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            Painel_Diário.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Painel_Semanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            Painel_Mensal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            Painel_Perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnMenu.SuspendLayout();
            pnConteudo.SuspendLayout();
            panelWelcome.SuspendLayout();
            flowLayoutPanelReports.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 25);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 1;
            label1.Text = "Relatório Geral";
            label1.Click += label1_Click;
            // 
            // Painel_Diário
            // 
            Painel_Diário.BackColor = Color.FromArgb(136, 170, 238);
            Painel_Diário.Controls.Add(lblDiario);
            Painel_Diário.Controls.Add(label2);
            Painel_Diário.Controls.Add(pictureBox3);
            Painel_Diário.Location = new Point(3, 3);
            Painel_Diário.Margin = new Padding(8, 8, 30, 8);
            Painel_Diário.Name = "Painel_Diário";
            Painel_Diário.Size = new Size(132, 71);
            Painel_Diário.TabIndex = 2;
            // 
            // lblDiario
            // 
            lblDiario.AutoSize = true;
            lblDiario.BackColor = Color.FromArgb(136, 170, 238);
            lblDiario.Enabled = false;
            lblDiario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiario.ForeColor = SystemColors.ActiveCaptionText;
            lblDiario.Location = new Point(20, 29);
            lblDiario.Name = "lblDiario";
            lblDiario.Size = new Size(34, 25);
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
            label2.Location = new Point(10, 7);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 10;
            label2.Text = "Diário";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(80, 18);
            pictureBox3.Margin = new Padding(3, 1, 3, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 36);
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
            Painel_Semanal.Location = new Point(153, 8);
            Painel_Semanal.Margin = new Padding(8, 8, 30, 8);
            Painel_Semanal.Name = "Painel_Semanal";
            Painel_Semanal.Size = new Size(132, 71);
            Painel_Semanal.TabIndex = 3;
            // 
            // lblSemanal
            // 
            lblSemanal.AutoSize = true;
            lblSemanal.BackColor = Color.FromArgb(255, 232, 164);
            lblSemanal.Enabled = false;
            lblSemanal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSemanal.ForeColor = SystemColors.ActiveCaptionText;
            lblSemanal.Location = new Point(18, 31);
            lblSemanal.Name = "lblSemanal";
            lblSemanal.Size = new Size(34, 25);
            lblSemanal.TabIndex = 14;
            lblSemanal.Text = "00";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(76, 23);
            pictureBox4.Margin = new Padding(3, 1, 3, 1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 36);
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
            label5.Location = new Point(8, 11);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 13;
            label5.Text = "Semanal";
            // 
            // Painel_Mensal
            // 
            Painel_Mensal.BackColor = Color.FromArgb(238, 136, 136);
            Painel_Mensal.Controls.Add(lblMensal);
            Painel_Mensal.Controls.Add(pictureBox5);
            Painel_Mensal.Controls.Add(label7);
            Painel_Mensal.Location = new Point(318, 3);
            Painel_Mensal.Margin = new Padding(8, 8, 30, 8);
            Painel_Mensal.Name = "Painel_Mensal";
            Painel_Mensal.Size = new Size(132, 71);
            Painel_Mensal.TabIndex = 3;
            // 
            // lblMensal
            // 
            lblMensal.AutoSize = true;
            lblMensal.BackColor = Color.FromArgb(238, 136, 136);
            lblMensal.Enabled = false;
            lblMensal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensal.ForeColor = SystemColors.ActiveCaptionText;
            lblMensal.Location = new Point(18, 31);
            lblMensal.Name = "lblMensal";
            lblMensal.Size = new Size(34, 25);
            lblMensal.TabIndex = 17;
            lblMensal.Text = "00";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(78, 23);
            pictureBox5.Margin = new Padding(3, 1, 3, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 36);
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
            label7.Location = new Point(8, 11);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 16;
            label7.Text = "Mensal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Mongolian Baiti", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(160, 30);
            label3.Name = "label3";
            label3.Size = new Size(210, 20);
            label3.TabIndex = 4;
            label3.Text = "Bem-vindo ao Pontualize!";
            // 
            // btnSolicitarAdvertencia
            // 
            btnSolicitarAdvertencia.BackColor = Color.MidnightBlue;
            btnSolicitarAdvertencia.FlatStyle = FlatStyle.Flat;
            btnSolicitarAdvertencia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSolicitarAdvertencia.ForeColor = Color.White;
            btnSolicitarAdvertencia.Location = new Point(190, 190);
            btnSolicitarAdvertencia.Margin = new Padding(3, 2, 3, 2);
            btnSolicitarAdvertencia.Name = "btnSolicitarAdvertencia";
            btnSolicitarAdvertencia.Size = new Size(150, 25);
            btnSolicitarAdvertencia.TabIndex = 6;
            btnSolicitarAdvertencia.Text = "botão";
            btnSolicitarAdvertencia.TextAlign = ContentAlignment.TopCenter;
            btnSolicitarAdvertencia.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Location = new Point(3, 8);
            button1.Name = "button1";
            button1.Size = new Size(575, 177);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.WhiteSmoke;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 60);
            label6.Name = "label6";
            label6.Size = new Size(556, 64);
            label6.TabIndex = 8;
            label6.Text = resources.GetString("label6.Text");
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Painel_Perfil
            // 
            Painel_Perfil.Controls.Add(pictureBox1);
            Painel_Perfil.Dock = DockStyle.Top;
            Painel_Perfil.Location = new Point(0, 0);
            Painel_Perfil.Margin = new Padding(3, 1, 3, 1);
            Painel_Perfil.Name = "Painel_Perfil";
            Painel_Perfil.Size = new Size(200, 59);
            Painel_Perfil.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 13);
            pictureBox1.Margin = new Padding(3, 1, 3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTurma);
            panel1.Controls.Add(Turmas_Direcionamento);
            panel1.Controls.Add(Notificacao_Direcionamento);
            panel1.Controls.Add(BTN_Relatorio_Direcionamento);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 59);
            panel1.Margin = new Padding(3, 1, 3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 90);
            panel1.TabIndex = 8;
            // 
            // lblTurma
            // 
            lblTurma.AutoSize = true;
            lblTurma.BackColor = Color.MidnightBlue;
            lblTurma.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTurma.ForeColor = SystemColors.ButtonHighlight;
            lblTurma.Location = new Point(36, 47);
            lblTurma.Name = "lblTurma";
            lblTurma.Size = new Size(41, 15);
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
            Turmas_Direcionamento.Location = new Point(0, 46);
            Turmas_Direcionamento.Margin = new Padding(0);
            Turmas_Direcionamento.MaxDropDownItems = 3;
            Turmas_Direcionamento.Name = "Turmas_Direcionamento";
            Turmas_Direcionamento.Size = new Size(200, 24);
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
            Notificacao_Direcionamento.Location = new Point(0, 23);
            Notificacao_Direcionamento.Margin = new Padding(3, 1, 3, 1);
            Notificacao_Direcionamento.Name = "Notificacao_Direcionamento";
            Notificacao_Direcionamento.Size = new Size(200, 23);
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
            BTN_Relatorio_Direcionamento.Margin = new Padding(3, 1, 3, 1);
            BTN_Relatorio_Direcionamento.Name = "BTN_Relatorio_Direcionamento";
            BTN_Relatorio_Direcionamento.Size = new Size(200, 23);
            BTN_Relatorio_Direcionamento.TabIndex = 6;
            BTN_Relatorio_Direcionamento.Text = "Relatório";
            BTN_Relatorio_Direcionamento.UseVisualStyleBackColor = false;
            BTN_Relatorio_Direcionamento.Click += BTN_Relatorio_Direcionamento_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(Btn_Sair);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 480);
            panel2.Margin = new Padding(3, 1, 3, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(LblFuncao);
            panel3.Controls.Add(lblNome);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 1, 3, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 50);
            panel3.TabIndex = 10;
            // 
            // LblFuncao
            // 
            LblFuncao.AutoSize = true;
            LblFuncao.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblFuncao.ForeColor = SystemColors.ButtonHighlight;
            LblFuncao.Location = new Point(50, 28);
            LblFuncao.Name = "LblFuncao";
            LblFuncao.Size = new Size(46, 15);
            LblFuncao.TabIndex = 2;
            LblFuncao.Text = "Função";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = SystemColors.ButtonHighlight;
            lblNome.Location = new Point(50, 11);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(41, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            lblNome.Click += lblNome_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 11);
            pictureBox2.Margin = new Padding(3, 1, 3, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Btn_Sair
            // 
            Btn_Sair.BackColor = Color.MidnightBlue;
            Btn_Sair.Dock = DockStyle.Bottom;
            Btn_Sair.FlatAppearance.BorderSize = 0;
            Btn_Sair.FlatStyle = FlatStyle.Flat;
            Btn_Sair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Sair.ForeColor = Color.White;
            Btn_Sair.Location = new Point(0, 60);
            Btn_Sair.Margin = new Padding(3, 1, 3, 1);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(200, 40);
            Btn_Sair.TabIndex = 5;
            Btn_Sair.Text = "Sair";
            Btn_Sair.UseVisualStyleBackColor = false;
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.MidnightBlue;
            pnMenu.Controls.Add(panel2);
            pnMenu.Controls.Add(panel1);
            pnMenu.Controls.Add(Painel_Perfil);
            pnMenu.Dock = DockStyle.Fill;
            pnMenu.Location = new Point(0, 0);
            pnMenu.Margin = new Padding(0);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(200, 580);
            pnMenu.TabIndex = 0;
            // 
            // pnConteudo
            // 
            pnConteudo.BackColor = Color.Lavender;
            pnConteudo.Controls.Add(panelWelcome);
            pnConteudo.Controls.Add(flowLayoutPanelReports);
            pnConteudo.Controls.Add(label1);
            pnConteudo.Dock = DockStyle.Fill;
            pnConteudo.Location = new Point(200, 0);
            pnConteudo.Margin = new Padding(0);
            pnConteudo.Name = "pnConteudo";
            pnConteudo.Size = new Size(750, 580);
            pnConteudo.TabIndex = 1;
            pnConteudo.Paint += pnConteudo_Paint;
            // 
            // panelWelcome
            // 
            panelWelcome.Anchor = AnchorStyles.None;
            panelWelcome.Controls.Add(label6);
            panelWelcome.Controls.Add(label3);
            panelWelcome.Controls.Add(btnSolicitarAdvertencia);
            panelWelcome.Controls.Add(button1);
            panelWelcome.Location = new Point(67, 168);
            panelWelcome.Name = "panelWelcome";
            panelWelcome.Size = new Size(585, 250);
            panelWelcome.TabIndex = 10;
            // 
            // flowLayoutPanelReports
            // 
            flowLayoutPanelReports.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanelReports.Controls.Add(Painel_Diário);
            flowLayoutPanelReports.Controls.Add(Painel_Semanal);
            flowLayoutPanelReports.Controls.Add(Painel_Mensal);
            flowLayoutPanelReports.Location = new Point(54, 59);
            flowLayoutPanelReports.Name = "flowLayoutPanelReports";
            flowLayoutPanelReports.Size = new Size(620, 90);
            flowLayoutPanelReports.TabIndex = 9;
            flowLayoutPanelReports.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pnMenu, 0, 0);
            tableLayoutPanel1.Controls.Add(pnConteudo, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(950, 580);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // frmDashboard_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 580);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 1, 3, 1);
            Name = "frmDashboard_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Resize += frmDashboard_Principal_Resize;
            Painel_Diário.ResumeLayout(false);
            Painel_Diário.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            Painel_Semanal.ResumeLayout(false);
            Painel_Semanal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            Painel_Mensal.ResumeLayout(false);
            Painel_Mensal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            Painel_Perfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnMenu.ResumeLayout(false);
            pnConteudo.ResumeLayout(false);
            pnConteudo.PerformLayout();
            panelWelcome.ResumeLayout(false);
            panelWelcome.PerformLayout();
            flowLayoutPanelReports.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
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
        private Label label3;
        private Button btnSolicitarAdvertencia;
        private Button button1;
        private Label label6;
        private Panel Painel_Perfil;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblTurma;
        private ComboBox Turmas_Direcionamento;
        private Button Notificacao_Direcionamento;
        private Button BTN_Relatorio_Direcionamento;
        private Panel panel2;
        private Panel panel3;
        private Label LblFuncao;
        private Label lblNome;
        private PictureBox pictureBox2;
        private Button Btn_Sair;
        private Panel pnMenu;
        private Panel pnConteudo;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanelReports;
        private Panel panelWelcome;
    }
}

