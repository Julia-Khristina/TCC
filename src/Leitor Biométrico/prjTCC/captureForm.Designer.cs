namespace prjTCC
{
    partial class captureForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(captureForm));
            this.picDigital = new System.Windows.Forms.PictureBox();
            this.txtPrompt = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtRM = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskTxtTel = new System.Windows.Forms.MaskedTextBox();
            this.picBoxLOGO = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelecionarFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDigital)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLOGO)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picDigital
            // 
            this.picDigital.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picDigital.Location = new System.Drawing.Point(28, 85);
            this.picDigital.Name = "picDigital";
            this.picDigital.Size = new System.Drawing.Size(186, 212);
            this.picDigital.TabIndex = 0;
            this.picDigital.TabStop = false;
            // 
            // txtPrompt
            // 
            this.txtPrompt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrompt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrompt.Location = new System.Drawing.Point(28, 313);
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.ReadOnly = true;
            this.txtPrompt.Size = new System.Drawing.Size(186, 20);
            this.txtPrompt.TabIndex = 1;
            this.txtPrompt.TextChanged += new System.EventHandler(this.txtPrompt_TextChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.White;
            this.txtStatus.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtStatus.Location = new System.Drawing.Point(3, 387);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(228, 20);
            this.txtStatus.TabIndex = 2;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStatus.Location = new System.Drawing.Point(23, 345);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 25);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(368, 131);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(356, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.ForeColor = System.Drawing.Color.Transparent;
            this.btnScan.Location = new System.Drawing.Point(612, 346);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(112, 41);
            this.btnScan.TabIndex = 5;
            this.btnScan.Text = "Escanear";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // txtRM
            // 
            this.txtRM.Location = new System.Drawing.Point(368, 192);
            this.txtRM.Name = "txtRM";
            this.txtRM.Size = new System.Drawing.Size(62, 20);
            this.txtRM.TabIndex = 6;
            this.txtRM.TextChanged += new System.EventHandler(this.txtRM_TextChanged);
            this.txtRM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRM_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(436, 192);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 20);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(723, 0);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(37, 32);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cmbTurma
            // 
            this.cmbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Location = new System.Drawing.Point(368, 240);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(288, 21);
            this.cmbTurma.TabIndex = 11;
            this.cmbTurma.SelectedIndexChanged += new System.EventHandler(this.cmbTurma_SelectedIndexChanged);
            // 
            // cmbAno
            // 
            this.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(662, 240);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(62, 21);
            this.cmbAno.TabIndex = 12;
            this.cmbAno.SelectedIndexChanged += new System.EventHandler(this.cmbAno_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picDigital);
            this.panel1.Controls.Add(this.picBoxLOGO);
            this.panel1.Controls.Add(this.txtPrompt);
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 433);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "RM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(659, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Telefone";
            // 
            // maskTxtTel
            // 
            this.maskTxtTel.Location = new System.Drawing.Point(637, 192);
            this.maskTxtTel.Mask = "(00)00000-0000";
            this.maskTxtTel.Name = "maskTxtTel";
            this.maskTxtTel.Size = new System.Drawing.Size(87, 20);
            this.maskTxtTel.TabIndex = 21;
            this.maskTxtTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.maskTxtTel.TextChanged += new System.EventHandler(this.maskTxtTel_TextChanged);
            // 
            // picBoxLOGO
            // 
            this.picBoxLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLOGO.Image")));
            this.picBoxLOGO.Location = new System.Drawing.Point(-62, -41);
            this.picBoxLOGO.Name = "picBoxLOGO";
            this.picBoxLOGO.Size = new System.Drawing.Size(369, 191);
            this.picBoxLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLOGO.TabIndex = 22;
            this.picBoxLOGO.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(246, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 130);
            this.panel2.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnSelecionarFoto
            // 
            this.btnSelecionarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarFoto.Location = new System.Drawing.Point(256, 275);
            this.btnSelecionarFoto.Name = "btnSelecionarFoto";
            this.btnSelecionarFoto.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarFoto.TabIndex = 23;
            this.btnSelecionarFoto.Text = "INSERIR";
            this.btnSelecionarFoto.UseVisualStyleBackColor = true;
            this.btnSelecionarFoto.Click += new System.EventHandler(this.btnSelecionarFoto_Click);
            // 
            // captureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(759, 409);
            this.Controls.Add(this.btnSelecionarFoto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.maskTxtTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.cmbTurma);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRM);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "captureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "capture";
            this.Activated += new System.EventHandler(this.captureForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.capture_FormClosing);
            this.Load += new System.EventHandler(this.capture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDigital)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLOGO)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDigital;
        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.ComboBox cmbTurma;
        public System.Windows.Forms.ComboBox cmbAno;
        protected System.Windows.Forms.TextBox txtNome;
        protected System.Windows.Forms.TextBox txtRM;
        protected System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox maskTxtTel;
        private System.Windows.Forms.PictureBox picBoxLOGO;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSelecionarFoto;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}