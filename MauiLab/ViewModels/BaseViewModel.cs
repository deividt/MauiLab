using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiLab.ViewModels;

public abstract partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    private bool _isBusy;
    
    public bool IsNotBusy => !_isBusy;
}