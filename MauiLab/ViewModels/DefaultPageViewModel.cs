using CommunityToolkit.Mvvm.Input;

namespace MauiLab.ViewModels;

public partial class DefaultPageViewModel : BaseViewModel
{
    public DefaultPageViewModel(INavigationService navigationService) : base(navigationService)
    {
    }

    [ICommand]
    private async Task GoBack()
    {
        await Navigation.GoBackAsync();
    }
}