using System;

namespace SerilogAuditee
{
    public abstract class AuditeeException : Exception
    {
        protected AuditeeException(string message) : base(message)
        {
        }

        protected AuditeeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
