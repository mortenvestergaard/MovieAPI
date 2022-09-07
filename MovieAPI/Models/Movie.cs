using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string? Poster { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<MovieGenres>? Genres { get; set; }
        public string? ReleaseDate { get; set; }
        public string? Runtime { get; set; }

    }
}