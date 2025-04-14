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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBarra
            // 
            btnBarra.BackColor = Color.MidnightBlue;
            btnBarra.Location = new Point(-7, -8);
            btnBarra.Name = "btnBarra";
            btnBarra.Size = new Size(388, 468);
            btnBarra.TabIndex = 0;
            btnBarra.UseVisualStyleBackColor = false;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.MidnightBlue;
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(515, 370);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(149, 38);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Login_Etec;
            pictureBox1.Location = new Point(-7, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(372, 468);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(513, 48);
            label1.Name = "label1";
            label1.Size = new Size(153, 52);
            label1.TabIndex = 3;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(434, 164);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 4;
            label2.Text = "Email Cadastrado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(434, 115);
            label3.Name = "label3";
            label3.Size = new Size(307, 15);
            label3.TabIndex = 5;
            label3.Text = "____________________________________________________________";
            // 
            // lblAcesse
            // 
            lblAcesse.AutoSize = true;
            lblAcesse.ForeColor = SystemColors.ControlDarkDark;
            lblAcesse.Location = new Point(521, 120);
            lblAcesse.Name = "lblAcesse";
            lblAcesse.Size = new Size(136, 15);
            lblAcesse.TabIndex = 6;
            lblAcesse.Text = "Acesse a sua Dashboard!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(435, 299);
            label5.Name = "label5";
            label5.Size = new Size(307, 15);
            label5.TabIndex = 7;
            label5.Text = "____________________________________________________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(434, 255);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 8;
            label4.Text = "Senha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(562, 163);
            label6.Name = "label6";
            label6.Size = new Size(17, 21);
            label6.TabIndex = 9;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(484, 255);
            label7.Name = "label7";
            label7.Size = new Size(17, 21);
            label7.TabIndex = 10;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(434, 208);
            label8.Name = "label8";
            label8.Size = new Size(307, 15);
            label8.TabIndex = 11;
            label8.Text = "____________________________________________________________";
            // 
            // lblStatusEmail
            // 
            lblStatusEmail.AutoSize = true;
            lblStatusEmail.ForeColor = Color.Red;
            lblStatusEmail.Location = new Point(434, 226);
            lblStatusEmail.Name = "lblStatusEmail";
            lblStatusEmail.Size = new Size(0, 15);
            lblStatusEmail.TabIndex = 12;
            // 
            // lblStatusSenha
            // 
            lblStatusSenha.AutoSize = true;
            lblStatusSenha.ForeColor = Color.Red;
            lblStatusSenha.Location = new Point(435, 318);
            lblStatusSenha.Name = "lblStatusSenha";
            lblStatusSenha.Size = new Size(0, 15);
            lblStatusSenha.TabIndex = 13;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.InactiveBorder;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            txtUsuario.Location = new Point(438, 192);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(303, 20);
            txtUsuario.TabIndex = 14;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.InactiveBorder;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.FromArgb(64, 64, 64);
            txtSenha.Location = new Point(438, 284);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(303, 20);
            txtSenha.TabIndex = 15;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(800, 450);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}