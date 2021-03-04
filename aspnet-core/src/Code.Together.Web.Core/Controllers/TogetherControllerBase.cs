using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Code.Together.Controllers
{
    public abstract class TogetherControllerBase: AbpController
    {
        protected TogetherControllerBase()
        {
            LocalizationSourceName = TogetherConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
