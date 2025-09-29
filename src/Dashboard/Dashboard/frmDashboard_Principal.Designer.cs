
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard_Principal));
            label1 = new Label();
            Painel_Diário = new Panel();
            lblDiario = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            Painel_Semanal = new Panel();
            pictureBox4 = new PictureBox();
            lblSemanal = new Label();
            label5 = new Label();
            Painel_Mensal = new Panel();
            pictureBox5 = new PictureBox();
            lblMensal = new Label();
            label7 = new Label();
            flowLayoutPanelReports = new FlowLayoutPanel();
            label3 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            imageListMenu = new ImageList(components);
            lblFalsoComboBox = new Label();
            pnConteudo = new Panel();
            tableLayoutPanelCards = new TableLayoutPanel();
            panelWelcome = new Panel();
            BtnWelcome = new ArredondamentoBtn();
            arredondamentoBtn1 = new ArredondamentoBtn();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuPrincipal2 = new MenuPrincipal();
            Painel_Diário.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Painel_Semanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            Painel_Mensal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            pnConteudo.SuspendLayout();
            tableLayoutPanelCards.SuspendLayout();
            panelWelcome.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 53);
            label1.Name = "label1";
            label1.Size = new Size(199, 29);
            label1.TabIndex = 1;
            label1.Text = "Relatório Geral";
            // 
            // Painel_Diário
            // 
            Painel_Diário.BackColor = Color.FromArgb(136, 170, 238);
            Painel_Diário.Controls.Add(lblDiario);
            Painel_Diário.Controls.Add(label2);
            Painel_Diário.Controls.Add(pictureBox3);
            Painel_Diário.Dock = DockStyle.Fill;
            Painel_Diário.Location = new Point(3, 4);
            Painel_Diário.Margin = new Padding(3, 4, 17, 4);
            Painel_Diário.Name = "Painel_Diário";
            Painel_Diário.Size = new Size(225, 168);
            Painel_Diário.TabIndex = 2;
            // 
            // lblDiario
            // 
            lblDiario.AutoSize = true;
            lblDiario.BackColor = Color.FromArgb(136, 170, 238);
            lblDiario.Enabled = false;
            lblDiario.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiario.ForeColor = SystemColors.ActiveCaptionText;
            lblDiario.Location = new Point(23, 64);
            lblDiario.Name = "lblDiario";
            lblDiario.Size = new Size(75, 60);
            lblDiario.TabIndex = 11;
            lblDiario.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(136, 170, 238);
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(26, 31);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 10;
            label2.Text = "Diário";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(113, 36);
            pictureBox3.Margin = new Padding(3, 1, 3, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(87, 91);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // Painel_Semanal
            // 
            Painel_Semanal.BackColor = Color.FromArgb(255, 232, 164);
            Painel_Semanal.Controls.Add(pictureBox4);
            Painel_Semanal.Controls.Add(lblSemanal);
            Painel_Semanal.Controls.Add(label5);
            Painel_Semanal.Dock = DockStyle.Fill;
            Painel_Semanal.Location = new Point(262, 4);
            Painel_Semanal.Margin = new Padding(17, 4, 17, 4);
            Painel_Semanal.Name = "Painel_Semanal";
            Painel_Semanal.Size = new Size(211, 168);
            Painel_Semanal.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(106, 36);
            pictureBox4.Margin = new Padding(3, 1, 3, 1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(87, 91);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // lblSemanal
            // 
            lblSemanal.AutoSize = true;
            lblSemanal.BackColor = Color.FromArgb(255, 232, 164);
            lblSemanal.Enabled = false;
            lblSemanal.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSemanal.ForeColor = SystemColors.ActiveCaptionText;
            lblSemanal.Location = new Point(21, 61);
            lblSemanal.Name = "lblSemanal";
            lblSemanal.Size = new Size(75, 60);
            lblSemanal.TabIndex = 14;
            lblSemanal.Text = "00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 232, 164);
            label5.Enabled = false;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(16, 31);
            label5.Name = "label5";
            label5.Size = new Size(86, 28);
            label5.TabIndex = 13;
            label5.Text = "Semanal";
            // 
            // Painel_Mensal
            // 
            Painel_Mensal.BackColor = Color.FromArgb(238, 136, 136);
            Painel_Mensal.Controls.Add(pictureBox5);
            Painel_Mensal.Controls.Add(lblMensal);
            Painel_Mensal.Controls.Add(label7);
            Painel_Mensal.Controls.Add(flowLayoutPanelReports);
            Painel_Mensal.Dock = DockStyle.Fill;
            Painel_Mensal.Location = new Point(507, 4);
            Painel_Mensal.Margin = new Padding(17, 4, 3, 4);
            Painel_Mensal.Name = "Painel_Mensal";
            Painel_Mensal.Size = new Size(226, 168);
            Painel_Mensal.TabIndex = 3;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(123, 33);
            pictureBox5.Margin = new Padding(3, 1, 3, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(87, 91);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // lblMensal
            // 
            lblMensal.AutoSize = true;
            lblMensal.BackColor = Color.FromArgb(238, 136, 136);
            lblMensal.Enabled = false;
            lblMensal.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensal.ForeColor = SystemColors.ActiveCaptionText;
            lblMensal.Location = new Point(31, 61);
            lblMensal.Name = "lblMensal";
            lblMensal.Size = new Size(75, 60);
            lblMensal.TabIndex = 17;
            lblMensal.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(238, 136, 136);
            label7.Enabled = false;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(31, 33);
            label7.Name = "label7";
            label7.Size = new Size(74, 28);
            label7.TabIndex = 16;
            label7.Text = "Mensal";
            // 
            // flowLayoutPanelReports
            // 
            flowLayoutPanelReports.Location = new Point(0, 0);
            flowLayoutPanelReports.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelReports.Name = "flowLayoutPanelReports";
            flowLayoutPanelReports.Size = new Size(229, 133);
            flowLayoutPanelReports.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Mongolian Baiti", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(234, 52);
            label3.Name = "label3";
            label3.Size = new Size(262, 25);
            label3.TabIndex = 4;
            label3.Text = "Bem-vindo ao Pontualize!";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.WhiteSmoke;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 107);
            label6.Name = "label6";
            label6.Size = new Size(699, 80);
            label6.TabIndex = 8;
            label6.Text = resources.GetString("label6.Text");
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // imageListMenu
            // 
            imageListMenu.ColorDepth = ColorDepth.Depth32Bit;
            imageListMenu.ImageStream = (ImageListStreamer)resources.GetObject("imageListMenu.ImageStream");
            imageListMenu.TransparentColor = Color.Transparent;
            imageListMenu.Images.SetKeyName(0, "Relatório.png");
            imageListMenu.Images.SetKeyName(1, "alert.png");
            imageListMenu.Images.SetKeyName(2, "chart-histogram.png");
            imageListMenu.Images.SetKeyName(3, "seta.png");
            imageListMenu.Images.SetKeyName(4, "");
            // 
            // lblFalsoComboBox
            // 
            lblFalsoComboBox.AutoSize = true;
            lblFalsoComboBox.Location = new Point(99, 107);
            lblFalsoComboBox.Name = "lblFalsoComboBox";
            lblFalsoComboBox.Size = new Size(65, 20);
            lblFalsoComboBox.TabIndex = 11;
            lblFalsoComboBox.Text = "  Turmas";
            // 
            // pnConteudo
            // 
            pnConteudo.BackColor = Color.Lavender;
            pnConteudo.Controls.Add(tableLayoutPanelCards);
            pnConteudo.Controls.Add(panelWelcome);
            pnConteudo.Controls.Add(label1);
            pnConteudo.Dock = DockStyle.Fill;
            pnConteudo.Location = new Point(229, 0);
            pnConteudo.Margin = new Padding(0);
            pnConteudo.Name = "pnConteudo";
            pnConteudo.Size = new Size(857, 631);
            pnConteudo.TabIndex = 1;
            // 
            // tableLayoutPanelCards
            // 
            tableLayoutPanelCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelCards.ColumnCount = 3;
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelCards.Controls.Add(Painel_Diário, 0, 0);
            tableLayoutPanelCards.Controls.Add(Painel_Semanal, 1, 0);
            tableLayoutPanelCards.Controls.Add(Painel_Mensal, 2, 0);
            tableLayoutPanelCards.Location = new Point(62, 100);
            tableLayoutPanelCards.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanelCards.Name = "tableLayoutPanelCards";
            tableLayoutPanelCards.RowCount = 1;
            tableLayoutPanelCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelCards.Size = new Size(736, 176);
            tableLayoutPanelCards.TabIndex = 9;
            // 
            // panelWelcome
            // 
            panelWelcome.Anchor = AnchorStyles.None;
            panelWelcome.Controls.Add(BtnWelcome);
            panelWelcome.Controls.Add(label6);
            panelWelcome.Controls.Add(lblFalsoComboBox);
            panelWelcome.Controls.Add(label3);
            panelWelcome.Controls.Add(arredondamentoBtn1);
            panelWelcome.Location = new Point(62, 284);
            panelWelcome.Margin = new Padding(3, 4, 3, 4);
            panelWelcome.Name = "panelWelcome";
            panelWelcome.Size = new Size(736, 303);
            panelWelcome.TabIndex = 10;
            // 
            // BtnWelcome
            // 
            BtnWelcome.BackColor = Color.MidnightBlue;
            BtnWelcome.BorderColor = Color.Transparent;
            BtnWelcome.BorderRadius = 10;
            BtnWelcome.BorderSize = 0;
            BtnWelcome.FlatAppearance.BorderSize = 0;
            BtnWelcome.FlatStyle = FlatStyle.Flat;
            BtnWelcome.ForeColor = Color.White;
            BtnWelcome.Location = new Point(262, 249);
            BtnWelcome.Margin = new Padding(3, 4, 3, 4);
            BtnWelcome.Name = "BtnWelcome";
            BtnWelcome.Size = new Size(171, 45);
            BtnWelcome.TabIndex = 12;
            BtnWelcome.Text = "Acesse";
            BtnWelcome.UseVisualStyleBackColor = false;
            // 
            // arredondamentoBtn1
            // 
            arredondamentoBtn1.BackColor = Color.WhiteSmoke;
            arredondamentoBtn1.BorderColor = Color.Transparent;
            arredondamentoBtn1.BorderRadius = 10;
            arredondamentoBtn1.BorderSize = 0;
            arredondamentoBtn1.FlatAppearance.BorderSize = 0;
            arredondamentoBtn1.FlatStyle = FlatStyle.Flat;
            arredondamentoBtn1.ForeColor = Color.White;
            arredondamentoBtn1.Location = new Point(6, 11);
            arredondamentoBtn1.Margin = new Padding(3, 4, 3, 4);
            arredondamentoBtn1.Name = "arredondamentoBtn1";
            arredondamentoBtn1.Size = new Size(727, 236);
            arredondamentoBtn1.TabIndex = 13;
            arredondamentoBtn1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 229F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pnConteudo, 1, 0);
            tableLayoutPanel1.Controls.Add(menuPrincipal2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1086, 631);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // menuPrincipal2
            // 
            menuPrincipal2.Dock = DockStyle.Fill;
            menuPrincipal2.Location = new Point(0, 0);
            menuPrincipal2.Margin = new Padding(0);
            menuPrincipal2.Name = "menuPrincipal2";
            menuPrincipal2.Size = new Size(229, 631);
            menuPrincipal2.TabIndex = 6;
            // 
            // frmDashboard_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 631);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 1, 3, 1);
            Name = "frmDashboard_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Painel_Diário.ResumeLayout(false);
            Painel_Diário.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            Painel_Semanal.ResumeLayout(false);
            Painel_Semanal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            Painel_Mensal.ResumeLayout(false);
            Painel_Mensal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            pnConteudo.ResumeLayout(false);
            pnConteudo.PerformLayout();
            tableLayoutPanelCards.ResumeLayout(false);
            panelWelcome.ResumeLayout(false);
            panelWelcome.PerformLayout();
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
        private Label label5;
        private Label lblMensal;
        private Label label7;
        private Label label3;
        private Label label6;
        private Panel panel1;
        private Panel pnConteudo;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanelCards;
        private Panel panelWelcome;
        private FlowLayoutPanel flowLayoutPanelReports;
        private ImageList imageListMenu;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label lblFalsoComboBox;
        private MenuPrincipal menuPrincipal2;
        private ArredondamentoBtn BtnWelcome;
        private ArredondamentoBtn arredondamentoBtn1;
    }
}

