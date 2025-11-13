using System.Windows.Forms;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurma));
            tableLayoutPanel1 = new TableLayoutPanel();
            menuPrincipal1 = new MenuPrincipal();
            pnConteudo = new Panel();
            panel8 = new Panel();
            btnExportar = new ArredondamentoBtn();
            panel4 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            btn1Ano = new ArredondamentoBtn();
            btn2Ano = new ArredondamentoBtn();
            btn3Ano = new ArredondamentoBtn();
            arredondamentoBtn1 = new ArredondamentoBtn();
            panel5 = new Panel();
            tlpConteudoPrincipal = new TableLayoutPanel();
            pnAlunoAtrasos = new Panel();
            tbAtrasoTurma = new DataGridView();
            pnGraficoTurma = new Panel();
            arredondamentoCard1 = new CustomControls.ArredondamentoCard();
            panel2 = new Panel();
            btnSolicitarAdvertencia = new ArredondamentoBtn();
            panel1 = new Panel();
            pictureBoxCarometro = new CustomControls.RoundedPictureBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            lblRM = new Label();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblNomeAluno = new Label();
            lblTelAluno = new Label();
            label5 = new Label();
            lblEmailAluno = new Label();
            lblAnoAluno = new Label();
            panel3 = new Panel();
            lblNmTurma = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel7 = new Panel();
            pnAtrasos_dia = new PanelSombra();
            label2 = new Label();
            button7 = new Button();
            pictureBox3 = new PictureBox();
            pn_Atrasos_Dia = new Label();
            panel6 = new Panel();
            pnAtrasos_Totais = new PanelSombra();
            button6 = new Button();
            label4 = new Label();
            lblDiario = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            pnConteudo.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel5.SuspendLayout();
            tlpConteudoPrincipal.SuspendLayout();
            pnAlunoAtrasos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbAtrasoTurma).BeginInit();
            pnGraficoTurma.SuspendLayout();
            arredondamentoCard1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCarometro).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel7.SuspendLayout();
            pnAtrasos_dia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            pnAtrasos_Totais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // menuPrincipal1
            // 
            menuPrincipal1.Dock = DockStyle.Fill;
            menuPrincipal1.Location = new Point(0, 0);
            menuPrincipal1.Margin = new Padding(0);
            menuPrincipal1.Name = "menuPrincipal1";
            menuPrincipal1.Size = new Size(218, 591);
            menuPrincipal1.TabIndex = 6;
            // 
            // pnConteudo
            // 
            pnConteudo.BackColor = Color.GhostWhite;
            pnConteudo.Controls.Add(panel8);
            pnConteudo.Controls.Add(panel4);
            pnConteudo.Controls.Add(panel5);
            pnConteudo.Controls.Add(panel3);
            pnConteudo.Dock = DockStyle.Fill;
            pnConteudo.Location = new Point(221, 3);
            pnConteudo.Name = "pnConteudo";
            pnConteudo.Padding = new Padding(0, 0, 0, 10);
            pnConteudo.Size = new Size(989, 585);
            pnConteudo.TabIndex = 1;
            pnConteudo.Paint += pnConteudo_Paint;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnExportar);
            panel8.Location = new Point(772, 10);
            panel8.Name = "panel8";
            panel8.Size = new Size(298, 301);
            panel8.TabIndex = 19;
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
            btnExportar.Location = new Point(126, 32);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(155, 39);
            btnExportar.TabIndex = 11;
            btnExportar.Text = "Exportar relatório";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.GhostWhite;
            panel4.Controls.Add(tableLayoutPanel4);
            panel4.Location = new Point(0, 247);
            panel4.Margin = new Padding(3, 3, 3, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5, 0, 0, 0);
            panel4.Size = new Size(766, 51);
            panel4.TabIndex = 18;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.1046028F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.8256626F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(btn1Ano, 0, 0);
            tableLayoutPanel4.Controls.Add(btn2Ano, 1, 0);
            tableLayoutPanel4.Controls.Add(btn3Ano, 2, 0);
            tableLayoutPanel4.Controls.Add(arredondamentoBtn1, 3, 0);
            tableLayoutPanel4.Location = new Point(38, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(717, 47);
            tableLayoutPanel4.TabIndex = 17;
            // 
            // btn1Ano
            // 
            btn1Ano.BackColor = Color.MidnightBlue;
            btn1Ano.BorderColor = Color.Transparent;
            btn1Ano.BorderRadius = 10;
            btn1Ano.BorderSize = 0;
            btn1Ano.DisableHoverEffect = false;
            btn1Ano.FlatAppearance.BorderSize = 0;
            btn1Ano.FlatStyle = FlatStyle.Flat;
            btn1Ano.ForeColor = Color.White;
            btn1Ano.Location = new Point(2, 2);
            btn1Ano.Margin = new Padding(2);
            btn1Ano.Name = "btn1Ano";
            btn1Ano.Size = new Size(118, 36);
            btn1Ano.TabIndex = 13;
            btn1Ano.Text = "1º Ano";
            btn1Ano.UseVisualStyleBackColor = false;
            btn1Ano.Click += btn1Ano_Click;
            // 
            // btn2Ano
            // 
            btn2Ano.BackColor = Color.MidnightBlue;
            btn2Ano.BorderColor = Color.Transparent;
            btn2Ano.BorderRadius = 10;
            btn2Ano.BorderSize = 0;
            btn2Ano.DisableHoverEffect = false;
            btn2Ano.FlatAppearance.BorderSize = 0;
            btn2Ano.FlatStyle = FlatStyle.Flat;
            btn2Ano.ForeColor = Color.White;
            btn2Ano.Location = new Point(181, 2);
            btn2Ano.Margin = new Padding(2);
            btn2Ano.Name = "btn2Ano";
            btn2Ano.Size = new Size(118, 36);
            btn2Ano.TabIndex = 14;
            btn2Ano.Text = "2º Ano";
            btn2Ano.UseVisualStyleBackColor = false;
            btn2Ano.Click += btn2Ano_Click;
            // 
            // btn3Ano
            // 
            btn3Ano.BackColor = Color.MidnightBlue;
            btn3Ano.BorderColor = Color.Transparent;
            btn3Ano.BorderRadius = 10;
            btn3Ano.BorderSize = 0;
            btn3Ano.DisableHoverEffect = false;
            btn3Ano.FlatAppearance.BorderSize = 0;
            btn3Ano.FlatStyle = FlatStyle.Flat;
            btn3Ano.ForeColor = Color.White;
            btn3Ano.Location = new Point(361, 2);
            btn3Ano.Margin = new Padding(2);
            btn3Ano.Name = "btn3Ano";
            btn3Ano.Size = new Size(118, 36);
            btn3Ano.TabIndex = 15;
            btn3Ano.Text = "3º Ano";
            btn3Ano.UseVisualStyleBackColor = false;
            btn3Ano.Click += btn3Ano_Click;
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
            arredondamentoBtn1.Location = new Point(539, 2);
            arredondamentoBtn1.Margin = new Padding(2);
            arredondamentoBtn1.Name = "arredondamentoBtn1";
            arredondamentoBtn1.Size = new Size(118, 36);
            arredondamentoBtn1.TabIndex = 16;
            arredondamentoBtn1.Text = "Todos";
            arredondamentoBtn1.UseVisualStyleBackColor = false;
            arredondamentoBtn1.Click += arredondamentoBtn1_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(tlpConteudoPrincipal);
            panel5.Location = new Point(0, 305);
            panel5.Name = "panel5";
            panel5.Size = new Size(1069, 429);
            panel5.TabIndex = 18;
            // 
            // tlpConteudoPrincipal
            // 
            tlpConteudoPrincipal.BackColor = Color.GhostWhite;
            tlpConteudoPrincipal.ColumnCount = 2;
            tlpConteudoPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.5187378F));
            tlpConteudoPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.4812622F));
            tlpConteudoPrincipal.Controls.Add(pnAlunoAtrasos, 0, 0);
            tlpConteudoPrincipal.Controls.Add(pnGraficoTurma, 1, 0);
            tlpConteudoPrincipal.Dock = DockStyle.Fill;
            tlpConteudoPrincipal.Location = new Point(0, 0);
            tlpConteudoPrincipal.Name = "tlpConteudoPrincipal";
            tlpConteudoPrincipal.Padding = new Padding(35, 0, 15, 30);
            tlpConteudoPrincipal.RowCount = 1;
            tlpConteudoPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpConteudoPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 399F));
            tlpConteudoPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 399F));
            tlpConteudoPrincipal.Size = new Size(1069, 429);
            tlpConteudoPrincipal.TabIndex = 0;
            // 
            // pnAlunoAtrasos
            // 
            pnAlunoAtrasos.BackColor = Color.Lavender;
            pnAlunoAtrasos.Controls.Add(tbAtrasoTurma);
            pnAlunoAtrasos.Dock = DockStyle.Fill;
            pnAlunoAtrasos.Location = new Point(38, 2);
            pnAlunoAtrasos.Margin = new Padding(3, 2, 3, 2);
            pnAlunoAtrasos.Name = "pnAlunoAtrasos";
            pnAlunoAtrasos.Size = new Size(417, 395);
            pnAlunoAtrasos.TabIndex = 5;
            // 
            // tbAtrasoTurma
            // 
            tbAtrasoTurma.AllowUserToOrderColumns = true;
            tbAtrasoTurma.BackgroundColor = Color.Lavender;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbAtrasoTurma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbAtrasoTurma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(168, 230, 207);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbAtrasoTurma.DefaultCellStyle = dataGridViewCellStyle2;
            tbAtrasoTurma.Dock = DockStyle.Fill;
            tbAtrasoTurma.GridColor = Color.FromArgb(233, 236, 239);
            tbAtrasoTurma.Location = new Point(0, 0);
            tbAtrasoTurma.Margin = new Padding(10, 10, 15, 10);
            tbAtrasoTurma.Name = "tbAtrasoTurma";
            tbAtrasoTurma.ReadOnly = true;
            tbAtrasoTurma.RowHeadersWidth = 51;
            tbAtrasoTurma.Size = new Size(417, 395);
            tbAtrasoTurma.TabIndex = 0;
            tbAtrasoTurma.CellContentClick += tbAtrasoTurma_CellContentClick;
            // 
            // pnGraficoTurma
            // 
            pnGraficoTurma.BackColor = Color.GhostWhite;
            pnGraficoTurma.Controls.Add(arredondamentoCard1);
            pnGraficoTurma.Dock = DockStyle.Fill;
            pnGraficoTurma.Location = new Point(461, 2);
            pnGraficoTurma.Margin = new Padding(3, 2, 3, 10);
            pnGraficoTurma.Name = "pnGraficoTurma";
            pnGraficoTurma.Size = new Size(590, 387);
            pnGraficoTurma.TabIndex = 7;
            pnGraficoTurma.Paint += pnGraficoTurma_Paint;
            // 
            // arredondamentoCard1
            // 
            arredondamentoCard1.BackColor = Color.White;
            arredondamentoCard1.BorderColor = Color.Transparent;
            arredondamentoCard1.BorderRadius = 15;
            arredondamentoCard1.BorderSize = 0;
            arredondamentoCard1.Controls.Add(panel2);
            arredondamentoCard1.Controls.Add(panel1);
            arredondamentoCard1.Location = new Point(3, 1);
            arredondamentoCard1.Name = "arredondamentoCard1";
            arredondamentoCard1.Size = new Size(579, 391);
            arredondamentoCard1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSolicitarAdvertencia);
            panel2.Location = new Point(6, 260);
            panel2.Name = "panel2";
            panel2.Size = new Size(567, 123);
            panel2.TabIndex = 12;
            // 
            // btnSolicitarAdvertencia
            // 
            btnSolicitarAdvertencia.BackColor = Color.MidnightBlue;
            btnSolicitarAdvertencia.BorderColor = Color.Transparent;
            btnSolicitarAdvertencia.BorderRadius = 10;
            btnSolicitarAdvertencia.BorderSize = 0;
            btnSolicitarAdvertencia.DisableHoverEffect = false;
            btnSolicitarAdvertencia.FlatAppearance.BorderSize = 0;
            btnSolicitarAdvertencia.FlatStyle = FlatStyle.Flat;
            btnSolicitarAdvertencia.ForeColor = Color.White;
            btnSolicitarAdvertencia.Location = new Point(16, 6);
            btnSolicitarAdvertencia.Name = "btnSolicitarAdvertencia";
            btnSolicitarAdvertencia.Size = new Size(164, 34);
            btnSolicitarAdvertencia.TabIndex = 0;
            btnSolicitarAdvertencia.Text = "Solicitar Advertencia";
            btnSolicitarAdvertencia.UseVisualStyleBackColor = false;
            btnSolicitarAdvertencia.Click += btnSolicitarAdvertencia_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBoxCarometro);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblRM);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblNomeAluno);
            panel1.Controls.Add(lblTelAluno);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblEmailAluno);
            panel1.Controls.Add(lblAnoAluno);
            panel1.Location = new Point(6, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 257);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBoxCarometro
            // 
            pictureBoxCarometro.BackColor = Color.White;
            pictureBoxCarometro.BorderRadius = 15;
            pictureBoxCarometro.Location = new Point(23, 33);
            pictureBoxCarometro.Name = "pictureBoxCarometro";
            pictureBoxCarometro.Size = new Size(157, 193);
            pictureBoxCarometro.TabIndex = 19;
            pictureBoxCarometro.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.LightGray;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Silver;
            button5.Location = new Point(209, 234);
            button5.Name = "button5";
            button5.Size = new Size(335, 1);
            button5.TabIndex = 18;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Silver;
            button4.Location = new Point(209, 190);
            button4.Name = "button4";
            button4.Size = new Size(335, 1);
            button4.TabIndex = 17;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Silver;
            button3.Location = new Point(209, 141);
            button3.Name = "button3";
            button3.Size = new Size(335, 1);
            button3.TabIndex = 16;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Silver;
            button2.Location = new Point(209, 96);
            button2.Name = "button2";
            button2.Size = new Size(335, 1);
            button2.TabIndex = 15;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Silver;
            button1.Location = new Point(209, 53);
            button1.Name = "button1";
            button1.Size = new Size(335, 1);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(108, 117, 125);
            label1.Location = new Point(205, 27);
            label1.Name = "label1";
            label1.Size = new Size(37, 21);
            label1.TabIndex = 13;
            label1.Text = "RM:";
            // 
            // lblRM
            // 
            lblRM.AutoSize = true;
            lblRM.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRM.ForeColor = Color.FromArgb(44, 62, 80);
            lblRM.Location = new Point(240, 28);
            lblRM.Name = "lblRM";
            lblRM.Size = new Size(0, 20);
            lblRM.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(108, 117, 125);
            label8.Location = new Point(206, 68);
            label8.Name = "label8";
            label8.Size = new Size(56, 21);
            label8.TabIndex = 10;
            label8.Text = "Nome:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(108, 117, 125);
            label6.Location = new Point(205, 160);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 7;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(108, 117, 125);
            label7.Location = new Point(206, 205);
            label7.Name = "label7";
            label7.Size = new Size(41, 21);
            label7.TabIndex = 8;
            label7.Text = "Ano:";
            // 
            // lblNomeAluno
            // 
            lblNomeAluno.AutoSize = true;
            lblNomeAluno.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNomeAluno.ForeColor = Color.FromArgb(44, 62, 80);
            lblNomeAluno.Location = new Point(259, 70);
            lblNomeAluno.Name = "lblNomeAluno";
            lblNomeAluno.Size = new Size(0, 20);
            lblNomeAluno.TabIndex = 0;
            // 
            // lblTelAluno
            // 
            lblTelAluno.AutoSize = true;
            lblTelAluno.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTelAluno.ForeColor = Color.FromArgb(44, 62, 80);
            lblTelAluno.Location = new Point(273, 114);
            lblTelAluno.Name = "lblTelAluno";
            lblTelAluno.Size = new Size(0, 20);
            lblTelAluno.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(108, 117, 125);
            label5.Location = new Point(205, 113);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 6;
            label5.Text = "Telefone:";
            // 
            // lblEmailAluno
            // 
            lblEmailAluno.AutoSize = true;
            lblEmailAluno.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblEmailAluno.ForeColor = Color.FromArgb(44, 62, 80);
            lblEmailAluno.Location = new Point(256, 160);
            lblEmailAluno.Name = "lblEmailAluno";
            lblEmailAluno.Size = new Size(0, 20);
            lblEmailAluno.TabIndex = 2;
            // 
            // lblAnoAluno
            // 
            lblAnoAluno.AutoSize = true;
            lblAnoAluno.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAnoAluno.ForeColor = Color.FromArgb(44, 62, 80);
            lblAnoAluno.Location = new Point(243, 206);
            lblAnoAluno.Name = "lblAnoAluno";
            lblAnoAluno.Size = new Size(0, 20);
            lblAnoAluno.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.GhostWhite;
            panel3.Controls.Add(lblNmTurma);
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(35, 0, 0, 0);
            panel3.Size = new Size(766, 242);
            panel3.TabIndex = 17;
            panel3.Paint += panel3_Paint;
            // 
            // lblNmTurma
            // 
            lblNmTurma.AutoSize = true;
            lblNmTurma.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblNmTurma.Location = new Point(33, 34);
            lblNmTurma.Name = "lblNmTurma";
            lblNmTurma.Size = new Size(194, 37);
            lblNmTurma.TabIndex = 2;
            lblNmTurma.Text = "Administração";
            lblNmTurma.TextAlign = ContentAlignment.MiddleLeft;
            lblNmTurma.Click += lblNmTurma_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.31323F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.31323F));
            tableLayoutPanel3.Controls.Add(panel7, 1, 0);
            tableLayoutPanel3.Controls.Add(panel6, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(35, 86);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(731, 156);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // panel7
            // 
            panel7.Controls.Add(pnAtrasos_dia);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(368, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(360, 150);
            panel7.TabIndex = 11;
            // 
            // pnAtrasos_dia
            // 
            pnAtrasos_dia.BackColor = Color.White;
            pnAtrasos_dia.BorderRadius = 15;
            pnAtrasos_dia.Controls.Add(label2);
            pnAtrasos_dia.Controls.Add(button7);
            pnAtrasos_dia.Controls.Add(pictureBox3);
            pnAtrasos_dia.Controls.Add(pn_Atrasos_Dia);
            pnAtrasos_dia.Dock = DockStyle.Left;
            pnAtrasos_dia.Location = new Point(0, 0);
            pnAtrasos_dia.Name = "pnAtrasos_dia";
            pnAtrasos_dia.ShadowColor = Color.FromArgb(50, 0, 0, 0);
            pnAtrasos_dia.ShadowSize = 5;
            pnAtrasos_dia.Size = new Size(294, 150);
            pnAtrasos_dia.TabIndex = 13;
            pnAtrasos_dia.Paint += pnAtrasos_dia_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(24, 88);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 10;
            label2.Text = "Atrasos Totais";
            // 
            // button7
            // 
            button7.BackColor = Color.SteelBlue;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.SteelBlue;
            button7.Location = new Point(27, 120);
            button7.Name = "button7";
            button7.Size = new Size(164, 2);
            button7.TabIndex = 12;
            button7.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(174, 16);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(92, 93);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pn_Atrasos_Dia
            // 
            pn_Atrasos_Dia.Font = new Font("Segoe UI", 45F, FontStyle.Bold);
            pn_Atrasos_Dia.ForeColor = Color.MidnightBlue;
            pn_Atrasos_Dia.Location = new Point(10, 0);
            pn_Atrasos_Dia.Name = "pn_Atrasos_Dia";
            pn_Atrasos_Dia.Size = new Size(127, 96);
            pn_Atrasos_Dia.TabIndex = 0;
            pn_Atrasos_Dia.Text = "00";
            pn_Atrasos_Dia.Click += label3_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(pnAtrasos_Totais);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(359, 150);
            panel6.TabIndex = 13;
            // 
            // pnAtrasos_Totais
            // 
            pnAtrasos_Totais.BackColor = Color.White;
            pnAtrasos_Totais.BorderRadius = 15;
            pnAtrasos_Totais.Controls.Add(button6);
            pnAtrasos_Totais.Controls.Add(label4);
            pnAtrasos_Totais.Controls.Add(lblDiario);
            pnAtrasos_Totais.Controls.Add(pictureBox1);
            pnAtrasos_Totais.Dock = DockStyle.Left;
            pnAtrasos_Totais.Location = new Point(0, 0);
            pnAtrasos_Totais.Name = "pnAtrasos_Totais";
            pnAtrasos_Totais.ShadowColor = Color.FromArgb(50, 0, 0, 0);
            pnAtrasos_Totais.ShadowSize = 5;
            pnAtrasos_Totais.Size = new Size(299, 150);
            pnAtrasos_Totais.TabIndex = 13;
            // 
            // button6
            // 
            button6.BackColor = Color.SteelBlue;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.SteelBlue;
            button6.Location = new Point(28, 120);
            button6.Name = "button6";
            button6.Size = new Size(164, 2);
            button6.TabIndex = 11;
            button6.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(26, 88);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 10;
            label4.Text = "Atrasos do dia";
            // 
            // lblDiario
            // 
            lblDiario.Font = new Font("Segoe UI", 45F, FontStyle.Bold);
            lblDiario.ForeColor = Color.MidnightBlue;
            lblDiario.Location = new Point(10, 3);
            lblDiario.Name = "lblDiario";
            lblDiario.Size = new Size(163, 81);
            lblDiario.TabIndex = 0;
            lblDiario.Text = "00";
            lblDiario.Click += lblDiario_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(156, -15);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 218F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(menuPrincipal1, 0, 0);
            tableLayoutPanel2.Controls.Add(pnConteudo, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1213, 591);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // frmTurma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 591);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTurma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTurma";
            WindowState = FormWindowState.Maximized;
            Load += frmTurma_Load;
            pnConteudo.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tlpConteudoPrincipal.ResumeLayout(false);
            pnAlunoAtrasos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbAtrasoTurma).EndInit();
            pnGraficoTurma.ResumeLayout(false);
            arredondamentoCard1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCarometro).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            pnAtrasos_dia.ResumeLayout(false);
            pnAtrasos_dia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            pnAtrasos_Totais.ResumeLayout(false);
            pnAtrasos_Totais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnBotões;
        private Label lblNmTurma;
        private Panel pnAlunoAtrasos;
        private DataGridView tbAtrasoTurma;
        private Panel pnGraficoTurma;
        private Label lblAnoAluno;
        private Label lblEmailAluno;
        private Label lblTelAluno;
        private Label lblNomeAluno;
        private Label lblDiario;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label pn_Atrasos_Dia;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tlpConteudoPrincipal;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
        // private Button btnMoldura; // REMOVIDO - Declaração da variável removida
        private Label label8;
        private Panel panel1;
        private Panel panel2;
        private ArredondamentoBtn btnSolicitarAdvertencia;
        private ArredondamentoBtn btnExportar;
        private TableLayoutPanel tableLayoutPanel2;
        private MenuPrincipal menuPrincipal1;
        private Panel pnConteudo;
        private TableLayoutPanel tableLayoutPanel3;
        private ArredondamentoBtn btn3Ano;
        private ArredondamentoBtn btn2Ano;
        private ArredondamentoBtn btn1Ano;
        private Label lblRM;
        private ArredondamentoBtn arredondamentoBtn1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private PanelSombra pnAtrasos_Totais;
        private Panel panel7;
        private PanelSombra pnAtrasos_dia;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button6;
        private Button button7;
        private Panel panel8;
        private CustomControls.ArredondamentoCard arredondamentoCard1;
        private CustomControls.RoundedPictureBox pictureBoxCarometro;
    }
}
