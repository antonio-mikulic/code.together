using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Code.Together.Authorization.Users;
using Code.Together.CodingTasks;

namespace Code.Together.UserTasks
{
    public class UserCodingTaskSolution : FullAuditedEntity, IMustHaveTenant
    {
        public long UserId { get; set; }
        public User User { get; set; }

        public int CodingTaskId { get; set; }
        public CodingTask CodingTask { get; set; }

        public TimeSpan Duration { get; set; }
        public int HintsUsed { get; set; }
        public int Score { get; set; }
        public int InProgress { get; set; }

        public string UserSubmittedSolutionJson { get; set; }
        public string UserSubmittedResultJson { get; set; }

        public int TenantId { get; set; }
    }
}