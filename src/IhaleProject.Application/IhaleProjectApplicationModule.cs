using Abp.AutoMapper;
using Abp.FluentValidation;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AutoMapper;
using IhaleProject.Application.Contracts.Birim;
using IhaleProject.Authorization;
using IhaleProject.Domain.Birim;

namespace IhaleProject
{
    [DependsOn(
        typeof(IhaleProjectCoreModule), 
        typeof(AbpAutoMapperModule),
        typeof(AbpFluentValidationModule))
        ]
    public class IhaleProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<IhaleProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(IhaleProjectApplicationModule).GetAssembly();
            //var mapperAssembly = typeof(IhaleProjectApplicationAutoMapperProfile).GetAssembly();
            
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
                //cfg=>cfg.AddProfile<IhaleProjectApplicationAutoMapperProfile>()
            );
        }
    }
}
