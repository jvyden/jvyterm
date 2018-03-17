using System;
using System.IO;
using System.Text;

namespace jvyterm
{
    class logger
    {
        static string logf = Environment.CurrentDirectory + "\\data\\log.txt";
        public static void log(string text)
        {
            using (var f = File.Open(logf, FileMode.Append))
            {
                byte[] bytes = Encoding.ASCII.GetBytes(text + '\n');
                f.Write(bytes, 0, bytes.Length);
            }
            Console.WriteLine(text);
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
