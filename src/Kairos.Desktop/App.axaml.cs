using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Kairos.Desktop.ViewModels;
using Kairos.Desktop.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Kairos.Desktop;

public partial class App : Application
{
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

            var provider = services.BuildServiceProvider();

            desktop.MainWindow = new MainWindow
            {
                DataContext = provider.GetRequiredService<MainViewModel>(),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}