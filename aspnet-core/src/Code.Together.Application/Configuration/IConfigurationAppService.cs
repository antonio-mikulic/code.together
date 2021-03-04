using System.Threading.Tasks;
using Code.Together.Configuration.Dto;

namespace Code.Together.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
