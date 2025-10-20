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
            lblDescricao_Notificacao = new Label();
            lblTitulo_Notificacao = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnConteudo = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanelNotificacoes = new FlowLayoutPanel();
            Card_Notificacao = new CustomControls.ArredondamentoCard();
            img_sino = new PictureBox();
            molduraSino = new ArredondamentoBtn();
            panel4 = new Panel();
            btnExportar = new ArredondamentoBtn();
            label2 = new Label();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel7 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            cbAno = new ComboBox();
            arredondamentoBtn2 = new ArredondamentoBtn();
            panel3 = new Panel();
            panel6 = new Panel();
            lblTurma = new Label();
            Turmas_Direcionamento = new ComboBox();
            arredondamentoBtn3 = new ArredondamentoBtn();
            cbTurma = new ComboBox();
            arredondamentoBtn1 = new ArredondamentoBtn();
            menuPrincipal2 = new MenuPrincipal();
            tableLayoutPanel1.SuspendLayout();
            pnConteudo.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanelNotificacoes.SuspendLayout();
            Card_Notificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_sino).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // lblDescricao_Notificacao
            // 
            lblDescricao_Notificacao.AutoSize = true;
            lblDescricao_Notificacao.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao_Notificacao.Location = new Point(86, 40);
            lblDescricao_Notificacao.Name = "lblDescricao_Notificacao";
            lblDescricao_Notificacao.Size = new Size(407, 15);
            lblDescricao_Notificacao.TabIndex = 4;
            lblDescricao_Notificacao.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
            // 
            // lblTitulo_Notificacao
            // 
            lblTitulo_Notificacao.AutoSize = true;
            lblTitulo_Notificacao.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo_Notificacao.Location = new Point(83, 13);
            lblTitulo_Notificacao.Name = "lblTitulo_Notificacao";
            lblTitulo_Notificacao.Size = new Size(149, 20);
            lblTitulo_Notificacao.TabIndex = 3;
            lblTitulo_Notificacao.Text = "Título da Notificação";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 218F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pnConteudo, 1, 0);
            tableLayoutPanel1.Controls.Add(menuPrincipal2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(996, 550);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // pnConteudo
            // 
            pnConteudo.Controls.Add(tableLayoutPanel2);
            pnConteudo.Dock = DockStyle.Fill;
            pnConteudo.Location = new Point(218, 0);
            pnConteudo.Margin = new Padding(0);
            pnConteudo.Name = "pnConteudo";
            pnConteudo.Size = new Size(778, 550);
            pnConteudo.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanelNotificacoes, 0, 2);
            tableLayoutPanel2.Controls.Add(panel4, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 21.636364F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 63.4545441F));
            tableLayoutPanel2.Size = new Size(778, 550);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanelNotificacoes
            // 
            flowLayoutPanelNotificacoes.BackColor = Color.GhostWhite;
            flowLayoutPanelNotificacoes.Controls.Add(Card_Notificacao);
            flowLayoutPanelNotificacoes.Dock = DockStyle.Fill;
            flowLayoutPanelNotificacoes.Location = new Point(3, 203);
            flowLayoutPanelNotificacoes.Name = "flowLayoutPanelNotificacoes";
            flowLayoutPanelNotificacoes.Padding = new Padding(30, 0, 0, 0);
            flowLayoutPanelNotificacoes.Size = new Size(772, 344);
            flowLayoutPanelNotificacoes.TabIndex = 7;
            // 
            // Card_Notificacao
            // 
            Card_Notificacao.BackColor = Color.White;
            Card_Notificacao.BorderColor = Color.Transparent;
            Card_Notificacao.BorderRadius = 15;
            Card_Notificacao.BorderSize = 0;
            Card_Notificacao.Controls.Add(img_sino);
            Card_Notificacao.Controls.Add(molduraSino);
            Card_Notificacao.Controls.Add(lblTitulo_Notificacao);
            Card_Notificacao.Controls.Add(lblDescricao_Notificacao);
            Card_Notificacao.Location = new Point(33, 3);
            Card_Notificacao.Name = "Card_Notificacao";
            Card_Notificacao.Size = new Size(635, 68);
            Card_Notificacao.TabIndex = 0;
            // 
            // img_sino
            // 
            img_sino.BackColor = Color.Lavender;
            img_sino.Image = (Image)resources.GetObject("img_sino.Image");
            img_sino.Location = new Point(29, 15);
            img_sino.Margin = new Padding(3, 1, 3, 1);
            img_sino.Name = "img_sino";
            img_sino.Size = new Size(40, 39);
            img_sino.SizeMode = PictureBoxSizeMode.StretchImage;
            img_sino.TabIndex = 5;
            img_sino.TabStop = false;
            // 
            // molduraSino
            // 
            molduraSino.BackColor = Color.Lavender;
            molduraSino.BorderColor = Color.Transparent;
            molduraSino.BorderRadius = 10;
            molduraSino.BorderSize = 0;
            molduraSino.DisableHoverEffect = false;
            molduraSino.FlatAppearance.BorderSize = 0;
            molduraSino.FlatStyle = FlatStyle.Flat;
            molduraSino.ForeColor = Color.White;
            molduraSino.Location = new Point(19, 8);
            molduraSino.Name = "molduraSino";
            molduraSino.Size = new Size(58, 52);
            molduraSino.TabIndex = 6;
            molduraSino.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.GhostWhite;
            panel4.Controls.Add(btnExportar);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(772, 76);
            panel4.TabIndex = 18;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportar.BackColor = Color.MidnightBlue;
            btnExportar.BorderColor = Color.Transparent;
            btnExportar.BorderRadius = 10;
            btnExportar.BorderSize = 0;
            btnExportar.DisableHoverEffect = false;
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 11F);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(608, 38);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(155, 39);
            btnExportar.TabIndex = 12;
            btnExportar.Text = "Exportar relatório";
            btnExportar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(33, 34);
            label2.Name = "label2";
            label2.Size = new Size(169, 37);
            label2.TabIndex = 1;
            label2.Text = "Notificações";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Location = new Point(3, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(772, 76);
            panel2.TabIndex = 20;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.GhostWhite;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.30334F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.69666F));
            tableLayoutPanel3.Controls.Add(panel7, 0, 0);
            tableLayoutPanel3.Controls.Add(panel5, 1, 1);
            tableLayoutPanel3.Controls.Add(panel3, 0, 1);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 35.1851845F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 64.81481F));
            tableLayoutPanel3.Size = new Size(778, 97);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.Controls.Add(label1);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(292, 28);
            panel7.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 4);
            label1.Margin = new Padding(3, 0, 20, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 6;
            label1.Text = "Filtros:";
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Controls.Add(cbAno);
            panel5.Controls.Add(arredondamentoBtn2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(301, 37);
            panel5.Name = "panel5";
            panel5.Size = new Size(474, 57);
            panel5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MidnightBlue;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 10);
            label4.Name = "label4";
            label4.Size = new Size(138, 21);
            label4.TabIndex = 3;
            label4.Text = "Selecione o ano...";
            // 
            // cbAno
            // 
            cbAno.BackColor = Color.MidnightBlue;
            cbAno.FlatStyle = FlatStyle.Flat;
            cbAno.FormattingEnabled = true;
            cbAno.Location = new Point(30, 9);
            cbAno.Name = "cbAno";
            cbAno.Size = new Size(227, 23);
            cbAno.TabIndex = 3;
            cbAno.Visible = false;
            // 
            // arredondamentoBtn2
            // 
            arredondamentoBtn2.BackColor = Color.MidnightBlue;
            arredondamentoBtn2.BorderColor = Color.Transparent;
            arredondamentoBtn2.BorderRadius = 10;
            arredondamentoBtn2.BorderSize = 0;
            arredondamentoBtn2.DisableHoverEffect = false;
            arredondamentoBtn2.FlatAppearance.BorderSize = 0;
            arredondamentoBtn2.FlatStyle = FlatStyle.Flat;
            arredondamentoBtn2.ForeColor = Color.White;
            arredondamentoBtn2.Location = new Point(20, 3);
            arredondamentoBtn2.Name = "arredondamentoBtn2";
            arredondamentoBtn2.Size = new Size(244, 34);
            arredondamentoBtn2.TabIndex = 2;
            arredondamentoBtn2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(cbTurma);
            panel3.Controls.Add(arredondamentoBtn1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(292, 57);
            panel3.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.BackColor = Color.GhostWhite;
            panel6.Controls.Add(lblTurma);
            panel6.Controls.Add(Turmas_Direcionamento);
            panel6.Controls.Add(arredondamentoBtn3);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(292, 57);
            panel6.TabIndex = 8;
            // 
            // lblTurma
            // 
            lblTurma.AutoSize = true;
            lblTurma.BackColor = Color.MidnightBlue;
            lblTurma.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTurma.ForeColor = Color.White;
            lblTurma.Location = new Point(51, 10);
            lblTurma.Name = "lblTurma";
            lblTurma.Size = new Size(151, 21);
            lblTurma.TabIndex = 2;
            lblTurma.Text = "Selecione o curso...";
            lblTurma.Click += lblTurma_Click;
            // 
            // Turmas_Direcionamento
            // 
            Turmas_Direcionamento.BackColor = Color.Lavender;
            Turmas_Direcionamento.FlatStyle = FlatStyle.Flat;
            Turmas_Direcionamento.Font = new Font("Segoe UI", 10F);
            Turmas_Direcionamento.ForeColor = Color.Black;
            Turmas_Direcionamento.FormattingEnabled = true;
            Turmas_Direcionamento.Location = new Point(49, 19);
            Turmas_Direcionamento.Name = "Turmas_Direcionamento";
            Turmas_Direcionamento.Size = new Size(227, 25);
            Turmas_Direcionamento.TabIndex = 1;
            Turmas_Direcionamento.Visible = false;
            Turmas_Direcionamento.SelectedIndexChanged += Turmas_Direcionamento_SelectedIndexChanged;
            Turmas_Direcionamento.Leave += Turmas_Direcionamento_Leave;
            // 
            // arredondamentoBtn3
            // 
            arredondamentoBtn3.BackColor = Color.MidnightBlue;
            arredondamentoBtn3.BorderColor = Color.Transparent;
            arredondamentoBtn3.BorderRadius = 10;
            arredondamentoBtn3.BorderSize = 0;
            arredondamentoBtn3.DisableHoverEffect = false;
            arredondamentoBtn3.FlatAppearance.BorderSize = 0;
            arredondamentoBtn3.FlatStyle = FlatStyle.Flat;
            arredondamentoBtn3.ForeColor = Color.White;
            arredondamentoBtn3.Location = new Point(38, 3);
            arredondamentoBtn3.Margin = new Padding(3, 3, 30, 3);
            arredondamentoBtn3.Name = "arredondamentoBtn3";
            arredondamentoBtn3.Size = new Size(244, 36);
            arredondamentoBtn3.TabIndex = 0;
            arredondamentoBtn3.UseVisualStyleBackColor = false;
            // 
            // cbTurma
            // 
            cbTurma.FormattingEnabled = true;
            cbTurma.Location = new Point(47, 9);
            cbTurma.Name = "cbTurma";
            cbTurma.Size = new Size(227, 23);
            cbTurma.TabIndex = 1;
            // 
            // arredondamentoBtn1
            // 
            arredondamentoBtn1.BackColor = Color.MidnightBlue;
            arredondamentoBtn1.BorderColor = Color.Transparent;
            arredondamentoBtn1.BorderRadius = 10;
            arredondamentoBtn1.BorderSize = 0;
            arredondamentoBtn1.DisableHoverEffect = false;
            arredondamentoBtn1.FlatAppearance.BorderSize = 0;
            arredondamentoBtn1.FlatStyle = FlatStyle.Flat;
            arredondamentoBtn1.ForeColor = Color.White;
            arredondamentoBtn1.Location = new Point(38, 3);
            arredondamentoBtn1.Margin = new Padding(3, 3, 30, 3);
            arredondamentoBtn1.Name = "arredondamentoBtn1";
            arredondamentoBtn1.Size = new Size(244, 34);
            arredondamentoBtn1.TabIndex = 0;
            arredondamentoBtn1.Text = "arredondamentoBtn1";
            arredondamentoBtn1.UseVisualStyleBackColor = false;
            // 
            // menuPrincipal2
            // 
            menuPrincipal2.Dock = DockStyle.Fill;
            menuPrincipal2.Location = new Point(0, 0);
            menuPrincipal2.Margin = new Padding(0);
            menuPrincipal2.Name = "menuPrincipal2";
            menuPrincipal2.Size = new Size(218, 550);
            menuPrincipal2.TabIndex = 6;
            // 
            // frmNotificacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(996, 550);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1);
            Name = "frmNotificacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNotificacao";
            WindowState = FormWindowState.Maximized;
            Load += frmNotificacao_Load;
            tableLayoutPanel1.ResumeLayout(false);
            pnConteudo.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanelNotificacoes.ResumeLayout(false);
            Card_Notificacao.ResumeLayout(false);
            Card_Notificacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_sino).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitulo_Notificacao;
        private Label lblDescricao_Notificacao;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnConteudo;
        private MenuPrincipal menuPrincipal2;
        private Panel panel4;
        private Label label2;
        private Panel panel2;
        private ArredondamentoBtn arredondamentoBtn1;
        private ComboBox cbTurma;
        private Label label1;
        private ComboBox cbAno;
        private ArredondamentoBtn arredondamentoBtn2;
        private Panel panel5;
        private Panel panel3;
        private CustomControls.ArredondamentoCard Card_Notificacao;
        private PictureBox img_sino;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel7;
        private Panel panel6;
        private ComboBox Turmas_Direcionamento;
        private ArredondamentoBtn arredondamentoBtn3;
        private ArredondamentoBtn molduraSino;
        private FlowLayoutPanel flowLayoutPanelNotificacoes;
        private System.Windows.Forms.Timer NotificacaoTimer;
        private TableLayoutPanel tableLayoutPanel2;
        private ArredondamentoBtn btnExportar;
        private Label lblTurma;
        private Label label4;
    }
}