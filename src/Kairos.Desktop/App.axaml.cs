using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Kairos.Desktop.ViewModels;
using Kairos.Desktop.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Kairos.Desktop;

public partial class App : Application
{
    private ServiceProvider? _serviceProvider;
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var services = new ServiceCollection();
            services.AddKairosServices();

            _serviceProvider = services.BuildServiceProvider();

            desktop.Exit += (_, _) => _serviceProvider?.Dispose();

            desktop.MainWindow = new MainWindow
            {
                DataContext = _serviceProvider.GetRequiredService<MainViewModel>(),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}