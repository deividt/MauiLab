using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiLab.Constants;

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
    async Task NextPage()
    {
        await Navigation.NavigateAsync(Routes.Default);
    }
}