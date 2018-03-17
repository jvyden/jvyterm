using System;
using System.IO;
using System.Reflection;

namespace jvyterm
{
    public class PluginHandler
    {
        public static void init()
        {
            logger.log(lang.plugininit);
            string pluginf = Environment.CurrentDirectory + "\\data\\plugins\\";
            FileInfo[] dlls = getAllDLLs(pluginf);
            foreach (FileInfo f in dlls)
            {
                logger.log("Loading " + f.Name + " ...");
                Assembly a = Assembly.LoadFrom(f.FullName);
                Type[] t = a.GetTypes();
                run(t, "init");
            }
            
        }

        static FileInfo[] getAllDLLs(string dir)
        {
            DirectoryInfo d = new DirectoryInfo(dir);
            FileInfo[] dlls = d.GetFiles("*.dll");
            return dlls;
        }

        public static void run(Type[] t, string m)
        {
            foreach (Type type in t)
            {
                //MethodInfo method = type.GetMethod(m);
                var c = Activator.CreateInstance(type);
                type.InvokeMember(m, BindingFlags.InvokeMethod, null, c, null);
            }
        }
    }
}
