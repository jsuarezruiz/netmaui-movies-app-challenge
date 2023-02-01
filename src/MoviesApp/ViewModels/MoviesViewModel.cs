using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MoviesApp.Models;
using MoviesApp.Services;
using MoviesApp.Views;
using System.Collections.ObjectModel;

namespace MoviesApp.ViewModels
{
    public partial class MoviesViewModel : ObservableObject
    {
        readonly MoviesService _moviesService;

        public MoviesViewModel(MoviesService moviesService)
        {
            _moviesService = moviesService;

            LoadData();
        }

        public ObservableCollection<string> Sources { get; } = new();

        [ObservableProperty]
        string selectedSource;

        public ObservableCollection<string> Categories { get; } = new();

        public ObservableCollection<Movie> Movies { get; } = new();

        [ObservableProperty]
        Movie selectedMovie;

        [RelayCommand]
        async Task GoToDetails(Movie movie)
        {
            if (movie == null)
                return;

            await Shell.Current.GoToAsync(nameof(MovieDetailView), true, new Dictionary<string, object>
            {
                {"Movie", movie }
            });
        }

        void LoadData()
        {
            var sources = _moviesService.GetMovieSources();

            if (Sources.Count != 0)
                Sources.Clear();

            foreach (var source in sources)
                Sources.Add(source);

            SelectedSource = sources.First();

            var categories = _moviesService.GetMovieCategories();

            if (Categories.Count != 0)
                Categories.Clear();

            foreach (var category in categories)
                Categories.Add(category);

            var movies = _moviesService.GetMovies();

            if (Movies.Count != 0)
                Movies.Clear();

            foreach (var movie in movies)
                Movies.Add(movie);

            SelectedMovie = movies.FirstOrDefault(m => m.Title == "Ford v Ferrari");
        }
    }
}
