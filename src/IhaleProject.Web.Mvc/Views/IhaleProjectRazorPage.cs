﻿using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace IhaleProject.Web.Views
{
    public abstract class IhaleProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected IhaleProjectRazorPage()
        {
            LocalizationSourceName = IhaleProjectConsts.LocalizationSourceName;
        }
    }
}
