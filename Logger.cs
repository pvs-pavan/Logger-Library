using Logger.Enums;

namespace Logger
{
    public class Logger
    {
        private static readonly List<IMessageSink> sinks = new List<IMessageSink>();
        private static readonly Logger? instance;
        private Logger() { }
        public static Logger Instance => instance == null ? new Logger() : instance;
        public void AddSink(IMessageSink configuredSink)
        {
            sinks.Add(configuredSink);
        }
        public void LogMessage(string context, LogLevel level, string namespaceId)
        {
            var message = new LogMessage { Content = context, Level = level, Namespace = namespaceId };
            foreach (var sink in sinks)
            {
                sink.Write(message);
            }
        }
    }
}