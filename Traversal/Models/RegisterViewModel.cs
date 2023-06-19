using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı giriniz")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen kullanızı adınızı giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Mailinizi giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen Cinsiyet giriniz")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Lütfen Cinsiyet giriniz")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil, kontrol ediniz")]
        public string passwordConfirm { get; set; }
    }
}
