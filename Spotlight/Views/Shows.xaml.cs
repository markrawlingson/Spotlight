using Spotlight.ViewModels;

namespace Spotlight.Views;

public partial class Shows : ContentPage
{
    public Shows(ShowsViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;
    }
}