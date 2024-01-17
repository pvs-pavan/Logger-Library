namespace Logger.Sinks
{
    public class FileSink : IMessageSink
    {
        public void Write(LogMessage message)
        {
            // TODO
            Console.WriteLine($"File Log - [{message.Level}][{message.Namespace}]{message.Content}");
        }
    }
}
