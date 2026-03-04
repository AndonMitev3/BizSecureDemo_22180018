namespace BizSecureDemo_22180018.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; } // owner
        public string Title { get; set; } = "";
        public decimal Amount { get; set; }
        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    }
}
