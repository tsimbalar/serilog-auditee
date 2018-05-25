using Serilog;

namespace SerilogAuditee
{
    public static class Audit
    {
        public static IAuditee Auditee { get; } = new AuditLogger(Log.Logger);
    }
}
