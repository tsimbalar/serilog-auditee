namespace SerilogAuditee
{
    public class AuditeeConfigurationNotInitializedException : AuditeeException
    {
        public AuditeeConfigurationNotInitializedException() : base("The Audit configuration has not been initialized. Audit Events will not be stored. TODO : this behavior can be altered if needed")
        {
        }
    }
}
