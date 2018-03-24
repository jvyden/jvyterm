using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace jvyterm
{
    public class pluginHandler
    {
        static List<Type> typeList = new List<Type>(); // Prepare a new type for the command list.
        public static void init()
        {
            logger.log(lang.pluginInit, logger.logType.regular); // Tell the user we are initializing the plugins.
            string pluginf = Environment.CurrentDirectory + "\\data\\plugins\\"; // Get the plugin directory.
            FileInfo[] dlls = getAllDLLs(pluginf); // Define dlls as a list of all the dlls in the plugin directory.
            foreach (FileInfo f in dlls) // For each file, do this.
            {
                logger.log(lang.pluginLoad + f.Name + lang.dotDotDot, logger.logType.regular); // Tell the user we are loading a plugin.
                Assembly a = Assembly.LoadFrom(f.FullName); // Load the plugin.
                Type[] t = a.GetTypes(); // Prepares 
                foreach (Type type in t)
                {
                    typeList.Add(type);
                }
                Run("init", f.Name); // Initialize the plugin
            }
            
        }

        static FileInfo[] getAllDLLs(string dir)
        {
            DirectoryInfo d = new DirectoryInfo(dir);
            FileInfo[] dlls = d.GetFiles("*.dll");
            return dlls;
        }

        public static bool Run(string m, string init = null)
        {
            foreach (Type type in typeList)
            {
                var c = Activator.CreateInstance(type);
                try
                {
                    type.InvokeMember(m, BindingFlags.InvokeMethod, null, c, null);
                    return true;
                }
                catch { logger.log(lang.invalCmd, logger.logType.error); }
            }
            return true;
        }
    }
}
