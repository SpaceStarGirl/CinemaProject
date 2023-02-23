namespace CinemaProject.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string movieLength { get; set; }

        public DateTime ReleaseDate { get; set; }
        public List<Actor> actors { get; set; } //FK til actor
        public List<Genre> genres { get; set; }//FK til genre
        public List<Language> languages { get; set; } //FK til language
        public Movie()
        {
            actors = new List<Actor>();
            genres = new List<Genre>();
            languages = new List<Language>();
        }
    }
    
}
