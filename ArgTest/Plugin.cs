﻿using jvyterm;

namespace ArgTest
{
    public class plugin //For testing arguments for those who want try implementing the argument system.
    {
        public static void init(string[] args = null)
        {
            commandHandler.addCommand("argtest");
            commandHandler.addCommand("noargtest");
        }

        public static void argtest(string[] args = null)
        {
            logger.log(args.ToString(), logger.logType.Regular);
        }

        public static void noargtest(string[] args = null)
        {
            logger.log("working", logger.logType.Regular);
        }
    }
}
