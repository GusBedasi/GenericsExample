using System;

namespace GenericsConsole
{
    public class LogEntry : ILogEntry
    {
        public string Message { get; set; }
        public int ErrorCode { get; set; }
        public DateTime TimeOfEvent { get; set; } = DateTime.UtcNow;
    }
}