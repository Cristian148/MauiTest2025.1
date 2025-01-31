namespace MauiTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();

            //var NPage = new NavigationPage(new ContentPageDemo());
            //NPage.BarBackgroundColor = Colors.Chocolate;
            //NPage.BarTextColor = Colors.White;
            //MainPage = NPage;

            MainPage = new NavigationPage(new CommandsControlsDemo());
        }
    }
}