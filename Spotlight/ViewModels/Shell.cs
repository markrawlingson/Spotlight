using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Spotlight.Persistence.UnitOfWork;

namespace Spotlight.ViewModels;

public partial class ShellViewModel : ObservableObject
{
    private readonly IUnitOfWork _unitOfWork;

    public ShellViewModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [RelayCommand]
    static void OpenPreferences()
    {

    }

    [RelayCommand]
    async void Quit()
    {
        var shows = await _unitOfWork.Shows.GetAll();

        var x = "";
        //Application.Current.Quit();
    }

}