using System;
using System.Diagnostics;
using Serilog;

namespace SerilogAuditee.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var regularLogger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File(@"C:\temp\execution.log")
                .CreateLogger();

            Log.Logger = regularLogger;
            Log.Logger.Information("App is starting ! ");

            var auditLogger = new LoggerConfiguration()
                    // we want to allow to use existing extension methods
                    .AuditTo.File(@"C:\temp\audit.log",
                        outputTemplate:"{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level}] {Message}{NewLine}{Exception}{Properties:j}{NewLine}")
                    // we may not want to allow WriteTo ... or only if requested explicitely ????
                    .WriteTo.Console(outputTemplate:"{Audit:u}[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
                    .CreateAuditLogger() // todo : ensure this is actually writing somewhere !
                // possible options : "strict" : there must be an audit sink
                // write errors to a logger somewhere ... onError or something !
                ;

            Audit.Auditee = auditLogger;

            Log.Logger.Information("App is started");

            var appComponent = new AppComponent(args);

            var userInput = Console.ReadLine();
            while ( userInput!=null && userInput.Trim().Length > 0)
            {
                appComponent.ProcessLine(userInput);
                userInput = Console.ReadLine();
            }
            Log.Logger.Information("App is ending !");

            Log.CloseAndFlush();
            Audit.CloseAndFlush();

            if (Debugger.IsAttached)
            {
                Console.WriteLine("App is terminated but terminal is still there in debug mode. Press any key to close it ...");
                Console.ReadKey();
            }

        }
    }

    class AppComponent
    {
        static readonly ILogger logger = Log.ForContext<AppComponent>();
        static readonly IAuditee auditee = Audit.ForContext<AppComponent>();

        public AppComponent(string[] args)
        {
        }

        public void ProcessLine(string userInput)
        {
            if (userInput.StartsWith("!"))
            {
                logger.Debug("Important message detected ... writing to Audit trail ! {UserInput}", userInput);
                auditee.Information("User has typed {UserInput}", userInput);
            }
            else
            {
                logger.Information("User has typed {UserInput}", userInput);
            }
        }
    }
}
