namespace Dashboard
{
    partial class Frm_PromoverAluno
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
            label1 = new Label();
            label2 = new Label();
            cmbAno = new ComboBox();
            cbmAlunos = new ComboBox();
            btnPromover = new Button();
            cmbTurma = new ComboBox();
            lbl3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(530, 79);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Série:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 165);
            label2.Name = "label2";
            label2.Size = new Size(246, 15);
            label2.TabIndex = 1;
            label2.Text = "Selecionar alunos que não serão promovidos:";
            // 
            // cmbAno
            // 
            cmbAno.FormattingEnabled = true;
            cmbAno.Location = new Point(544, 106);
            cmbAno.Name = "cmbAno";
            cmbAno.Size = new Size(121, 23);
            cmbAno.TabIndex = 2;
            cmbAno.SelectedIndexChanged += cmbAno_SelectedIndexChanged_1;
            // 
            // cbmAlunos
            // 
            cbmAlunos.Enabled = false;
            cbmAlunos.FormattingEnabled = true;
            cbmAlunos.Location = new Point(338, 197);
            cbmAlunos.Name = "cbmAlunos";
            cbmAlunos.Size = new Size(327, 23);
            cbmAlunos.TabIndex = 3;
            // 
            // btnPromover
            // 
            btnPromover.Location = new Point(324, 326);
            btnPromover.Name = "btnPromover";
            btnPromover.Size = new Size(75, 23);
            btnPromover.TabIndex = 4;
            btnPromover.Text = "Promover";
            btnPromover.UseVisualStyleBackColor = true;
            // 
            // cmbTurma
            // 
            cmbTurma.FormattingEnabled = true;
            cmbTurma.Location = new Point(338, 106);
            cmbTurma.Name = "cmbTurma";
            cmbTurma.Size = new Size(121, 23);
            cmbTurma.TabIndex = 6;
            cmbTurma.SelectedIndexChanged += cmbTurma_SelectedIndexChanged_1;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(324, 79);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(41, 15);
            lbl3.TabIndex = 5;
            lbl3.Text = "Curso:";
            // 
            // Frm_PromoverAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 569);
            Controls.Add(cmbTurma);
            Controls.Add(lbl3);
            Controls.Add(btnPromover);
            Controls.Add(cbmAlunos);
            Controls.Add(cmbAno);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm_PromoverAluno";
            Text = "Frm_PromoverAluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbAno;
        private ComboBox cbmAlunos;
        private Button btnPromover;
        private ComboBox cmbTurma;
        private Label lbl3;
    }
}