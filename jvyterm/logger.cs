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
            using (var f = File.Open(logF, FileMode.Append)) // Open the log file
            {
                byte[] bytes = null;
                if (l == logType.silent) {
                    bytes = Encoding.ASCII.GetBytes("[SILENT]" + text + '\n');
                }
                else { bytes = Encoding.ASCII.GetBytes(text + '\n'); } // Write the log, then make a new line

                f.Write(bytes, 0, bytes.Length); // Write the file.
            }
            if (l == logType.error)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed; // Set the color to dark red.
                Console.WriteLine("[ERROR]: " + text); // Write the text.
                Console.ForegroundColor = ConsoleColor.Gray; // Reset the color.
            }
            else if (l == logType.regular)
            {
                Console.WriteLine(text); // Write the text.
            }
        }

        public static void init(string f)
        {
            if (!File.Exists(logF)) // Does the log file exist?
            {
                File.Create(logF).Dispose(); // If it doesnt, make it and close the file.
            }
            else
            {
                File.Delete(logF); // If it does, delete it...
                File.Create(logF).Dispose(); // ...and then recreate it, and then close the file.
            }
        }
    }
}
