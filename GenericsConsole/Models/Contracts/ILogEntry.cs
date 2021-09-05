using System;

namespace GenericsConsole
{
    public interface ILogEntry
    {
        string Message { get; set;}
        int ErrorCode { get; set;}
        DateTime TimeOfEvent { get; set; }
    }
}