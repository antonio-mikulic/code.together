using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Code.Together.CodingTasks;

namespace Code.Together.Companies
{
    public class CompanyCodingTask : FullAuditedEntity, IMustHaveTenant
    {
        public int CodingTaskId { get; set; }
        public CodingTask CodingTask { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public int TenantId { get; set; }
    }
}