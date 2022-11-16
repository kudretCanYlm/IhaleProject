using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using IhaleProject.Configuration.Dto;

namespace IhaleProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : IhaleProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
