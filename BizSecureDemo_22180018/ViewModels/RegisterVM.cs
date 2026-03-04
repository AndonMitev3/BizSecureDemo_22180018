using System.ComponentModel.DataAnnotations;

namespace BizSecureDemo_22180018.ViewModels
{
    public class RegisterVM
    {
        [Required, EmailAddress]
        public string Email { get; set; } = "";
        [Required, MinLength(6)]
        public string Password { get; set; } = "";
    }
}
