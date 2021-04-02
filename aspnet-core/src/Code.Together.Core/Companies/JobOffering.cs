using System.Collections.Generic;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Code.Together.Interviews;
using Code.Together.ProgrammingLanguages;
using Code.Together.Tags;

namespace Code.Together.Companies
{
    public class JobOffering : FullAuditedEntity, IMustHaveTenant
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Tag> Tags { get; set; }  = new List<Tag>();
        public ICollection<JobOfferingInterview> Interviews { get; set; } = new List<JobOfferingInterview>();
        public ICollection<ProgrammingLanguage> ProgrammingLanguages { get; set; } = new List<ProgrammingLanguage>();

        public int TenantId { get; set; }
    }
}