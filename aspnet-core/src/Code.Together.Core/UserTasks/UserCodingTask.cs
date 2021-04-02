using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Code.Together.Authorization.Users;
using Code.Together.CodingTasks;

namespace Code.Together.UserTasks
{
    public class UserCodingTask : FullAuditedEntity, IMustHaveTenant
    {
        [ForeignKey("OwnerUserId")]
        public long UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("OwnedCodingTaskId")]
        public int CodingTaskId { get; set; }
        public CodingTask CodingTask { get; set; }

        public int TenantId { get; set; }
    }
}