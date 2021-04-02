using System;
using System.Collections.Generic;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Code.Together.Interviews
{
    public class Interview : FullAuditedEntity, IMustHaveTenant
    {
        public InterviewType Type { get; set; }

        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }

        public string JoinCode { get; set; }

        public ICollection<InterviewUser> InterviewUsers { get; set; } = new List<InterviewUser>();
        public ICollection<JobOfferingInterview> JobOfferings { get; set; } = new List<JobOfferingInterview>();
        
        public int TenantId { get; set; }
    }
}