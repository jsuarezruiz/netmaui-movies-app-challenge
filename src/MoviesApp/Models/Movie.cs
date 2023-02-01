namespace MoviesApp.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Cover { get; set; }

        public double Rating { get; set; }
        public double Reviews { get; set; }

        public double Metascore { get; set; }
        public double CriticReviews { get; set; }

        public string Summary { get; set; }

        public IEnumerable<string> Categories { get; set; }
        public IEnumerable<Cast> Cast { get; set; }
    }
}
