using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibraryApp.Authorization;

namespace LibraryApp
{
    [DependsOn(
        typeof(LibraryAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LibraryAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LibraryAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LibraryAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
