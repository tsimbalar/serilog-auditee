namespace SerilogAuditee
{
    public static class Audit
    {
        public static IAuditee Auditee { get; set; } = AuditLogger.None;

        public static IAuditee ForContext<T>()
        {
            return Auditee.ForContext<T>();
        }

        public static void CloseAndFlush()
        {
            // TODO : dispose the underlying logger ...
        }
    }
}
