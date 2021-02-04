using System;
using static WynnicTranslator.Core.Translator.Variables;

namespace WynnicTranslator.Core.Languages
{
    public static partial class Translator
    {
        internal static partial class Converter
        {
            internal static class Wynnic
            {
                private static char NumberConverter(char i)
                {
                    return WynnicNumbers[Array.IndexOf(BaseNumbers, i)];
                }

                private static char SpecialCharConverter(char i)
                {
                    return WynnicSpecialChars[Array.IndexOf(BaseSpecialChars, i)];
                }

                private static char LetterConverter(char i)
                {
                    return WynnicLetters[Array.IndexOf(BaseLetters, i)];
                }

                internal static char AsciiConverter(char i)
                {
                    if (char.IsLetter(i))
                        return LetterConverter(i);
                    if (char.IsNumber(i))
                        return NumberConverter(i);
                    if (i == '?' || i == '!' || i == '.')
                        return SpecialCharConverter(i);
                    return i;
                }
            }
        }
    }
}