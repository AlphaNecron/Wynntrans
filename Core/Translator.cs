using System.Linq;
using static WynnicTranslator.Core.Languages.Translator;
using static WynnicTranslator.Core.Translator.TransUtils;

namespace WynnicTranslator.Core
{
    public static class Translator
    {
        public static string Translate(Lang lang, string i)
        {
            switch (lang)
            {
                case Lang.Gavellian:
                    return Gavellian.Translate(i);
                default:
                    return Wynnic.Translate(i);
            }
        }

        public static class TransUtils
        {
            public enum Lang
            {
                Wynnic = 0,
                Gavellian = 1
            }

            public static bool CheckForAllowedChar(char i, Lang language)
            {
                switch (language)
                {
                    case Lang.Gavellian:
                        return char.IsLetter(char.ToLower(i));
                    case Lang.Wynnic:
                        return char.IsLetter(char.ToLower(i)) || char.IsNumber(i) || i == '?' || i == '.' || i == '!';
                    default:
                        return false;
                }
            }
        }

        internal static class Variables
        {
            internal static readonly char[] BaseLetters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            internal static readonly char[] WynnicLetters = "⒜⒝⒞⒟⒠⒡⒢⒣⒤⒥⒦⒧⒨⒩⒪⒫⒬⒭⒮⒯⒰⒱⒲⒳⒴⒵".ToCharArray();

            internal static readonly char[] WynnicNumbers = "⑴⑵⑶⑷⑸⑹⑺⑻⑼".ToCharArray();

            // internal static readonly char[] WynnicAdditionalNumbers = "⑽⑾⑿".ToCharArray();
            internal static readonly char[] WynnicSpecialChars = "０１２".ToCharArray();
            internal static readonly char[] BaseNumbers = "123456789".ToCharArray();
            internal static readonly char[] GavellianLetters = "ⓐⓑⓒⓓⓔⓕⓖⓗⓘⓙⓚⓛⓜⓝⓞⓟⓠⓡⓢⓣⓤⓥⓦⓧⓨⓩ".ToCharArray();
            internal static readonly char[] BaseSpecialChars = ".!?".ToCharArray();
        }

        private static class Wynnic
        {
            internal static string Translate(string i)
            {
                return i.ToLower().Aggregate("", (current, c) => current + Converter.Wynnic.AsciiConverter(c));
            }
        }

        private static class Gavellian
        {
            internal static string Translate(string i)
            {
                return i.ToLower().Aggregate("", (current, c) => current + Converter.Gavellian.LetterConverter(c));
            }
        }
    }
}