using System;
using System.Diagnostics;
using Serilog;

namespace SerilogAuditee.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SerilogAuditee Sample App");
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.WriteLine("Type *something* after the prompt and press *Enter* to have it written to the log (may be postponed).");
            Console.WriteLine("Start with an exclamation mark to write it to the audit trail (should be immediate or fail).");
            Console.WriteLine("Press *Enter* to stop the app.");
            Console.WriteLine();

            ConfigureLogging();

            Log.Logger.Information("App is started");
            try
            {
                DoMain(args);
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "An unhandled error occurred. The app is crashing :-( ");
                throw;
            }
            finally
            {
                Log.Logger.Information("App is ending ...");

                Log.Logger.Debug("Flushing Log ...");
                Log.CloseAndFlush();
                Log.Logger.Debug("Flushing Audit ...");
                Audit.CloseAndFlush();

                Log.Logger.Information("App is terminated !");
            }

            if (Debugger.IsAttached)
            {
                Console.WriteLine("[DEBUGGER ATTACHED] App is terminated. Press any key to close it ...");
                Console.ReadKey();
            }
        }

        static void DoMain(string[] args)
        {
            var appComponent = new AppComponent(args);

            var userInput = Prompt();
            while (userInput != null && userInput.Trim().Length > 0)
            {
                appComponent.ProcessLine(userInput);
                userInput = Prompt();
            }
        }

        static void ConfigureLogging()
        {
            var logLocation = @"C:\temp\execution.log";
            var auditLocation = @"C:\temp\audit.log";
            Console.WriteLine($"Logs are written to \"{logLocation}\" + Console");
            Console.WriteLine($"Audit are written to \"{auditLocation}\" + Console");


            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console(outputTemplate: "[NOT AUDIT][{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}{Properties:j}{NewLine}")
                .WriteTo.File(logLocation)
                .CreateLogger();

            Log.Logger.Debug("Logging is configured");

            Audit.Logger = new AuditConfiguration()
                // we want to allow to use existing extension methods
                .AuditTo.Sink(sink => sink
                    .File(auditLocation,
                        outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level}] {Message}{NewLine}{Exception}{Properties:j}{NewLine}")
                )
                // we may not want to allow WriteTo ... or only if requested explicitely ????
                .WriteTo.Sink(sink => sink
                    .Console(outputTemplate: "[AUDIT][{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}{Properties:j}{NewLine}")
                )
                .CreateAuditLogger();

            Log.Logger.Debug("Audit trail is configured");
        }

        static string Prompt()
        {
            Console.Write(">");
            return Console.ReadLine();
        }
    }
}
