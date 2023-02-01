using MoviesApp.ViewModels;

namespace MoviesApp.Views;

public partial class MovieDetailView : ContentPage
{
	public MovieDetailView(MovieDetailViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}