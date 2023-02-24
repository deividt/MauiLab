using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiLab.ViewModels;

public abstract partial class BaseViewModel : ObservableObject
{
    protected BaseViewModel(INavigationService navigationService)
    {
        Navigation = navigationService;
    }
    
    protected INavigationService Navigation { get; }
    
    [ObservableProperty]
    private bool _isBusy;
    
    public bool IsNotBusy => !IsBusy;
}