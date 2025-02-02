using MauiTest.BindingDemo;

namespace MauiTest;

public partial class BindingDemo2 : ContentPage
{
    public BindingDemo2()
    {
        InitializeComponent();
    }

    private void btnOk_Clicked(object sender, EventArgs e)
    {
        var per = new Person
        {
            Name = "Cristian Ariel Abbate",
            Phone = "34244436",
            Address = "fasonilo 425"
        };

        //Parte uno para binding
        //var personBinding = new Binding();
        //personBinding.Source = per;
        //personBinding.Path = "Name";

        //lblName.SetBinding(Label.TextProperty, personBinding);

        //Parte tres para binding
        //lblName.BindingContext = per;
        //lblName.SetBinding(Label.TextProperty, "Name");

        //Parte cuatro para binding
        BindingContext = per;
    }
}