using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Code.Together.Companies;

namespace Code.Together.Interviews
{
    public class JobOfferingInterview : AuditedEntity, IMustHaveTenant
    {
        public int InterviewId { get; set; }
        public Interview Interview { get; set; }
        
        public int JobOfferingId { get; set; }
        public JobOffering JobOffering { get; set; }

        public int TenantId { get; set; }
    }
}