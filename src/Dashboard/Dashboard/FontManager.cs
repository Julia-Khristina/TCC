using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Dashboard
{
    public static class FontManager
    {
        private static readonly PrivateFontCollection privateFonts = new PrivateFontCollection();

        public static FontFamily PoppinsRegular { get; private set; }
        public static FontFamily PoppinsSemiBold { get; private set; }
        public static FontFamily PoppinsBold { get; private set; }

        static FontManager()
        {
            try
            {
                // PASSO 1: Carregar todos os arquivos de fonte.
                LoadFont("Poppins-Regular.ttf");
                LoadFont("Poppins-SemiBold.ttf");
                LoadFont("Poppins-Bold.ttf");

                // PASSO 2: Procurar as fontes pelos nomes conhecidos.
                PoppinsRegular = privateFonts.Families.FirstOrDefault(f => f.Name == "Poppins");
                PoppinsSemiBold = privateFonts.Families.FirstOrDefault(f => f.Name == "Poppins SemiBold");

                // =====================================================================
                // MUDANÇA CRÍTICA AQUI!
                // A fonte Bold pode ter o mesmo nome de família "Poppins".
                // O .NET diferencia pelo estilo (Bold, Regular, etc.).
                // Vamos atribuir a mesma família da Regular para a Bold.
                // =====================================================================
                PoppinsBold = PoppinsRegular;

                // PASSO 3: Verificar se alguma fonte falhou.
                if (PoppinsRegular == null || PoppinsSemiBold == null || PoppinsBold == null)
                {
#if DEBUG
                    string loadedFonts = string.Join(", ", privateFonts.Families.Select(f => f.Name));
                    MessageBox.Show($"Atenção: Uma ou mais fontes Poppins não foram encontradas. Usando 'Arial' como fallback.\n\nFontes carregadas: [{loadedFonts}]", "Erro de Fonte");
#endif

                    var fallbackFont = new FontFamily("Arial");
                    PoppinsRegular = PoppinsRegular ?? fallbackFont;
                    PoppinsSemiBold = PoppinsSemiBold ?? fallbackFont;
                    PoppinsBold = PoppinsBold ?? fallbackFont;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro crítico ao carregar fontes: " + ex.Message);
                var fallbackFont = new FontFamily("Arial");
                PoppinsRegular = PoppinsSemiBold = PoppinsBold = fallbackFont;
            }
        }

        private static void LoadFont(string fileName)
        {
            string fontPath = Path.Combine(Application.StartupPath, "Fonts", fileName);
            if (File.Exists(fontPath))
            {
                privateFonts.AddFontFile(fontPath);
            }
            else
            {
                throw new FileNotFoundException($"O arquivo de fonte '{fileName}' não foi encontrado no diretório 'Fonts'.");
            }
        }
    }
}
