using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Code.Together.Configuration;

namespace Code.Together.Web.Host.Startup
{
    [DependsOn(
       typeof(TogetherWebCoreModule))]
    public class TogetherWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TogetherWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TogetherWebHostModule).GetAssembly());
        }
    }
}
