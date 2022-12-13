using Spotlight.ViewModels;

namespace Spotlight;

public partial class AppShell : Shell
{
    public AppShell(ShellViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;
    }
}