using System;
using System.Collections.Generic;
using Serilog.Core;

namespace SerilogAuditee.Pipeline
{
    class NotConfiguredAuditLogger : IAuditLogger
    {
        public IAuditLogger ForContext(ILogEventEnricher enricher)
        {
            throw new NotImplementedException();
        }

        public IAuditLogger ForContext(IEnumerable<ILogEventEnricher> enrichers)
        {
            throw new NotImplementedException();
        }

        public IAuditLogger ForContext(string propertyName, object value, bool destructureObjects = false)
        {
            throw new NotImplementedException();
        }

        public IAuditLogger ForContext<TSource>()
        {
            throw new NotImplementedException();
        }

        public IAuditLogger ForContext(Type source)
        {
            throw new NotImplementedException();
        }

        public void Information(string messageTemplate)
        {
            throw new NotImplementedException();
        }

        public void Information<T>(string messageTemplate, T propertyValue)
        {
            throw new NotImplementedException();
        }

        public void Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            throw new NotImplementedException();
        }

        public void Information<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            throw new NotImplementedException();
        }

        public void Information(string messageTemplate, params object[] propertyValues)
        {
            throw new NotImplementedException();
        }

        public void Information(Exception exception, string messageTemplate)
        {
            throw new NotImplementedException();
        }

        public void Information<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            throw new NotImplementedException();
        }

        public void Information<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            throw new NotImplementedException();
        }

        public void Information<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            throw new NotImplementedException();
        }

        public void Information(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            throw new NotImplementedException();
        }

        public void Warning(string messageTemplate)
        {
            throw new NotImplementedException();
        }

        public void Warning<T>(string messageTemplate, T propertyValue)
        {
            throw new NotImplementedException();
        }

        public void Warning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            throw new NotImplementedException();
        }

        public void Warning<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            throw new NotImplementedException();
        }

        public void Warning(string messageTemplate, params object[] propertyValues)
        {
            throw new NotImplementedException();
        }

        public void Warning(Exception exception, string messageTemplate)
        {
            throw new NotImplementedException();
        }

        public void Warning<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            throw new NotImplementedException();
        }

        public void Warning<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            throw new NotImplementedException();
        }

        public void Warning<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            throw new NotImplementedException();
        }

        public void Warning(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            throw new NotImplementedException();
        }

        public void Error(string messageTemplate)
        {
            throw new NotImplementedException();
        }

        public void Error<T>(string messageTemplate, T propertyValue)
        {
            throw new NotImplementedException();
        }

        public void Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            throw new NotImplementedException();
        }

        public void Error<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            throw new NotImplementedException();
        }

        public void Error(string messageTemplate, params object[] propertyValues)
        {
            throw new NotImplementedException();
        }

        public void Error(Exception exception, string messageTemplate)
        {
            throw new NotImplementedException();
        }

        public void Error<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            throw new NotImplementedException();
        }

        public void Error<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            throw new NotImplementedException();
        }

        public void Error<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            throw new NotImplementedException();
        }

        public void Error(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string messageTemplate)
        {
            throw new NotImplementedException();
        }

        public void Fatal<T>(string messageTemplate, T propertyValue)
        {
            throw new NotImplementedException();
        }

        public void Fatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            throw new NotImplementedException();
        }

        public void Fatal<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string messageTemplate, params object[] propertyValues)
        {
            throw new NotImplementedException();
        }

        public void Fatal(Exception exception, string messageTemplate)
        {
            throw new NotImplementedException();
        }

        public void Fatal<T>(Exception exception, string messageTemplate, T propertyValue)
        {
            throw new NotImplementedException();
        }

        public void Fatal<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            throw new NotImplementedException();
        }

        public void Fatal<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2)
        {
            throw new NotImplementedException();
        }

        public void Fatal(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            throw new NotImplementedException();
        }
    }
}
