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
            tlpConteudoPrincipal = new TableLayoutPanel();
            lblNmTurma = new Label();
            btnExportar = new ArredondamentoBtn();
            pnAtrasos_Totais = new Panel();
            lblDiario = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pnAtrasos_dia = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            pnAlunoAtrasos = new Panel();
            tbAtrasoTurma = new DataGridView();
            pnGraficoTurma = new Panel();
            panel2 = new Panel();
            btnSolicitarAdvertencia = new ArredondamentoBtn();
            panel1 = new Panel();
            pictureBoxCarometro = new PictureBox();
            button1 = new Button();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblNomeAluno = new Label();
            lblTelAluno = new Label();
            label5 = new Label();
            lblEmailAluno = new Label();
            lblAnoAluno = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            pnConteudo.SuspendLayout();
            tlpConteudoPrincipal.SuspendLayout();
            pnAtrasos_Totais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnAtrasos_dia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            menuPrincipal1.Size = new Size(200, 490);
            menuPrincipal1.TabIndex = 6;
            // 
            // pnConteudo
            // 
            pnConteudo.Controls.Add(tlpConteudoPrincipal);
            pnConteudo.Dock = DockStyle.Fill;
            pnConteudo.Location = new Point(203, 3);
            pnConteudo.Name = "pnConteudo";
            pnConteudo.Padding = new Padding(10);
            pnConteudo.Size = new Size(615, 484);
            pnConteudo.TabIndex = 1;
            // 
            // tlpConteudoPrincipal
            // 
            tlpConteudoPrincipal.ColumnCount = 2;
            tlpConteudoPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpConteudoPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tlpConteudoPrincipal.Controls.Add(lblNmTurma, 0, 0);
            tlpConteudoPrincipal.Controls.Add(btnExportar, 1, 0);
            tlpConteudoPrincipal.Controls.Add(pnAtrasos_Totais, 0, 1);
            tlpConteudoPrincipal.Controls.Add(pnAtrasos_dia, 1, 1);
            tlpConteudoPrincipal.Controls.Add(pnAlunoAtrasos, 0, 2);
            tlpConteudoPrincipal.Controls.Add(pnGraficoTurma, 1, 2);
            tlpConteudoPrincipal.Dock = DockStyle.Fill;
            tlpConteudoPrincipal.Location = new Point(10, 10);
            tlpConteudoPrincipal.Name = "tlpConteudoPrincipal";
            tlpConteudoPrincipal.RowCount = 3;
            tlpConteudoPrincipal.RowStyles.Add(new RowStyle());
            tlpConteudoPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tlpConteudoPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpConteudoPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpConteudoPrincipal.Size = new Size(595, 464);
            tlpConteudoPrincipal.TabIndex = 0;
            // 
            // lblNmTurma
            // 
            lblNmTurma.AutoSize = true;
            lblNmTurma.Dock = DockStyle.Fill;
            lblNmTurma.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNmTurma.Location = new Point(3, 0);
            lblNmTurma.Name = "lblNmTurma";
            lblNmTurma.Size = new Size(261, 40);
            lblNmTurma.TabIndex = 2;
            lblNmTurma.Text = "Administração";
            lblNmTurma.TextAlign = ContentAlignment.MiddleLeft;
            lblNmTurma.Click += lblNmTurma_Click;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportar.BackColor = Color.MidnightBlue;
            btnExportar.BorderColor = Color.Transparent;
            btnExportar.BorderRadius = 10;
            btnExportar.BorderSize = 0;
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(473, 3);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(119, 34);
            btnExportar.TabIndex = 11;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = false;
            // 
            // pnAtrasos_Totais
            // 
            pnAtrasos_Totais.BackColor = Color.FromArgb(168, 230, 207);
            pnAtrasos_Totais.Controls.Add(lblDiario);
            pnAtrasos_Totais.Controls.Add(label2);
            pnAtrasos_Totais.Controls.Add(pictureBox3);
            pnAtrasos_Totais.Dock = DockStyle.Fill;
            pnAtrasos_Totais.Location = new Point(3, 42);
            pnAtrasos_Totais.Margin = new Padding(3, 2, 3, 2);
            pnAtrasos_Totais.Name = "pnAtrasos_Totais";
            pnAtrasos_Totais.Size = new Size(261, 116);
            pnAtrasos_Totais.TabIndex = 8;
            // 
            // lblDiario
            // 
            lblDiario.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiario.ForeColor = Color.FromArgb(45, 90, 61);
            lblDiario.Location = new Point(17, 52);
            lblDiario.Name = "lblDiario";
            lblDiario.Size = new Size(100, 23);
            lblDiario.TabIndex = 0;
            lblDiario.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(168, 230, 207);
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(45, 90, 61);
            label2.Location = new Point(17, 13);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 10;
            label2.Text = "Atrasos Totais";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(157, 13);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(85, 73);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pnAtrasos_dia
            // 
            pnAtrasos_dia.BackColor = Color.FromArgb(168, 208, 240);
            pnAtrasos_dia.Controls.Add(pictureBox1);
            pnAtrasos_dia.Controls.Add(label3);
            pnAtrasos_dia.Controls.Add(label4);
            pnAtrasos_dia.Dock = DockStyle.Fill;
            pnAtrasos_dia.Location = new Point(270, 42);
            pnAtrasos_dia.Margin = new Padding(3, 2, 3, 2);
            pnAtrasos_dia.Name = "pnAtrasos_dia";
            pnAtrasos_dia.Size = new Size(322, 116);
            pnAtrasos_dia.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(180, 13);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(52, 144, 220);
            label3.Location = new Point(17, 52);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            label3.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(168, 208, 240);
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(52, 144, 220);
            label4.Location = new Point(17, 13);
            label4.Name = "label4";
            label4.Size = new Size(109, 21);
            label4.TabIndex = 10;
            label4.Text = "Atrasos do dia";
            // 
            // pnAlunoAtrasos
            // 
            pnAlunoAtrasos.BackColor = Color.White;
            pnAlunoAtrasos.Controls.Add(tbAtrasoTurma);
            pnAlunoAtrasos.Dock = DockStyle.Fill;
            pnAlunoAtrasos.Location = new Point(3, 162);
            pnAlunoAtrasos.Margin = new Padding(3, 2, 3, 2);
            pnAlunoAtrasos.Name = "pnAlunoAtrasos";
            pnAlunoAtrasos.Size = new Size(261, 300);
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
            tbAtrasoTurma.Margin = new Padding(3, 2, 3, 2);
            tbAtrasoTurma.Name = "tbAtrasoTurma";
            tbAtrasoTurma.ReadOnly = true;
            tbAtrasoTurma.RowHeadersWidth = 51;
            tbAtrasoTurma.Size = new Size(261, 300);
            tbAtrasoTurma.TabIndex = 0;
            tbAtrasoTurma.CellContentClick += tbAtrasoTurma_CellContentClick;
            // 
            // pnGraficoTurma
            // 
            pnGraficoTurma.BackColor = Color.White;
            pnGraficoTurma.Controls.Add(panel2);
            pnGraficoTurma.Controls.Add(panel1);
            pnGraficoTurma.Dock = DockStyle.Fill;
            pnGraficoTurma.Location = new Point(270, 162);
            pnGraficoTurma.Margin = new Padding(3, 2, 3, 2);
            pnGraficoTurma.Name = "pnGraficoTurma";
            pnGraficoTurma.Size = new Size(322, 300);
            pnGraficoTurma.TabIndex = 7;
            pnGraficoTurma.Paint += pnGraficoTurma_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSolicitarAdvertencia);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 245);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 55);
            panel2.TabIndex = 12;
            // 
            // btnSolicitarAdvertencia
            // 
            btnSolicitarAdvertencia.BackColor = Color.MidnightBlue;
            btnSolicitarAdvertencia.BorderColor = Color.Transparent;
            btnSolicitarAdvertencia.BorderRadius = 10;
            btnSolicitarAdvertencia.BorderSize = 0;
            btnSolicitarAdvertencia.FlatAppearance.BorderSize = 0;
            btnSolicitarAdvertencia.FlatStyle = FlatStyle.Flat;
            btnSolicitarAdvertencia.ForeColor = Color.White;
            btnSolicitarAdvertencia.Location = new Point(16, 3);
            btnSolicitarAdvertencia.Name = "btnSolicitarAdvertencia";
            btnSolicitarAdvertencia.Size = new Size(150, 34);
            btnSolicitarAdvertencia.TabIndex = 0;
            btnSolicitarAdvertencia.Text = "Solicitar Advertencia";
            btnSolicitarAdvertencia.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBoxCarometro);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblNomeAluno);
            panel1.Controls.Add(lblTelAluno);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblEmailAluno);
            panel1.Controls.Add(lblAnoAluno);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 245);
            panel1.TabIndex = 11;
            // 
            // pictureBoxCarometro
            // 
            pictureBoxCarometro.Location = new Point(23, 26);
            pictureBoxCarometro.Name = "pictureBoxCarometro";
            pictureBoxCarometro.Size = new Size(136, 185);
            pictureBoxCarometro.TabIndex = 3;
            pictureBoxCarometro.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(16, 19);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(150, 201);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(108, 117, 125);
            label8.Location = new Point(197, 19);
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
            label6.Location = new Point(197, 135);
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
            label7.Location = new Point(197, 192);
            label7.Name = "label7";
            label7.Size = new Size(41, 21);
            label7.TabIndex = 8;
            label7.Text = "Ano:";
            // 
            // lblNomeAluno
            // 
            lblNomeAluno.AutoSize = true;
            lblNomeAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeAluno.ForeColor = Color.FromArgb(44, 62, 80);
            lblNomeAluno.Location = new Point(199, 40);
            lblNomeAluno.Name = "lblNomeAluno";
            lblNomeAluno.Size = new Size(0, 21);
            lblNomeAluno.TabIndex = 0;
            // 
            // lblTelAluno
            // 
            lblTelAluno.AutoSize = true;
            lblTelAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelAluno.ForeColor = Color.FromArgb(44, 62, 80);
            lblTelAluno.Location = new Point(199, 94);
            lblTelAluno.Name = "lblTelAluno";
            lblTelAluno.Size = new Size(0, 21);
            lblTelAluno.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(108, 117, 125);
            label5.Location = new Point(197, 73);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 6;
            label5.Text = "Telefone:";
            // 
            // lblEmailAluno
            // 
            lblEmailAluno.AutoSize = true;
            lblEmailAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailAluno.ForeColor = Color.FromArgb(44, 62, 80);
            lblEmailAluno.Location = new Point(198, 156);
            lblEmailAluno.Name = "lblEmailAluno";
            lblEmailAluno.Size = new Size(0, 21);
            lblEmailAluno.TabIndex = 2;
            // 
            // lblAnoAluno
            // 
            lblAnoAluno.AutoSize = true;
            lblAnoAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnoAluno.ForeColor = Color.FromArgb(44, 62, 80);
            lblAnoAluno.Location = new Point(196, 213);
            lblAnoAluno.Name = "lblAnoAluno";
            lblAnoAluno.Size = new Size(0, 21);
            lblAnoAluno.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(menuPrincipal1, 0, 0);
            tableLayoutPanel2.Controls.Add(pnConteudo, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(821, 490);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // frmTurma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 490);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTurma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTurma";
            WindowState = FormWindowState.Maximized;
            pnConteudo.ResumeLayout(false);
            tlpConteudoPrincipal.ResumeLayout(false);
            tlpConteudoPrincipal.PerformLayout();
            pnAtrasos_Totais.ResumeLayout(false);
            pnAtrasos_Totais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnAtrasos_dia.ResumeLayout(false);
            pnAtrasos_dia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button button1;
        private ArredondamentoBtn btnSolicitarAdvertencia;
        private ArredondamentoBtn btnExportar;
        private TableLayoutPanel tableLayoutPanel2;
        private MenuPrincipal menuPrincipal1;
        private Panel pnConteudo;
    }
}
