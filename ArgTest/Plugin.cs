using jvyterm;

namespace argTest
{
    public class plugin // For testing arguments for those who want try implementing the argument system.
    {
        public static void init()
        {
            pluginHandler.addCommand("argtest");
            pluginHandler.addCommand("noargtest");
        }

        public static void argtest()
        {
            string[] args = argHandler.getArgs();
            logger.log(args.ToString(), logger.logType.regular);
        }

        public static void noargtest()
        {
            logger.log("working", logger.logType.regular);
        }
    }
}
