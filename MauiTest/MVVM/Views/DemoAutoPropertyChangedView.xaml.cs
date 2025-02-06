using MauiTest.MVVM.ViewModels;

namespace MauiTest.MVVM.Views;

public partial class DemoAutoPropertyChangedView : ContentPage
{
    public DemoAutoPropertyChangedView()
    {
        InitializeComponent();
        BindingContext = new DemoAutoPropertyChangedViewModel();
    }
}