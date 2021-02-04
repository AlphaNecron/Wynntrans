using System;
using System.Diagnostics;

namespace WynnicTranslator.Core
{
    public static class Logger
    {
        private static bool _isDebug;

        public static void Init()
        {
            _isDebug = Debugger.IsAttached;
            if (!_isDebug) return;

            Debugger.Launch();
        }

        public static void Log(string content, string prefix = "INFO")
        {
            Debugger.Log(2, prefix, content + "\n");
            Console.WriteLine($@"[{prefix}] {content}");
        }
    }
}