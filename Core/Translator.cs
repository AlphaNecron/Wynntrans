using System;
using System.Linq;

namespace WynnicTranslator.Core
{
    public static class Translator
    {
        private static readonly char[] BaseLetters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        public static partial class Wynnic
        {
            private static readonly char[] WynnicLetters = "⒜⒝⒞⒟⒠⒡⒢⒣⒤⒥⒦⒧⒨⒩⒪⒫⒬⒭⒮⒯⒰⒱⒲⒳⒴⒵".ToCharArray();
            private static readonly char[] WynnicNumbers = "⑴⑵⑶⑷⑸⑹⑺⑻⑼".ToCharArray();
            private static readonly char[] WynnicAdditionalNumbers = "⑽⑾⑿".ToCharArray();
            private static readonly char[] WynnicSpecialChars = "０１２".ToCharArray();
            private static readonly char[] BaseNumbers = "123456789".ToCharArray();
            private static readonly char[] BaseSpecialChars = ".!?".ToCharArray();

            public static bool CheckForAllowedChar(char i)
            {
                switch (char.ToLower(i))
                {
                    case '.':
                    case '?':
                    case '!':
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'i':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                    case 'o':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'u':
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        return true;
                    default:
                        return false;
                }
            }

            public static string Translate(string i)
            {
                return i.ToLower().Aggregate("", (current, c) => current + AsciiConverter(c));
            }

            private static char NumberConverter(char i)
            {
                return (char) WynnicNumbers[Array.IndexOf(BaseNumbers, i)];
            }

            private static char SpecialCharConverter(char i)
            {
                return (char) WynnicSpecialChars[Array.IndexOf(BaseSpecialChars, i)];
            }

            private static char LetterConverter(char i)
            {
                return (char) WynnicLetters[Array.IndexOf(BaseLetters, i)];
            }

            private static char AsciiConverter(char i)
            {
                if (char.IsLetter(i))
                {
                    return LetterConverter(i);
                }
                else if (char.IsDigit(i))
                {
                    return NumberConverter(i);
                }
                else if (i == '?' || i == '!' || i == '.')
                {
                    return SpecialCharConverter(i);
                }
                else
                {
                    return i;
                }
            }
        }

        public static partial class Gavellian
            {
                private static readonly char[] GavellianLetters = "ⓐⓑⓒⓓⓔⓕⓖⓗⓘⓙⓚⓛⓜⓝⓞⓟⓠⓡⓢⓣⓤⓥⓦⓧⓨⓩ".ToCharArray();

                public static string Translate(string i)
                {
                    return i.ToLower().Aggregate("", (current, c) => current + LetterConverter(c));
                }

                public static bool CheckForAllowedChar(char i)
                {
                    return char.IsLetter(char.ToLower(i));
                }

                private static char LetterConverter(char i)
                {
                    if (char.IsLetter(i))
                    {
                        return (char) GavellianLetters[Array.IndexOf(BaseLetters, i)];
                    }
                    else
                    {
                        return i;
                    }
                }
            }
        }
}