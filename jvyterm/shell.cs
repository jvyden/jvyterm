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
            foreach (string c in commands)
            {
                if (c == cmd)
                {
                    PluginHandler.run(null, cmd);
                }
                else
                {
                    logger.log(lang.invalcmd);
                }
            }
        }
    }
}
