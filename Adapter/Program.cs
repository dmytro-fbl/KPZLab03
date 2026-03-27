namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            const string text = "Hello";
            logger.Log(text);
            logger.Error(text);
            logger.Warn(text);

            FileWriter writer = new FileWriter();

            Logger adapterLogger = new WriteLogger(writer);

            adapterLogger.Log(text);
            adapterLogger.Error(text);
            adapterLogger.Warn(text);
            
            
            
        }
    }
}
