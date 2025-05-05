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
            this.picDigital = new System.Windows.Forms.PictureBox();
            this.txtPrompt = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtRM = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDigital)).BeginInit();
            this.SuspendLayout();
            // 
            // picDigital
            // 
            this.picDigital.Location = new System.Drawing.Point(18, 55);
            this.picDigital.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picDigital.Name = "picDigital";
            this.picDigital.Size = new System.Drawing.Size(364, 594);
            this.picDigital.TabIndex = 0;
            this.picDigital.TabStop = false;
            // 
            // txtPrompt
            // 
            this.txtPrompt.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrompt.Location = new System.Drawing.Point(18, 658);
            this.txtPrompt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(362, 26);
            this.txtPrompt.TabIndex = 1;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtStatus.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtStatus.Location = new System.Drawing.Point(3, 766);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(1198, 45);
            this.txtStatus.TabIndex = 2;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(13, 724);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(108, 37);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(460, 98);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(532, 26);
            this.txtNome.TabIndex = 4;
            this.txtNome.Text = "Nome do Aluno";
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(1019, 682);
            this.btnScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(168, 63);
            this.btnScan.TabIndex = 5;
            this.btnScan.Text = "Escanear";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // txtRM
            // 
            this.txtRM.Location = new System.Drawing.Point(460, 154);
            this.txtRM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRM.Name = "txtRM";
            this.txtRM.Size = new System.Drawing.Size(532, 26);
            this.txtRM.TabIndex = 6;
            this.txtRM.Text = "RM";
            this.txtRM.TextChanged += new System.EventHandler(this.txtRM_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(460, 217);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(532, 26);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Text = "Email";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(460, 282);
            this.txtAno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(532, 26);
            this.txtAno.TabIndex = 8;
            this.txtAno.Text = "Ano";
            this.txtAno.TextChanged += new System.EventHandler(this.txtAno_TextChanged);
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(460, 354);
            this.txtTurma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(532, 26);
            this.txtTurma.TabIndex = 9;
            this.txtTurma.Text = "Turma";
            this.txtTurma.TextChanged += new System.EventHandler(this.txtTurma_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Location = new System.Drawing.Point(1132, 34);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 50);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // captureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 808);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRM);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtPrompt);
            this.Controls.Add(this.picDigital);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "captureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "capture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.capture_FormClosing);
            this.Load += new System.EventHandler(this.capture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDigital)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDigital;
        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtRM;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Button btnSair;
    }
}