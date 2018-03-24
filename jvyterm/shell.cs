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
            pluginHandler.init();
            bool running = true;
            while (running)
            {
                string input = getInput();
                runCmd(input);
            }
        }

        static void runCmd(string cmd)
        {
            string[] commands = commandHandler.getCmds();
            if (cmd != "help")
            {
                foreach (string c in commands)
                {
                    if (!pluginHandler.Run(cmd))
                    {
                        logger.log(lang.invalCmd, logger.logType.error);
                    }
                    break;

                }
            }
            else { help(); }
        }
        static void help()
        {
            string[] commands = commandHandler.getCmds();
            foreach (string c in commands)
            {
                logger.log(c, logger.logType.regular);
            }
        }
    }
}
