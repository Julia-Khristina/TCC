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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurma));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuPrincipal1 = new MenuPrincipal();
            pnConteudo = new Panel();
            btn3Ano = new ArredondamentoBtn();
            btn2Ano = new ArredondamentoBtn();
            btn1Ano = new ArredondamentoBtn();
            tableLayoutPanel3 = new TableLayoutPanel();
            pnAtrasos_dia = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            pnAtrasos_Totais = new Panel();
            lblDiario = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            btnExportar = new ArredondamentoBtn();
            lblNmTurma = new Label();
            tlpConteudoPrincipal = new TableLayoutPanel();
            pnAlunoAtrasos = new Panel();
            tbAtrasoTurma = new DataGridView();
            pnGraficoTurma = new Panel();
            panel2 = new Panel();
            btnSolicitarAdvertencia = new ArredondamentoBtn();
            panel1 = new Panel();
            label1 = new Label();
            lblRM = new Label();
            pictureBoxCarometro = new PictureBox();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblNomeAluno = new Label();
            lblTelAluno = new Label();
            label5 = new Label();
            lblEmailAluno = new Label();
            lblAnoAluno = new Label();
            arredondamentoBtn4 = new ArredondamentoBtn();
            tableLayoutPanel2 = new TableLayoutPanel();
            pnConteudo.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            pnAtrasos_dia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnAtrasos_Totais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tlpConteudoPrincipal.SuspendLayout();
            pnAlunoAtrasos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbAtrasoTurma).BeginInit();
            pnGraficoTurma.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCarometro).BeginInit();
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
            menuPrincipal1.Size = new Size(311, 1050);
            menuPrincipal1.TabIndex = 6;
            // 
            // pnConteudo
            // 
            pnConteudo.Controls.Add(btn3Ano);
            pnConteudo.Controls.Add(btn2Ano);
            pnConteudo.Controls.Add(btn1Ano);
            pnConteudo.Controls.Add(tableLayoutPanel3);
            pnConteudo.Controls.Add(btnExportar);
            pnConteudo.Controls.Add(lblNmTurma);
            pnConteudo.Controls.Add(tlpConteudoPrincipal);
            pnConteudo.Dock = DockStyle.Fill;
            pnConteudo.Location = new Point(315, 5);
            pnConteudo.Margin = new Padding(4, 5, 4, 5);
            pnConteudo.Name = "pnConteudo";
            pnConteudo.Padding = new Padding(14, 17, 14, 17);
            pnConteudo.Size = new Size(1240, 1040);
            pnConteudo.TabIndex = 1;
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
            btn3Ano.Location = new Point(507, 353);
            btn3Ano.Name = "btn3Ano";
            btn3Ano.Size = new Size(169, 60);
            btn3Ano.TabIndex = 15;
            btn3Ano.Text = "3º Ano";
            btn3Ano.UseVisualStyleBackColor = false;
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
            btn2Ano.Location = new Point(271, 353);
            btn2Ano.Name = "btn2Ano";
            btn2Ano.Size = new Size(169, 60);
            btn2Ano.TabIndex = 14;
            btn2Ano.Text = "2º Ano";
            btn2Ano.UseVisualStyleBackColor = false;
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
            btn1Ano.Location = new Point(27, 353);
            btn1Ano.Name = "btn1Ano";
            btn1Ano.Size = new Size(169, 60);
            btn1Ano.TabIndex = 13;
            btn1Ano.Text = "1º Ano";
            btn1Ano.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(pnAtrasos_dia, 1, 0);
            tableLayoutPanel3.Controls.Add(pnAtrasos_Totais, 0, 0);
            tableLayoutPanel3.Location = new Point(25, 112);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(958, 221);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // pnAtrasos_dia
            // 
            pnAtrasos_dia.BackColor = Color.FromArgb(168, 208, 240);
            pnAtrasos_dia.Controls.Add(pictureBox1);
            pnAtrasos_dia.Controls.Add(label3);
            pnAtrasos_dia.Controls.Add(label4);
            pnAtrasos_dia.Location = new Point(483, 3);
            pnAtrasos_dia.Margin = new Padding(4, 3, 4, 3);
            pnAtrasos_dia.Name = "pnAtrasos_dia";
            pnAtrasos_dia.Size = new Size(413, 215);
            pnAtrasos_dia.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(257, 22);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(52, 144, 220);
            label3.Location = new Point(24, 87);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 75);
            label3.TabIndex = 0;
            label3.Text = "00";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(168, 208, 240);
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(52, 144, 220);
            label4.Location = new Point(24, 22);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(165, 32);
            label4.TabIndex = 10;
            label4.Text = "Atrasos do dia";
            // 
            // pnAtrasos_Totais
            // 
            pnAtrasos_Totais.BackColor = Color.FromArgb(168, 230, 207);
            pnAtrasos_Totais.Controls.Add(lblDiario);
            pnAtrasos_Totais.Controls.Add(label2);
            pnAtrasos_Totais.Controls.Add(pictureBox3);
            pnAtrasos_Totais.Location = new Point(4, 3);
            pnAtrasos_Totais.Margin = new Padding(4, 3, 4, 3);
            pnAtrasos_Totais.Name = "pnAtrasos_Totais";
            pnAtrasos_Totais.Size = new Size(413, 215);
            pnAtrasos_Totais.TabIndex = 8;
            // 
            // lblDiario
            // 
            lblDiario.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiario.ForeColor = Color.FromArgb(45, 90, 61);
            lblDiario.Location = new Point(24, 85);
            lblDiario.Margin = new Padding(4, 0, 4, 0);
            lblDiario.Name = "lblDiario";
            lblDiario.Size = new Size(143, 77);
            lblDiario.TabIndex = 0;
            lblDiario.Text = "00";
            lblDiario.Click += lblDiario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(168, 230, 207);
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(45, 90, 61);
            label2.Location = new Point(24, 22);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 32);
            label2.TabIndex = 10;
            label2.Text = "Atrasos Totais";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(224, 22);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(121, 122);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
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
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(957, 22);
            btnExportar.Margin = new Padding(4, 5, 4, 5);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(170, 57);
            btnExportar.TabIndex = 11;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = false;
            // 
            // lblNmTurma
            // 
            lblNmTurma.AutoSize = true;
            lblNmTurma.Dock = DockStyle.Fill;
            lblNmTurma.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNmTurma.Location = new Point(14, 17);
            lblNmTurma.Margin = new Padding(4, 0, 4, 0);
            lblNmTurma.Name = "lblNmTurma";
            lblNmTurma.Size = new Size(237, 45);
            lblNmTurma.TabIndex = 2;
            lblNmTurma.Text = "Administração";
            lblNmTurma.TextAlign = ContentAlignment.MiddleLeft;
            lblNmTurma.Click += lblNmTurma_Click;
            // 
            // tlpConteudoPrincipal
            // 
            tlpConteudoPrincipal.ColumnCount = 2;
            tlpConteudoPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.7954559F));
            tlpConteudoPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.2045441F));
            tlpConteudoPrincipal.Controls.Add(pnAlunoAtrasos, 0, 0);
            tlpConteudoPrincipal.Controls.Add(pnGraficoTurma, 1, 0);
            tlpConteudoPrincipal.Dock = DockStyle.Bottom;
            tlpConteudoPrincipal.Location = new Point(14, 436);
            tlpConteudoPrincipal.Margin = new Padding(4, 5, 4, 5);
            tlpConteudoPrincipal.Name = "tlpConteudoPrincipal";
            tlpConteudoPrincipal.RowCount = 1;
            tlpConteudoPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpConteudoPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpConteudoPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpConteudoPrincipal.Size = new Size(1212, 587);
            tlpConteudoPrincipal.TabIndex = 0;
            // 
            // pnAlunoAtrasos
            // 
            pnAlunoAtrasos.BackColor = Color.White;
            pnAlunoAtrasos.Controls.Add(tbAtrasoTurma);
            pnAlunoAtrasos.Dock = DockStyle.Fill;
            pnAlunoAtrasos.Location = new Point(4, 3);
            pnAlunoAtrasos.Margin = new Padding(4, 3, 4, 3);
            pnAlunoAtrasos.Name = "pnAlunoAtrasos";
            pnAlunoAtrasos.Size = new Size(425, 581);
            pnAlunoAtrasos.TabIndex = 5;
            // 
            // tbAtrasoTurma
            // 
            tbAtrasoTurma.AllowUserToOrderColumns = true;
            tbAtrasoTurma.BackgroundColor = Color.White;
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
            tbAtrasoTurma.Margin = new Padding(4, 3, 4, 3);
            tbAtrasoTurma.Name = "tbAtrasoTurma";
            tbAtrasoTurma.ReadOnly = true;
            tbAtrasoTurma.RowHeadersWidth = 51;
            tbAtrasoTurma.Size = new Size(425, 581);
            tbAtrasoTurma.TabIndex = 0;
            tbAtrasoTurma.CellContentClick += tbAtrasoTurma_CellContentClick;
            // 
            // pnGraficoTurma
            // 
            pnGraficoTurma.BackColor = Color.White;
            pnGraficoTurma.Controls.Add(panel2);
            pnGraficoTurma.Controls.Add(panel1);
            pnGraficoTurma.Dock = DockStyle.Fill;
            pnGraficoTurma.Location = new Point(437, 3);
            pnGraficoTurma.Margin = new Padding(4, 3, 4, 3);
            pnGraficoTurma.Name = "pnGraficoTurma";
            pnGraficoTurma.Size = new Size(771, 581);
            pnGraficoTurma.TabIndex = 7;
            pnGraficoTurma.Paint += pnGraficoTurma_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSolicitarAdvertencia);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 493);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(771, 88);
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
            btnSolicitarAdvertencia.Location = new Point(23, 5);
            btnSolicitarAdvertencia.Margin = new Padding(4, 5, 4, 5);
            btnSolicitarAdvertencia.Name = "btnSolicitarAdvertencia";
            btnSolicitarAdvertencia.Size = new Size(214, 57);
            btnSolicitarAdvertencia.TabIndex = 0;
            btnSolicitarAdvertencia.Text = "Solicitar Advertencia";
            btnSolicitarAdvertencia.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblRM);
            panel1.Controls.Add(pictureBoxCarometro);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblNomeAluno);
            panel1.Controls.Add(lblTelAluno);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblEmailAluno);
            panel1.Controls.Add(lblAnoAluno);
            panel1.Controls.Add(arredondamentoBtn4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 493);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(108, 117, 125);
            label1.Location = new Point(293, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 32);
            label1.TabIndex = 13;
            label1.Text = "RM:";
            // 
            // lblRM
            // 
            lblRM.AutoSize = true;
            lblRM.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRM.ForeColor = Color.FromArgb(44, 62, 80);
            lblRM.Location = new Point(302, 67);
            lblRM.Margin = new Padding(4, 0, 4, 0);
            lblRM.Name = "lblRM";
            lblRM.Size = new Size(0, 32);
            lblRM.TabIndex = 12;
            // 
            // pictureBoxCarometro
            // 
            pictureBoxCarometro.Location = new Point(36, 46);
            pictureBoxCarometro.Margin = new Padding(4, 5, 4, 5);
            pictureBoxCarometro.Name = "pictureBoxCarometro";
            pictureBoxCarometro.Size = new Size(210, 308);
            pictureBoxCarometro.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCarometro.TabIndex = 3;
            pictureBoxCarometro.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(108, 117, 125);
            label8.Location = new Point(294, 111);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(85, 32);
            label8.TabIndex = 10;
            label8.Text = "Nome:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(108, 117, 125);
            label6.Location = new Point(295, 304);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 32);
            label6.TabIndex = 7;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(108, 117, 125);
            label7.Location = new Point(295, 399);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(62, 32);
            label7.TabIndex = 8;
            label7.Text = "Ano:";
            // 
            // lblNomeAluno
            // 
            lblNomeAluno.AutoSize = true;
            lblNomeAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeAluno.ForeColor = Color.FromArgb(44, 62, 80);
            lblNomeAluno.Location = new Point(298, 146);
            lblNomeAluno.Margin = new Padding(4, 0, 4, 0);
            lblNomeAluno.Name = "lblNomeAluno";
            lblNomeAluno.Size = new Size(0, 32);
            lblNomeAluno.TabIndex = 0;
            // 
            // lblTelAluno
            // 
            lblTelAluno.AutoSize = true;
            lblTelAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelAluno.ForeColor = Color.FromArgb(44, 62, 80);
            lblTelAluno.Location = new Point(298, 236);
            lblTelAluno.Margin = new Padding(4, 0, 4, 0);
            lblTelAluno.Name = "lblTelAluno";
            lblTelAluno.Size = new Size(0, 32);
            lblTelAluno.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(108, 117, 125);
            label5.Location = new Point(295, 201);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 32);
            label5.TabIndex = 6;
            label5.Text = "Telefone:";
            // 
            // lblEmailAluno
            // 
            lblEmailAluno.AutoSize = true;
            lblEmailAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailAluno.ForeColor = Color.FromArgb(44, 62, 80);
            lblEmailAluno.Location = new Point(297, 339);
            lblEmailAluno.Margin = new Padding(4, 0, 4, 0);
            lblEmailAluno.Name = "lblEmailAluno";
            lblEmailAluno.Size = new Size(0, 32);
            lblEmailAluno.TabIndex = 2;
            // 
            // lblAnoAluno
            // 
            lblAnoAluno.AutoSize = true;
            lblAnoAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnoAluno.ForeColor = Color.FromArgb(44, 62, 80);
            lblAnoAluno.Location = new Point(294, 434);
            lblAnoAluno.Margin = new Padding(4, 0, 4, 0);
            lblAnoAluno.Name = "lblAnoAluno";
            lblAnoAluno.Size = new Size(0, 32);
            lblAnoAluno.TabIndex = 4;
            // 
            // arredondamentoBtn4
            // 
            arredondamentoBtn4.BackColor = Color.MidnightBlue;
            arredondamentoBtn4.BorderColor = Color.Transparent;
            arredondamentoBtn4.BorderRadius = 10;
            arredondamentoBtn4.BorderSize = 0;
            arredondamentoBtn4.DisableHoverEffect = false;
            arredondamentoBtn4.FlatAppearance.BorderSize = 0;
            arredondamentoBtn4.FlatStyle = FlatStyle.Flat;
            arredondamentoBtn4.ForeColor = Color.White;
            arredondamentoBtn4.Location = new Point(23, 32);
            arredondamentoBtn4.Name = "arredondamentoBtn4";
            arredondamentoBtn4.Size = new Size(235, 335);
            arredondamentoBtn4.TabIndex = 11;
            arredondamentoBtn4.Text = "arredondamentoBtn4";
            arredondamentoBtn4.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 311F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(menuPrincipal1, 0, 0);
            tableLayoutPanel2.Controls.Add(pnConteudo, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1559, 1050);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // frmTurma
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1559, 1050);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmTurma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTurma";
            WindowState = FormWindowState.Maximized;
            pnConteudo.ResumeLayout(false);
            pnConteudo.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            pnAtrasos_dia.ResumeLayout(false);
            pnAtrasos_dia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnAtrasos_Totais.ResumeLayout(false);
            pnAtrasos_Totais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tlpConteudoPrincipal.ResumeLayout(false);
            pnAlunoAtrasos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbAtrasoTurma).EndInit();
            pnGraficoTurma.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCarometro).EndInit();
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
        private PictureBox pictureBoxCarometro;
        private Label label2;
        private Panel pnAtrasos_Totais;
        private PictureBox pictureBox3;
        private Panel pnAtrasos_dia;
        private PictureBox pictureBox1;
        private Label label3;
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
        private ArredondamentoBtn arredondamentoBtn4;
        private Label lblRM;
    }
}
