using System.ComponentModel.DataAnnotations;

namespace MusicPortal.BLL.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }

        [Display(Name = "Ім'я")]
        [Required(ErrorMessage = "Поле є обов'язковим для заповнення.")]
        public string? FirstName { get; set; }

        [Display(Name = "Прізвище")]
        [Required(ErrorMessage = "Поле є обов'язковим для заповнення.")]
        public string? LastName { get; set; }

        [Display(Name = "Логін")]
        [Required(ErrorMessage = "Введіть логін")]
        public string? Login { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Поле є обов'язковим для заповнення.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Поле є обов'язковим для заповнення.")]
        public string? Password { get; set; }

    }
}
