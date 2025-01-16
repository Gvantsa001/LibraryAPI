using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Range(1900, 2100, ErrorMessage = "Year of publication must be between 1900 and 2100.")]
        public int YearOfPublication { get; set; }

        [Required]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
