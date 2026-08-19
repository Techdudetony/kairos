using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Kairos.Desktop.ViewModels;
using Kairos.Desktop.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Kairos.Desktop;

public partial class App : Application
{
    private ServiceProvider? _serviceProvider;
    private ILoggerFactory? _loggerFactory;
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            _loggerFactory = LoggingBootstrapper.CreateLoggerFactory();

            var services = new ServiceCollection();
            services.AddKairosServices(_loggerFactory);

            _serviceProvider = services.BuildServiceProvider();

            var startupLogger = _loggerFactory.CreateLogger("Kairos.Desktop.App");
            startupLogger.LogInformation("Kairos application starting");

            desktop.Exit += (_, _) =>
            {
                startupLogger.LogInformation("Kairos application shutting down");

                _serviceProvider?.Dispose();
                _loggerFactory?.Dispose();
            };

            desktop.MainWindow = new MainWindow
            {
                DataContext = _serviceProvider.GetRequiredService<MainViewModel>(),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}