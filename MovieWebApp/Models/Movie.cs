using System.ComponentModel.DataAnnotations;

namespace MovieWebApp.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Movie Title is Required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Movie Price is Required")]
        public decimal? Price { get; set; }

        public string Slug => Title?.Replace(' ', '-').ToLower();
    }
}
