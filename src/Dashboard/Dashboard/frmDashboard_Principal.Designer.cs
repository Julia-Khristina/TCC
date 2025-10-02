
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
            pictureBox2 = new PictureBox();
            lblSemanal = new Label();
            label5 = new Label();
            Painel_Mensal = new Panel();
            pictureBox4 = new PictureBox();
            lblMensal = new Label();
            label7 = new Label();
            Painel_Notificacao = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            imageListMenu = new ImageList(components);
            pnConteudo = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            pnDiario = new Panel();
            arredondamentoBtn2 = new ArredondamentoBtn();
            pnNotificacoes = new Panel();
            arredondamentoBtn5 = new ArredondamentoBtn();
            pnMensal = new Panel();
            arredondamentoBtn4 = new ArredondamentoBtn();
            pnSemanal = new Panel();
            arredondamentoBtn3 = new ArredondamentoBtn();
            tableLayoutPanel2 = new TableLayoutPanel();
            panelWelcome = new Panel();
            richTextBox1 = new RichTextBox();
            arredondamentoBtn1 = new ArredondamentoBtn();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuPrincipal2 = new MenuPrincipal();
            Painel_Diário.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Painel_Semanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Painel_Mensal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            Painel_Notificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnConteudo.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            pnDiario.SuspendLayout();
            pnNotificacoes.SuspendLayout();
            pnMensal.SuspendLayout();
            pnSemanal.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panelWelcome.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(50, 44);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 1;
            label1.Text = "Relatório Geral";
            // 
            // Painel_Diário
            // 
            Painel_Diário.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Painel_Diário.BackColor = Color.LightBlue;
            Painel_Diário.Controls.Add(lblDiario);
            Painel_Diário.Controls.Add(label2);
            Painel_Diário.Controls.Add(pictureBox3);
            Painel_Diário.Location = new Point(25, 0);
            Painel_Diário.Margin = new Padding(3, 3, 15, 3);
            Painel_Diário.Name = "Painel_Diário";
            Painel_Diário.Size = new Size(267, 104);
            Painel_Diário.TabIndex = 2;
            // 
            // lblDiario
            // 
            lblDiario.AutoSize = true;
            lblDiario.BackColor = Color.LightBlue;
            lblDiario.Enabled = false;
            lblDiario.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiario.ForeColor = Color.MidnightBlue;
            lblDiario.Location = new Point(141, 35);
            lblDiario.Name = "lblDiario";
            lblDiario.Size = new Size(60, 47);
            lblDiario.TabIndex = 11;
            lblDiario.Text = "00";
            lblDiario.Click += lblDiario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightBlue;
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(124, 16);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 10;
            label2.Text = "Atraso diário";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(17, 13);
            pictureBox3.Margin = new Padding(3, 1, 3, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(84, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // Painel_Semanal
            // 
            Painel_Semanal.BackColor = Color.Moccasin;
            Painel_Semanal.Controls.Add(pictureBox2);
            Painel_Semanal.Controls.Add(lblSemanal);
            Painel_Semanal.Controls.Add(label5);
            Painel_Semanal.Location = new Point(25, 0);
            Painel_Semanal.Margin = new Padding(15, 0, 5, 3);
            Painel_Semanal.Name = "Painel_Semanal";
            Painel_Semanal.Size = new Size(267, 104);
            Painel_Semanal.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 19);
            pictureBox2.Margin = new Padding(3, 1, 3, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // lblSemanal
            // 
            lblSemanal.AutoSize = true;
            lblSemanal.BackColor = Color.Moccasin;
            lblSemanal.Enabled = false;
            lblSemanal.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSemanal.ForeColor = Color.MidnightBlue;
            lblSemanal.Location = new Point(153, 43);
            lblSemanal.Name = "lblSemanal";
            lblSemanal.Size = new Size(60, 47);
            lblSemanal.TabIndex = 14;
            lblSemanal.Text = "00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Moccasin;
            label5.Enabled = false;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(119, 22);
            label5.Name = "label5";
            label5.Size = new Size(117, 21);
            label5.TabIndex = 13;
            label5.Text = "Atraso semanal";
            // 
            // Painel_Mensal
            // 
            Painel_Mensal.BackColor = Color.PeachPuff;
            Painel_Mensal.Controls.Add(pictureBox4);
            Painel_Mensal.Controls.Add(lblMensal);
            Painel_Mensal.Controls.Add(label7);
            Painel_Mensal.Location = new Point(26, 0);
            Painel_Mensal.Margin = new Padding(15, 3, 3, 3);
            Painel_Mensal.Name = "Painel_Mensal";
            Painel_Mensal.Size = new Size(267, 104);
            Painel_Mensal.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(17, 17);
            pictureBox4.Margin = new Padding(3, 1, 3, 1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(84, 76);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // lblMensal
            // 
            lblMensal.AutoSize = true;
            lblMensal.BackColor = Color.PeachPuff;
            lblMensal.Enabled = false;
            lblMensal.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensal.ForeColor = Color.MidnightBlue;
            lblMensal.Location = new Point(141, 38);
            lblMensal.Name = "lblMensal";
            lblMensal.Size = new Size(60, 47);
            lblMensal.TabIndex = 17;
            lblMensal.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.PeachPuff;
            label7.Enabled = false;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(114, 17);
            label7.Name = "label7";
            label7.Size = new Size(109, 21);
            label7.TabIndex = 16;
            label7.Text = "Atraso mensal";
            // 
            // Painel_Notificacao
            // 
            Painel_Notificacao.BackColor = Color.LightSteelBlue;
            Painel_Notificacao.Controls.Add(pictureBox1);
            Painel_Notificacao.Controls.Add(label4);
            Painel_Notificacao.Controls.Add(label6);
            Painel_Notificacao.Location = new Point(25, 0);
            Painel_Notificacao.Margin = new Padding(15, 3, 3, 3);
            Painel_Notificacao.Name = "Painel_Notificacao";
            Painel_Notificacao.Size = new Size(267, 104);
            Painel_Notificacao.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 17);
            pictureBox1.Margin = new Padding(3, 1, 3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSteelBlue;
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(153, 41);
            label4.Name = "label4";
            label4.Size = new Size(60, 47);
            label4.TabIndex = 17;
            label4.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightSteelBlue;
            label6.Enabled = false;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(129, 17);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 16;
            label6.Text = "Notificações";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Lavender;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(23, 23);
            label3.Name = "label3";
            label3.Size = new Size(232, 25);
            label3.TabIndex = 4;
            label3.Text = "Bem-vindo ao Pontualize!";
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
            // pnConteudo
            // 
            pnConteudo.BackColor = Color.White;
            pnConteudo.Controls.Add(tableLayoutPanel3);
            pnConteudo.Controls.Add(tableLayoutPanel2);
            pnConteudo.Controls.Add(label1);
            pnConteudo.Dock = DockStyle.Fill;
            pnConteudo.Location = new Point(220, 0);
            pnConteudo.Margin = new Padding(0);
            pnConteudo.Name = "pnConteudo";
            pnConteudo.Size = new Size(770, 473);
            pnConteudo.TabIndex = 1;
            pnConteudo.Paint += pnConteudo_Paint;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(pnDiario, 0, 0);
            tableLayoutPanel3.Controls.Add(pnNotificacoes, 1, 1);
            tableLayoutPanel3.Controls.Add(pnMensal, 0, 1);
            tableLayoutPanel3.Controls.Add(pnSemanal, 1, 0);
            tableLayoutPanel3.Location = new Point(33, 317);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 42.121212F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 57.878788F));
            tableLayoutPanel3.Size = new Size(626, 330);
            tableLayoutPanel3.TabIndex = 16;
            // 
            // pnDiario
            // 
            pnDiario.Controls.Add(Painel_Diário);
            pnDiario.Controls.Add(arredondamentoBtn2);
            pnDiario.Location = new Point(3, 3);
            pnDiario.Name = "pnDiario";
            pnDiario.Padding = new Padding(2, 0, 2, 0);
            pnDiario.Size = new Size(307, 131);
            pnDiario.TabIndex = 12;
            // 
            // arredondamentoBtn2
            // 
            arredondamentoBtn2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            arredondamentoBtn2.BackColor = Color.SteelBlue;
            arredondamentoBtn2.BorderColor = Color.Transparent;
            arredondamentoBtn2.BorderRadius = 10;
            arredondamentoBtn2.BorderSize = 0;
            arredondamentoBtn2.DisableHoverEffect = false;
            arredondamentoBtn2.FlatAppearance.BorderSize = 0;
            arredondamentoBtn2.FlatStyle = FlatStyle.Flat;
            arredondamentoBtn2.ForeColor = Color.White;
            arredondamentoBtn2.Location = new Point(18, 25);
            arredondamentoBtn2.Margin = new Padding(10);
            arredondamentoBtn2.Name = "arredondamentoBtn2";
            arredondamentoBtn2.Size = new Size(274, 86);
            arredondamentoBtn2.TabIndex = 12;
            arredondamentoBtn2.UseVisualStyleBackColor = false;
            // 
            // pnNotificacoes
            // 
            pnNotificacoes.Controls.Add(Painel_Notificacao);
            pnNotificacoes.Controls.Add(arredondamentoBtn5);
            pnNotificacoes.Location = new Point(316, 142);
            pnNotificacoes.Name = "pnNotificacoes";
            pnNotificacoes.Size = new Size(307, 125);
            pnNotificacoes.TabIndex = 15;
            // 
            // arredondamentoBtn5
            // 
            arredondamentoBtn5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            arredondamentoBtn5.BackColor = Color.SteelBlue;
            arredondamentoBtn5.BorderColor = Color.Transparent;
            arredondamentoBtn5.BorderRadius = 10;
            arredondamentoBtn5.BorderSize = 0;
            arredondamentoBtn5.DisableHoverEffect = false;
            arredondamentoBtn5.FlatAppearance.BorderSize = 0;
            arredondamentoBtn5.FlatStyle = FlatStyle.Flat;
            arredondamentoBtn5.ForeColor = Color.White;
            arredondamentoBtn5.Location = new Point(18, 19);
            arredondamentoBtn5.Margin = new Padding(10);
            arredondamentoBtn5.Name = "arredondamentoBtn5";
            arredondamentoBtn5.Size = new Size(274, 93);
            arredondamentoBtn5.TabIndex = 14;
            arredondamentoBtn5.UseVisualStyleBackColor = false;
            // 
            // pnMensal
            // 
            pnMensal.Controls.Add(Painel_Mensal);
            pnMensal.Controls.Add(arredondamentoBtn4);
            pnMensal.Location = new Point(3, 142);
            pnMensal.Name = "pnMensal";
            pnMensal.Size = new Size(307, 125);
            pnMensal.TabIndex = 14;
            // 
            // arredondamentoBtn4
            // 
            arredondamentoBtn4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            arredondamentoBtn4.BackColor = Color.DarkSalmon;
            arredondamentoBtn4.BorderColor = Color.Transparent;
            arredondamentoBtn4.BorderRadius = 10;
            arredondamentoBtn4.BorderSize = 0;
            arredondamentoBtn4.DisableHoverEffect = false;
            arredondamentoBtn4.FlatAppearance.BorderSize = 0;
            arredondamentoBtn4.FlatStyle = FlatStyle.Flat;
            arredondamentoBtn4.ForeColor = Color.White;
            arredondamentoBtn4.Location = new Point(18, 26);
            arredondamentoBtn4.Margin = new Padding(10);
            arredondamentoBtn4.Name = "arredondamentoBtn4";
            arredondamentoBtn4.Size = new Size(272, 86);
            arredondamentoBtn4.TabIndex = 13;
            arredondamentoBtn4.UseVisualStyleBackColor = false;
            // 
            // pnSemanal
            // 
            pnSemanal.Controls.Add(Painel_Semanal);
            pnSemanal.Controls.Add(arredondamentoBtn3);
            pnSemanal.Location = new Point(316, 3);
            pnSemanal.Name = "pnSemanal";
            pnSemanal.Padding = new Padding(2, 0, 2, 0);
            pnSemanal.Size = new Size(307, 131);
            pnSemanal.TabIndex = 13;
            // 
            // arredondamentoBtn3
            // 
            arredondamentoBtn3.BackColor = Color.SandyBrown;
            arredondamentoBtn3.BorderColor = Color.Transparent;
            arredondamentoBtn3.BorderRadius = 10;
            arredondamentoBtn3.BorderSize = 0;
            arredondamentoBtn3.DisableHoverEffect = false;
            arredondamentoBtn3.FlatAppearance.BorderSize = 0;
            arredondamentoBtn3.FlatStyle = FlatStyle.Flat;
            arredondamentoBtn3.ForeColor = Color.White;
            arredondamentoBtn3.Location = new Point(18, 24);
            arredondamentoBtn3.Margin = new Padding(10);
            arredondamentoBtn3.Name = "arredondamentoBtn3";
            arredondamentoBtn3.Size = new Size(274, 86);
            arredondamentoBtn3.TabIndex = 12;
            arredondamentoBtn3.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.RoyalBlue;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel2.Controls.Add(panelWelcome, 0, 0);
            tableLayoutPanel2.Location = new Point(56, 99);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(586, 179);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // panelWelcome
            // 
            panelWelcome.BackColor = Color.White;
            panelWelcome.Controls.Add(richTextBox1);
            panelWelcome.Controls.Add(label3);
            panelWelcome.Controls.Add(arredondamentoBtn1);
            panelWelcome.Dock = DockStyle.Fill;
            panelWelcome.Location = new Point(0, 0);
            panelWelcome.Margin = new Padding(0);
            panelWelcome.Name = "panelWelcome";
            panelWelcome.Size = new Size(586, 179);
            panelWelcome.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Lavender;
            richTextBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(23, 58);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(541, 96);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // arredondamentoBtn1
            // 
            arredondamentoBtn1.BackColor = Color.Lavender;
            arredondamentoBtn1.BorderColor = Color.Transparent;
            arredondamentoBtn1.BorderRadius = 10;
            arredondamentoBtn1.BorderSize = 0;
            arredondamentoBtn1.DisableHoverEffect = true;
            arredondamentoBtn1.Dock = DockStyle.Top;
            arredondamentoBtn1.FlatAppearance.BorderSize = 0;
            arredondamentoBtn1.FlatAppearance.MouseOverBackColor = Color.Lavender;
            arredondamentoBtn1.FlatStyle = FlatStyle.Flat;
            arredondamentoBtn1.ForeColor = Color.Lavender;
            arredondamentoBtn1.Location = new Point(0, 0);
            arredondamentoBtn1.Margin = new Padding(20, 0, 20, 0);
            arredondamentoBtn1.Name = "arredondamentoBtn1";
            arredondamentoBtn1.Padding = new Padding(3, 0, 3, 0);
            arredondamentoBtn1.Size = new Size(586, 175);
            arredondamentoBtn1.TabIndex = 13;
            arredondamentoBtn1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pnConteudo, 1, 0);
            tableLayoutPanel1.Controls.Add(menuPrincipal2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(990, 473);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // menuPrincipal2
            // 
            menuPrincipal2.Dock = DockStyle.Fill;
            menuPrincipal2.Location = new Point(0, 0);
            menuPrincipal2.Margin = new Padding(0);
            menuPrincipal2.Name = "menuPrincipal2";
            menuPrincipal2.Size = new Size(220, 473);
            menuPrincipal2.TabIndex = 6;
            // 
            // frmDashboard_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 473);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Painel_Mensal.ResumeLayout(false);
            Painel_Mensal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            Painel_Notificacao.ResumeLayout(false);
            Painel_Notificacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnConteudo.ResumeLayout(false);
            pnConteudo.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            pnDiario.ResumeLayout(false);
            pnNotificacoes.ResumeLayout(false);
            pnMensal.ResumeLayout(false);
            pnSemanal.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
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
        private Panel panel1;
        private Panel pnConteudo;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelWelcome;
        private ImageList imageListMenu;
        private MenuPrincipal menuPrincipal2;
        private ArredondamentoBtn arredondamentoBtn1;
        private RichTextBox richTextBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel Painel_Notificacao;
        private Label label4;
        private Label label6;
        private ArredondamentoBtn arredondamentoBtn2;
        private ArredondamentoBtn arredondamentoBtn3;
        private Panel pnDiario;
        private Panel pnSemanal;
        private Panel pnMensal;
        private ArredondamentoBtn arredondamentoBtn4;
        private Panel pnNotificacoes;
        private ArredondamentoBtn arredondamentoBtn5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox2;
    }
}

