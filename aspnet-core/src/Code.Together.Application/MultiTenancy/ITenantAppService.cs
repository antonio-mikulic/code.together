using Abp.Application.Services;
using Code.Together.MultiTenancy.Dto;

namespace Code.Together.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

