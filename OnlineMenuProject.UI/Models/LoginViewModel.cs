using System.ComponentModel.DataAnnotations;

namespace OnlineMenuProject.UI.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email Adresiniz")]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [Display(Name = "Şifreniz")]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage ="Şifreniz en az 4 karakter olmalıdır.")]
        public string Password { get; set; }


        public bool RememberMe { get; set; }
    }
}
