﻿using System.Collections.Generic;

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
