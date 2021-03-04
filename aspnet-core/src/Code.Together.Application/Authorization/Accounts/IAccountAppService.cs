using System.Threading.Tasks;
using Abp.Application.Services;
using Code.Together.Authorization.Accounts.Dto;

namespace Code.Together.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
