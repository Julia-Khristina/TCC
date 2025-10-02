
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
            panel2 = new Panel();
            label9 = new Label();
            lblNome = new Label();
            pictureBox5 = new PictureBox();
            label8 = new Label();
            menuPrincipal2 = new MenuPrincipal();
            tableLayoutPanel4 = new TableLayoutPanel();
            arredondamentoBtn6 = new ArredondamentoBtn();
            tableLayoutPanel5 = new TableLayoutPanel();
            label10 = new Label();
            arredondamentoBtn7 = new ArredondamentoBtn();
            arredondamentoBtn8 = new ArredondamentoBtn();
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
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(71, 73);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(222, 41);
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
            Painel_Diário.Location = new Point(36, 0);
            Painel_Diário.Margin = new Padding(4, 5, 21, 5);
            Painel_Diário.Name = "Painel_Diário";
            Painel_Diário.Size = new Size(381, 173);
            Painel_Diário.TabIndex = 2;
            // 
            // lblDiario
            // 
            lblDiario.AutoSize = true;
            lblDiario.BackColor = Color.LightBlue;
            lblDiario.Enabled = false;
            lblDiario.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiario.ForeColor = Color.MidnightBlue;
            lblDiario.Location = new Point(201, 58);
            lblDiario.Margin = new Padding(4, 0, 4, 0);
            lblDiario.Name = "lblDiario";
            lblDiario.Size = new Size(90, 71);
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
            label2.Location = new Point(177, 27);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 32);
            label2.TabIndex = 10;
            label2.Text = "Atraso diário";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(24, 22);
            pictureBox3.Margin = new Padding(4, 2, 4, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 117);
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
            Painel_Semanal.Location = new Point(36, 0);
            Painel_Semanal.Margin = new Padding(21, 0, 7, 5);
            Painel_Semanal.Name = "Painel_Semanal";
            Painel_Semanal.Size = new Size(381, 173);
            Painel_Semanal.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 32);
            pictureBox2.Margin = new Padding(4, 2, 4, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 117);
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
            lblSemanal.Location = new Point(219, 72);
            lblSemanal.Margin = new Padding(4, 0, 4, 0);
            lblSemanal.Name = "lblSemanal";
            lblSemanal.Size = new Size(90, 71);
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
            label5.Location = new Point(170, 37);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(176, 32);
            label5.TabIndex = 13;
            label5.Text = "Atraso semanal";
            // 
            // Painel_Mensal
            // 
            Painel_Mensal.BackColor = Color.PeachPuff;
            Painel_Mensal.Controls.Add(pictureBox4);
            Painel_Mensal.Controls.Add(lblMensal);
            Painel_Mensal.Controls.Add(label7);
            Painel_Mensal.Location = new Point(37, 0);
            Painel_Mensal.Margin = new Padding(21, 5, 4, 5);
            Painel_Mensal.Name = "Painel_Mensal";
            Painel_Mensal.Size = new Size(381, 173);
            Painel_Mensal.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(24, 28);
            pictureBox4.Margin = new Padding(4, 2, 4, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(120, 127);
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
            lblMensal.Location = new Point(201, 63);
            lblMensal.Margin = new Padding(4, 0, 4, 0);
            lblMensal.Name = "lblMensal";
            lblMensal.Size = new Size(90, 71);
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
            label7.Location = new Point(163, 28);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(164, 32);
            label7.TabIndex = 16;
            label7.Text = "Atraso mensal";
            // 
            // Painel_Notificacao
            // 
            Painel_Notificacao.BackColor = Color.LightSteelBlue;
            Painel_Notificacao.Controls.Add(pictureBox1);
            Painel_Notificacao.Controls.Add(label4);
            Painel_Notificacao.Controls.Add(label6);
            Painel_Notificacao.Location = new Point(36, 0);
            Painel_Notificacao.Margin = new Padding(21, 5, 4, 5);
            Painel_Notificacao.Name = "Painel_Notificacao";
            Painel_Notificacao.Size = new Size(381, 173);
            Painel_Notificacao.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 28);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 127);
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
            label4.Location = new Point(219, 68);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 71);
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
            label6.Location = new Point(184, 28);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(145, 32);
            label6.TabIndex = 16;
            label6.Text = "Notificações";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Lavender;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(33, 38);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(355, 40);
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
            pnConteudo.Location = new Point(314, 0);
            pnConteudo.Margin = new Padding(0);
            pnConteudo.Name = "pnConteudo";
            pnConteudo.Size = new Size(733, 788);
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
            tableLayoutPanel3.Location = new Point(47, 528);
            tableLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 42.121212F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 57.878788F));
            tableLayoutPanel3.Size = new Size(894, 550);
            tableLayoutPanel3.TabIndex = 16;
            // 
            // pnDiario
            // 
            pnDiario.Controls.Add(Painel_Diário);
            pnDiario.Controls.Add(arredondamentoBtn2);
            pnDiario.Location = new Point(4, 5);
            pnDiario.Margin = new Padding(4, 5, 4, 5);
            pnDiario.Name = "pnDiario";
            pnDiario.Padding = new Padding(3, 0, 3, 0);
            pnDiario.Size = new Size(439, 218);
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
            arredondamentoBtn2.Location = new Point(26, 42);
            arredondamentoBtn2.Margin = new Padding(14, 17, 14, 17);
            arredondamentoBtn2.Name = "arredondamentoBtn2";
            arredondamentoBtn2.Size = new Size(391, 143);
            arredondamentoBtn2.TabIndex = 12;
            arredondamentoBtn2.UseVisualStyleBackColor = false;
            // 
            // pnNotificacoes
            // 
            pnNotificacoes.Controls.Add(Painel_Notificacao);
            pnNotificacoes.Controls.Add(arredondamentoBtn5);
            pnNotificacoes.Location = new Point(451, 236);
            pnNotificacoes.Margin = new Padding(4, 5, 4, 5);
            pnNotificacoes.Name = "pnNotificacoes";
            pnNotificacoes.Size = new Size(439, 208);
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
            arredondamentoBtn5.Location = new Point(26, 32);
            arredondamentoBtn5.Margin = new Padding(14, 17, 14, 17);
            arredondamentoBtn5.Name = "arredondamentoBtn5";
            arredondamentoBtn5.Size = new Size(391, 155);
            arredondamentoBtn5.TabIndex = 14;
            arredondamentoBtn5.UseVisualStyleBackColor = false;
            // 
            // pnMensal
            // 
            pnMensal.Controls.Add(Painel_Mensal);
            pnMensal.Controls.Add(arredondamentoBtn4);
            pnMensal.Location = new Point(4, 236);
            pnMensal.Margin = new Padding(4, 5, 4, 5);
            pnMensal.Name = "pnMensal";
            pnMensal.Size = new Size(439, 208);
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
            arredondamentoBtn4.Location = new Point(26, 43);
            arredondamentoBtn4.Margin = new Padding(14, 17, 14, 17);
            arredondamentoBtn4.Name = "arredondamentoBtn4";
            arredondamentoBtn4.Size = new Size(389, 143);
            arredondamentoBtn4.TabIndex = 13;
            arredondamentoBtn4.UseVisualStyleBackColor = false;
            // 
            // pnSemanal
            // 
            pnSemanal.Controls.Add(Painel_Semanal);
            pnSemanal.Controls.Add(arredondamentoBtn3);
            pnSemanal.Location = new Point(451, 5);
            pnSemanal.Margin = new Padding(4, 5, 4, 5);
            pnSemanal.Name = "pnSemanal";
            pnSemanal.Padding = new Padding(3, 0, 3, 0);
            pnSemanal.Size = new Size(439, 218);
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
            arredondamentoBtn3.Location = new Point(26, 40);
            arredondamentoBtn3.Margin = new Padding(14, 17, 14, 17);
            arredondamentoBtn3.Name = "arredondamentoBtn3";
            arredondamentoBtn3.Size = new Size(391, 143);
            arredondamentoBtn3.TabIndex = 12;
            arredondamentoBtn3.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.RoyalBlue;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tableLayoutPanel2.Controls.Add(panelWelcome, 0, 0);
            tableLayoutPanel2.Location = new Point(80, 165);
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(837, 298);
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
            panelWelcome.Size = new Size(837, 298);
            panelWelcome.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Lavender;
            richTextBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(33, 97);
            richTextBox1.Margin = new Padding(4, 5, 4, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(771, 157);
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
            arredondamentoBtn1.Margin = new Padding(29, 0, 29, 0);
            arredondamentoBtn1.Name = "arredondamentoBtn1";
            arredondamentoBtn1.Padding = new Padding(4, 0, 4, 0);
            arredondamentoBtn1.Size = new Size(837, 292);
            arredondamentoBtn1.TabIndex = 13;
            arredondamentoBtn1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 314F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel2, 2, 0);
            tableLayoutPanel1.Controls.Add(pnConteudo, 1, 0);
            tableLayoutPanel1.Controls.Add(menuPrincipal2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1414, 788);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1050, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(361, 782);
            panel2.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Desktop;
            label9.Location = new Point(4, 458);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(222, 28);
            label9.TabIndex = 21;
            label9.Text = "Orientação Educacional";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblNome.ForeColor = SystemColors.Desktop;
            lblNome.Location = new Point(4, 285);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(204, 28);
            lblNome.TabIndex = 20;
            lblNome.Text = "Regiane Moraes Silva";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.perfil;
            pictureBox5.Location = new Point(3, 66);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(178, 169);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Desktop;
            label8.Location = new Point(4, 0);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(159, 41);
            label8.TabIndex = 18;
            label8.Text = "Meu Perfil";
            // 
            // menuPrincipal2
            // 
            menuPrincipal2.Dock = DockStyle.Fill;
            menuPrincipal2.Location = new Point(0, 0);
            menuPrincipal2.Margin = new Padding(0);
            menuPrincipal2.Name = "menuPrincipal2";
            menuPrincipal2.Size = new Size(314, 788);
            menuPrincipal2.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(arredondamentoBtn8, 0, 6);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(label9, 0, 3);
            tableLayoutPanel4.Controls.Add(lblNome, 0, 2);
            tableLayoutPanel4.Controls.Add(label10, 0, 4);
            tableLayoutPanel4.Controls.Add(arredondamentoBtn7, 0, 5);
            tableLayoutPanel4.Controls.Add(pictureBox5, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 7;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 22.22222F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 77.77778F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 173F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 166F));
            tableLayoutPanel4.Size = new Size(361, 782);
            tableLayoutPanel4.TabIndex = 17;
            // 
            // arredondamentoBtn6
            // 
            arredondamentoBtn6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            arredondamentoBtn6.BackColor = Color.MidnightBlue;
            arredondamentoBtn6.BorderColor = Color.Transparent;
            arredondamentoBtn6.BorderRadius = 10;
            arredondamentoBtn6.BorderSize = 0;
            arredondamentoBtn6.DisableHoverEffect = false;
            arredondamentoBtn6.FlatAppearance.BorderSize = 0;
            arredondamentoBtn6.FlatStyle = FlatStyle.Flat;
            arredondamentoBtn6.ForeColor = Color.White;
            arredondamentoBtn6.Location = new Point(172, 3);
            arredondamentoBtn6.Name = "arredondamentoBtn6";
            arredondamentoBtn6.Size = new Size(163, 51);
            arredondamentoBtn6.TabIndex = 22;
            arredondamentoBtn6.Text = "arredondamentoBtn6";
            arredondamentoBtn6.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label8, 0, 0);
            tableLayoutPanel5.Controls.Add(arredondamentoBtn6, 1, 0);
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(338, 57);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Desktop;
            label10.Location = new Point(4, 498);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(203, 41);
            label10.TabIndex = 23;
            label10.Text = "Minhas ações";
            // 
            // arredondamentoBtn7
            // 
            arredondamentoBtn7.BackColor = Color.MidnightBlue;
            arredondamentoBtn7.BorderColor = Color.Transparent;
            arredondamentoBtn7.BorderRadius = 10;
            arredondamentoBtn7.BorderSize = 0;
            arredondamentoBtn7.DisableHoverEffect = false;
            arredondamentoBtn7.FlatAppearance.BorderSize = 0;
            arredondamentoBtn7.FlatStyle = FlatStyle.Flat;
            arredondamentoBtn7.ForeColor = Color.White;
            arredondamentoBtn7.Location = new Point(3, 547);
            arredondamentoBtn7.Name = "arredondamentoBtn7";
            arredondamentoBtn7.Size = new Size(297, 57);
            arredondamentoBtn7.TabIndex = 23;
            arredondamentoBtn7.Text = "arredondamentoBtn7";
            arredondamentoBtn7.UseVisualStyleBackColor = false;
            // 
            // arredondamentoBtn8
            // 
            arredondamentoBtn8.BackColor = Color.MidnightBlue;
            arredondamentoBtn8.BorderColor = Color.Transparent;
            arredondamentoBtn8.BorderRadius = 10;
            arredondamentoBtn8.BorderSize = 0;
            arredondamentoBtn8.DisableHoverEffect = false;
            arredondamentoBtn8.FlatAppearance.BorderSize = 0;
            arredondamentoBtn8.FlatStyle = FlatStyle.Flat;
            arredondamentoBtn8.ForeColor = Color.White;
            arredondamentoBtn8.Location = new Point(3, 618);
            arredondamentoBtn8.Name = "arredondamentoBtn8";
            arredondamentoBtn8.Size = new Size(294, 57);
            arredondamentoBtn8.TabIndex = 24;
            arredondamentoBtn8.Text = "arredondamentoBtn8";
            arredondamentoBtn8.UseVisualStyleBackColor = false;
            // 
            // frmDashboard_Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 788);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 2, 4, 2);
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
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
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
        private Panel panel2;
        private Label lblNome;
        private PictureBox pictureBox5;
        private Label label8;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel4;
        private ArredondamentoBtn arredondamentoBtn6;
        private TableLayoutPanel tableLayoutPanel5;
        private ArredondamentoBtn arredondamentoBtn8;
        private Label label10;
        private ArredondamentoBtn arredondamentoBtn7;
    }
}

