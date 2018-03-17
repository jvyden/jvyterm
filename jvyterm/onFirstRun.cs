using System;
using System.IO;
namespace jvyterm
{
    class onFirstRun
    {
        public static void prep(string f)
        {
            Directory.CreateDirectory(f);
            Directory.CreateDirectory(f + @"\plugins\");
            DirectoryInfo d = new DirectoryInfo(Environment.CurrentDirectory);
            FileInfo[] i = d.GetFiles("*.dll");
            foreach(FileInfo fi in i)
            {
                fi.MoveTo(f + @"\plugins\");
            }
        }
    }
}
