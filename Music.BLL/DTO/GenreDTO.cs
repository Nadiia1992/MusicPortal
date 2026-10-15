using System.ComponentModel.DataAnnotations;


namespace MusicPortal.BLL.DTO
{
    public class GenreDTO
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Будь ласка, введіть Жанр")]
        [Display(Name = "Жанр")]
        public required string Genre { get; set; }
    }
}
