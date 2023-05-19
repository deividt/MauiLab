using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiLab.Constants;
using Syncfusion.Maui.Popup;

namespace MauiLab.ViewModels;

public partial class MainPageViewModel : BaseViewModel
{
    private readonly SfPopup _popup;

    public MainPageViewModel(INavigationService navigationService) : base(navigationService)
    {
        _popup = new SfPopup
        {
            ShowCloseButton = true,
            StaysOpen = true
        };
    }
    
    [ObservableProperty]
    private int _count;
    
    [RelayCommand]
    private void IncrementCount()
    {
        Count++;
    }

    [RelayCommand]
    private async Task NextPage()
    {
        await Navigation.NavigateAsync(Routes.Default);
    }
    
    [RelayCommand]
    private void SyncfusionPopup()
    {
        _popup.Show();
    }
}