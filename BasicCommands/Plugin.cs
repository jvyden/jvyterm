using jvyterm;
using System;

namespace BasicCommands
{
    public class Plugin
    {
        public static void init()
        {
            CommandHandler.addCommand("exit");
            CommandHandler.addCommand("clear");
            CommandHandler.addCommand("cls");
        }

        public static void exit()
        {
            logger.log("Goodbye!");
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
