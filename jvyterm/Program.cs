using System;
using System.Xml;
using System.IO

namespace jvyterm
{
    class Program
    {
        static void Main()
        {
            init();
        }
        static string[] lang = { "Initializing..."};
        static void init()
        {
            Console.WriteLine(lang[0]);

        }
        static void firstrun()
        {
            if (!Directory.Exists(Environment.CurrentDirectory + ""))
        }
    }
}
