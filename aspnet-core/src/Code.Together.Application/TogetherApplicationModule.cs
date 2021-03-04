using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Code.Together.Authorization;

namespace Code.Together
{
    [DependsOn(
        typeof(TogetherCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TogetherApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TogetherAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TogetherApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
