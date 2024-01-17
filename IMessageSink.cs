namespace Logger
{
    public interface IMessageSink
    {
        void Write(LogMessage message);
    }
}
