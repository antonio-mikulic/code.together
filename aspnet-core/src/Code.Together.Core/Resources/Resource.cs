using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Code.Together.Resources
{
    public class Resource : FullAuditedEntity, IMustHaveTenant
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string FullText { get; set; }
        public string Location { get; set; }
        public SupportedResourceType Type { get; set; }

        public int TenantId { get; set; }
    }
}