namespace jvyterm
{
    public class argHandler
    {
        public static string[] getArgs()
        {
            string[] aargs = null; ;
            try {aargs = args.Split(' '); } catch { }
            
            return aargs;
        }

        public static string args;
    }
}
