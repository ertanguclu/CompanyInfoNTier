using CompanyInfo.Entities.Models.Concrete;
using System.ComponentModel.DataAnnotations;

namespace CompanyInfo.MVCUI.Models.ViewModels
{
    public class UserInsertVM
    {
        [MaxLength(50,ErrorMessage ="en fazla 50 karakter olabilir")]
        [MinLength(2,ErrorMessage ="En az 2 harfli olabilir")]
        [DataType(DataType.Text)]
        public string Ad { get; set; }
        [MaxLength(50, ErrorMessage = "en fazla 50 karakter olabilir")]
        [MinLength(2, ErrorMessage = "En az 2 harfli olabilir")]
        [DataType(DataType.Text)]
        public string Soyad { get; set; }
        [MaxLength(20, ErrorMessage = "en fazla 20 karakter olabilir")]
        [MinLength(10, ErrorMessage = "En az 10 harfli olabilir")]
        [DataType(DataType.PhoneNumber)]
        public string Gsm { get; set; }
        [MaxLength(50, ErrorMessage = "en fazla 50 karakter olabilir")]
        [MinLength(7, ErrorMessage = "En az 7 harfli olabilir")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Girilen şifreler uyumsuzdur.")]
        public string RePassword { get; set; }
        
        public bool? Cinsiyet { get; set; }
        public IFormFile? UserImage { get; set; }
    }
}
