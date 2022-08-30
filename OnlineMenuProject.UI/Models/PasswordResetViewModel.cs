using System.ComponentModel.DataAnnotations;

namespace OnlineMenuProject.UI.Models
{
    public class PasswordResetViewModel
    {
        [Display(Name = "Email adresiniz")]
        [Required(ErrorMessage = "Email adresi gereklidir.")]
        [EmailAddress]
        public string Email { get; set; }



        [Display(Name = "Yeni şifreniz")]
        [Required(ErrorMessage = "Şifre alanı boş bırakılmamalıdır")]
        [DataType(DataType.Password)]
        [MinLength(4,ErrorMessage = "Şifreniz en az 4 karakter olmalıdır.")]
        [MaxLength(20,ErrorMessage = "Şifreniz en fazla 20 karakter olmalıdır.")]
        public string PasswordNew { get; set; }
    }
}
