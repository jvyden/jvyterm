using System;
using System.IO;

namespace jvyterm
{
    class program
    {
        static string dataF = Environment.CurrentDirectory + "\\data"; // Get the data directory.
        static void Main()
        {
            init();
        }

        static void init()
        {
            Console.Title = "jvyterm";
            Console.WriteLine(lang.init); // Tell the user that we're initializing the program.
            firstRun(); // See if the program has been ran before.
            logger.init(dataF); // Tells the logger to initialize with the data directory.
            logger.log(lang.loggerInit, logger.logType.regular); // Tell the user the logger has been initialized.
            shell.run(); // Begin running the shell.
        }
        static void firstRun()
        {
            if (!Directory.Exists(dataF)) // Is the data directory there? If not, continue.
            {
                Console.WriteLine(lang.firstRun); // Tell the user we are preparing the data directory.
                onFirstRun.prep(dataF); // Prepare with the data directory.
            }
        }
    }
}