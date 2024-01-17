using Logger.Configuration;
using Logger.Enums;
using Logger.Sinks;

namespace ClientApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var logger = new LoggerBuilder().AddSink(new ConsoleSink()).AddSink(new FileSink()).Build();
            logger.LogMessage("this is error message", LogLevel.Error, "ApplicationNamespace");
        }
    }
}