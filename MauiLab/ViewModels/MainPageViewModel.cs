using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiLab.ViewModels;

public partial class MainPageViewModel : BaseViewModel
{
    public MainPageViewModel(INavigationService navigationService) : base(navigationService)
    {
    }
    
    [ObservableProperty]
    private int _count;
    
    [ICommand]
    private void IncrementCount()
    {
        Count++;
    }

    [ICommand]
    async Task CheckConnectivity()
    {
        await Task.CompletedTask;
    }
}