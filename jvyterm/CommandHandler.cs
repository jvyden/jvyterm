using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jvyterm
{
    public class CommandHandler
    {
        static List<string> a = new List<string>();

        public static void addCommand(string cmd)
        {
            a.Add(cmd);
        }

        public static string[] getCmds()
        {
            return a.ToArray();
        }
    }
}
