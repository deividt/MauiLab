using Microsoft.Extensions.Configuration;

namespace MauiLab.Extensions;

public static class ConfigurationExtension
{
    public static AppSettings.Settings GetAppSettings(this IConfiguration configuration)
    {
        return configuration.GetSection(nameof(AppSettings.Settings)).Get<AppSettings.Settings>();
    }
}