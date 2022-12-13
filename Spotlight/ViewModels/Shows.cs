using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Spotlight.ViewModels;

public partial class ShowsViewModel : ObservableObject
{
    //private readonly IUnitOfWork _unitOfWork;

    //public ShowsViewModel(IUnitOfWork unitOfWork)
    //{
    //    _unitOfWork = unitOfWork;
    //}

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(CountText))]
    int count;

    public string CountText
    {
        get
        {
            string text = "Click me";
            if (count > 0)
            {
                text = $"Clicked {count} " + (count == 1 ? "time" : "times");
            }
            SemanticScreenReader.Announce(text);
            return text;
        }
    }

    [RelayCommand]
    async void Increment()
    {
        Count++;
    }
}