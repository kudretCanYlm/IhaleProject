using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace IhaleProject.Controllers
{
    public abstract class IhaleProjectControllerBase: AbpController
    {
        protected IhaleProjectControllerBase()
        {
            LocalizationSourceName = IhaleProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
