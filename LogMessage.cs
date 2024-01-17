using Logger.Enums;

namespace Logger
{
    public class LogMessage
    {
        public string? Content { get; set; }
        public LogLevel Level { get; set; }
        public string? Namespace { get; set; }
    }
}
