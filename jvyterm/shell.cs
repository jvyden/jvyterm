using System;

namespace jvyterm
{
    class shell
    {
        public static void run()
        {
            PluginHandler.init();
            bool running = true;
            while (running)
            {
                Console.Write(">");
                string input = Console.ReadLine();
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
                        logger.log(lang.invalcmd);
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
                logger.log(c);
            }
        }
    }
}
