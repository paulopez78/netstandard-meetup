using System;
using System.Collections.Generic;

namespace LoggingLib
{
    public class Logger
    {
        private static List<string> InMemoryLog = new List<string>();

        public static void Log(string message) =>
            InMemoryLog.Add(message);
    }
}
