namespace Dashboard
{
    partial class MenuPrincipal
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            Notificacao_Direcionamento = new Button();
            imageListMenu = new ImageList(components);
            Turmas_Direcionamento = new ComboBox();
            BTN_Relatorio_Direcionamento = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            LblFuncao = new Label();
            lblNome = new Label();
            pictureBox2 = new PictureBox();
            pnSairContainer = new Panel();
            Btn_Sair = new Button();
            pnMenu = new Panel();
            pnEspacador = new Panel();
            flowLayoutPanelMenu = new FlowLayoutPanel();
            btnTurma = new Button();
            Painel_Perfil = new Panel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnSairContainer.SuspendLayout();
            pnMenu.SuspendLayout();
            flowLayoutPanelMenu.SuspendLayout();
            Painel_Perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Notificacao_Direcionamento
            // 
            Notificacao_Direcionamento.BackColor = Color.MidnightBlue;
            Notificacao_Direcionamento.FlatAppearance.BorderSize = 0;
            Notificacao_Direcionamento.FlatStyle = FlatStyle.Flat;
            Notificacao_Direcionamento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Notificacao_Direcionamento.ForeColor = Color.White;
            Notificacao_Direcionamento.ImageAlign = ContentAlignment.MiddleLeft;
            Notificacao_Direcionamento.ImageIndex = 1;
            Notificacao_Direcionamento.ImageList = imageListMenu;
            Notificacao_Direcionamento.Location = new Point(28, 119);
            Notificacao_Direcionamento.Margin = new Padding(21, 5, 4, 20);
            Notificacao_Direcionamento.Name = "Notificacao_Direcionamento";
            Notificacao_Direcionamento.Padding = new Padding(7, 5, 4, 5);
            Notificacao_Direcionamento.Size = new Size(257, 67);
            Notificacao_Direcionamento.TabIndex = 1;
            Notificacao_Direcionamento.Text = "  Notificação";
            Notificacao_Direcionamento.TextImageRelation = TextImageRelation.ImageBeforeText;
            Notificacao_Direcionamento.UseVisualStyleBackColor = false;
            Notificacao_Direcionamento.Click += Notificacao_Direcionamento_Click;
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
            // Turmas_Direcionamento
            // 
            Turmas_Direcionamento.AllowDrop = true;
            Turmas_Direcionamento.BackColor = Color.MidnightBlue;
            Turmas_Direcionamento.DrawMode = DrawMode.OwnerDrawFixed;
            Turmas_Direcionamento.FlatStyle = FlatStyle.Flat;
            Turmas_Direcionamento.Font = new Font("Segoe UI", 9.95F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Turmas_Direcionamento.ForeColor = Color.White;
            Turmas_Direcionamento.FormattingEnabled = true;
            Turmas_Direcionamento.Location = new Point(14, 206);
            Turmas_Direcionamento.Margin = new Padding(7, 0, 0, 0);
            Turmas_Direcionamento.MaxDropDownItems = 3;
            Turmas_Direcionamento.Name = "Turmas_Direcionamento";
            Turmas_Direcionamento.Size = new Size(284, 35);
            Turmas_Direcionamento.TabIndex = 9;
            Turmas_Direcionamento.Visible = false;
            // 
            // BTN_Relatorio_Direcionamento
            // 
            BTN_Relatorio_Direcionamento.BackColor = Color.MidnightBlue;
            BTN_Relatorio_Direcionamento.FlatAppearance.BorderSize = 0;
            BTN_Relatorio_Direcionamento.FlatStyle = FlatStyle.Flat;
            BTN_Relatorio_Direcionamento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTN_Relatorio_Direcionamento.ForeColor = Color.White;
            BTN_Relatorio_Direcionamento.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Relatorio_Direcionamento.ImageIndex = 0;
            BTN_Relatorio_Direcionamento.ImageList = imageListMenu;
            BTN_Relatorio_Direcionamento.Location = new Point(28, 27);
            BTN_Relatorio_Direcionamento.Margin = new Padding(21, 10, 4, 20);
            BTN_Relatorio_Direcionamento.Name = "BTN_Relatorio_Direcionamento";
            BTN_Relatorio_Direcionamento.Padding = new Padding(7, 5, 4, 5);
            BTN_Relatorio_Direcionamento.Size = new Size(257, 67);
            BTN_Relatorio_Direcionamento.TabIndex = 0;
            BTN_Relatorio_Direcionamento.Text = "  Relatório";
            BTN_Relatorio_Direcionamento.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Relatorio_Direcionamento.UseVisualStyleBackColor = false;
            BTN_Relatorio_Direcionamento.Click += BTN_Relatorio_Direcionamento_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 593);
            panel2.Margin = new Padding(4, 33, 4, 5);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 0, 33);
            panel2.Size = new Size(329, 125);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(LblFuncao);
            panel3.Controls.Add(lblNome);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 9);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(329, 83);
            panel3.TabIndex = 10;
            // 
            // LblFuncao
            // 
            LblFuncao.AutoSize = true;
            LblFuncao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblFuncao.ForeColor = SystemColors.ButtonHighlight;
            LblFuncao.Location = new Point(90, 37);
            LblFuncao.Margin = new Padding(4, 0, 4, 0);
            LblFuncao.Name = "LblFuncao";
            LblFuncao.Size = new Size(87, 31);
            LblFuncao.TabIndex = 2;
            LblFuncao.Text = "Função";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = SystemColors.ButtonHighlight;
            lblNome.Location = new Point(90, 10);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(79, 31);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            lblNome.Click += lblNome_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.perfil;
            pictureBox2.Location = new Point(34, 17);
            pictureBox2.Margin = new Padding(4, 2, 4, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pnSairContainer
            // 
            pnSairContainer.BackColor = Color.MidnightBlue;
            pnSairContainer.Controls.Add(Btn_Sair);
            pnSairContainer.Dock = DockStyle.Bottom;
            pnSairContainer.Location = new Point(0, 718);
            pnSairContainer.Margin = new Padding(4, 5, 4, 5);
            pnSairContainer.Name = "pnSairContainer";
            pnSairContainer.Padding = new Padding(29, 17, 29, 17);
            pnSairContainer.Size = new Size(329, 150);
            pnSairContainer.TabIndex = 11;
            // 
            // Btn_Sair
            // 
            Btn_Sair.BackColor = Color.White;
            Btn_Sair.Dock = DockStyle.Top;
            Btn_Sair.FlatAppearance.BorderSize = 0;
            Btn_Sair.FlatStyle = FlatStyle.Flat;
            Btn_Sair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Sair.ForeColor = Color.MidnightBlue;
            Btn_Sair.Location = new Point(29, 17);
            Btn_Sair.Margin = new Padding(4, 5, 4, 5);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Padding = new Padding(14, 17, 14, 17);
            Btn_Sair.Size = new Size(271, 67);
            Btn_Sair.TabIndex = 5;
            Btn_Sair.Text = "Sair";
            Btn_Sair.UseVisualStyleBackColor = false;
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.MidnightBlue;
            pnMenu.Controls.Add(pnEspacador);
            pnMenu.Controls.Add(flowLayoutPanelMenu);
            pnMenu.Controls.Add(Painel_Perfil);
            pnMenu.Controls.Add(panel2);
            pnMenu.Controls.Add(pnSairContainer);
            pnMenu.Dock = DockStyle.Fill;
            pnMenu.Location = new Point(0, 0);
            pnMenu.Margin = new Padding(0);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(329, 868);
            pnMenu.TabIndex = 0;
            // 
            // pnEspacador
            // 
            pnEspacador.BackColor = Color.Transparent;
            pnEspacador.Dock = DockStyle.Fill;
            pnEspacador.Location = new Point(0, 438);
            pnEspacador.Margin = new Padding(4, 5, 4, 5);
            pnEspacador.Name = "pnEspacador";
            pnEspacador.Size = new Size(329, 155);
            pnEspacador.TabIndex = 0;
            // 
            // flowLayoutPanelMenu
            // 
            flowLayoutPanelMenu.Controls.Add(BTN_Relatorio_Direcionamento);
            flowLayoutPanelMenu.Controls.Add(Notificacao_Direcionamento);
            flowLayoutPanelMenu.Controls.Add(Turmas_Direcionamento);
            flowLayoutPanelMenu.Controls.Add(btnTurma);
            flowLayoutPanelMenu.Dock = DockStyle.Top;
            flowLayoutPanelMenu.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelMenu.Location = new Point(0, 148);
            flowLayoutPanelMenu.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            flowLayoutPanelMenu.Padding = new Padding(7, 17, 0, 0);
            flowLayoutPanelMenu.Size = new Size(329, 290);
            flowLayoutPanelMenu.TabIndex = 8;
            flowLayoutPanelMenu.WrapContents = false;
            // 
            // btnTurma
            // 
            btnTurma.BackColor = Color.MidnightBlue;
            btnTurma.FlatAppearance.BorderSize = 0;
            btnTurma.FlatStyle = FlatStyle.Flat;
            btnTurma.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTurma.ForeColor = Color.White;
            btnTurma.ImageAlign = ContentAlignment.MiddleLeft;
            btnTurma.ImageIndex = 3;
            btnTurma.ImageList = imageListMenu;
            btnTurma.Location = new Point(28, 241);
            btnTurma.Margin = new Padding(21, 0, 4, 0);
            btnTurma.Name = "btnTurma";
            btnTurma.Padding = new Padding(7, 5, 4, 0);
            btnTurma.Size = new Size(257, 67);
            btnTurma.TabIndex = 11;
            btnTurma.Text = "  Turmas";
            btnTurma.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTurma.UseVisualStyleBackColor = false;
            // 
            // Painel_Perfil
            // 
            Painel_Perfil.BackColor = Color.MidnightBlue;
            Painel_Perfil.Controls.Add(pictureBox1);
            Painel_Perfil.Dock = DockStyle.Top;
            Painel_Perfil.Location = new Point(0, 0);
            Painel_Perfil.Margin = new Padding(4, 5, 4, 5);
            Painel_Perfil.Name = "Painel_Perfil";
            Painel_Perfil.Size = new Size(329, 148);
            Painel_Perfil.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO1;
            pictureBox1.Location = new Point(10, 55);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 286F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pnMenu, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(329, 868);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MenuPrincipal";
            Size = new Size(329, 868);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnSairContainer.ResumeLayout(false);
            pnMenu.ResumeLayout(false);
            flowLayoutPanelMenu.ResumeLayout(false);
            Painel_Perfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Notificacao_Direcionamento;
        private ImageList imageListMenu;
        private ComboBox Turmas_Direcionamento;
        private Button BTN_Relatorio_Direcionamento;
        private Panel panel2;
        private Panel panel3;
        private Label LblFuncao;
        private Label lblNome;
        private PictureBox pictureBox2;
        private Panel pnSairContainer;
        private Button Btn_Sair;
        private Panel pnMenu;
        private Panel pnEspacador;
        private FlowLayoutPanel flowLayoutPanelMenu;
        private Button btnTurma;
        private Panel Painel_Perfil;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
