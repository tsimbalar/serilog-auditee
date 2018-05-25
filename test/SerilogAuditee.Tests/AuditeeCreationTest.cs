using Serilog;
using Xunit;

namespace SerilogAuditee.Tests
{
    public class AuditeeCreationTest
    {
        [Fact]
        public void LoggerDotAuditeeReturnsAnIAuditee()
        {
            var logger = new LoggerConfiguration().CreateLogger();

            var auditee = logger.Auditee();

            Assert.NotNull(auditee);
            Assert.IsAssignableFrom<IAuditee>(auditee);
        }

        [Fact]
        public void StaticAuditDotAuditeeReturnsAnIAuditee()
        {
            var auditee = Audit.Auditee;

            Assert.NotNull(auditee);
            Assert.IsAssignableFrom<IAuditee>(auditee);
        }
    }
}
