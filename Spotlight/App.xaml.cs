using Spotlight.ViewModels;

namespace Spotlight;

public partial class App : Application
{

    public App(ShellViewModel vm)
    {
        InitializeComponent();

        MainPage = new AppShell(vm);
    }
}
