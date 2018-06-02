using System;
using System.Collections.Generic;
using Serilog;
using Serilog.Core;

namespace SerilogAuditee.Core
{
    sealed class AuditLogger : IAuditLogger, IDisposable
    {
        ILogger _innerLogger;

        internal AuditLogger(ILogger innerLogger)
        {
            _innerLogger = innerLogger ?? throw new ArgumentNullException(nameof(innerLogger));
        }

        public IAuditLogger ForContext(ILogEventEnricher enricher)
        {
            return new AuditLogger(_innerLogger.ForContext(enricher));
        }

        public IAuditLogger ForContext(IEnumerable<ILogEventEnricher> enrichers)
        {
            return new AuditLogger(_innerLogger.ForContext(enrichers));
        }

        public IAuditLogger ForContext(string propertyName, object value, bool destructureObjects = false)
        {
            return new AuditLogger(_innerLogger.ForContext(propertyName, value, destructureObjects));
        }

        public IAuditLogger ForContext<TSource>()
        {
            return new AuditLogger(_innerLogger.ForContext<TSource>());
        }

        public IAuditLogger ForContext(Type source)
        {
            return new AuditLogger(_innerLogger.ForContext(source));
        }

        public void Information(string messageTemplate)
        {
            _innerLogger.Information(messageTemplate);
        }

        public void Information<T>(string messageTemplate, T propertyValue)
        {
            _innerLogger.Information(messageTemplate, propertyValue);
        }

        public void Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            _innerLogger.Information(messageTemplate, propertyValue0, propertyValue1);
        }

        public void Information<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            _innerLogger.Information(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Information(string messageTemplate, params object[] propertyValues)
        {
            _innerLogger.Information(messageTemplate, propertyValues);
        }

        public void Information(Exception exception, string messageTemplate)
        {
            _innerLogger.Information(exception, messageTemplate);
        }

        public void Information<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            _innerLogger.Information(exception, messageTemplate, propertyValue);
        }

        public void Information<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            _innerLogger.Information(exception, messageTemplate, propertyValue0, propertyValue1);
        }

        public void Information<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            _innerLogger.Information(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Information(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            _innerLogger.Information(exception, messageTemplate, propertyValues);
        }

        public void Warning(string messageTemplate)
        {
            _innerLogger.Warning(messageTemplate);
        }

        public void Warning<T>(string messageTemplate, T propertyValue)
        {
            _innerLogger.Warning(messageTemplate, propertyValue);
        }

        public void Warning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            _innerLogger.Warning(messageTemplate, propertyValue0, propertyValue1);
        }

        public void Warning<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            _innerLogger.Warning(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Warning(string messageTemplate, params object[] propertyValues)
        {
            _innerLogger.Warning(messageTemplate, propertyValues);
        }

        public void Warning(Exception exception, string messageTemplate)
        {
            _innerLogger.Warning(exception, messageTemplate);
        }

        public void Warning<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            _innerLogger.Warning(exception, messageTemplate, propertyValue);
        }

        public void Warning<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            _innerLogger.Warning(exception, messageTemplate, propertyValue0, propertyValue1);
        }

        public void Warning<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            _innerLogger.Warning(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Warning(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            _innerLogger.Warning(exception, messageTemplate, propertyValues);
        }

        public void Error(string messageTemplate)
        {
            _innerLogger.Error(messageTemplate);
        }

        public void Error<T>(string messageTemplate, T propertyValue)
        {
            _innerLogger.Error(messageTemplate, propertyValue);
        }

        public void Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            _innerLogger.Error(messageTemplate, propertyValue0, propertyValue1);
        }

        public void Error<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            _innerLogger.Error(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Error(string messageTemplate, params object[] propertyValues)
        {
            _innerLogger.Error(messageTemplate, propertyValues);
        }

        public void Error(Exception exception, string messageTemplate)
        {
            _innerLogger.Error(exception, messageTemplate);
        }

        public void Error<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            _innerLogger.Error(exception, messageTemplate, propertyValue);
        }

        public void Error<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            _innerLogger.Error(exception, messageTemplate, propertyValue0, propertyValue1);
        }

        public void Error<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            _innerLogger.Error(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Error(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            _innerLogger.Error(exception, messageTemplate, propertyValues);
        }

        public void Fatal(string messageTemplate)
        {
            _innerLogger.Fatal(messageTemplate);
        }

        public void Fatal<T>(string messageTemplate, T propertyValue)
        {
            _innerLogger.Fatal(messageTemplate, propertyValue);
        }

        public void Fatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            _innerLogger.Fatal(messageTemplate, propertyValue0, propertyValue1);
        }

        public void Fatal<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            _innerLogger.Fatal(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Fatal(string messageTemplate, params object[] propertyValues)
        {
            _innerLogger.Fatal(messageTemplate, propertyValues);
        }

        public void Fatal(Exception exception, string messageTemplate)
        {
            _innerLogger.Fatal(exception, messageTemplate);
        }

        public void Fatal<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            _innerLogger.Fatal(exception, messageTemplate, propertyValue);
        }

        public void Fatal<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            _innerLogger.Fatal(exception, messageTemplate, propertyValue0, propertyValue1);
        }

        public void Fatal<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            _innerLogger.Fatal(exception, messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

        public void Fatal(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            _innerLogger.Fatal(exception, messageTemplate, propertyValues);
        }

        public void Dispose()
        {
            (_innerLogger as IDisposable)?.Dispose();
        }
    }
}
