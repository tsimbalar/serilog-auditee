using System;
using Serilog;
using Serilog.Configuration;

namespace SerilogAuditee.Configuration
{
    public class AuditToSinkConfiguration
    {
        readonly AuditConfiguration _auditConfiguration;

        internal AuditToSinkConfiguration(AuditConfiguration auditConfiguration)
        {
            _auditConfiguration = auditConfiguration;
        }

        public AuditConfiguration Sink(Func<LoggerAuditSinkConfiguration, LoggerConfiguration> configureSerilogAuditTo)
        {
            if (configureSerilogAuditTo == null) throw new ArgumentNullException(nameof(configureSerilogAuditTo));
            _auditConfiguration.AddAuditSink(configureSerilogAuditTo);
            return _auditConfiguration;
        }
    }
}
