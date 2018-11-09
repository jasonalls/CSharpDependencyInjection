using System;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using CSharpDependencyInjection.Contracts;

namespace CSharpDependencyInjection.Logging
{
    internal class EventLogLogger : IErrorLogger
    {
        public void LogMessage(Exception ex)
        {
            EventLog objEventLog = new EventLog();
            var sourceName = ConfigurationManager.AppSettings["App"];
            var logName = ConfigurationManager.AppSettings["LogName"];
            if (!(EventLog.SourceExists(sourceName)))
            {
                EventLog.CreateEventSource(sourceName, logName);
            }
            objEventLog.Source = sourceName;
            var message = $"Message: {ex.Message} \n StackTrace: {ex.StackTrace} \n Date/ Time: {DateTime.Now.ToString(CultureInfo.InvariantCulture)}";  
            objEventLog.WriteEntry(message, EventLogEntryType.Error);
        }
    }
}
