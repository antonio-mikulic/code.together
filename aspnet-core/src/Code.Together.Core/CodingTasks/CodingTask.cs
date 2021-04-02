using System.Collections.Generic;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Code.Together.Company;
using Code.Together.ProgrammingLanguages;
using Code.Together.Tags;
using Code.Together.UserTasks;

namespace Code.Together.CodingTasks
{
    public class CodingTask : FullAuditedEntity, IMustHaveTenant
    {
        public int TenantId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public int TotalHints { get; set; }
        public double Difficulty { get; set; }
        public double ReportedDifficulty { get; set; }

        public string CorrectSolutionJson { get; set; }
        public string CorrectResultJson { get; set; }

        public CodingTaskState State { get; set; }

        public bool IsPrivate { get; set; }
        public string OwnerId { get; set; }
        public CodingTaskOwner OwnerType { get; set; }

        public int ProgrammingLanguageId { get; set; } 
        public ProgrammingLanguage ProgrammingLanguage { get; set; }

        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
        public ICollection<UserCodingTask> UserCodingTasks { get; set; } = new List<UserCodingTask>();
        public ICollection<CompanyCodingTask> CompanyCodingTasks { get; set; } = new List<CompanyCodingTask>();
        public ICollection<UserCodingTaskSolution> UserCodingTaskSolutions { get; set; } = new List<UserCodingTaskSolution>(); 
    }
}