using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Code.Together.Companies;

namespace Code.Together.Subscriptions
{
    public class SubscriptionDetails : FullAuditedEntity, IMustHaveTenant
    {
        public int TenantId { get; set; }
        public DateTimeOffset ValidFrom { get; set; }
        public DateTimeOffset ValidTo { get; set; }
        public double Price { get; set; }
        
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}