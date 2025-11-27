using DPFP;
using DPFP.Capture;
using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;
using Dashboard;


namespace prjTCC
{
    public partial class captureForm : Form, DPFP.Capture.EventHandler
    {
        private DPFP.Capture.Capture Capturer;
        public string Nome = "";
        public string RM = "";
        public string Turma = "";
        public string Ano = "";
        public string Email = "";
        public string Telefone = "";

        private DPFP.Template Template;

        private const int borderRadius = 25; // Mesma constante usada no frmLogin
        private bool isMouseOverBtnVoltar = false;
        private bool isMouseOverBtnScan = false;

        public void onTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;

                if (Template != null)
                {
                    MessageBox.Show(this,"Aluno cadastrado com sucesso","Cadastrado", MessageBoxButtons.OK,MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o aluno");

                }

            }));
        }

        public captureForm()
        {
            InitializeComponent();

            // Configurações do scan
            btnScan.FlatStyle = FlatStyle.Flat;
            btnScan.FlatAppearance.BorderSize = 0;
            btnScan.BackColor = ColorTranslator.FromHtml("#5C6BC0"); // Azul principal
            btnScan.ForeColor = Color.White;
            btnScan.Paint += (s, e) => RoundControl(btnScan, e, ref isMouseOverBtnScan);
            btnScan.Resize += (s, e) => btnScan.Invalidate();
            btnScan.MouseEnter += (s, e) => { isMouseOverBtnScan = true; btnScan.Invalidate(); };
            btnScan.MouseLeave += (s, e) => { isMouseOverBtnScan = false; btnScan.Invalidate(); };

            
            // Configurações do voltar
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.BackColor = ColorTranslator.FromHtml("#DDE0E3"); // Cinza claro
            btnVoltar.ForeColor = ColorTranslator.FromHtml("#212529");
            btnVoltar.Paint += (s, e) => RoundControl(btnVoltar, e, ref isMouseOverBtnVoltar);
            btnVoltar.Resize += (s, e) => btnVoltar.Invalidate();
            btnVoltar.MouseEnter += (s, e) => { isMouseOverBtnVoltar = true; btnVoltar.Invalidate(); };
            btnVoltar.MouseLeave += (s, e) => { isMouseOverBtnVoltar = false; btnVoltar.Invalidate(); };

            // Configurações do voltar
            btnSelecionarFoto.FlatAppearance.BorderSize = 0;
            btnSelecionarFoto.BackColor = ColorTranslator.FromHtml("#DDE0E3"); // Azul principal
            btnSelecionarFoto.ForeColor = ColorTranslator.FromHtml("#212529");
            btnSelecionarFoto.Paint += (s, e) => RoundControl(btnSelecionarFoto, e, ref isMouseOverBtnVoltar);
            btnSelecionarFoto.Resize += (s, e) => btnSelecionarFoto.Invalidate();
            btnSelecionarFoto.MouseEnter += (s, e) => { isMouseOverBtnVoltar = true; btnSelecionarFoto.Invalidate(); };
            btnSelecionarFoto.MouseLeave += (s, e) => { isMouseOverBtnVoltar = false; btnSelecionarFoto.Invalidate(); };
        }

        private void RoundControl(Control control, PaintEventArgs e, ref bool isMouseOver)
        {
            if (control == null || e == null || control.IsDisposed || !control.IsHandleCreated)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (var path = new GraphicsPath())
            {
                Rectangle bounds = new Rectangle(0, 0, control.Width - 1, control.Height - 1);
                path.AddArc(bounds.X, bounds.Y, borderRadius, borderRadius, 180, 90);
                path.AddArc(bounds.Right - borderRadius, bounds.Y, borderRadius, borderRadius, 270, 90);
                path.AddArc(bounds.Right - borderRadius, bounds.Bottom - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - borderRadius, borderRadius, borderRadius, 90, 90);
                path.CloseAllFigures();

                control.Region = new Region(path);

                // Define a cor considerando MouseOver
                Color currentBackColor = control.BackColor;
                if (isMouseOver)
                {
                    if (control == btnVoltar)
                        currentBackColor = ColorTranslator.FromHtml("#D6D9DC"); // MouseOver cinza

                    else if (control == btnScan)
                        currentBackColor = ColorTranslator.FromHtml("#7986CB"); // MouseOver azul mais claro
                    else 
                        currentBackColor = ColorTranslator.FromHtml("#D6D9DC");
                }

                e.Graphics.FillPath(new SolidBrush(currentBackColor), path);
                e.Graphics.DrawPath(new Pen(control.Parent?.BackColor ?? Color.Transparent, 1), path);

                if (control is Button btn)
                {
                    TextRenderer.DrawText(
                        e.Graphics,
                        btn.Text,
                        btn.Font,
                        control.ClientRectangle,
                        btn.ForeColor,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
            }
        }

        protected void SetPrompt(string prompt)
        {
            this.Invoke(new Function(delegate ()
                {
                    txtPrompt.Text = prompt;

                }));
        }

        protected void SetStatus(string status)
        {
            this.Invoke(new Function(delegate ()
            {
                lblStatus.Text = status;

            }));
        }



        protected void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new Function(delegate ()
            {
                picDigital.Image = new Bitmap(bitmap, picDigital.Size);
            }));
        }

        protected void SetFname(string value)
        {
            this.Invoke(new Function(delegate ()
            {
                txtNome.Text = value;
            }));
        }

        protected void SetRM(string value)
        {
            this.Invoke(new Function(delegate ()
            {
                txtRM.Text = value;
            }));
        }

        protected void SetEmail(string value)
        {
            this.Invoke(new Function(delegate ()
            {
                txtEmail.Text = value;
            }));
        }



        protected void SetAno(string value)
        {
            this.Invoke(new Function(delegate ()
            {
                cmbAno.Text = value;
            }));
        }

        protected void SetTurma(string value)
        {
            this.Invoke(new Function(delegate ()
            {
                cmbTurma.Text = value;
            }));
        }

        protected void SetTelefone(string value)
        {
            this.Invoke(new Function(delegate ()
            {
                maskTxtTel.Text = value;
            }));
        }

        protected virtual void init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();
                if (null != Capturer)
                {
                    Capturer.EventHandler = this;
                }

                else
                    SetPrompt("Não inicializou a captura de digital");
            }
            catch 
            {
                MessageBox.Show("Não inicializou a captura de digital");
            }
        }

        // Processo

        protected virtual void Process(DPFP.Sample Sample)
        {
            DrawPicture(ConvertSampleToBitmap(Sample));
        }

        

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Converter = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            Converter.ConvertToPicture(Sample, ref bitmap);
            return bitmap;
        }

        protected void Start()
        { 
            if(null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Usando o leitor, escaneando a sua digital");
                }
                catch
                {
                    SetPrompt("Não foi possivel iniciar");
                }
            }
        }

        protected void Stop()
        {
            if (Capturer != null)
            {
                try
                {
                    Capturer.StopCapture();
                    if (timer1 != null) timer1.Stop(); 
                }
                catch
                {
                    SetPrompt("Não foi possível terminar a captura");
                }
            }
        }
        protected void MakeReport(string message)
        {
            this.Invoke(new Function(delegate ()
            {
                txtStatus.AppendText(message + "\r\n");

            }));
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet feature = new DPFP.FeatureSet();

            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref feature);

            if (feedback == DPFP.Capture.CaptureFeedback.Good)
            {
                return feature;
            }
            else
            {
                return null;
            }
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            MakeReport("Captura concluída com sucesso.");
            Process(Sample); // Processa a digital capturada
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("Dedo removido do sensor.");
            SetPrompt("Posicione novamente o dedo para capturar.");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("Dedo detectado no sensor.");
            SetPrompt("Capturando a digital...");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("Leitor biométrico conectado.");
            SetPrompt("Leitor pronto para captura.");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("Leitor biométrico desconectado.");
            SetPrompt("Reconecte o leitor para continuar.");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
            {
                MakeReport("Qualidade da digital: Boa.");
            }
            else
            {
                MakeReport("Qualidade da digital: Ruim. Tente novamente.");
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            Start();
        }

        private void capture_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();

            if (MessageBox.Show("Confirma a saída dessa tela?",
                "Mensagem", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)

                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void capture_Load(object sender, EventArgs e)
        {
            init();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Nome = txtNome.Text;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                MessageBox.Show("Campo Vazio","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Campo Vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (maskTxtTel.Text == "")
            {
                MessageBox.Show("Campo Vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskTxtTel.Focus();
                return;
            }
            if (txtRM.Text == "")
            {
                MessageBox.Show("Campo Vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRM.Focus();
                return;
            }
            if (cmbAno.SelectedIndex == -1)
            {
                MessageBox.Show("Campo Vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbAno.Focus();
                return;
            }
            if (cmbTurma.SelectedIndex == -1)
            {
                MessageBox.Show("Campo Vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbTurma.Focus();
                return;
            }


            Start();


        }

      

        private void txtRM_TextChanged(object sender, EventArgs e)
        {
            RM = txtRM.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Email = txtEmail.Text;
        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTurma_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTurma.SelectedValue != null)
                Turma = cmbTurma.SelectedValue.ToString();
        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAno.SelectedValue != null)
                Ano = cmbAno.SelectedValue.ToString();
        }

        private void captureForm_Activated(object sender, EventArgs e)
        {
        
        }

        private void txtRM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44
                && e.KeyChar != (char)45)  //8=backspace,44=virgula,45=Negativo
            {
                e.Handled = true;
            }
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir somente dígitos e tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela o caractere digitado
            }
        }

        private bool IsValidEmail(string email)
        {
            // Expressão regular simples para validar email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email inválido! Por favor, digite um email no formato correto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();  // Deixa o foco na TextBox para corrigir
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txtPrompt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelecionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
 
            }
        }

        private void maskTxtTel_TextChanged(object sender, EventArgs e)
        {
            Telefone = maskTxtTel.Text;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

