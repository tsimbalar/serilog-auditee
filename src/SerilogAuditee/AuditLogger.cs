using Serilog;

namespace SerilogAuditee
{
    sealed class AuditLogger : IAuditee
    {
        public AuditLogger(ILogger self)
        {
        }
    }
}
