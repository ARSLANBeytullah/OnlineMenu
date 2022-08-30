using System.ComponentModel.DataAnnotations;

namespace OnlineMenuProject.UI.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Kullanıcı Adı Gereklidir.")]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
        
        [Display(Name = "Telefon")]
        public string PhoneNumber { get; set; }

        
        
        [Required(ErrorMessage = "E-mail gereklidir.")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        
        
        [Required(ErrorMessage="Şifre gereklidir.")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; } //byte[] olarak da alınabilir.
    }
}
