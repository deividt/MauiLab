using CommunityToolkit.Mvvm.ComponentModel;
using MauiLab.Services;
using MauiLab.Services.Interfaces;
using MauiLab.ViewModels;
using MauiLab.Views;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace MauiLab.Extensions;

public static class MauiAppBuilderExtensions
{
    public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.TryAddSingleton<IConnectivityService, ConnectivityService>();

        return mauiAppBuilder;
    }
    
    public static MauiAppBuilder RegisterPages(this MauiAppBuilder mauiAppBuilder)
    {
        return mauiAppBuilder
            .AddPage<MainPage, MainViewModel>()
            .AddPage<AppShell>();
    }

    public static MauiAppBuilder AddPage<TPage, TViewModel>(this MauiAppBuilder mauiAppBuilder)
        where TPage : Page where TViewModel : ObservableObject
    {
        mauiAppBuilder.Services.TryAddTransient<TPage>();
        mauiAppBuilder.Services.TryAddTransient<TViewModel>();
        Routing.RegisterRoute(nameof(TPage), typeof(TPage));

        return mauiAppBuilder;
    }
    
    public static MauiAppBuilder AddPage<TPage>(this MauiAppBuilder mauiAppBuilder)
        where TPage : Page
    {
        mauiAppBuilder.Services.TryAddTransient<TPage>();

        return mauiAppBuilder;
    }
}