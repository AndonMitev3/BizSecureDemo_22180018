using System.ComponentModel.DataAnnotations;

namespace BizSecureDemo_22180018.ViewModels
{
    public class LoginVM
    {
        [Required, EmailAddress]
        public string Email { get; set; } = "";
        [Required]
        public string Password { get; set; } = "";
    }
}
