using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Serilog.Core;
using Serilog.Events;
using Serilog.Parsing;
using Xunit;

namespace SerilogAuditee.Tests
{
    public class AuditLoggerTest
    {
        [Fact]
        public void TryingToWriteAuditTraceWithoutConfigurationThrows()
        {
            IAuditee auditee = new AuditLogger(Logger.None);

            var failingCalls = new Expression<Action<IAuditee>>[]
            {
                // testing all possible signatures / overloads that should behave consistently

                // void Write(LogEvent logEvent);
                a => a.Write(new LogEvent(DateTimeOffset.UtcNow, LogEventLevel.Information, new Exception("kaboom"),
                    new MessageTemplate(new List<MessageTemplateToken>(){ new TextToken("the text", -1)}),
                    new List<LogEventProperty>())),

                // void Write(LogEventLevel level, Exception exception, string messageTemplate);
                a => a.Write(LogEventLevel.Information, new Exception("boom"), "it failed"),

                // void Write<T>(LogEventLevel level, Exception exception, string messageTemplate, T propertyValue);
                a => a.Write(LogEventLevel.Information, new Exception("boom"), "It failed with 1 prop {First}", "plop"),

                // void Write<T0, T1>(LogEventLevel level, Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1);
                a => a.Write(LogEventLevel.Information, new Exception("boom"), "It failed with 2 props {First}, {Second}", "plop", "foo"),

                // void Write<T0, T1, T2>(LogEventLevel level, Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);
                a => a.Write(LogEventLevel.Information, new Exception("boom"), "It failed with 3 props {First}, {Second}, {Third}", "plop", "foo", "qux"),

                // void Write(LogEventLevel level, Exception exception, string messageTemplate, params object[] propertyValues);
                a => a.Write(LogEventLevel.Information, new Exception("boom"), "It failed with 4 props {First}, {Second}, {Third}, {Fourth}", "plop", "foo", "qux", "bar"),

                // void Write(LogEventLevel level, string messageTemplate);
                a => a.Write(LogEventLevel.Information, "The simplest"),

                // void Write<T>(LogEventLevel level, string messageTemplate, T propertyValue);
                a => a.Write(LogEventLevel.Information, "It failed with 1 prop {First}", "plop"),

                // void Write<T0, T1>(LogEventLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1);
                a => a.Write(LogEventLevel.Information, "It failed with 2 props {First}, {Second}", "plop", "foo"),

                // void Write<T0, T1, T2>(LogEventLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2);
                a => a.Write(LogEventLevel.Information, "It failed with 3 props {First}, {Second}, {Third}", "plop", "foo", "qux"),

                // void Write(LogEventLevel level, string messageTemplate, params object[] propertyValues);
                a => a.Write(LogEventLevel.Information, "It failed with 4 props {First}, {Second}, {Third}, {Fourth}", "plop", "foo", "qux", "bar"),
            };

            foreach (var failingCall in failingCalls)
            {
                Assert.Throws<AuditeeConfigurationNotInitializedException>(() =>
                    failingCall.Compile()(auditee)
                );
            }

            Assert.Throws<AuditeeConfigurationNotInitializedException>(() =>
                    auditee.Write(LogEventLevel.Warning,
                        "Audited action {AuditActionType} by {AuditUser}",
                        "Checkout", "Me")
                );
        }
    }
}
