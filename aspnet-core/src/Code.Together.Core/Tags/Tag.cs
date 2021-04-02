using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Code.Together.Tags
{
    public class Tag : FullAuditedEntity, IMustHaveTenant, IExtendableObject
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public string EntityType { get; set; }

        [Required]
        public string EntityId { get; set; }

        public int TenantId { get; set; }
        public string ExtensionData { get; set; }
    }
}