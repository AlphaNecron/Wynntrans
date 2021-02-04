using System;
using static WynnicTranslator.Core.Translator.Variables;

namespace WynnicTranslator.Core.Languages
{
    public static partial class Translator
    {
        internal static partial class Converter
        {
            internal static class Gavellian
            {
                internal static char LetterConverter(char i)
                {
                    switch (char.IsLetter(i))
                    {
                        case true:
                            return GavellianLetters[Array.IndexOf(BaseLetters, i)];
                        default:
                            return i;
                    }
                }
            }
        }
    }
}