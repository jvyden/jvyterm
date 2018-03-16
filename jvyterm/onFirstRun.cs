using System.IO;
namespace jvyterm
{
    class onFirstRun
    {
        public static void prep(string f)
        {
            Directory.CreateDirectory(f);
            Directory.CreateDirectory(f + @"\plugins\");
        }
    }
}
