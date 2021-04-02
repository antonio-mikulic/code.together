using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Code.Together.Subscriptions
{
    public class SubscriptionFeature : FullAuditedEntity, IMustHaveTenant
    {
        public double Price { get; set; }
        public double OriginalPrice { get; set; }
        public string UniqueKey { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public int TenantId { get; set; }
    }
}