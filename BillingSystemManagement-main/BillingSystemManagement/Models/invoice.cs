namespace BillingSystemManagement.Models
{
    public class invoice
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
