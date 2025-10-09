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
            lblNome = new Label();
            arredondamentoBtn7 = new ArredondamentoBtn();
            Imagem_Perfil = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            arredondamentoBtn8 = new ArredondamentoBtn();
            btnVoltar = new Button();
            btnAlterar = new Button();
            label9 = new Label();
            label12 = new Label();
            label13 = new Label();
            lblTelefone = new Label();
            label11 = new Label();
            label14 = new Label();
            lblEmail = new Label();
            label16 = new Label();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)Imagem_Perfil).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(324, 168);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(0, 21);
            lblNome.TabIndex = 3;
            // 
            // arredondamentoBtn7
            // 
            arredondamentoBtn7.BackColor = Color.GhostWhite;
            arredondamentoBtn7.BorderColor = Color.Transparent;
            arredondamentoBtn7.BorderRadius = 10;
            arredondamentoBtn7.BorderSize = 0;
            arredondamentoBtn7.DisableHoverEffect = false;
            arredondamentoBtn7.FlatAppearance.BorderSize = 0;
            arredondamentoBtn7.FlatStyle = FlatStyle.Flat;
            arredondamentoBtn7.ForeColor = Color.White;
            arredondamentoBtn7.Location = new Point(45, 115);
            arredondamentoBtn7.Name = "arredondamentoBtn7";
            arredondamentoBtn7.Size = new Size(222, 280);
            arredondamentoBtn7.TabIndex = 12;
            arredondamentoBtn7.UseVisualStyleBackColor = false;
            // 
            // Imagem_Perfil
            // 
            Imagem_Perfil.Image = Properties.Resources.regiane;
            Imagem_Perfil.Location = new Point(51, 121);
            Imagem_Perfil.Name = "Imagem_Perfil";
            Imagem_Perfil.Size = new Size(209, 245);
            Imagem_Perfil.SizeMode = PictureBoxSizeMode.StretchImage;
            Imagem_Perfil.TabIndex = 13;
            Imagem_Perfil.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(395, 42);
            label7.Name = "label7";
            label7.Size = new Size(236, 30);
            label7.TabIndex = 14;
            label7.Text = "Configurações da Conta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(328, 88);
            label8.Name = "label8";
            label8.Size = new Size(371, 21);
            label8.TabIndex = 15;
            label8.Text = "Confira e atualize suas informações quando precisar";
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
            arredondamentoBtn8.Location = new Point(-48, -10);
            arredondamentoBtn8.Name = "arredondamentoBtn8";
            arredondamentoBtn8.Size = new Size(220, 499);
            arredondamentoBtn8.TabIndex = 16;
            arredondamentoBtn8.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.MidnightBlue;
            btnVoltar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(347, 394);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(149, 38);
            btnVoltar.TabIndex = 35;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.MidnightBlue;
            btnAlterar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Location = new Point(523, 394);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(149, 38);
            btnAlterar.TabIndex = 34;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(50, 368);
            label9.Name = "label9";
            label9.Size = new Size(115, 17);
            label9.TabIndex = 36;
            label9.Text = "Trocar de imagem";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(324, 140);
            label12.Name = "label12";
            label12.Size = new Size(55, 20);
            label12.TabIndex = 46;
            label12.Text = "Nome:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.ControlDark;
            label13.Location = new Point(325, 179);
            label13.Name = "label13";
            label13.Size = new Size(377, 15);
            label13.TabIndex = 45;
            label13.Text = "__________________________________________________________________________";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 12F);
            lblTelefone.Location = new Point(324, 244);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(0, 21);
            lblTelefone.TabIndex = 47;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(324, 216);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 49;
            label11.Text = "Telefone:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.ControlDark;
            label14.Location = new Point(325, 255);
            label14.Name = "label14";
            label14.Size = new Size(377, 15);
            label14.TabIndex = 48;
            label14.Text = "__________________________________________________________________________";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(324, 325);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(0, 21);
            lblEmail.TabIndex = 50;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(324, 297);
            label16.Name = "label16";
            label16.Size = new Size(52, 20);
            label16.TabIndex = 52;
            label16.Text = "Email:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.ControlDark;
            label17.Location = new Point(325, 336);
            label17.Name = "label17";
            label17.Size = new Size(377, 15);
            label17.TabIndex = 51;
            label17.Text = "__________________________________________________________________________";
            // 
            // FrmPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(770, 483);
            Controls.Add(lblEmail);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(lblTelefone);
            Controls.Add(label11);
            Controls.Add(label14);
            Controls.Add(lblNome);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label9);
            Controls.Add(btnVoltar);
            Controls.Add(btnAlterar);
            Controls.Add(Imagem_Perfil);
            Controls.Add(arredondamentoBtn7);
            Controls.Add(arredondamentoBtn8);
            Controls.Add(label8);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1, 2, 1, 2);
            Name = "FrmPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRelatorio";
            Load += FrmPerfil_Load;
            ((System.ComponentModel.ISupportInitialize)Imagem_Perfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNome;
        private ArredondamentoBtn arredondamentoBtn7;
        private PictureBox Imagem_Perfil;
        private Label label7;
        private Label label8;
        private ArredondamentoBtn arredondamentoBtn8;
        private Button btnVoltar;
        private Button btnAlterar;
        private Label label9;
        private Label label12;
        private Label label13;
        private Label lblTelefone;
        private Label label11;
        private Label label14;
        private Label lblEmail;
        private Label label16;
        private Label label17;
    }
}