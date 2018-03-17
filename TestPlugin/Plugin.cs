using jvyterm;

namespace TestPlugin
{
    public class Plugin
    {
        public static void init()
        {
            CommandHandler.addCommand("test");
        }

        public static void test()
        {
            logger.log("Test works");
        }
    }
}
