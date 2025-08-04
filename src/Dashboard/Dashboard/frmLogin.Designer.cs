namespace Dashboard
{
    partial class frmLogin
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
            btnBarra = new Button();
            btnEntrar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblAcesse = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblStatusEmail = new Label();
            lblStatusSenha = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            lblEsqueciSenha = new Label();
            PicMostrarSenha = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicMostrarSenha).BeginInit();
            SuspendLayout();
            // 
            // btnBarra
            // 
            btnBarra.BackColor = Color.MidnightBlue;
            btnBarra.Location = new Point(-8, -11);
            btnBarra.Margin = new Padding(3, 4, 3, 4);
            btnBarra.Name = "btnBarra";
            btnBarra.Size = new Size(443, 624);
            btnBarra.TabIndex = 0;
            btnBarra.UseVisualStyleBackColor = false;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(98, 114, 255);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(589, 497);
            btnEntrar.Margin = new Padding(3, 4, 3, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(170, 51);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Login_Etec;
            pictureBox1.Location = new Point(-8, -11);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(429, 624);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(586, 51);
            label1.Name = "label1";
            label1.Size = new Size(189, 64);
            label1.TabIndex = 3;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(496, 205);
            label2.Name = "label2";
            label2.Size = new Size(168, 28);
            label2.TabIndex = 4;
            label2.Text = "Email Cadastrado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(496, 140);
            label3.Name = "label3";
            label3.Size = new Size(369, 20);
            label3.TabIndex = 5;
            label3.Text = "____________________________________________________________";
            // 
            // lblAcesse
            // 
            lblAcesse.AutoSize = true;
            lblAcesse.ForeColor = SystemColors.ControlDarkDark;
            lblAcesse.Location = new Point(595, 147);
            lblAcesse.Name = "lblAcesse";
            lblAcesse.Size = new Size(173, 20);
            lblAcesse.TabIndex = 6;
            lblAcesse.Text = "Acesse a sua Dashboard!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(497, 385);
            label5.Name = "label5";
            label5.Size = new Size(369, 20);
            label5.TabIndex = 7;
            label5.Text = "____________________________________________________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(496, 327);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 8;
            label4.Text = "Senha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(657, 204);
            label6.Name = "label6";
            label6.Size = new Size(20, 28);
            label6.TabIndex = 9;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(559, 327);
            label7.Name = "label7";
            label7.Size = new Size(20, 28);
            label7.TabIndex = 10;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(496, 264);
            label8.Name = "label8";
            label8.Size = new Size(369, 20);
            label8.TabIndex = 11;
            label8.Text = "____________________________________________________________";
            // 
            // lblStatusEmail
            // 
            lblStatusEmail.AutoSize = true;
            lblStatusEmail.ForeColor = Color.Red;
            lblStatusEmail.Location = new Point(496, 288);
            lblStatusEmail.Name = "lblStatusEmail";
            lblStatusEmail.Size = new Size(0, 20);
            lblStatusEmail.TabIndex = 12;
            // 
            // lblStatusSenha
            // 
            lblStatusSenha.AutoSize = true;
            lblStatusSenha.ForeColor = Color.Red;
            lblStatusSenha.Location = new Point(497, 411);
            lblStatusSenha.Name = "lblStatusSenha";
            lblStatusSenha.Size = new Size(0, 20);
            lblStatusSenha.TabIndex = 13;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.InactiveBorder;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            txtUsuario.Location = new Point(501, 243);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(346, 25);
            txtUsuario.TabIndex = 14;
            txtUsuario.KeyDown += txtUsuario_KeyDown;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.InactiveBorder;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.FromArgb(64, 64, 64);
            txtSenha.Location = new Point(501, 365);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.Size = new Size(346, 25);
            txtSenha.TabIndex = 15;
            txtSenha.TextChanged += txtSenha_TextChanged;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // lblEsqueciSenha
            // 
            lblEsqueciSenha.AutoSize = true;
            lblEsqueciSenha.ForeColor = Color.Red;
            lblEsqueciSenha.Location = new Point(741, 447);
            lblEsqueciSenha.Name = "lblEsqueciSenha";
            lblEsqueciSenha.Size = new Size(117, 20);
            lblEsqueciSenha.TabIndex = 16;
            lblEsqueciSenha.Text = "Esqueci a senha!";
            lblEsqueciSenha.Click += lblEsqueciSenha_Click;
            // 
            // PicMostrarSenha
            // 
            PicMostrarSenha.Image = Properties.Resources.olho_fechado;
            PicMostrarSenha.Location = new Point(813, 375);
            PicMostrarSenha.Margin = new Padding(3, 4, 3, 4);
            PicMostrarSenha.Name = "PicMostrarSenha";
            PicMostrarSenha.Size = new Size(27, 27);
            PicMostrarSenha.SizeMode = PictureBoxSizeMode.StretchImage;
            PicMostrarSenha.TabIndex = 17;
            PicMostrarSenha.TabStop = false;
            PicMostrarSenha.Click += PicMostrarSenha_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(914, 600);
            Controls.Add(PicMostrarSenha);
            Controls.Add(lblEsqueciSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblStatusSenha);
            Controls.Add(lblStatusEmail);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(lblAcesse);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnEntrar);
            Controls.Add(btnBarra);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Activated += frmLogin_Activated;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicMostrarSenha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBarra;
        private Button btnEntrar;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblAcesse;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblStatusEmail;
        private Label lblStatusSenha;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label lblEsqueciSenha;
        private PictureBox PicMostrarSenha;
    }
}