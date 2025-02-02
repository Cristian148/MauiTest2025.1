using MauiTest.MVVM.Models;
using MauiTest.MVVM.ViewModels;

namespace MauiTest.MVVM.Views;

public partial class PersonView : ContentPage
{
    public PersonView()
    {
        InitializeComponent();

        BindingContext = new PersonViewModel();

        //var person = new Person
        //{
        //    Name = "Cris",
        //    Age = 24
        //};

        //BindingContext = person;
    }
}