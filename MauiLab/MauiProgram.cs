using CommunityToolkit.Maui;
using MauiLab.Services;
using MauiLab.Services.Interfaces;
using MauiLab.ViewModels;
using MauiLab.Views;

namespace MauiLab;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddTransient<MainViewModel>();
        builder.Services.AddTransient<MainPage>();

        builder.Services.AddSingleton<IConnectivityService, ConnectivityService>();

        return builder.Build();
    }
}