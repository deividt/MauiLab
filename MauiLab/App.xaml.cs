using MauiLab.Extensions;
using Microsoft.Extensions.Configuration;

namespace MauiLab;

public partial class App : Application
{
    public App(IConfiguration configuration)
    {
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(configuration.GetAppSettings().Syncfusion.License);
        InitializeComponent();
    }
}