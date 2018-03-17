using System;
using System.IO;

namespace jvyterm
{
    class PluginHandler
    {
        public static void init()
        {
            logger.log("Initializing plugins...");
            string pluginf = Environment.CurrentDirectory + "\\data\\plugins\\";
            getAllDLLs(pluginf);
        }

        static FileInfo[] getAllDLLs(string dir)
        {
            DirectoryInfo d = new DirectoryInfo(dir);
            FileInfo[] dlls = d.GetFiles("*.dll");
            return dlls;
        }
    }
}
