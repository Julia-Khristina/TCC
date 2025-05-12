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
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
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
            lblPercentual.Location = new Point(328, 278);
            lblPercentual.Margin = new Padding(4, 0, 4, 0);
            lblPercentual.Name = "lblPercentual";
            lblPercentual.Size = new Size(13, 20);
            lblPercentual.TabIndex = 15;
            lblPercentual.Text = ".";
            lblPercentual.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(136, 100);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(405, 20);
            label3.TabIndex = 14;
            label3.Text = "CONTROLE DE ENTRADA DE ALUNOS ATRASADOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(197, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(286, 52);
            label1.TabIndex = 13;
            label1.Text = "PONTUALIZE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(254, 204);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(169, 21);
            label2.TabIndex = 12;
            label2.Text = "Carregando! Aguarde...";
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
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(676, 412);
            Controls.Add(label5);
            Controls.Add(lblPercentual);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
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
        private Label label3;
        private Label label1;
        private Label label2;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
    }
}