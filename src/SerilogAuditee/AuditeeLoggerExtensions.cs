using System;
using SerilogAuditee;

namespace Serilog
{
    public static class AuditeeLoggerExtensions
    {
        public static IAuditee Auditee(this ILogger self)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));
            return new AuditLogger(self);
        }
    }
}
