using System;

namespace jvyterm
{
    class shell
    {
        public static string getInput()
        {
            Console.Write(">");
            string input = Console.ReadLine();
            return input;
        }
        public static void run()
        {
            PluginHandler.init();
            bool running = true;
            while (running)
            {
                string input = getInput();
                runCmd(input);
            }
        }

        static void runCmd(string cmd)
        {
            string[] commands = CommandHandler.getCmds();
            if (cmd != "help")
            {
                foreach (string c in commands)
                {
                    if (!PluginHandler.Run(cmd))
                    {
                        logger.log(lang.invalcmd, logger.LogType.Error);
                    }
                    break;

                }
            }
            else { help(); }
        }
        static void help()
        {
            string[] commands = CommandHandler.getCmds();
            foreach (string c in commands)
            {
                logger.log(c, logger.LogType.Regular);
            }
        }
    }
}
