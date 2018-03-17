using jvyterm;
using System;

namespace BasicCommands
{
    public class Plugin
    {
        public static void init()
        {
            CommandHandler.addCommand("exit");
        }

        public static void exit()
        {
            logger.log("Goodbye!");
            Environment.Exit(0);
        }
    }
}
