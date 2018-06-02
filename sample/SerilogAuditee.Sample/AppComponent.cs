using Serilog;

namespace SerilogAuditee.Sample
{
    class AppComponent
    {
        static readonly ILogger logger = Log.ForContext<AppComponent>();
        static readonly IAuditLogger auditLogger = Audit.ForContext<AppComponent>();

        public AppComponent(string[] args)
        {
        }

        public void ProcessLine(string userInput)
        {
            if (userInput.StartsWith("!"))
            {
                logger.Debug("Important message detected ... writing to Audit trail ! {UserInput}", userInput);
                auditLogger.Information("User has typed {UserInput}", userInput);
            }
            else
            {
                logger.Information("User has typed {UserInput}", userInput);
            }
        }
    }
}
