using System;
using System.IO;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Extensions.Logging;

namespace Kairos.Desktop;

/// <summary>
/// Configures Serilog as the concrete logging implementation for Kairos and exposes it
/// through the standard Microsoft.Extensions.Logging abstraction. Serilog itself is
/// confined to this composition-root project; inner layers depend only on
/// Microsoft.Extensions.Logging.ILogger&lt;T&gt;.
/// </summary>
internal static class LoggingBootstrapper
{
    public static ILoggerFactory CreateLoggerFactory()
    {
        var logDirectory = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Kairos",
            "logs");

        var logFilePath = Path.Combine(logDirectory, "kairos-.log");

        var serilogLogger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Debug()
                .WriteTo.File(
                    logFilePath,
                    rollingInterval: RollingInterval.Day,
                    shared: true)
                .CreateLogger();

        return new SerilogLoggerFactory(serilogLogger, dispose: true);
    }
}