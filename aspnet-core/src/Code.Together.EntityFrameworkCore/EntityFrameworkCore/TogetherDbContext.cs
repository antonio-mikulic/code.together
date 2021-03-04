using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Code.Together.Authorization.Roles;
using Code.Together.Authorization.Users;
using Code.Together.MultiTenancy;

namespace Code.Together.EntityFrameworkCore
{
    public class TogetherDbContext : AbpZeroDbContext<Tenant, Role, User, TogetherDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TogetherDbContext(DbContextOptions<TogetherDbContext> options)
            : base(options)
        {
        }
    }
}
