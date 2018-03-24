using System;
using System.IO;
using System.Text;

namespace jvyterm
{
    public class logger
    {
        static string logF = Environment.CurrentDirectory + "\\data\\log.txt";
        public enum logType {error, regular, silent};
        public static void log(string text, logType l)
        {
            using (var f = File.Open(logF, FileMode.Append))
            {
                byte[] bytes = Encoding.ASCII.GetBytes(text + '\n');
                f.Write(bytes, 0, bytes.Length);
            }
            if (l == logType.error)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(text);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (l == logType.regular)
            {
                Console.WriteLine(text);
            }
        }

        public static void init(string f)
        {
            if (!File.Exists(logF))
            {
                File.Create(logF).Dispose();
            }
            else
            {
                File.Delete(logF);
                File.Create(logF).Dispose();
            }
        }
    }
}
