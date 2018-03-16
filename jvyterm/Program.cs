using System;
using System.IO;

namespace jvyterm
{
    class Program
    {
        static string dataf = Environment.CurrentDirectory + "\\data";
        static void Main()
        {
            init();
        }
        //static string[] lang = {"Initializing...", "First run, prepping..."};

        static void init()
        {
            Console.WriteLine(lang.init);
            firstrun();
            logger.init(dataf);
            logger.log(lang.loggerinit);
        }
        static void firstrun()
        {
            if (!Directory.Exists(dataf))
            {
                Console.WriteLine(lang.firstrun);
                onFirstRun.prep(dataf);
            }
        }
    }
}









//https://imgur.com/cTPu369