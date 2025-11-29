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
            label9 = new Label();
            label7 = new Label();
            btnVoltar = new ArredondamentoBtn();
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            arredondamentoCard1 = new CustomControls.ArredondamentoCard();
            label8 = new Label();
            arredondamentoCard2 = new CustomControls.ArredondamentoCard();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            arredondamentoCard1.SuspendLayout();
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
            btn_promover.Location = new Point(92, 420);
            btn_promover.Margin = new Padding(3, 2, 3, 2);
            btn_promover.Name = "btn_promover";
            btn_promover.Size = new Size(164, 38);
            btn_promover.TabIndex = 5;
            btn_promover.Text = "Promover";
            btn_promover.UseVisualStyleBackColor = false;
            btn_promover.Click += btn_promover_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(89, 177);
            label6.Name = "label6";
            label6.Size = new Size(384, 20);
            label6.TabIndex = 4;
            label6.Text = "Em caso de retenção, selecione abaixo o(s) aluno(s) que ";
            // 
            // panel5
            // 
            panel5.Controls.Add(clbAlunos);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(86, 239);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(463, 164);
            panel5.TabIndex = 3;
            // 
            // clbAlunos
            // 
            clbAlunos.Enabled = false;
            clbAlunos.FormattingEnabled = true;
            clbAlunos.Location = new Point(6, 25);
            clbAlunos.Margin = new Padding(3, 2, 3, 2);
            clbAlunos.Name = "clbAlunos";
            clbAlunos.Size = new Size(447, 130);
            clbAlunos.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 2;
            label5.Text = "Selecione os alunos:";
            // 
            // cbmSerie
            // 
            cbmSerie.FormattingEnabled = true;
            cbmSerie.Location = new Point(261, 20);
            cbmSerie.Margin = new Padding(3, 2, 3, 2);
            cbmSerie.Name = "cbmSerie";
            cbmSerie.Size = new Size(192, 23);
            cbmSerie.TabIndex = 2;
            cbmSerie.SelectedIndexChanged += cbmSerie_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 2);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 0;
            label3.Text = "Série:";
            // 
            // panel3
            // 
            panel3.Controls.Add(cbmSerie);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(cbmCurso);
            panel3.Location = new Point(86, 109);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(463, 49);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 2);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 1;
            label4.Text = "Curso:";
            // 
            // cbmCurso
            // 
            cbmCurso.FormattingEnabled = true;
            cbmCurso.Location = new Point(6, 20);
            cbmCurso.Margin = new Padding(3, 2, 3, 2);
            cbmCurso.Name = "cbmCurso";
            cbmCurso.Size = new Size(209, 23);
            cbmCurso.TabIndex = 1;
            cbmCurso.SelectedIndexChanged += cbmCurso_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(119, 70);
            label2.Name = "label2";
            label2.Size = new Size(404, 20);
            label2.TabIndex = 1;
            label2.Text = "Preencha abaixo as informações para promover uma turma.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(230, 25);
            label1.Name = "label1";
            label1.Size = new Size(172, 30);
            label1.TabIndex = 0;
            label1.Text = "Promover Alunos";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.GhostWhite;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btn_promover);
            panel2.Controls.Add(btnVoltar);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(260, 1);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(609, 535);
            panel2.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(89, 199);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 9;
            label9.Text = "promovidos.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(464, 177);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 8;
            label7.Text = " não serão ";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.MidnightBlue;
            btnVoltar.BorderColor = Color.Transparent;
            btnVoltar.BorderRadius = 10;
            btnVoltar.BorderSize = 0;
            btnVoltar.DisableHoverEffect = false;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(464, 467);
            btnVoltar.Margin = new Padding(3, 2, 3, 2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 38);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Location = new Point(-34, -14);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 565);
            panel1.TabIndex = 9;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Lavender;
            richTextBox1.Font = new Font("Segoe UI", 9F);
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.Location = new Point(15, 55);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(210, 96);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "Este formulário é utilizado para realizar a passagem de ano (promoção) de turmas inteiras, permitindo a marcação dos alunos que foram retidos.";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // arredondamentoCard1
            // 
            arredondamentoCard1.BackColor = Color.Lavender;
            arredondamentoCard1.BorderColor = Color.Transparent;
            arredondamentoCard1.BorderRadius = 10;
            arredondamentoCard1.BorderSize = 0;
            arredondamentoCard1.Controls.Add(label8);
            arredondamentoCard1.Controls.Add(richTextBox1);
            arredondamentoCard1.Location = new Point(46, 75);
            arredondamentoCard1.Name = "arredondamentoCard1";
            arredondamentoCard1.Size = new Size(238, 170);
            arredondamentoCard1.TabIndex = 59;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(27, 22);
            label8.Name = "label8";
            label8.Size = new Size(181, 21);
            label8.TabIndex = 9;
            label8.Text = "Orientação importante!";
            // 
            // arredondamentoCard2
            // 
            arredondamentoCard2.BackColor = Color.MidnightBlue;
            arredondamentoCard2.BorderColor = Color.Transparent;
            arredondamentoCard2.BorderRadius = 10;
            arredondamentoCard2.BorderSize = 0;
            arredondamentoCard2.Location = new Point(48, 85);
            arredondamentoCard2.Name = "arredondamentoCard2";
            arredondamentoCard2.Size = new Size(244, 167);
            arredondamentoCard2.TabIndex = 60;
            // 
            // frmPromoverAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(868, 538);
            Controls.Add(arredondamentoCard1);
            Controls.Add(arredondamentoCard2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
            arredondamentoCard1.ResumeLayout(false);
            arredondamentoCard1.PerformLayout();
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
        private CheckedListBox clbAlunos;
        private ArredondamentoBtn btnVoltar;
        private Label label7;
        private RichTextBox richTextBox1;
        private CustomControls.ArredondamentoCard arredondamentoCard1;
        private Label label9;
        private Label label8;
        private CustomControls.ArredondamentoCard arredondamentoCard2;
    }
}