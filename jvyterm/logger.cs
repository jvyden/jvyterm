using System;
using System.IO;
using System.Text;

namespace jvyterm
{
    public class logger
    {
        static string logf = Environment.CurrentDirectory + "\\data\\log.txt";
        public enum LogType {Error, Regular};
        public static void log(string text, LogType l)
        {
            using (var f = File.Open(logf, FileMode.Append))
            {
                byte[] bytes = Encoding.ASCII.GetBytes(text + '\n');
                f.Write(bytes, 0, bytes.Length);
            }
            if (l == LogType.Error)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(text);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (l == LogType.Regular)
            {
                Console.WriteLine(text);
            }
        }

        public static void init(string f)
        {
            if (!File.Exists(logf))
            {
                File.Create(logf).Dispose();
            }
            else
            {
                File.Delete(logf);
                File.Create(logf).Dispose();
            }
        }
    }
}
