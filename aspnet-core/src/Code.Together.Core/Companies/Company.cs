using System.Collections.Generic;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Code.Together.Subscriptions;

namespace Code.Together.Companies
{
    public class Company : FullAuditedEntity, IMustHaveTenant
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public SubscriptionDetails SubscriptionDetails { get; set; }
        public ICollection<CompanyCodingTask> CompanyCodingTasks { get; set; } = new List<CompanyCodingTask>();
        public ICollection<JobOffering> JobOfferings { get; set; } = new List<JobOffering>();

        public int TenantId { get; set; }
    }
}