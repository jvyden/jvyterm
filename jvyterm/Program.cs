using System;
using System.IO;

namespace jvyterm
{
    class Program
    {
        static void Main()
        {
            init();
        }
        //static string[] lang = {"Initializing...", "First run, prepping..."};

        static void init()
        {
            Console.WriteLine(lang.init);
            firstrun();
        }
        static void firstrun()
        {
            if (!Directory.Exists(Environment.CurrentDirectory + "\\data"))
            {
                Console.WriteLine(lang.firstrun);
                onFirstRun.prep();
            }
        }
    }
}









//https://imgur.com/cTPu369