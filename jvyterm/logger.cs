using System;
using System.IO;
using System.Security.Permissions;
using System.Text;

namespace jvyterm
{
    class logger
    {
        static string logf = Environment.CurrentDirectory + "\\data\\log.txt";
        public static void log(string text)
        {
            FileStream f = File.Open(logf, FileMode.Append);
            byte[] bytes = Encoding.ASCII.GetBytes(text);
            f.Write(bytes, 0, bytes.Length);
            Console.WriteLine(text);
            f.Close();
        }

        public static void init(string f)
        {
            var writePermission = new FileIOPermission(FileIOPermissionAccess.Write, logf);
            var appendPermission = new FileIOPermission(FileIOPermissionAccess.Append, logf);
            writePermission.Demand();
            appendPermission.Demand();

            if (!File.Exists(logf))
            {
                File.Create(logf);
            }
            else
            {
                File.Delete(logf);
                File.Create(logf);
            }
        }
    }
}
