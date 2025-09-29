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
            label1 = new Label();
            Painel_Grafico = new Panel();
            pictureBox3 = new PictureBox();
            lblDescricao_Notificacao = new Label();
            lblTitulo_Notificacao = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnConteudo = new Panel();
            menuPrincipal2 = new MenuPrincipal();
            Painel_Grafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            pnConteudo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 39);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 2;
            label1.Text = "Notificação";
            label1.Click += label1_Click;
            // 
            // Painel_Grafico
            // 
            Painel_Grafico.BackColor = SystemColors.ButtonHighlight;
            Painel_Grafico.Controls.Add(pictureBox3);
            Painel_Grafico.Controls.Add(lblDescricao_Notificacao);
            Painel_Grafico.Controls.Add(lblTitulo_Notificacao);
            Painel_Grafico.Location = new Point(20, 80);
            Painel_Grafico.Margin = new Padding(3, 1, 3, 1);
            Painel_Grafico.Name = "Painel_Grafico";
            Painel_Grafico.Size = new Size(522, 54);
            Painel_Grafico.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(591, 13);
            pictureBox3.Margin = new Padding(3, 1, 3, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // lblDescricao_Notificacao
            // 
            lblDescricao_Notificacao.AutoSize = true;
            lblDescricao_Notificacao.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao_Notificacao.Location = new Point(17, 28);
            lblDescricao_Notificacao.Name = "lblDescricao_Notificacao";
            lblDescricao_Notificacao.Size = new Size(407, 15);
            lblDescricao_Notificacao.TabIndex = 4;
            lblDescricao_Notificacao.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
            // 
            // lblTitulo_Notificacao
            // 
            lblTitulo_Notificacao.AutoSize = true;
            lblTitulo_Notificacao.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo_Notificacao.Location = new Point(15, 6);
            lblTitulo_Notificacao.Name = "lblTitulo_Notificacao";
            lblTitulo_Notificacao.Size = new Size(149, 20);
            lblTitulo_Notificacao.TabIndex = 3;
            lblTitulo_Notificacao.Text = "Título da Notificação";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pnConteudo, 1, 0);
            tableLayoutPanel1.Controls.Add(menuPrincipal2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(832, 433);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // pnConteudo
            // 
            pnConteudo.Controls.Add(label1);
            pnConteudo.Controls.Add(Painel_Grafico);
            pnConteudo.Dock = DockStyle.Fill;
            pnConteudo.Location = new Point(200, 0);
            pnConteudo.Margin = new Padding(0);
            pnConteudo.Name = "pnConteudo";
            pnConteudo.Size = new Size(632, 433);
            pnConteudo.TabIndex = 7;
            // 
            // menuPrincipal2
            // 
            menuPrincipal2.Dock = DockStyle.Fill; // <-- ADICIONE ESTA LINHA
            menuPrincipal2.Location = new Point(0, 0); // O Dock controla a posição, pode zerar
            menuPrincipal2.Margin = new Padding(0); // Remove margens
            menuPrincipal2.Name = "menuPrincipal1";
            // menuPrincipal1.Size = new Size(197, 427); // REMOVA ou comente esta linha
            menuPrincipal2.TabIndex = 6;
            // 
            // frmNotificacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 433);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1);
            Name = "frmNotificacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNotificacao";
            WindowState = FormWindowState.Maximized;
            Load += frmNotificacao_Load;
            Painel_Grafico.ResumeLayout(false);
            Painel_Grafico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            pnConteudo.ResumeLayout(false);
            pnConteudo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel Painel_Grafico;
        private Label lblTitulo_Notificacao;
        private Label lblDescricao_Notificacao;
        private PictureBox pictureBox3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnConteudo;
        private MenuPrincipal menuPrincipal2;
    }
}