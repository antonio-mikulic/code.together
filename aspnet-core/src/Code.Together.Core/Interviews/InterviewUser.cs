using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Code.Together.Authorization.Users;

namespace Code.Together.Interviews
{
    public class InterviewUser : AuditedEntity, IMustHaveTenant
    {
        public int InterviewId { get; set; }
        public Interview Interview { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        public int TenantId { get; set; }
    }
}