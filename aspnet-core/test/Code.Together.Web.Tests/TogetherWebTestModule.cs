using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Code.Together.EntityFrameworkCore;
using Code.Together.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Code.Together.Web.Tests
{
    [DependsOn(
        typeof(TogetherWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TogetherWebTestModule : AbpModule
    {
        public TogetherWebTestModule(TogetherEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TogetherWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TogetherWebMvcModule).Assembly);
        }
    }
}