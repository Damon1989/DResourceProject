using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DResourceProject.MultiTenancy.Dto;

namespace DResourceProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
