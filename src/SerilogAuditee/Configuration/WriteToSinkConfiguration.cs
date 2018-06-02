using System;
using Serilog;
using Serilog.Configuration;

namespace SerilogAuditee.Configuration
{
    public class WriteToSinkConfiguration
    {
        readonly AuditConfiguration _auditConfiguration;

        internal WriteToSinkConfiguration(AuditConfiguration auditConfiguration)
        {
            _auditConfiguration = auditConfiguration;
        }

        public AuditConfiguration Sink(Func<LoggerSinkConfiguration, LoggerConfiguration> configureSerilogWriteTo)
        {
            _auditConfiguration.AddSink(configureSerilogWriteTo);
            return _auditConfiguration;
        }
        
    }
}
