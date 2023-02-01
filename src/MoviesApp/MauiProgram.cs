using Microsoft.Extensions.Logging;
using MoviesApp.Services;
using MoviesApp.ViewModels;
using MoviesApp.Views;

namespace MoviesApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<MoviesService>();
        builder.Services.AddSingleton<MoviesViewModel>();
        builder.Services.AddSingleton<MoviesView>();

        builder.Services.AddTransient<MovieDetailViewModel>();
        builder.Services.AddTransient<MovieDetailView>();

        return builder.Build();
	}
}
