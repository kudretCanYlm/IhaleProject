using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IhaleProject.Configuration;

namespace IhaleProject.Web.Host.Startup
{
    [DependsOn(
       typeof(IhaleProjectWebCoreModule))]
    public class IhaleProjectWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public IhaleProjectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IhaleProjectWebHostModule).GetAssembly());
        }
    }
}
