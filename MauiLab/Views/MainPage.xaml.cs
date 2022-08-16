using MauiLab.ViewModels;

namespace MauiLab.Views;

public partial class MainPage : BasePage
{
    public MainPage(MainViewModel viewModel) : base(viewModel)
    {
        InitializeComponent();
    }
}