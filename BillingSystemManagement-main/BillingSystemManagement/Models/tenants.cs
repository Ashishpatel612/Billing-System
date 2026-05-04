namespace BillingSystemManagement.Models
{
    public class tenants
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Subscription> Subscriptions { get; set; }
    }
}
