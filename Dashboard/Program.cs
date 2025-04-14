using System;
using System.IO;
using System.Windows.Forms;

namespace Dashboard
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configura o manipulador de exceções não tratadas
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            // Configurações iniciais importantes
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicialização da configuração da aplicação
            ApplicationConfiguration.Initialize();

            // Execute o formulário principal com tratamento de exceções
            try
            {
                Application.Run(new frmSplash());
            }
            catch (Exception ex)
            {
                LogError(ex);
                ShowFatalError(ex);
            }
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            LogError(e.Exception);
            ShowFatalError(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is Exception ex)
            {
                LogError(ex);
                ShowFatalError(ex);
            }
        }

        private static void LogError(Exception ex)
        {
            try
            {
                string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error_log.txt");
                File.AppendAllText(logPath, $"[{DateTime.Now}] ERROR: {ex}\nStack Trace: {ex.StackTrace}\n\n");
            }
            catch { /* Não falhar se não conseguir escrever no log */ }
        }

        private static void ShowFatalError(Exception ex)
        {
            MessageBox.Show($"Ocorreu um erro crítico: {ex.Message}\nO aplicativo será fechado.\n\nDetalhes foram registrados no log.",
                          "Erro Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}