using System;
using System.Xml;
using System.IO;

namespace jvyterm
{
    class Program
    {
        static void Main()
        {
            init();
        }
        static string[] lang = {"Initializing...", "First run, prepping..."};
        static void init()
        {
            Console.WriteLine(lang[0]);
            firstrun();
        }
        static void firstrun()
        {
            if (!Directory.Exists(Environment.CurrentDirectory + "\\data"))
            {
                Console.WriteLine(lang[1]);
                onFirstRun.prep();
            }
        }
    }
}









//https://imgur.com/cTPu369