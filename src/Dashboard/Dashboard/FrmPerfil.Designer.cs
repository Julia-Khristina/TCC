namespace Dashboard
{
    partial class FrmPerfil
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
            lblnm = new Label();
            label1 = new Label();
            pnConteudo = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAddAuxiliar = new ArredondamentoBtn();
            btnAddAluno = new ArredondamentoBtn();
            panel5 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuPrincipal1 = new MenuPrincipal();
            pnConteudo.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblnm
            // 
            lblnm.AutoSize = true;
            lblnm.Dock = DockStyle.Bottom;
            lblnm.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnm.Location = new Point(211, 103);
            lblnm.Name = "lblnm";
            lblnm.Size = new Size(202, 30);
            lblnm.TabIndex = 17;
            lblnm.Text = "Nome";
            lblnm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 133);
            label1.Name = "label1";
            label1.Size = new Size(202, 21);
            label1.TabIndex = 18;
            label1.Text = "Função exercida";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pnConteudo
            // 
            pnConteudo.Controls.Add(tableLayoutPanel2);
            pnConteudo.Controls.Add(panel5);
            pnConteudo.Dock = DockStyle.Fill;
            pnConteudo.Location = new Point(203, 3);
            pnConteudo.Name = "pnConteudo";
            pnConteudo.Size = new Size(626, 427);
            pnConteudo.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.9952049F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.0047951F));
            tableLayoutPanel2.Controls.Add(btnAddAuxiliar, 0, 0);
            tableLayoutPanel2.Controls.Add(btnAddAluno, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 236);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(626, 191);
            tableLayoutPanel2.TabIndex = 20;
            // 
            // btnAddAuxiliar
            // 
            btnAddAuxiliar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddAuxiliar.BackColor = Color.MidnightBlue;
            btnAddAuxiliar.BorderColor = Color.Transparent;
            btnAddAuxiliar.BorderRadius = 10;
            btnAddAuxiliar.BorderSize = 0;
            btnAddAuxiliar.FlatAppearance.BorderSize = 0;
            btnAddAuxiliar.FlatStyle = FlatStyle.Flat;
            btnAddAuxiliar.ForeColor = Color.White;
            btnAddAuxiliar.Location = new Point(153, 3);
            btnAddAuxiliar.Name = "btnAddAuxiliar";
            btnAddAuxiliar.Size = new Size(150, 40);
            btnAddAuxiliar.TabIndex = 19;
            btnAddAuxiliar.Text = "Adicionar Auxiliar";
            btnAddAuxiliar.UseVisualStyleBackColor = false;
            // 
            // btnAddAluno
            // 
            btnAddAluno.BackColor = Color.MidnightBlue;
            btnAddAluno.BorderColor = Color.Transparent;
            btnAddAluno.BorderRadius = 10;
            btnAddAluno.BorderSize = 0;
            btnAddAluno.FlatAppearance.BorderSize = 0;
            btnAddAluno.FlatStyle = FlatStyle.Flat;
            btnAddAluno.ForeColor = Color.White;
            btnAddAluno.Location = new Point(309, 3);
            btnAddAluno.Name = "btnAddAluno";
            btnAddAluno.Size = new Size(149, 40);
            btnAddAluno.TabIndex = 19;
            btnAddAluno.Text = "Adicionar Aluno";
            btnAddAluno.UseVisualStyleBackColor = false;
            btnAddAluno.Click += btnAddAluno_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(tableLayoutPanel3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(626, 236);
            panel5.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(lblnm, 1, 0);
            tableLayoutPanel3.Controls.Add(label1, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 103F));
            tableLayoutPanel3.Size = new Size(626, 236);
            tableLayoutPanel3.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(menuPrincipal1, 0, 0);
            tableLayoutPanel1.Controls.Add(pnConteudo, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(832, 433);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // menuPrincipal1
            // 
            menuPrincipal1.Dock = DockStyle.Fill;
            menuPrincipal1.Location = new Point(0, 0);
            menuPrincipal1.Margin = new Padding(0);
            menuPrincipal1.Name = "menuPrincipal1";
            menuPrincipal1.Size = new Size(200, 433);
            menuPrincipal1.TabIndex = 6;
            // 
            // FrmPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 433);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1, 2, 1, 2);
            Name = "FrmPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRelatorio";
            WindowState = FormWindowState.Maximized;
            pnConteudo.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblnm;
        private Label label1;
        private Panel pnConteudo;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel1;
        private MenuPrincipal menuPrincipal1;
        private ArredondamentoBtn btnAddAuxiliar;
        private ArredondamentoBtn btnAddAluno;
        private TableLayoutPanel tableLayoutPanel3;
    }
}