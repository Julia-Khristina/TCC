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
            label5 = new Label();
            lblPercentual = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            lblStatus = new Label();
            progressBar = new ProgressBar();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(308, 369);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 13);
            label5.TabIndex = 16;
            label5.Text = "Versão 1.0";
            // 
            // lblPercentual
            // 
            lblPercentual.AutoSize = true;
            lblPercentual.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPercentual.Location = new Point(328, 216);
            lblPercentual.Margin = new Padding(4, 0, 4, 0);
            lblPercentual.Name = "lblPercentual";
            lblPercentual.Size = new Size(13, 20);
            lblPercentual.TabIndex = 15;
            lblPercentual.Text = ".";
            lblPercentual.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.MidnightBlue;
            lblSubtitulo.Location = new Point(128, 122);
            lblSubtitulo.Margin = new Padding(4, 0, 4, 0);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(413, 18);
            lblSubtitulo.TabIndex = 14;
            lblSubtitulo.Text = "CONTROLE DE ENTRADA DE ALUNOS ATRASADOS";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.MidnightBlue;
            lblTitulo.Location = new Point(182, 48);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(309, 55);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "PONTUALIZE";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(256, 219);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 16);
            lblStatus.TabIndex = 12;
            // 
            // progressBar
            // 
            progressBar.BackColor = SystemColors.ActiveCaptionText;
            progressBar.ForeColor = Color.Purple;
            progressBar.Location = new Point(136, 248);
            progressBar.Margin = new Padding(4, 3, 4, 3);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(405, 27);
            progressBar.TabIndex = 11;
            // 
            // timer
            // 
            timer.Interval = 50;
            // 
            // frmSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(676, 412);
            Controls.Add(label5);
            Controls.Add(lblPercentual);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Controls.Add(lblStatus);
            Controls.Add(progressBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInicio";
            Load += frmSplash_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label lblPercentual;
        private Label lblSubtitulo;
        private Label lblTitulo;
        private Label lblStatus;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
    }
}