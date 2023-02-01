using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MoviesApp.Models;

namespace MoviesApp.ViewModels
{
    [QueryProperty(nameof(Movie), "Movie")]
    public partial class MovieDetailViewModel : ObservableObject
    {
        [ObservableProperty]
        Movie movie;

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
