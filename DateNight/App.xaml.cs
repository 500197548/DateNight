namespace DateNight;
using DateNight.Models;

public partial class App : Application
{
    public static DateCalc dateCalc;
    
    public App()
    {
        InitializeComponent();

        dateCalc = new DateCalc();
        MainPage = new AppShell();
    }
}