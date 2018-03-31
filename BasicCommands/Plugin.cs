using jvyterm;
using System;

namespace basicCommands
{
    public class plugin
    {
        public static void init()
        {
            pluginHandler.addCommand("exit");
            pluginHandler.addCommand("clear");
            pluginHandler.addCommand("cls");
        }

        public static void exit()
        {
            logger.log("Goodbye!", logger.logType.regular);
            Environment.Exit(0);
        }

        public static void clear()
        {
            Console.Clear();
        }

        public static void cls()
        {
            clear();
        }
    }
}
