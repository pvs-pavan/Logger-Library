namespace Logger.Configuration
{
    public class LoggerBuilder
    {
        private readonly Logger _logger = Logger.Instance;
        public LoggerBuilder AddSink(IMessageSink sink)
        {
            _logger.AddSink(sink);
            return this;
        }
        public Logger Build() { return _logger; }
    }
}
