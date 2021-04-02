using System;
using System.Collections.Generic;
using Abp.Authorization.Users;
using Abp.Extensions;
using Code.Together.Interviews;
using Code.Together.ProgrammingLanguages;
using Code.Together.UserTasks;

namespace Code.Together.Authorization.Users
{
    public class User : AbpUser<User>
    {
        public const string DefaultPassword = "123qwe";

        public int? CompanyId { get; set; }
        public Company.Company Company { get; set; }

        public ICollection<InterviewUser> InterviewUsers { get; set; } = new List<InterviewUser>();
        public ICollection<ProgrammingLanguageUser> ProgrammingLanguages { get; set; } = new List<ProgrammingLanguageUser>();
        public ICollection<UserCodingTaskSolution> UserCodingTaskSolutions { get; set; } = new List<UserCodingTaskSolution>();
        public ICollection<UserCodingTask> UserCodingTasks { get; set; } = new List<UserCodingTask>();
        
        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress,
                Roles = new List<UserRole>()
            };

            user.SetNormalizedNames();

            return user;
        }
    }
}
