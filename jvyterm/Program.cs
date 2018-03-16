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
        }
        static void firstrun()
        {
            if (!Directory.Exists(dataf)) //Should we drop data folder?
            {
                logger.log(lang.firstrun);
                onFirstRun.prep(dataf);
            }
        }
    }
}









//https://imgur.com/cTPu369