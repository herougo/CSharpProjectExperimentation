using System;
using System.IO;

namespace Utility.Core
{
    public static class Logger
    {
        public static string LogFolder = AppDomain.CurrentDomain.BaseDirectory;

        public static void LogInfo(string message)
        {
            File.AppendAllText(Path.Combine(LogFolder, "log.txt"), "\n" + message);
        }
    }
}
