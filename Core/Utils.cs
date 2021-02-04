using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WynnicTranslator.Core
{
    public static class Utils
    {
        public static class FontUtils
        {
            private static readonly PrivateFontCollection FontCollection = new PrivateFontCollection();
            public static Font WynnicFont;
            public static Font FallbackFont;

            public static void Init()
            {
                FontCollection.AddFontFile(Path.Combine(
                    App.ResFolder, "Wynnic-Regular.otf"));
                FontCollection.AddFontFile(Path.Combine(App.ResFolder, "FiraSans-Medium.ttf"));
                WynnicFont = new Font(FontCollection.Families[1], 11F);
                FallbackFont = new Font(FontCollection.Families[0], 10.5F);
                foreach (var font in FontCollection.Families) Logger.Log(font.Name, "FONT");
                FontCollection.Dispose();
            }
        }

        public static class App
        {
            private static readonly string StartDir = Application.StartupPath;

            private static string StartupDir => Regex.Split(StartDir, "bin")[0].TrimEnd('\\');

            public static string ResFolder => Path.Combine(StartupDir, "res");
        }
    }
}