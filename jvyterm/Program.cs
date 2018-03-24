using System;
using System.IO;

namespace jvyterm
{
    class program
    {
        static string dataf = Environment.CurrentDirectory + "\\data"; // Get the data directory.
        static void Main()
        {
            init();
        }

        static void init()
        {
            Console.Title = "jvyterm";
            Console.WriteLine(lang.init); // Tell the user that we're initializing the program.
            firstrun(); // See if the program has been ran before.
            logger.init(dataf); // Tells the logger to initialize with the data directory.
            logger.log(lang.loggerinit, logger.logType.Regular); // Tell the user the logger has been initialized.
            shell.run(); // Begin running the shell.
        }
        static void firstrun()
        {
            if (!Directory.Exists(dataf)) // Is the data directory there? If not, continue.
            {
                Console.WriteLine(lang.firstrun); // Tell the user we are preparing the data directory.
                onFirstRun.prep(dataf); // Prepare with the data directory.
            }
        }
    }
}









//https://imgur.com/cTPu369