using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IhaleProject.Authorization;

namespace IhaleProject
{
    [DependsOn(
        typeof(IhaleProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class IhaleProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<IhaleProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(IhaleProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
