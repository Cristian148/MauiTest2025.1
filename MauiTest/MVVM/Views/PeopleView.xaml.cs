using MauiTest.MVVM.ViewModels;

namespace MauiTest.MVVM.Views;

public partial class PeopleView : ContentPage
{
    public PeopleView()
    {
        InitializeComponent();
        BindingContext = new PeopleViewModels();
    }
}