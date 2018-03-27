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
                Type[] t = a.GetTypes(); // Make list of commands.
                foreach (Type type in t)
                {
                    typeList.Add(type); // Adds all of the commands to the list of commands
                }
                Run("init", f.Name); // Initialize the plugin
            }
            
        }

        static FileInfo[] getAllDLLs(string dir)
        {
            DirectoryInfo d = new DirectoryInfo(dir); // Get the directory
            FileInfo[] dlls = d.GetFiles("*.dll"); // Get the dlls
            return dlls;
        }

        public static bool Run(string m, string init = null)
        {
            foreach (Type type in typeList) // Search all commands
            {
                var c = Activator.CreateInstance(type);
                try
                {
                    type.InvokeMember(m, BindingFlags.InvokeMethod, null, c, null); // Call the command
                    return true;
                }
                catch { logger.log(lang.invalCmd, logger.logType.error); } // Wrong command
            }
            return true;
        }
    }
}
