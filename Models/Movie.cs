using System;

namespace MovieManager.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Actors { get; set; }
        public string Director { get; set; }
        public string ImdbRating { get; set; }
        public MovieCategory Category { get; set; }
        public DateTime DateReleased { get; set; }
    }
}