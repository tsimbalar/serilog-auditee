using System;
using System.Threading;
using Serilog.Core;
using SerilogAuditee.Pipeline;

namespace SerilogAuditee
{
    public static class Audit
    {
        static IAuditLogger _logger = new NotConfiguredAuditLogger();

        public static IAuditLogger Logger
        {
            get => _logger;
            set => _logger = value ?? throw new ArgumentNullException(nameof(value));
        }
        
        /// <summary>
        /// Resets <see cref="Logger"/> to the default and disposes the original if possible
        /// </summary>
        public static void CloseAndFlush()
        {
            IAuditLogger logger = Interlocked.Exchange(ref _logger, new NotConfiguredAuditLogger());

            (logger as IDisposable)?.Dispose();
        }

        /// <summary>
        /// Create a logger that enriches log events via the provided enrichers.
        /// </summary>
        /// <param name="enricher">Enricher that applies in the context.</param>
        /// <returns>A logger that will enrich log events as specified.</returns>
        public static IAuditLogger ForContext(ILogEventEnricher enricher)
        {
            return Logger.ForContext(enricher);
        }

        /// <summary>
        /// Create a logger that enriches log events via the provided enrichers.
        /// </summary>
        /// <param name="enrichers">Enrichers that apply in the context.</param>
        /// <returns>A logger that will enrich log events as specified.</returns>
        public static IAuditLogger ForContext(ILogEventEnricher[] enrichers)
        {
            return Logger.ForContext(enrichers);
        }

        /// <summary>
        /// Create a logger that enriches log events with the specified property.
        /// </summary>
        /// <returns>A logger that will enrich log events as specified.</returns>
        public static IAuditLogger ForContext(string propertyName, object value, bool destructureObjects = false)
        {
            return Logger.ForContext(propertyName, value, destructureObjects);
        }

        /// <summary>
        /// Create a logger that marks log events as being from the specified
        /// source type.
        /// </summary>
        /// <typeparam name="TSource">Type generating log messages in the context.</typeparam>
        /// <returns>A logger that will enrich log events as specified.</returns>
        public static IAuditLogger ForContext<TSource>()
        {
            return Logger.ForContext<TSource>();
        }

        /// <summary>
        /// Create a logger that marks log events as being from the specified
        /// source type.
        /// </summary>
        /// <param name="source">Type generating log messages in the context.</param>
        /// <returns>A logger that will enrich log events as specified.</returns>
        public static IAuditLogger ForContext(Type source)
        {
            return Logger.ForContext(source);
        }
    }
}
