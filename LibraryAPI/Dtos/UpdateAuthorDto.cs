using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Dtos
{
    public class UpdateAuthorDto
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Author name cannot exceed 100 characters.")]
        public string Name { get; set; }
    }
}
