using System;
using System.IO;
namespace jvyterm
{
    class onFirstRun
    {
        public static void prep(string f)
        {
            Directory.CreateDirectory(f); // Make a data folder...
            Directory.CreateDirectory(f + @"\plugins\"); //...and a plugins folder in that folder.
           
            DirectoryInfo d = new DirectoryInfo(Environment.CurrentDirectory); // Get the current directory.
            FileInfo[] i = d.GetFiles("*.dll"); // Get all the dlls in the current directory.
            foreach(FileInfo fi in i)
            {
                fi.MoveTo(f + @"\plugins\" + fi.Name); // Move all of them into the plugins folder.
            }
            
        }
    }
}
