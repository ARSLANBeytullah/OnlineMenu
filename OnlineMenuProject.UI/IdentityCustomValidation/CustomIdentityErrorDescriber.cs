using Microsoft.AspNetCore.Identity;

namespace OnlineMenuProject.UI.IdentityCustomValidation
{
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError InvalidUserName(string userName)
        {
            return new IdentityError() { Code = "InvalidUserName",Description = $"Bu {userName} geçersizdir." };
        }
        public override IdentityError InvalidEmail(string email)
        {
            return new IdentityError() { Code = "InvalidEmail", Description = $"Bu {email} geçersizdir" };
        }
        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError() { Code = "DuplicateUserName", Description = $"Bu {userName} zaten kullanılmaktadır" };
        }
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError() { Code = "DuplicateEmail", Description= $"Bu {email} zaten kullanılmaktadır"};
        }
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError() { Code = "PasswordTooShort", Description = $"Şifreniz en az {length} karakter olmalıdır." };
        }






      
    }
}
