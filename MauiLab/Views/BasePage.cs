using MauiLab.ViewModels;

namespace MauiLab.Views;

public abstract class BasePage : ContentPage
{
    protected BasePage(BaseViewModel viewModel)
    {
        BindingContext = viewModel;
    }
}