namespace Dashboard
{
    partial class frmPromoverAlunos
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
            btn_promover = new ArredondamentoBtn();
            label6 = new Label();
            panel5 = new Panel();
            clbAlunos = new CheckedListBox();
            label5 = new Label();
            cbmSerie = new ComboBox();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            cbmCurso = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pnLine = new Panel();
            panel1 = new Panel();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            btnVoltar = new ArredondamentoBtn();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_promover
            // 
            btn_promover.BackColor = Color.MidnightBlue;
            btn_promover.BorderColor = Color.Transparent;
            btn_promover.BorderRadius = 10;
            btn_promover.BorderSize = 0;
            btn_promover.DisableHoverEffect = false;
            btn_promover.FlatAppearance.BorderSize = 0;
            btn_promover.FlatStyle = FlatStyle.Flat;
            btn_promover.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_promover.ForeColor = Color.White;
            btn_promover.Location = new Point(286, 536);
            btn_promover.Name = "btn_promover";
            btn_promover.Size = new Size(188, 50);
            btn_promover.TabIndex = 5;
            btn_promover.Text = "Promover";
            btn_promover.UseVisualStyleBackColor = false;
            btn_promover.Click += btn_promover_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(34, 243);
            label6.Name = "label6";
            label6.Size = new Size(678, 25);
            label6.TabIndex = 4;
            label6.Text = "Em caso de retenção, selecione abaixo o(s) aluno(s) que não serão promovidos.";
            // 
            // panel5
            // 
            panel5.Controls.Add(clbAlunos);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(110, 285);
            panel5.Name = "panel5";
            panel5.Size = new Size(518, 218);
            panel5.TabIndex = 3;
            // 
            // clbAlunos
            // 
            clbAlunos.Enabled = false;
            clbAlunos.FormattingEnabled = true;
            clbAlunos.Location = new Point(28, 30);
            clbAlunos.Name = "clbAlunos";
            clbAlunos.Size = new Size(454, 180);
            clbAlunos.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 4);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 2;
            label5.Text = "Selecione os alunos:";
            // 
            // cbmSerie
            // 
            cbmSerie.FormattingEnabled = true;
            cbmSerie.Location = new Point(310, 26);
            cbmSerie.Name = "cbmSerie";
            cbmSerie.Size = new Size(172, 28);
            cbmSerie.TabIndex = 2;
            cbmSerie.SelectedIndexChanged += cbmSerie_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 3);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 0;
            label3.Text = "Série:";
            // 
            // panel3
            // 
            panel3.Controls.Add(cbmSerie);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(cbmCurso);
            panel3.Location = new Point(110, 145);
            panel3.Name = "panel3";
            panel3.Size = new Size(518, 65);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 2);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 1;
            label4.Text = "Curso:";
            // 
            // cbmCurso
            // 
            cbmCurso.FormattingEnabled = true;
            cbmCurso.Location = new Point(19, 26);
            cbmCurso.Name = "cbmCurso";
            cbmCurso.Size = new Size(238, 28);
            cbmCurso.TabIndex = 1;
            cbmCurso.SelectedIndexChanged += cbmCurso_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(110, 92);
            label2.Name = "label2";
            label2.Size = new Size(515, 25);
            label2.TabIndex = 1;
            label2.Text = "Preencha abaixo as informações para promover uma turma.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(274, 43);
            label1.Name = "label1";
            label1.Size = new Size(217, 37);
            label1.TabIndex = 0;
            label1.Text = "Promover alunos";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.GhostWhite;
            panel2.Controls.Add(pnLine);
            panel2.Controls.Add(btn_promover);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(305, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(727, 609);
            panel2.TabIndex = 10;
            // 
            // pnLine
            // 
            pnLine.BackColor = Color.MidnightBlue;
            pnLine.Location = new Point(514, 264);
            pnLine.Name = "pnLine";
            pnLine.Size = new Size(191, 3);
            pnLine.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnVoltar);
            panel1.Location = new Point(-39, -19);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 648);
            panel1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MidnightBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.WhiteSmoke;
            textBox1.Location = new Point(53, 218);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(275, 132);
            textBox1.TabIndex = 13;
            textBox1.Text = "Este formulário é utilizado para realizar a passagem de ano (promoção) de turmas inteiras, permitindo a marcação dos alunos que foram retidos.";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO1;
            pictureBox1.Location = new Point(72, 54);
            pictureBox1.Margin = new Padding(3, 1, 3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.GhostWhite;
            btnVoltar.BorderColor = Color.Transparent;
            btnVoltar.BorderRadius = 10;
            btnVoltar.BorderSize = 0;
            btnVoltar.DisableHoverEffect = false;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.MidnightBlue;
            btnVoltar.Location = new Point(95, 556);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(188, 50);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmPromoverAlunos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 613);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPromoverAlunos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPromoverAlunos";
            Load += frmPromoverAlunos_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ArredondamentoBtn btn_promover;
        private Label label6;
        private Panel panel5;
        private Label label5;
        private ComboBox cbmSerie;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private ComboBox cbmCurso;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Panel pnLine;
        private CheckedListBox clbAlunos;
        private ArredondamentoBtn btnVoltar;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}