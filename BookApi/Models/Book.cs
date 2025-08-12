using System.ComponentModel.DataAnnotations;

namespace BookApi.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string Author { get; set; }

        public int? PublishedYear { get; set; }
    }
}
