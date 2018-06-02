using System;
using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace SerilogAuditee
{
    sealed class AuditLogger : IAuditee
    {
        readonly ILogger _wrapped;

        public AuditLogger(ILogger wrapped)
        {
            _wrapped = wrapped ?? throw new ArgumentNullException(nameof(wrapped));
        }

        internal static IAuditee None { get; } = new AuditLogger(Logger.None);

        public void Write(LogEvent logEvent)
        {
            EnsureConfigurationIsInitialized();
            throw new NotImplementedException();
        }

        public void Write(LogEventLevel level, string messageTemplate)
        {
            EnsureConfigurationIsInitialized();
            throw new NotImplementedException();
        }

        public void Write<T>(LogEventLevel level, string messageTemplate, T propertyValue)
        {
            EnsureConfigurationIsInitialized();
            throw new NotImplementedException();
        }

        public void Write<T0, T1>(LogEventLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            EnsureConfigurationIsInitialized();
            throw new NotImplementedException();
        }

        public void Write<T0, T1, T2>(LogEventLevel level, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            EnsureConfigurationIsInitialized();
            throw new NotImplementedException();
        }

        public void Write(LogEventLevel level, string messageTemplate, params object[] propertyValues)
        {
            EnsureConfigurationIsInitialized();
            throw new NotImplementedException();
        }

        public void Write(LogEventLevel level, Exception exception, string messageTemplate)
        {
            EnsureConfigurationIsInitialized();
            throw new NotImplementedException();
        }

        public void Write<T>(LogEventLevel level, Exception exception, string messageTemplate, T propertyValue)
        {
            EnsureConfigurationIsInitialized();
            throw new NotImplementedException();
        }

        public void Write<T0, T1>(LogEventLevel level, Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            EnsureConfigurationIsInitialized();
            throw new NotImplementedException();
        }

        public void Write<T0, T1, T2>(LogEventLevel level, Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            EnsureConfigurationIsInitialized();
            throw new NotImplementedException();
        }

        public void Write(LogEventLevel level, Exception exception, string messageTemplate, params object[] propertyValues)
        {
            EnsureConfigurationIsInitialized();
            throw new NotImplementedException();
        }

        public void Information<T>(string messageTemplate, T propertyValue)
        {
            _wrapped.Information(messageTemplate, propertyValue);
        }

        public IAuditee ForContext<T>()
        {
            return new AuditLogger(_wrapped.ForContext<T>());
        }

        private static void EnsureConfigurationIsInitialized()
        {
            throw new AuditeeConfigurationNotInitializedException();
        }
    }
}

