using System.ComponentModel.DataAnnotations;

namespace BizSecureDemo_22180018.ViewModels
{
    public class CreateOrderVM
    {
        [Required]
        [MaxLength(80)]
        public string Title { get; set; } = null!;

        [Required]
        public decimal Amount { get; set; }
    }
}
