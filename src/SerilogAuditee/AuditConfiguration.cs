using Serilog;

namespace SerilogAuditee
{
    class AuditConfiguration
    {
    }

    public static class AuditLoggerExtensions
    {
        public static IAuditee CreateAuditLogger(this LoggerConfiguration loggerConfiguration)
        {
            // possibly add some stuff here to ensure there is some auditing in there !
            return new AuditLogger(loggerConfiguration.CreateLogger().ForContext("Audit", "audit"));
        }
    }
}
