using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Code.Together.Authorization.Users;

namespace Code.Together.ProgrammingLanguages
{
    public class ProgrammingLanguageUser : FullAuditedEntity, IMustHaveTenant
    {
        public int ProgrammingLanguageId { get; set; }
        public ProgrammingLanguage ProgrammingLanguage { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        public int TenantId { get; set; }
    }
}