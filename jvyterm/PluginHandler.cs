using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace jvyterm
{
    public class PluginHandler
    {
        static List<Type> typelist = new List<Type>();
        public static void init()
        {
            logger.log(lang.plugininit, logger.LogType.Regular);
            string pluginf = Environment.CurrentDirectory + "\\data\\plugins\\";
            FileInfo[] dlls = getAllDLLs(pluginf);
            foreach (FileInfo f in dlls)
            {
                logger.log(lang.pluginload + f.Name + lang.pluginload2, logger.LogType.Regular);
                Assembly a = Assembly.LoadFrom(f.FullName);
                Type[] t = a.GetTypes();
                foreach (Type type in t)
                {
                    typelist.Add(type);
                }
                Run("init", f.Name);
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
            foreach (Type type in typelist)
            {
                if (m == "init") { logger.log(lang.plugininit2 + init + lang.plugininit3, logger.LogType.Regular); }
                var c = Activator.CreateInstance(type);
                try
                {
                    type.InvokeMember(m, BindingFlags.InvokeMethod, null, c, null);
                    return true;
                }
                catch { logger.log(lang.invalcmd, logger.LogType.Error); }
            }
            return true;
        }
    }
}
