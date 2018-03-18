using jvyterm;

namespace ArgTest
{
    public class Plugin //For testing arguments for those who want to implement
    {
        public static void init(string[] args = null)
        {
            CommandHandler.addCommand("echo");
        }

        public static void echo(string[] args = null)
        {
            logger.log(args.ToString(), logger.LogType.Regular);
        }
    }
}
