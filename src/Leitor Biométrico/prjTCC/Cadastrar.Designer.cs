namespace prjTCC
{
    partial class Cadastrar
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // txtRM
            // 
            this.txtRM.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // txtEmail
            // 
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // maskTxtTel
            // 
            this.maskTxtTel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 609);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Cadastrar";
            this.Text = "Reroll";
            this.Load += new System.EventHandler(this.reroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }

}