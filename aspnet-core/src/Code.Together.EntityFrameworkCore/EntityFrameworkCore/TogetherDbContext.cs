using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Code.Together.Authorization.Roles;
using Code.Together.Authorization.Users;
using Code.Together.CodingTasks;
using Code.Together.Company;
using Code.Together.Interviews;
using Code.Together.MultiTenancy;
using Code.Together.ProgrammingLanguages;
using Code.Together.Resources;
using Code.Together.Subscriptions;
using Code.Together.Tags;
using Code.Together.UserTasks;

namespace Code.Together.EntityFrameworkCore
{
    public class TogetherDbContext : AbpZeroDbContext<Tenant, Role, User, TogetherDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TogetherDbContext(DbContextOptions<TogetherDbContext> options)
            : base(options)
        {

        }

        public DbSet<CodingTask> CodingTasks { get; set; }
        public DbSet<Company.Company> Companies { get; set; }
        public DbSet<CompanyCodingTask> CompanyCodingTasks { get; set; }
        public DbSet<JobOffering> JobOfferings { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        public DbSet<ProgrammingLanguageUser> ProgrammingLanguageUser { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<SubscriptionDetails> SubscriptionDetails { get; set; }
        public DbSet<SubscriptionFeature> SubscriptionFeatures { get; set; }
        public DbSet<SubscriptionGroup> SubscriptionGroups { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<UserCodingTaskSolution> UserCodingTaskSolution { get; set; }
        public DbSet<UserCodingTask> UserCodingTasks { get; set; }
        public DbSet<InterviewUser> InterviewUsers { get; set; }
        public DbSet<JobOfferingInterview> JobOfferingInterviews { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CodingTask>()
                .HasIndex(p => p.TenantId);

            modelBuilder.Entity<CompanyCodingTask>()
                .HasIndex(p => p.TenantId);

            modelBuilder.Entity<Company.Company>()
                .HasIndex(p => p.TenantId);

            modelBuilder.Entity<JobOffering>()
                .HasIndex(p => p.TenantId); 

            modelBuilder.Entity<JobOfferingInterview>()
                .HasIndex(p => p.TenantId);

            modelBuilder.Entity<Interview>()
                .HasIndex(p => p.TenantId);

            modelBuilder.Entity<InterviewUser>()
                .HasIndex(p => p.TenantId);

            modelBuilder.Entity<ProgrammingLanguage>()
                .HasIndex(p => p.TenantId);

            modelBuilder.Entity<ProgrammingLanguageUser>()
                .HasIndex(p => p.TenantId);

            modelBuilder.Entity<Resource>()
                .HasIndex(p => p.TenantId);

            modelBuilder.Entity<SubscriptionDetails>()
                .HasIndex(p => p.TenantId);

            modelBuilder.Entity<SubscriptionFeature>()
                .HasIndex(p => p.TenantId);

            modelBuilder.Entity<SubscriptionGroup>()
                .HasIndex(p => p.TenantId);

            modelBuilder.Entity<Tag>()
                .HasIndex(p => p.TenantId); 

            modelBuilder.Entity<UserCodingTaskSolution>()
                .HasIndex(p => p.TenantId);

            modelBuilder.Entity<UserCodingTask>()
                .HasIndex(p => p.TenantId);
        }

    }
}
