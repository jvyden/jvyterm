using jvyterm;

namespace ArgTest
{
    public class Plugin //For testing arguments for those who want try implementing the argument system.
    {
        public static void init(string[] args = null)
        {
            CommandHandler.addCommand("argtest");
            CommandHandler.addCommand("noargtest");
        }

        public static void argtest(string[] args = null)
        {
            logger.log(args.ToString(), logger.LogType.Regular);
        }

        public static void noargtest(string[] args = null)
        {
            logger.log("working", logger.LogType.Regular);
        }
    }
}
