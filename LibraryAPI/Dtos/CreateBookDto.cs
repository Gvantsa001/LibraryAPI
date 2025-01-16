namespace LibraryAPI.Dtos
{
    using System.ComponentModel.DataAnnotations;

    public class CreateBookDto
    {
        [Required]
        [MaxLength(200, ErrorMessage = "Title cannot exceed 200 characters.")]
        public string Title { get; set; }

        [Range(1900, 2100, ErrorMessage = "Year of publication must be between 1900 and 2100.")]
        public int YearOfPublication { get; set; }

        [Required(ErrorMessage = "AuthorId is required.")]
        public int AuthorId { get; set; }
    }
}