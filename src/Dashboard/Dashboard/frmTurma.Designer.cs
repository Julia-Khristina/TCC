namespace Dashboard
{
    partial class frmTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurma));
            Painel_Perfil = new Panel();
            pictureBox1 = new PictureBox();
            Turmas_Direcionamento = new ComboBox();
            btn_Notificacao_Direcionamento = new Button();
            btn_Relatorio_Direcionamento = new Button();
            pnMenu = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            LblFuncao = new Label();
            lblNome = new Label();
            pictureBox2 = new PictureBox();
            Btn_Voltar = new Button();
            pnBotões = new Panel();
            lblNmTurma = new Label();
            pnAlunoAtrasos = new Panel();
            tbAtrasoTurma = new DataGridView();
            pnGraficoTurma = new Panel();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            lblDiario = new Label();
            label2 = new Label();
            pnAtrasos_Totais = new Panel();
            pictureBox3 = new PictureBox();
            pnAtrasos_dia = new Panel();
            label3 = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            btnSolicitarAdvertencia = new Button();
            btnExportar = new Button();
            pictureBox5 = new PictureBox();
            Painel_Perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnMenu.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnBotões.SuspendLayout();
            pnAlunoAtrasos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbAtrasoTurma).BeginInit();
            pnGraficoTurma.SuspendLayout();
            pnAtrasos_Totais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnAtrasos_dia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // Painel_Perfil
            // 
            Painel_Perfil.Controls.Add(pictureBox1);
            Painel_Perfil.Location = new Point(0, 0);
            Painel_Perfil.Margin = new Padding(3, 2, 3, 2);
            Painel_Perfil.Name = "Painel_Perfil";
            Painel_Perfil.Size = new Size(139, 58);
            Painel_Perfil.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, -29);
            pictureBox1.Margin = new Padding(3, 1, 3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
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
            Turmas_Direcionamento.Location = new Point(0, 44);
            Turmas_Direcionamento.Margin = new Padding(0);
            Turmas_Direcionamento.MaxDropDownItems = 3;
            Turmas_Direcionamento.Name = "Turmas_Direcionamento";
            Turmas_Direcionamento.Size = new Size(139, 24);
            Turmas_Direcionamento.TabIndex = 9;
            // 
            // btn_Notificacao_Direcionamento
            // 
            btn_Notificacao_Direcionamento.BackColor = Color.MidnightBlue;
            btn_Notificacao_Direcionamento.Dock = DockStyle.Top;
            btn_Notificacao_Direcionamento.FlatAppearance.BorderSize = 0;
            btn_Notificacao_Direcionamento.FlatStyle = FlatStyle.Flat;
            btn_Notificacao_Direcionamento.ForeColor = SystemColors.ButtonHighlight;
            btn_Notificacao_Direcionamento.Location = new Point(0, 22);
            btn_Notificacao_Direcionamento.Margin = new Padding(3, 2, 3, 2);
            btn_Notificacao_Direcionamento.Name = "btn_Notificacao_Direcionamento";
            btn_Notificacao_Direcionamento.Size = new Size(139, 22);
            btn_Notificacao_Direcionamento.TabIndex = 9;
            btn_Notificacao_Direcionamento.Text = "Notificação";
            btn_Notificacao_Direcionamento.UseVisualStyleBackColor = false;
            btn_Notificacao_Direcionamento.Click += btn_Notificacao_Direcionamento_Click;
            // 
            // btn_Relatorio_Direcionamento
            // 
            btn_Relatorio_Direcionamento.BackColor = Color.MidnightBlue;
            btn_Relatorio_Direcionamento.Dock = DockStyle.Top;
            btn_Relatorio_Direcionamento.FlatAppearance.BorderSize = 0;
            btn_Relatorio_Direcionamento.FlatStyle = FlatStyle.Flat;
            btn_Relatorio_Direcionamento.ForeColor = SystemColors.ButtonHighlight;
            btn_Relatorio_Direcionamento.Location = new Point(0, 0);
            btn_Relatorio_Direcionamento.Margin = new Padding(3, 2, 3, 2);
            btn_Relatorio_Direcionamento.Name = "btn_Relatorio_Direcionamento";
            btn_Relatorio_Direcionamento.Size = new Size(139, 22);
            btn_Relatorio_Direcionamento.TabIndex = 8;
            btn_Relatorio_Direcionamento.Text = "Relátorio";
            btn_Relatorio_Direcionamento.UseVisualStyleBackColor = false;
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.MidnightBlue;
            pnMenu.Controls.Add(panel2);
            pnMenu.Controls.Add(pnBotões);
            pnMenu.Controls.Add(Painel_Perfil);
            pnMenu.Location = new Point(0, 0);
            pnMenu.Margin = new Padding(3, 2, 3, 2);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(139, 434);
            pnMenu.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(Btn_Voltar);
            panel2.Location = new Point(0, 326);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(139, 108);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(LblFuncao);
            panel3.Controls.Add(lblNome);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(11, 16);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(113, 42);
            panel3.TabIndex = 2;
            // 
            // LblFuncao
            // 
            LblFuncao.AutoSize = true;
            LblFuncao.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblFuncao.ForeColor = Color.FromArgb(224, 224, 224);
            LblFuncao.Location = new Point(55, 22);
            LblFuncao.Name = "LblFuncao";
            LblFuncao.Size = new Size(38, 12);
            LblFuncao.TabIndex = 3;
            LblFuncao.Text = "Função";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = SystemColors.ButtonHighlight;
            lblNome.Location = new Point(52, 7);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            lblNome.Click += lblNome_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 2);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.BackColor = Color.White;
            Btn_Voltar.FlatStyle = FlatStyle.Flat;
            Btn_Voltar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Voltar.ForeColor = Color.MidnightBlue;
            Btn_Voltar.Location = new Point(25, 70);
            Btn_Voltar.Margin = new Padding(3, 2, 3, 2);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(83, 25);
            Btn_Voltar.TabIndex = 0;
            Btn_Voltar.Text = "Voltar";
            Btn_Voltar.TextAlign = ContentAlignment.TopCenter;
            Btn_Voltar.UseVisualStyleBackColor = false;
            // 
            // pnBotões
            // 
            pnBotões.Controls.Add(Turmas_Direcionamento);
            pnBotões.Controls.Add(btn_Notificacao_Direcionamento);
            pnBotões.Controls.Add(btn_Relatorio_Direcionamento);
            pnBotões.Location = new Point(3, 59);
            pnBotões.Margin = new Padding(3, 2, 3, 2);
            pnBotões.Name = "pnBotões";
            pnBotões.Size = new Size(139, 68);
            pnBotões.TabIndex = 8;
            // 
            // lblNmTurma
            // 
            lblNmTurma.AutoSize = true;
            lblNmTurma.Font = new Font("Segoe UI", 12F);
            lblNmTurma.Location = new Point(161, 13);
            lblNmTurma.Name = "lblNmTurma";
            lblNmTurma.Size = new Size(51, 21);
            lblNmTurma.TabIndex = 2;
            lblNmTurma.Text = "Curso";
            lblNmTurma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnAlunoAtrasos
            // 
            pnAlunoAtrasos.BackColor = SystemColors.ButtonHighlight;
            pnAlunoAtrasos.Controls.Add(tbAtrasoTurma);
            pnAlunoAtrasos.Location = new Point(161, 131);
            pnAlunoAtrasos.Margin = new Padding(3, 2, 3, 2);
            pnAlunoAtrasos.Name = "pnAlunoAtrasos";
            pnAlunoAtrasos.Size = new Size(230, 253);
            pnAlunoAtrasos.TabIndex = 5;
            // 
            // tbAtrasoTurma
            // 
            tbAtrasoTurma.AllowUserToOrderColumns = true;
            tbAtrasoTurma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbAtrasoTurma.Location = new Point(3, -2);
            tbAtrasoTurma.Margin = new Padding(3, 2, 3, 2);
            tbAtrasoTurma.Name = "tbAtrasoTurma";
            tbAtrasoTurma.RowHeadersWidth = 51;
            tbAtrasoTurma.Size = new Size(230, 251);
            tbAtrasoTurma.TabIndex = 0;
            tbAtrasoTurma.CellContentClick += tbAtrasoTurma_CellContentClick;
            // 
            // pnGraficoTurma
            // 
            pnGraficoTurma.BackColor = SystemColors.ButtonHighlight;
            pnGraficoTurma.Controls.Add(pictureBox5);
            pnGraficoTurma.Controls.Add(label6);
            pnGraficoTurma.Controls.Add(label5);
            pnGraficoTurma.Controls.Add(label1);
            pnGraficoTurma.Location = new Point(419, 131);
            pnGraficoTurma.Margin = new Padding(3, 2, 3, 2);
            pnGraficoTurma.Name = "pnGraficoTurma";
            pnGraficoTurma.Size = new Size(391, 253);
            pnGraficoTurma.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(141, 79);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 2;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(141, 47);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 1;
            label5.Text = "label5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 17);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // lblDiario
            // 
            lblDiario.AutoSize = true;
            lblDiario.BackColor = Color.FromArgb(255, 232, 164);
            lblDiario.Enabled = false;
            lblDiario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiario.ForeColor = SystemColors.ActiveCaptionText;
            lblDiario.Location = new Point(32, 29);
            lblDiario.Name = "lblDiario";
            lblDiario.Size = new Size(34, 25);
            lblDiario.TabIndex = 11;
            lblDiario.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 232, 164);
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(4, 13);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 10;
            label2.Text = "Atrasos Totais";
            // 
            // pnAtrasos_Totais
            // 
            pnAtrasos_Totais.BackColor = Color.FromArgb(255, 232, 164);
            pnAtrasos_Totais.Controls.Add(lblDiario);
            pnAtrasos_Totais.Controls.Add(label2);
            pnAtrasos_Totais.Controls.Add(pictureBox3);
            pnAtrasos_Totais.Location = new Point(206, 55);
            pnAtrasos_Totais.Margin = new Padding(3, 2, 3, 2);
            pnAtrasos_Totais.Name = "pnAtrasos_Totais";
            pnAtrasos_Totais.Size = new Size(153, 62);
            pnAtrasos_Totais.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(94, 15);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pnAtrasos_dia
            // 
            pnAtrasos_dia.BackColor = Color.FromArgb(136, 170, 238);
            pnAtrasos_dia.Controls.Add(label3);
            pnAtrasos_dia.Controls.Add(label4);
            pnAtrasos_dia.Controls.Add(pictureBox4);
            pnAtrasos_dia.Location = new Point(622, 55);
            pnAtrasos_dia.Margin = new Padding(3, 2, 3, 2);
            pnAtrasos_dia.Name = "pnAtrasos_dia";
            pnAtrasos_dia.Size = new Size(153, 62);
            pnAtrasos_dia.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(136, 170, 238);
            label3.Enabled = false;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(32, 29);
            label3.Name = "label3";
            label3.Size = new Size(34, 25);
            label3.TabIndex = 11;
            label3.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(136, 170, 238);
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(1, 13);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 10;
            label4.Text = "Atrasos do dia";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(94, 15);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // btnSolicitarAdvertencia
            // 
            btnSolicitarAdvertencia.BackColor = Color.MidnightBlue;
            btnSolicitarAdvertencia.FlatStyle = FlatStyle.Flat;
            btnSolicitarAdvertencia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSolicitarAdvertencia.ForeColor = Color.White;
            btnSolicitarAdvertencia.Location = new Point(161, 396);
            btnSolicitarAdvertencia.Margin = new Padding(3, 2, 3, 2);
            btnSolicitarAdvertencia.Name = "btnSolicitarAdvertencia";
            btnSolicitarAdvertencia.Size = new Size(150, 25);
            btnSolicitarAdvertencia.TabIndex = 3;
            btnSolicitarAdvertencia.Text = "Solicitar Advertência";
            btnSolicitarAdvertencia.TextAlign = ContentAlignment.TopCenter;
            btnSolicitarAdvertencia.UseVisualStyleBackColor = false;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.MidnightBlue;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(720, 11);
            btnExportar.Margin = new Padding(3, 2, 3, 2);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(90, 21);
            btnExportar.TabIndex = 13;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(17, 17);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 111);
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // frmTurma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 433);
            Controls.Add(btnExportar);
            Controls.Add(btnSolicitarAdvertencia);
            Controls.Add(pnAtrasos_dia);
            Controls.Add(pnAtrasos_Totais);
            Controls.Add(pnGraficoTurma);
            Controls.Add(pnAlunoAtrasos);
            Controls.Add(lblNmTurma);
            Controls.Add(pnMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmTurma";
            StartPosition = FormStartPosition.CenterScreen;
            Painel_Perfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnBotões.ResumeLayout(false);
            pnAlunoAtrasos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbAtrasoTurma).EndInit();
            pnGraficoTurma.ResumeLayout(false);
            pnGraficoTurma.PerformLayout();
            pnAtrasos_Totais.ResumeLayout(false);
            pnAtrasos_Totais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnAtrasos_dia.ResumeLayout(false);
            pnAtrasos_dia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel Painel_Perfil;
        private ComboBox Turmas_Direcionamento;
        private Button btn_Notificacao_Direcionamento;
        private Button btn_Relatorio_Direcionamento;
        private Panel pnMenu;
        private Panel panel2;
        private Panel panel3;
        private Label LblFuncao;
        private Label lblNome;
        private PictureBox pictureBox2;
        private Button Btn_Voltar;
        private Panel pnBotões;
        private Label lblNmTurma;
        private Panel pnAlunoAtrasos;
        private DataGridView tbAtrasoTurma;
        private Panel pnGraficoTurma;
        private Label lblDiario;
        private Label label2;
        private Panel pnAtrasos_Totais;
        private PictureBox pictureBox3;
        private Panel pnAtrasos_dia;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox4;
        private Button btnSolicitarAdvertencia;
        private Button btnExportar;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Label label1;
        private PictureBox pictureBox5;
    }
}