using Abp.AspNetCore.Mvc.ViewComponents;

namespace IhaleProject.Web.Views
{
    public abstract class IhaleProjectViewComponent : AbpViewComponent
    {
        protected IhaleProjectViewComponent()
        {
            LocalizationSourceName = IhaleProjectConsts.LocalizationSourceName;
        }
    }
}
