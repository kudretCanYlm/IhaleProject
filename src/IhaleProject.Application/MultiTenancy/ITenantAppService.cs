using Abp.Application.Services;
using IhaleProject.MultiTenancy.Dto;

namespace IhaleProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

