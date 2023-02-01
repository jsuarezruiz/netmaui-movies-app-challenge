using MoviesApp.ViewModels;

namespace MoviesApp.Views;

public partial class MoviesView : ContentPage
{
	public MoviesView(MoviesViewModel viewModel)
	{
		InitializeComponent();

        BindingContext = viewModel;
    }
}