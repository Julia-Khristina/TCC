namespace Dashboard
{
    partial class frmSplash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            label5 = new Label();
            lblPercentual = new Label();
            lblSubtitulo = new Label();
            lblStatus = new Label();
            progressBar = new ProgressBar();
            timer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(293, 353);
            label5.Name = "label5";
            label5.Size = new Size(58, 13);
            label5.TabIndex = 16;
            label5.Text = "Versão 1.0";
            // 
            // lblPercentual
            // 
            lblPercentual.AutoSize = true;
            lblPercentual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPercentual.Location = new Point(310, 267);
            lblPercentual.Name = "lblPercentual";
            lblPercentual.Size = new Size(13, 20);
            lblPercentual.TabIndex = 15;
            lblPercentual.Text = ".";
            lblPercentual.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.MidnightBlue;
            lblSubtitulo.Location = new Point(172, 115);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(298, 20);
            lblSubtitulo.TabIndex = 14;
            lblSubtitulo.Text = "Controle de entrada de alunos atrasados";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(251, 206);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 16);
            lblStatus.TabIndex = 12;
            // 
            // progressBar
            // 
            progressBar.BackColor = SystemColors.ActiveBorder;
            progressBar.ForeColor = Color.Purple;
            progressBar.Location = new Point(109, 233);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(428, 22);
            progressBar.TabIndex = 11;
            // 
            // timer
            // 
            timer.Interval = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(234, 204);
            label1.Name = "label1";
            label1.Size = new Size(178, 18);
            label1.TabIndex = 17;
            label1.Text = "Preparando seu acesso...";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(173, 120);
            label4.Name = "label4";
            label4.Size = new Size(0, 13);
            label4.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(155, -39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // frmSplash
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(646, 389);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(lblPercentual);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblStatus);
            Controls.Add(progressBar);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInicio";
            Load += frmSplash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label lblPercentual;
        private Label lblSubtitulo;
        private Label lblStatus;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private Label label1;
        private Label label4;
        private PictureBox pictureBox1;
    }
}