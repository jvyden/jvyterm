using jvyterm;

namespace ExampleProject
{
    public class Plugin
    {
        public static void init()
        {
            CommandHandler.addCommand("foo");
        }

        public static void foo()
        {
            logger.log("bar");
        }
    }
}
