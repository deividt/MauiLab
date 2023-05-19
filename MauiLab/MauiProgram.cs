using CommunityToolkit.Maui;
using MauiLab.Constants;
using MauiLab.Services;
using MauiLab.Services.Interfaces;
using MauiLab.Views;
using Microsoft.Extensions.Configuration;
using Syncfusion.Maui.Core.Hosting;

namespace MauiLab;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UsePrism(prism =>
            {
                prism.RegisterTypes(container =>
                {
                    container.RegisterServices();
                    container.RegisterPages();
                });
                //prism.OnAppStart(Routes.Main);
                prism.OnAppStart(async navigation => 
                    await navigation.NavigateAsync($"{Routes.Navigation}/{Routes.Main}"));
            })
            .UseMauiCommunityToolkit()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Configuration.AddConfiguration(config);
        return builder.Build();
    }

    private static IContainerRegistry RegisterServices(this IContainerRegistry container)
    {
        container.RegisterSingleton<IConnectivityService, ConnectivityService>();
        return container;
    }
    
    private static IContainerRegistry RegisterPages(this IContainerRegistry container)
    {
        container.RegisterForNavigation<MainPage>();
        container.RegisterForNavigation<DefaultPage>();
        return container;
    }
}