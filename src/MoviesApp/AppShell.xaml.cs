using MoviesApp.Views;

namespace MoviesApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		
		Routing.RegisterRoute(nameof(MovieDetailView), typeof(MovieDetailView));
    }
}
