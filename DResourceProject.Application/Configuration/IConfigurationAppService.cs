using System.Threading.Tasks;
using Abp.Application.Services;
using DResourceProject.Configuration.Dto;

namespace DResourceProject.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}