using Microsoft.AspNetCore.Identity;

namespace Traversal.Models
{
    public class CustomIdentityVali: IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Parola Minimum {length} karakter Olmalıdır"
            };
        }
        public override IdentityError PasswordRequiresUpper( )
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Parola En Az Bir Büyük Harf İçermelidir"
            };

        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Parola En Az Bir Küçük Harf İçermelidir"
            };

        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Parola En Az Bir Sembol İçermelidir"
            };

        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = "        public override IdentityError PasswordRequiresDigit()\r\n",
                Description = "Parola En Az Bir Harf İçermelidir"
            };

        }
    }
}
