using System;
using System.Collections.Generic;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Code.Together.Subscriptions
{
    public class SubscriptionGroup : FullAuditedEntity, IMustHaveTenant
    {
        public TimeSpan Duration { get; set; }
        public double DefaultPrice { get; set; }
        public double CurrentPrice { get; set; }

        public ICollection<SubscriptionDetails> SubscriptionDetails { get; set; } = new List<SubscriptionDetails>();
        public ICollection<SubscriptionFeature> Features { get; set; } = new List<SubscriptionFeature>();
        public int TenantId { get; set; }
    }
}