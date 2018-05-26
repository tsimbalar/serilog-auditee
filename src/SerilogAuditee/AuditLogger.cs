using System;
using Serilog;
using Serilog.Events;

namespace SerilogAuditee
{
    sealed class AuditLogger : IAuditee
    {
        public AuditLogger(ILogger wrapped)
        {
        }

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

        private static void EnsureConfigurationIsInitialized()
        {
            throw new AuditeeConfigurationNotInitializedException();
        }
    }
}
