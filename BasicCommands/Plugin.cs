using jvyterm;
using System;

namespace BasicCommands
{
    public class plugin
    {
        public static void init()
        {
            commandHandler.addCommand("exit");
            commandHandler.addCommand("clear");
            commandHandler.addCommand("cls");
        }

        public static void exit()
        {
            logger.log("Goodbye!", logger.logType.Regular);
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
