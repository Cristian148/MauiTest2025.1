using MauiTest.MVVM.ViewModels;

namespace MauiTest.MVVM.Views;

public partial class CommandsView : ContentPage
{
    public CommandsView()
    {
        InitializeComponent();
        BindingContext = new CommandsViewModel();
    }
}