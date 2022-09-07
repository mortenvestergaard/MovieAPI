using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Models
{
    //Represents a mapping table between a movie and its genres
    public class MovieGenres
    {
        [Key]
        public int Id { get; set; }
        public string? GenreName { get; set; }
    }
}
