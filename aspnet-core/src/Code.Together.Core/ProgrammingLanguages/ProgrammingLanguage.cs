using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Code.Together.CodingTasks;
using Code.Together.Companies;
using Code.Together.Resources;
using Code.Together.Tags;
using System.Collections.Generic;

namespace Code.Together.ProgrammingLanguages
{
    public class ProgrammingLanguage : FullAuditedEntity, IMustHaveTenant
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public double Difficulty { get; set; }

        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
        public ICollection<Resource> Resources { get; set; } = new List<Resource>();
        public ICollection<JobOffering> JobOfferings { get; set; } = new List<JobOffering>();
        public ICollection<CodingTask> CodingTasks { get; set; } = new List<CodingTask>();
        public ICollection<ProgrammingLanguageUser> ProgrammingLanguageUsers { get; set; } = new List<ProgrammingLanguageUser>();

        public int TenantId { get; set; }
    }
}
