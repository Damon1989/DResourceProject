using System.Threading.Tasks;
using Abp.Application.Services;
using DResourceProject.Sessions.Dto;

namespace DResourceProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
