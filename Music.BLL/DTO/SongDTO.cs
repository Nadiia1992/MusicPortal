using System.ComponentModel.DataAnnotations;

namespace MusicPortal.BLL.DTO
{
    public class SongDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле є обов'язковим для заповнення")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "Довжина має бути від 5 до 500 символів.")]
        [Display(Name = "Назва")]
        public string? NameOfSong { get; set; }


        [Display(Name = "Фото")]
        public string? Foto { get; set; }

        [Display(Name = "Аудіо")]
        public string? AudioPath { get; set; }

        public int UserId { get; set; }
        public string? User { get; set; }

        public int SingersId { get; set; }

        public string? Singer { get; set; }

        public int GenreId { get; set; }
        public string? Genre { get; set; }
    }
}
