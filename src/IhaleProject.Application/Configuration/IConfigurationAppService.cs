using System.Threading.Tasks;
using IhaleProject.Configuration.Dto;

namespace IhaleProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
