using MoviesApp.Models;

namespace MoviesApp.Services
{
    public class MoviesService
    {
        public IEnumerable<string> GetMovieSources()
        {
            return new List<string>
            {
                "In Teather",
                "Box Office",
                "Coming Soon"
            };
        }
         
        public IEnumerable<string> GetMovieCategories()
        {
            return new List<string>
            {
                "Action",
                "Crime",
                "Comedy",
                "Drama"
            };
        }
         
        public IEnumerable<Movie> GetMovies()
        {
            var categories = new List<string>
            {
                "Action",
                "Biography",
                "Drama"
            };

            var cast = new List<Cast>
            {
                new Cast { Name = "James Mangold", Image = "actor_1.jpg", Character = "Director" },
                new Cast { Name = "Matt Damon", Image = "actor_2.jpg", Character = "Carrol" },
                new Cast { Name = "Christian Bale", Image = "actor_3.jpg", Character = "Ken Miles" },
                new Cast { Name = "Caitriona Balfe", Image = "actor_4.jpg", Character = "Mollie" },
            };

            return new List<Movie>
            {
                new Movie { Title = "Avatar", Cover = "avatar.jpg", Rating = 9.5, Metascore = 92, Summary = "A paraplegic Marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home.", Categories = categories, Cast = cast },
                new Movie { Title = "Ford v Ferrari", Cover = "ford_v_ferrari.jpg", Rating = 8.2, Metascore = 86, Summary = "After young Riley is uprooted from her Midwest life and moved to San Francisco, her emotions - Joy, Fear, Anger, Disgust and Sadness - conflict on how best to navigate a new city, house, and school.", Categories = categories, Cast = cast },
                new Movie { Title = "Inside Out", Cover = "insideout.jpg", Rating = 8.9, Metascore = 88, Summary = "American car designer Carroll Shelby and driver Ken Miles battle corporate interference and the laws of physics to build a revolutionary race car for Ford in order to defeat Ferrari at the 24 Hours of Le Mans in 1966.", Categories = categories, Cast = cast },
            };
        }
    }
}
