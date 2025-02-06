using MauiTest.MVVM.ViewModels;

namespace MauiTest.MVVM.Views;

public partial class DataView : ContentPage
{
    public DataView()
    {
        InitializeComponent();
        BindingContext = new DataViewModel();
    }
}