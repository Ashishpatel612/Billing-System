using System.Numerics;

namespace BillingSystemManagement.Models
{
    public class Subscription
    {
      
            public int Id { get; set; }
            public int TenantId { get; set; }
            public int PlanId { get; set; }

            public DateTime StartDate { get; set; }
            public bool IsActive { get; set; }

            public Tenant Tenant { get; set; }
            public Plan Plan { get; set; }
        

    }
}
