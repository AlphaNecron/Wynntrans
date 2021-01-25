using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net.Mime;
using System.Windows.Forms;

namespace WynnicTranslator.Core
{
    public static class Utils
    {
        public static class FontUtils
        {
            private static PrivateFontCollection _fontCollection = new PrivateFontCollection();
            public static Font WynnicFont;
            public static void LoadFont()
            {
                _fontCollection.AddFontFile(Path.Combine(
                    Application.StartupPath, "res", "Wynnic-Regular.otf"));
                WynnicFont = new Font(_fontCollection.Families[0], 12);
            }
        }
    }
}