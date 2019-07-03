using System.Threading.Tasks;
using Abp.Application.Services;
using DResourceProject.Authorization.Accounts.Dto;

namespace DResourceProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
