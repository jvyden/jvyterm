using System;

namespace jvyterm
{
    class shell
    {
        public static string getInput()
        {
            Console.Write(">");
            string input = Console.ReadLine(); //Get the input from the user
            return input;
        }
        public static void run()
        {
            pluginHandler.init(); // Initialize the pluginHandler
            bool running = true; 
            while (running)
            {
                string input = getInput(); // Get input,
                runCmd(input);             // and run the command
            }
        }

        static void runCmd(string cmd)
        {
            string[] commands = commandHandler.getCmds(); // Get all of the comamnds
            if (cmd != "help")
            {
                foreach (string c in commands) // Search all of the commands.
                {
                    if (!pluginHandler.Run(cmd)) // Attempt to run the command. If false, continue.
                    {
                        logger.log(lang.invalCmd, logger.logType.error); // If its not a command, say so.
                    }
                    break;

                }
            }
            else { help(); } // If its help, run help.
        }
        static void help() // Get all the commands and list them.
        {
            string[] commands = commandHandler.getCmds();
            foreach (string c in commands)
            {
                logger.log(c, logger.logType.regular);
            }
        }
    }
}
