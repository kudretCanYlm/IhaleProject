using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IhaleProject.EntityFrameworkCore;
using IhaleProject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace IhaleProject.Web.Tests
{
    [DependsOn(
        typeof(IhaleProjectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class IhaleProjectWebTestModule : AbpModule
    {
        public IhaleProjectWebTestModule(IhaleProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IhaleProjectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(IhaleProjectWebMvcModule).Assembly);
        }
    }
}