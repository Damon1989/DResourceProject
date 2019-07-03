using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DResourceProject.Roles.Dto;
using DResourceProject.Users.Dto;

namespace DResourceProject.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}