using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Code.Together.Configuration.Dto;

namespace Code.Together.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TogetherAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
