namespace MauiLab.AppSettings;

public sealed class Settings
{
    public required int KeyOne { get; set; }
    public required bool KeyTwo { get; set; }
    public required NestedSettings Syncfusion { get; set; } = null!;
}

public sealed class NestedSettings
{
    public required string License { get; set; } = null!;
}