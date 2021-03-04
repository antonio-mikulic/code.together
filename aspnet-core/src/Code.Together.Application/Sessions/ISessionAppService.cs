using System.Threading.Tasks;
using Abp.Application.Services;
using Code.Together.Sessions.Dto;

namespace Code.Together.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
