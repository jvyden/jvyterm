using System;

namespace jvyterm
{
    class shell
    {
        public static void run()
        {
            bool running = true;
            while (running)
            {
                Console.Write(">");
                string input = Console.ReadLine();
            }
        }
    }
}
