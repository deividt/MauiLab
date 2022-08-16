using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiLab.ViewModels;

public partial class MainViewModel : BaseViewModel
{
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
        await Shell.Current.GoToAsync("ERROR!!");
    }
}