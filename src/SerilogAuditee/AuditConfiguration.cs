using System;
using System.Collections.Generic;
using Serilog;
using Serilog.Configuration;
using SerilogAuditee.Configuration;
using SerilogAuditee.Core;

namespace SerilogAuditee
{
    public class AuditConfiguration
    {
        const string AuditTypeEnrichedPropertyName = "AuditType";
        const string AuditTypeEnrichedPropertyDefaultValue = "Audit";

        List<Func<LoggerConfiguration, LoggerConfiguration>> _customizations = new List<Func<LoggerConfiguration, LoggerConfiguration>>();

        public AuditConfiguration()
        {
            AuditTo = new AuditToSinkConfiguration(this);
            WriteTo = new WriteToSinkConfiguration(this);
        }

        public AuditToSinkConfiguration AuditTo { get; }

        public WriteToSinkConfiguration WriteTo { get; }

        public IAuditLogger CreateAuditLogger()
        {
            var innerConfiguration = new LoggerConfiguration()
                    .MinimumLevel.Information()
                    .Enrich.WithProperty(AuditTypeEnrichedPropertyName, AuditTypeEnrichedPropertyDefaultValue)
                // stuff that will always happen :
                // - enrich with property AuditEvent
                // - minimumLevel = Information
                ;

            innerConfiguration = ApplyCustomizations(innerConfiguration);

            return new AuditLogger(innerConfiguration.CreateLogger());
        }

        LoggerConfiguration ApplyCustomizations(LoggerConfiguration innerConfiguration)
        {
            var result = innerConfiguration;
            foreach (var customization in _customizations)
            {
                result = customization(result);
            }

            return result;
        }

        internal void AddAuditSink(Func<LoggerAuditSinkConfiguration, LoggerConfiguration> configureAuditTo)
        {
            _customizations.Add(initial => configureAuditTo(initial.AuditTo));
        }


        internal void AddSink(Func<LoggerSinkConfiguration, LoggerConfiguration> configureWriteTo)
        {
            _customizations.Add(initial => configureWriteTo(initial.WriteTo));
        }
    }
}
