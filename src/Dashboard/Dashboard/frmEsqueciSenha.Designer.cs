namespace Dashboard
{
    partial class frmEsqueciSenha
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
            txtSenha = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblAcesse = new Label();
            label3 = new Label();
            label1 = new Label();
            btnAlterar = new Button();
            btnBarra = new Button();
            btnVoltar = new Button();
            txtConfirmacao = new TextBox();
            label2 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblStatusSenha = new Label();
            txtEmail = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            lblStatusEmail = new Label();
            PicMostrarSenha = new PictureBox();
            PicMostrarSenha2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PicMostrarSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicMostrarSenha2).BeginInit();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.InactiveBorder;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.FromArgb(64, 64, 64);
            txtSenha.Location = new Point(400, 388);
            txtSenha.Margin = new Padding(4, 5, 4, 5);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.Size = new Size(517, 30);
            txtSenha.TabIndex = 32;
            txtSenha.TextChanged += txtSenha_TextChanged;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(467, 348);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(24, 32);
            label7.TabIndex = 27;
            label7.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(396, 348);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 32);
            label4.TabIndex = 25;
            label4.Text = "Senha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(396, 413);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(509, 25);
            label5.TabIndex = 24;
            label5.Text = "_______________________________________________________________________";
            // 
            // lblAcesse
            // 
            lblAcesse.AutoSize = true;
            lblAcesse.ForeColor = SystemColors.ControlDarkDark;
            lblAcesse.Location = new Point(504, 163);
            lblAcesse.Margin = new Padding(4, 0, 4, 0);
            lblAcesse.Name = "lblAcesse";
            lblAcesse.Size = new Size(319, 25);
            lblAcesse.TabIndex = 23;
            lblAcesse.Text = "Digite a seguir as informações pedidas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(396, 155);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(509, 25);
            label3.TabIndex = 22;
            label3.Text = "_______________________________________________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(314, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(729, 77);
            label1.TabIndex = 20;
            label1.Text = "Recuperação de Acesso";
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.MidnightBlue;
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Location = new Point(703, 610);
            btnAlterar.Margin = new Padding(4, 5, 4, 5);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(213, 63);
            btnAlterar.TabIndex = 18;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnBarra
            // 
            btnBarra.BackColor = Color.MidnightBlue;
            btnBarra.Location = new Point(-386, -45);
            btnBarra.Margin = new Padding(4, 5, 4, 5);
            btnBarra.Name = "btnBarra";
            btnBarra.Size = new Size(584, 802);
            btnBarra.TabIndex = 17;
            btnBarra.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.MidnightBlue;
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(396, 610);
            btnVoltar.Margin = new Padding(4, 5, 4, 5);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(213, 63);
            btnVoltar.TabIndex = 33;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtConfirmacao
            // 
            txtConfirmacao.BackColor = SystemColors.InactiveBorder;
            txtConfirmacao.BorderStyle = BorderStyle.None;
            txtConfirmacao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmacao.ForeColor = Color.FromArgb(64, 64, 64);
            txtConfirmacao.Location = new Point(399, 500);
            txtConfirmacao.Margin = new Padding(4, 5, 4, 5);
            txtConfirmacao.Name = "txtConfirmacao";
            txtConfirmacao.PasswordChar = '●';
            txtConfirmacao.Size = new Size(514, 30);
            txtConfirmacao.TabIndex = 38;
            txtConfirmacao.TextChanged += txtConfirmacao_TextChanged;
            txtConfirmacao.KeyDown += txtConfirmacao_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(446, 500);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(598, 460);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(24, 32);
            label6.TabIndex = 36;
            label6.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(399, 460);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(207, 32);
            label8.TabIndex = 35;
            label8.Text = "Confirme a senha:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlDark;
            label9.Location = new Point(399, 525);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(509, 25);
            label9.TabIndex = 34;
            label9.Text = "_______________________________________________________________________";
            // 
            // lblStatusSenha
            // 
            lblStatusSenha.AutoSize = true;
            lblStatusSenha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusSenha.ForeColor = Color.Red;
            lblStatusSenha.Location = new Point(399, 565);
            lblStatusSenha.Margin = new Padding(4, 0, 4, 0);
            lblStatusSenha.Name = "lblStatusSenha";
            lblStatusSenha.Size = new Size(0, 25);
            lblStatusSenha.TabIndex = 39;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.InactiveBorder;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(403, 257);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(517, 30);
            txtEmail.TabIndex = 44;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(446, 257);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(0, 25);
            label10.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(469, 217);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(24, 32);
            label11.TabIndex = 42;
            label11.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(397, 217);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(76, 32);
            label12.TabIndex = 41;
            label12.Text = "Email:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.ControlDark;
            label13.Location = new Point(399, 282);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(509, 25);
            label13.TabIndex = 40;
            label13.Text = "_______________________________________________________________________";
            // 
            // lblStatusEmail
            // 
            lblStatusEmail.AutoSize = true;
            lblStatusEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusEmail.ForeColor = Color.Red;
            lblStatusEmail.Location = new Point(400, 317);
            lblStatusEmail.Margin = new Padding(4, 0, 4, 0);
            lblStatusEmail.Name = "lblStatusEmail";
            lblStatusEmail.Size = new Size(0, 25);
            lblStatusEmail.TabIndex = 45;
            // 
            // PicMostrarSenha
            // 
            PicMostrarSenha.Cursor = Cursors.Hand;
            PicMostrarSenha.Image = Properties.Resources.olho_fechado;
            PicMostrarSenha.Location = new Point(871, 398);
            PicMostrarSenha.Margin = new Padding(4, 5, 4, 5);
            PicMostrarSenha.Name = "PicMostrarSenha";
            PicMostrarSenha.Size = new Size(34, 33);
            PicMostrarSenha.SizeMode = PictureBoxSizeMode.StretchImage;
            PicMostrarSenha.TabIndex = 46;
            PicMostrarSenha.TabStop = false;
            PicMostrarSenha.Click += PicMostrarSenha_Click;
            // 
            // PicMostrarSenha2
            // 
            PicMostrarSenha2.Cursor = Cursors.Hand;
            PicMostrarSenha2.Image = Properties.Resources.olho_fechado;
            PicMostrarSenha2.Location = new Point(871, 510);
            PicMostrarSenha2.Margin = new Padding(4, 5, 4, 5);
            PicMostrarSenha2.Name = "PicMostrarSenha2";
            PicMostrarSenha2.Size = new Size(34, 33);
            PicMostrarSenha2.SizeMode = PictureBoxSizeMode.StretchImage;
            PicMostrarSenha2.TabIndex = 47;
            PicMostrarSenha2.TabStop = false;
            PicMostrarSenha2.Click += PicMostrarSenha2_Click;
            // 
            // frmEsqueciSenha
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1143, 750);
            Controls.Add(PicMostrarSenha2);
            Controls.Add(PicMostrarSenha);
            Controls.Add(lblStatusEmail);
            Controls.Add(txtEmail);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(lblStatusSenha);
            Controls.Add(txtConfirmacao);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(btnVoltar);
            Controls.Add(txtSenha);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(lblAcesse);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnAlterar);
            Controls.Add(btnBarra);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmEsqueciSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Activated += frmEsqueciSenha_Activated;
            Load += frmEsqueciSenha_Load;
            ((System.ComponentModel.ISupportInitialize)PicMostrarSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicMostrarSenha2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSenha;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label lblAcesse;
        private Label label3;
        private Label label1;
        private Button btnAlterar;
        private Button btnBarra;
        private Button btnVoltar;
        private TextBox txtConfirmacao;
        private Label label2;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label lblStatusSenha;
        private TextBox txtEmail;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label lblStatusEmail;
        private PictureBox PicMostrarSenha;
        private PictureBox pictureBox1;
        private PictureBox PicMostrarSenha2;
    }
}