using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Sinks
{
    public class ConsoleSink : IMessageSink
    {
        public void Write(LogMessage message)
        {
           Console.WriteLine($"[{message.Level}][{message.Namespace}]{message.Content}");
        }
    }
}
