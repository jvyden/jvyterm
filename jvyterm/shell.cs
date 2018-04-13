using System;

namespace jvyterm
{
    class shell
    {
        public static string getInput()
        {
            Console.Write(">");
            string input = Console.ReadLine(); // Get the input from the user
            return input;
        }
        public static void run()
        {
            pluginHandler.init(); // Initialize the pluginHandler
            bool running = true; 
            while (running)
            {
 
                string input = getInput(); // Get input,
                setArgs(input);            // send it to the argument handler,
                runCmd(input);             // and then run the command.
            }
        }

        static void runCmd(string cmd)
        {
            string[] commands = pluginHandler.getCmds(); // Get all of the commands
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
            string[] commands = pluginHandler.getCmds();
            foreach (string c in commands)
            {
                logger.log(c, logger.logType.regular);
            }
        }
        public static string setArgs(string input)
        {
            string args = input.Substring(0, input.LastIndexOf(" ") + 1);
            return args;
        }
    }
}
