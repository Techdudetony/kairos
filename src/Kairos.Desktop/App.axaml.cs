using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Kairos.Application.FocusIntentions;
using Kairos.Desktop.ViewModels;
using Kairos.Desktop.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Kairos.Desktop;

public partial class App : Avalonia.Application
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
            desktop.ShutdownMode = ShutdownMode.OnLastWindowClose;

            _loggerFactory = LoggingBootstrapper.CreateLoggerFactory();

            var services = new ServiceCollection();
            services.AddKairosServices(_loggerFactory);

            _serviceProvider = services.BuildServiceProvider();

            var startupLogger = _loggerFactory.CreateLogger("Kairos.Desktop.App");
            startupLogger.LogInformation("Kairos application starting");

            var repository = _serviceProvider.GetRequiredService<IFocusSessionRepository>();
            var restoredSession = repository.Load();

            if (restoredSession is not null)
            {
                _serviceProvider.GetRequiredService<ActiveFocusSessionStore>().Set(restoredSession);
            }

            // Resolved here purely to start its CurrentChanged subscription; nothing else
            // in the container consumes FocusSessionPersistenceCoordinator via constructor
            // injection, so it would never otherwise be constructed.
            _serviceProvider.GetRequiredService<FocusSessionPersistenceCoordinator>().Start();

            desktop.Exit += (_, _) =>
            {
                startupLogger.LogInformation("Kairos application shutting down");

                _serviceProvider?.Dispose();
                _loggerFactory?.Dispose();
            };

            desktop.MainWindow = new MainWindow
            {
                DataContext = _serviceProvider.GetRequiredService<CreateFocusIntentionViewModel>(),
            };

            var activeIntentionWindow = new ActiveIntentionWindow
            {
                DataContext = _serviceProvider.GetRequiredService<ActiveIntentionViewModel>(),
            };
            activeIntentionWindow.Initialize(
                _serviceProvider.GetRequiredService<EditFocusIntentionHandler>(),
                _serviceProvider.GetRequiredService<ActiveFocusSessionStore>());
            activeIntentionWindow.Show();
        }

        base.OnFrameworkInitializationCompleted();
    }
}
